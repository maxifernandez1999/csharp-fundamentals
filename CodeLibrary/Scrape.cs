
using System.Net;

namespace CodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            string reply = GetWebPage(url);
            //File.WriteAllText(url, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString(url);
        }
    }
}