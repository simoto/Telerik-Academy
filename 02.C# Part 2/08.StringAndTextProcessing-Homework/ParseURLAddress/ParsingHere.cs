using System;

//Write a program that parses an URL address given in the format:

//        and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

class ParsingHere
{
    static void Main()
    {
        Uri myPath = new Uri("http://www.devbg.org/forum/index.php");

        string protocol = myPath.Scheme;
        string server = myPath.Host;
        string resourse = myPath.LocalPath;

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resourse);
    }
}