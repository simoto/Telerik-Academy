using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

class DLFileFromInternet
{
    static void Main()
    {
        try
        {
            using (WebClient dlFile = new WebClient())
            {
                dlFile.DownloadFile(@"http://www.devbg.org/img/Logo-BASD.jpg", @"../../Logo.jpg");
                Console.WriteLine("Operation is complete!");
            }
        }
        catch (ProtocolViolationException)
        {
            Console.WriteLine("You have internet problem.");
        }
        catch (TimeoutException)
        {
            Console.WriteLine("File transfer is not complete.");
        }
        catch (Exception)
        {
            Console.WriteLine("Operation can not complete.");
        }
    }
}