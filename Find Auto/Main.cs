using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Find_Auto.Core;
using System;
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

        bool isLoading=false;

        int pages;

        HtmlLoader loader;

        Parsing parsing;

        public Main()
        {
            InitializeComponent();

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

            textBox1.Text = searchString;
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
            else
            {
                for(int i=1; i <= pages; i++)
                {
                    source = await loader.GetSource(searchString+"page="+i.ToString());
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
                dataGrid.Rows.Add(linkParsed[i].Trim(),
                    "",
                    img,
                    modelParsed[i],
                    descriptionParsed[i].TrimStart(),
                    dataString[1].Trim(),   //year
                    dataString[2].Trim(),   // mileage
                    locationParsed[i].Substring(0, locationParsed[i].IndexOf('›')),
                    priceParsed[i].Trim()
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

        }


    }
}
