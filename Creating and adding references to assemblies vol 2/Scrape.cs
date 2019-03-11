using System;
using System.IO;
using System.Net;

namespace Creating_and_adding_references_to_assemblies_vol_2
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }

        public string ScarpeWebpage(string url, string filepath)
        {

            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;

        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
