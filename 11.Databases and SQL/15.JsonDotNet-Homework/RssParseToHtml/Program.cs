namespace RssParseToHtml
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            Uri address = new Uri("http://forums.academy.telerik.com/feed/qa.rss");
            string path = @"../../TelerikForum.xml";
            WebClient client = new WebClient();
            client.DownloadFile(address, path);
            client.Dispose();

           // string jsonFromXml = JsonConvert.SerializeXNode(path);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            string jsonFromXml = JsonConvert.SerializeXmlNode(xmlDocument);

            JObject jsonObj = JObject.Parse(jsonFromXml);
            var allItemTitles = jsonObj["rss"]["channel"]["item"].AsJEnumerable();

            foreach (var item in allItemTitles)
            {
                Console.WriteLine(item["title"]);
            }

            string allItems = jsonObj["rss"]["channel"]["item"].ToString();
            var PocoCollection = JsonConvert.DeserializeObject<ICollection<Item>>(allItems);

            foreach (var item in PocoCollection)
            {
                Console.WriteLine(item.Title);
            }

            //No time for Html generation...
        }
    }
}
