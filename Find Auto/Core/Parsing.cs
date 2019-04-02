using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Auto.Core
{
    class Parsing
    {
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
        //childVifUrl tricky_link
        public string[] ParseLinks(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("childVifUrl tricky_link"));
            foreach (var item in items)
            {
                list.Add(item.GetAttribute("href"));
            }
            return list.ToArray();
        }
        //parse img
        public string[] ParseImgs(IHtmlDocument document, string imgId)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("img").Where(item => item.Id != null && item.Id.Contains(imgId));
            foreach (var item in items)
            {
                list.Add(item.GetAttribute("src"));
            }
            return list.ToArray();
        }
        //totPage
        public string[] ParsePages(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("totPage"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
