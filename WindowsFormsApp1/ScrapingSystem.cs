using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ScrapingSystem
    {
        public static HtmlAgilityPack.HtmlDocument Loader(string url)
        {
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument;
        }
        public static List<string> URL(string url)
        {
            var htmlDocument = Loader(url);
            var URLlink = htmlDocument.DocumentNode.SelectNodes("//td[@class='swimstyle']//a[@href]");
            var distance = htmlDocument.DocumentNode.SelectNodes("//td[@class='swimstyle']//a");
            List<string> linki = new List<string>();
            for (int i = 0; i < URLlink.Count; i++)
            {
                if (!distance[i].InnerText.Contains("Lap") && !distance[i].InnerText.Contains("x"))
                {
                    linki.Add("https://www.swimrankings.net/index.php" + URLlink[i].GetAttributeValue("href", "").Replace("amp;", "") + "&points=rudolph_2023");
                }
            }
            return linki;
        }
    }
}
