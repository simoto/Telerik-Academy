namespace _05.XmlReadingUsingReader
{
    using System;
    using System.Xml;
    using System.Xml.Linq;

    //Write a program, which using XmlReaderextracts all song titles from catalog.xml.
    class Program
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../01.Catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
            Console.WriteLine("------------------");

            //Rewrite the same using XDocumentand LINQ query.
            XDocument xmlDoc = XDocument.Load("../../../01.Catalog.xml");
            var songs = xmlDoc.Descendants("song");

            foreach (var song in songs) 
            { 
                Console.WriteLine(song.Element("title").Value); 
            }
        }
    }
}
