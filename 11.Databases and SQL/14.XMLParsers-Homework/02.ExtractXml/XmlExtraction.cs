namespace _02.ExtractXml
{
    using System;
    using System.Xml;

    class XmlExtraction
    {
        static void Main()
        {
            //Write program that extracts all different artists which are found in the catalog.xml.
            //For each author you should print the number of albums in the catalogue. 
            //Use the DOM parser and a hash-table.

            XmlDocument doc = new XmlDocument(); 
            doc.Load("../../01.Catalog.xml"); 
            XmlNode rootNode = doc.DocumentElement; 

            Console.WriteLine("Root node: {0}", rootNode.Name); 
            foreach (XmlAttribute atr in rootNode.Attributes) 
            { 
                Console.WriteLine("Attribute: {0}={1}", atr.Name, atr.Value); 
            } 
            
            foreach (XmlNode albums in rootNode.ChildNodes) 
            {
                foreach (XmlNode album in albums)
                {
                    Console.WriteLine("\nAlbum name = {0}", album["name"].InnerText);
                    Console.WriteLine("Album artist = {0}", album["artist"].InnerText);
                    Console.WriteLine("Album year = {0}", album["year"].InnerText);

                    Console.WriteLine("Songs: ");
                    foreach (XmlNode item in album["songs"])
                    {
                        Console.WriteLine("Song name {0}", item["title"].InnerText);
                        Console.WriteLine("Song duration {0}", item["duration"].InnerText);
                    }
                }           
            }

            Console.WriteLine("----------------");

            //Implement the previous using XPath.

            string xPathQuery = "/catalog/albums/album"; 
            XmlNodeList albumList = doc.SelectNodes(xPathQuery);

            foreach (XmlNode currentNode in albumList) 
            {
                var albumName = currentNode.SelectSingleNode("name"); 
                Console.WriteLine(albumName.InnerText); 
            }
        }
    }
}
