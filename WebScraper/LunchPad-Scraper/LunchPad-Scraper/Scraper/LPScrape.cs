using System;
using HtmlAgilityPack;
namespace LunchPad_Scraper.Scraper
{
	public class LPScrape
	{
        public static int menu { get; private set; }

        public static void Main()
		{
			var url = "https://Lunchpad.com";
			ScrapeWebPage(url);
		}

		public static void ScrapeWebPage(string url)

		{
			var web = new HtmlWeb();
			var doc = web.Load(url);
			var titleNode = doc.DocumentNode.SelectSingleNode("//title");

			var menuNode = doc.DocumentNode.SelectSingleNode("");
            var divNodes = doc.DocumentNode.SelectNodes("<div id="1" class="user-menu-select">");
            var divNodes = doc.DocumentNode.SelectNodes("<div id="2" class="user - menu - select">");

			if( divNodes != null)
			{
				foreach (var divNode in divnodes)
				{
					var divContent = divNode.InnerText;
					Console.WriteLine("Div Content:" divContent);

				}

			}

            //etc

            Console.WriteLine("Page Title:" + pageTitle);
			Console.WriteLine("user-menu-select:" + pageMenu)
		}
	}
}

