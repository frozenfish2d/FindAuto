using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Windows.Forms;


namespace Find_Auto
{
    public partial class Main : Form
    {
        public int siteId;
        public string tablePrefix;
        public string brandValue;
        public string modelValue;
        public string minPrice;
        public string maxPrice;
        public string minYear;
        public string maxYear;
        public string searchString;

        bool isLoading=false;

        HtmlLoader loader;

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SelectProject selectForm = new SelectProject();
            selectForm.StartPosition = FormStartPosition.CenterScreen;
            selectForm.Owner = this;
            selectForm.ShowDialog();
            selectForm.TopMost = true;
            loader = new HtmlLoader();
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

            labelBrand.Text = brandValue;
            labelModel.Text = modelValue;
            string tMinPrice,tMaxPrice,tMinYear,tMaxYear;
            if (brandValue!=null)
                searchString += "/" + brandValue.ToLower();

            if (modelValue != null)
                searchString += "/" + modelValue+"?";
                else searchString += "/vaihtoautot?";
            if (minPrice != null)
            {
                searchString += "pfrom=" + minPrice + "&";
                tMinPrice = minPrice;
            }
            else tMinPrice = "N/A";

            if (maxPrice != null)
            {
                searchString += "pto=" + maxPrice + "&";
                tMaxPrice = maxPrice;
            }
            else tMaxPrice = "N/A";
            if (minYear != null)
            {
                searchString += "yfrom=" + minYear + "&";
                tMinYear = minYear;
            }
            else tMinYear = "N/A";
            if (maxYear != null)
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


            var modelParsed = ParseModels(document);
            var descriptionParsed = ParseDescriptions(document);
            var yearParsed = ParseYears(document);
            var locationParsed = ParseLocations(document);
            var priceParsed = ParsePrices(document);

            dataGrid.ClearSelection();
            for (int i = 0; i < modelParsed.Length; i++)
            {
                string[] dataString = yearParsed[i].Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); ;
                dataGrid.Rows.Add("",
                    modelParsed[i], 
                    descriptionParsed[i].TrimStart(),
                    dataString[1].Trim(),
                    dataString[2].Trim(), 
                    locationParsed[i].Substring(0, locationParsed[i].IndexOf('›')),
                    priceParsed[i].Trim());
            }
            isLoading = false;
        }

        public string[] ParseModels(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("make_model_link"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
        public string[] ParseDescriptions(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("checkLnesFlat"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
        public string[] ParseLocations(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("list_seller_info"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
        public string[] ParseYears(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("vehicle_other_info clearfix_nett"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
        //main_price
        public string[] ParsePrices(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("main_price"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
        }

    }
}
