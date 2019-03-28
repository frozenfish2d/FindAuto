using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Find_Auto
{
    class HtmlLoader
    {
        HttpClient client = new HttpClient();

        public async Task<string> GetSource(string currentUrl)
        {
           
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
