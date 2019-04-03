using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Find_Auto.Core;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
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
            switch (siteId)
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

            labelBrand.Text = brandName;
            labelModel.Text = modelName;
            string tMinPrice,tMaxPrice,tMinYear,tMaxYear;
            if (brandValue!=null)
                searchString += "/" + brandValue.ToLower();
                else
                labelBrand.Text = "N/A";
            if (modelValue != null)
                searchString += "/" + modelValue + "?";
                else
                {
                searchString += "/vaihtoautot?";
                labelModel.Text = "N/A";
                }
            if (minPrice != "")
            {
                searchString += "pfrom=" + minPrice + "&";
                tMinPrice = minPrice;
            }
            else tMinPrice = "N/A";

            if (maxPrice != "")
            {
                searchString += "pto=" + maxPrice + "&";
                tMaxPrice = maxPrice;
            }
            else tMaxPrice = "N/A";
            if (minYear != "")
            {
                searchString += "yfrom=" + minYear + "&";
                tMinYear = minYear;
            }
            else tMinYear = "N/A";
            if (maxYear != "")
            {
                searchString += "yto=" + maxYear + "&";
                tMaxYear = maxYear;
            }
            else tMaxYear = "N/A";

            //textBox1.Text = searchString;
            labelYear.Text = tMinYear + " - " + tMaxYear;
            labelPrice.Text = tMinPrice + " - " + tMaxPrice + "  €";
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                dataGrid.Rows.Clear();
                LoadingData();
            }

        }
        public async void LoadingData()
        {
            isLoading = true;
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
                    string message = "Search result contains "+pages * 30 + " lines.\nLoading will take a lot of time.\nAre you want to proceed?";
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

        private void ParsingAllData(IHtmlDocument document)
        {
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
                WebClient wc = new WebClient();
                var imgParsed = parsing.ParseImgs(document, imgId);
                //Uri uri = new Uri(imgParsed[0]);
                Image img = new Bitmap(wc.OpenRead(imgParsed[0]));
                string[] dataString = year_mileageParsed[i].Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); ;

                string sqlString = "INSERT INTO Searches " +
                    "(state, model, description, year, mileage,location, price, url, img, searchid) " +
                    "OUTPUT INSERTED.[Id] " +
                    "VALUES " +
                    "(0, " +
                    "'"+ modelParsed[i] + "'," +
                    "'"+ descriptionParsed[i].TrimStart()+"', " +
                    "'"+ dataString[1].Trim()+"', " +
                    "'"+ dataString[2].Trim()+"', " +
                    "'"+ locationParsed[i].Substring(0, locationParsed[i].IndexOf('›'))+"', "+
                    "'" + priceParsed[i].Trim()+"', " +
                    "'"+ linkParsed[i].Trim()+"', " +
                    "'"+ imgParsed[0]+"', " +
                    " "+ searchId+" )" ;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.OpenAsync();
                    SqlCommand cmd = new SqlCommand(sqlString, connection);
                    searchResultId = (int)cmd.ExecuteScalar();
                }

                dataGrid.Rows.Add(linkParsed[i].Trim(),
                    Properties.Resources.green,
                    img,
                    modelParsed[i],
                    descriptionParsed[i].TrimStart(),
                    dataString[1].Trim(),   //year
                    dataString[2].Trim(),   // mileage
                    locationParsed[i].Substring(0, locationParsed[i].IndexOf('›')),
                    priceParsed[i].Trim(),
                    searchResultId
                    );


            }
        }


        //
        //----------
        //
        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
        }



        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Process.Start(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            dataGrid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(197, 197, 197);
            dataGrid.Rows[e.RowIndex].Cells[1].Value = Properties.Resources.gray;
            var id = dataGrid.Rows[e.RowIndex].Cells[9].Value;
            string sqlString = "UPDATE Searches SET state=1 WHERE Id='" + id + "' "  ;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(sqlString, connection);
                cmd.ExecuteNonQuery();
                //searchResultId = (int)cmd.ExecuteScalar();
            }

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
