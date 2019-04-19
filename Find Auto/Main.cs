using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Find_Auto.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Find_Auto
{
    public partial class Main : Form
    {
        public int siteId;
        public string tablePrefix;
        public string brandValue;
        public string brandName;
        public string modelValue;
        public string modelName;
        public string minPrice;
        public string maxPrice;
        public string minYear;
        public string maxYear;
        public string searchString;
        public int searchId;

        string connString;

        bool isLoading=false;

        int pages;

        int searchResultId;

        HtmlLoader loader;
        Parsing parsing;

        List<string> loadedResults = new List<string>();

        public Main()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Find Auto\Find Auto\searchData.mdf;Integrated Security=True;Connect Timeout=30";
            StartPosition = FormStartPosition.CenterScreen;
            SelectProject selectForm = new SelectProject();       
            selectForm.StartPosition = FormStartPosition.CenterScreen;
            selectForm.Owner = this;
            selectForm.TopMost = true;
            selectForm.ShowDialog();
            loader = new HtmlLoader();
            parsing = new Parsing();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            switch (SearchParameters.siteId)
            {
                case 0:
                    labelSite.Text = "Nettiauto";
                    searchString = "https://www.nettiauto.com";
                    break;
                case 1:
                    labelSite.Text = "Kamux";
                    searchString = "https://www.nettiauto.com";
                    break;
                default:
                    searchString = "https://www.nettiauto.com";
                    break;
            }

            labelBrand.Text = SearchParameters.brandName;
            labelModel.Text = SearchParameters.modelName;
            string tMinPrice,tMaxPrice,tMinYear,tMaxYear;
            if (SearchParameters.brandValue !=null)
                searchString += "/" + SearchParameters.brandValue;
                else
                labelBrand.Text = "N/A";
            if (SearchParameters.modelValue != null)
                searchString += "/" + SearchParameters.modelValue + "?";
                else
                {
                searchString += "/vaihtoautot?";
                labelModel.Text = "N/A";
                }
            if (SearchParameters.minPrice != "")
            {
                searchString += "pfrom=" + SearchParameters.minPrice + "&";
                tMinPrice = SearchParameters.minPrice;
            }
            else tMinPrice = "N/A";

            if (SearchParameters.maxPrice != "")
            {
                searchString += "pto=" + SearchParameters.maxPrice + "&";
                tMaxPrice = SearchParameters.maxPrice;
            }
            else tMaxPrice = "N/A";
            if (SearchParameters.minYear != "")
            {
                searchString += "yfrom=" + SearchParameters.minYear + "&";
                tMinYear = SearchParameters.minYear;
            }
            else tMinYear = "N/A";
            if (SearchParameters.maxYear != "")
            {
                searchString += "yto=" + SearchParameters.maxYear + "&";
                tMaxYear = SearchParameters.maxYear;
            }
            else tMaxYear = "N/A";

            if((tMinYear == "N/A") && (tMaxYear == "N/A"))
            {
                labelYear.Text = "N/A";
            }
            else
            {
                labelYear.Text = tMinYear + " - " + tMaxYear;
            }
            if ((tMinPrice == "N/A") && (tMaxPrice == "N/A"))
            {
                labelPrice.Text = "N/A";
            }
            else
            {
                labelPrice.Text = tMinPrice + " - " + tMaxPrice + "  €";
            }


            textBox1.Text = searchString;
        }


        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (!isLoading )
            {       
                dataGrid.Rows.Clear();
                LoadingData();
            }
            /*if(!isLoading && !SearchParameters.isNewSearch)
            {
                dataGrid.Rows.Clear();
                LoadSavedData(SearchParameters.searchId);
            }
            */
        }


        public async void LoadingData()
        {
            isLoading = true;
            if(!SearchParameters.isNewSearch)
                LoadSavedData(SearchParameters.searchId);
            var domParser = new HtmlParser();
            var source = await loader.GetSource(searchString);
            var document = await domParser.ParseDocumentAsync(source);
            var pageParsed = parsing.ParsePages(document);
            pages = Convert.ToInt32(pageParsed[0]);
            if (pages <= 1)
                {
                    ParsingAllData(document);
                }
            else if (pages > 10)
                {
                    string message = "Search result contains "+pages * 30 + " lines.\nLoading will take a lot of time.\nDo you want to proceed?";
                    string caption = "Search result is too big";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 1; i <= pages; i++)
                        {
                            source = await loader.GetSource(searchString + "page=" + i.ToString());
                            document = await domParser.ParseDocumentAsync(source);
                            ParsingAllData(document);
                        }

                    }
                }
            else
                {
                    for (int i = 1; i <= pages; i++)
                    {
                        source = await loader.GetSource(searchString + "page=" + i.ToString());
                        document = await domParser.ParseDocumentAsync(source);
                        ParsingAllData(document);
                    }
                }
            isLoading = false;
        }

        private async void LoadSavedData(int id)
        {
            loadedResults.Clear();
            string sqlString = "SELECT * FROM Searches WHERE searchid = '"+id+"' ORDER BY state";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(sqlString, connection);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    dataGrid.ClearSelection();
                    object stateImage;
                    while (await reader.ReadAsync())
                    {
                        if ((int)reader.GetValue(1) == 2)
                        {
                            stateImage = Properties.Resources.gray;
                        }
                        else if((int)reader.GetValue(1) == 0)
                        {
                            stateImage = Properties.Resources.purp;
                        }
                        else
                        {
                            stateImage = Properties.Resources.green;
                        }

                        HttpClient http = new HttpClient();
                        var bytes = await http.GetByteArrayAsync(reader.GetValue(9).ToString());
                        Image img = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));
                        dataGrid.Rows.Add(
                            reader.GetValue(8),
                            stateImage,
                            img,
                            reader.GetValue(2),
                            reader.GetValue(3),
                            reader.GetValue(4),
                            reader.GetValue(5),
                            reader.GetValue(6),
                            reader.GetValue(7),
                            reader.GetValue(0)
                            );
                        loadedResults.Add(reader.GetValue(8).ToString());
                        
                    }
                }
            }

        }


        private async void ParsingAllData(IHtmlDocument document)
        {
            var emptySearch = parsing.ParseEmpty(document);
            if (emptySearch > 0) return;
            var modelParsed = parsing.ParseModels(document);
            var descriptionParsed = parsing.ParseDescriptions(document);
            var year_mileageParsed = parsing.ParseYears(document);
            var locationParsed = parsing.ParseLocations(document);
            var priceParsed = parsing.ParsePrices(document);
            var linkParsed = parsing.ParseLinks(document);
            dataGrid.ClearSelection();
            string imgId;
            for (int i = 0; i < modelParsed.Length; i++)
            {
                string[] imgSrc = linkParsed[i].Split(new char[] { '/' });
                imgId = imgSrc[imgSrc.Length - 1];             
                var imgParsed = parsing.ParseImgs(document, imgId);
                string url = imgParsed[0];
                if (!SearchParameters.isNewSearch)
                {
                    if (loadedResults.Contains(linkParsed[i].Trim()))
                    {
                        continue;
                    }
                }
                HttpClient http = new HttpClient();
                var bytes = await http.GetByteArrayAsync(url);
                Image img = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));

                string[] dataString = year_mileageParsed[i].Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); ;

                string sqlString = "INSERT INTO Searches " +
                    "(state, model, description, year, mileage,location, price, url, img, searchid) " +
                    "OUTPUT INSERTED.[Id] " +
                    "VALUES " +
                    "(1, " +
                    "'"+ modelParsed[i].Trim() + "'," +
                    "'"+ descriptionParsed[i].Trim()+"', " +
                    "'"+ dataString[1].Trim()+"', " +
                    "'"+ dataString[2].Trim()+"', " +
                    "'"+ locationParsed[i].Substring(0, locationParsed[i].IndexOf('›'))+"', "+
                    "'" + priceParsed[i].Trim()+"', " +
                    "'"+ linkParsed[i].Trim()+"', " +
                    "'"+ imgParsed[0].Trim() + "', " +
                    " "+ SearchParameters.searchId +" )" ;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = new SqlCommand(sqlString, connection);
                    searchResultId = Convert.ToInt32(cmd.ExecuteScalar());
                }


                if (!SearchParameters.isNewSearch)
                {
                    dataGrid.Rows.Insert(0, linkParsed[i].Trim(),
                    Properties.Resources.red,
                    img,
                    modelParsed[i].Trim(),
                    descriptionParsed[i].Trim(),
                    dataString[1].Trim(),
                    dataString[2].Trim(),
                    locationParsed[i].Substring(0, locationParsed[i].IndexOf('›')),
                    priceParsed[i].Trim(),
                    searchResultId);
                }
                else
                {
                    dataGrid.Rows.Add(linkParsed[i].Trim(),
                    Properties.Resources.red,
                    img,
                    modelParsed[i].Trim(),
                    descriptionParsed[i].Trim(),
                    dataString[1].Trim(),
                    dataString[2].Trim(),
                    locationParsed[i].Substring(0, locationParsed[i].IndexOf('›')),
                    priceParsed[i].Trim(),
                    searchResultId
                    );
                }
                
            }
        }

        //
        //----------
        //
        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
        }
       
        private async void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            //Process.Start(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            //dataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(197, 197, 197);
            dataGrid.Rows[e.RowIndex].Cells[1].Value = Properties.Resources.gray;
            var id = dataGrid.Rows[e.RowIndex].Cells[9].Value;
            string sqlString = "UPDATE Searches SET state=2 WHERE Id='" + id + "' "  ;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(sqlString, connection);
                await cmd.ExecuteNonQueryAsync();
            }
            ViewerForm viewer = new ViewerForm(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),//url
                dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString(),//model
                dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString(),//description
                dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString(),//year
                dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString()//price 
                );
            viewer.StartPosition = FormStartPosition.CenterScreen;
            viewer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectProject selectForm = new SelectProject();
            selectForm.StartPosition = FormStartPosition.CenterScreen;
            selectForm.Owner = this;
            selectForm.TopMost = true;
            selectForm.ShowDialog();
        }
    }
}
