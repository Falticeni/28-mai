using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace Exercitiul2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti adresa url de unde doriti sa descarcati fila: ");
            string url = Console.ReadLine();
            string localFileName = Path.GetFileName(url);
            WebClient myWebClient = new WebClient();
            try
            {
                Console.WriteLine("Start downloading {0}", url);
                myWebClient.DownloadFile(url, localFileName);
                Console.WriteLine("Download succesfull.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }

            
            Console.ReadKey();
        }
    }
}
