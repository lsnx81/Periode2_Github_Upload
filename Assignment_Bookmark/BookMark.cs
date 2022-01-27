using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_Bookmark
{
    internal class BookMark
    {
        public string NaamWebsite { get; set; }
        public string URL { get; set; }

        public void LinkNaarDeWebsite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
        }
        private List<BookMark> LijstVullenMetFavorieten()
        {
            Console.WriteLine("Geef je 5 Top Websites in aub:");
            List<BookMark> websites = new List<BookMark>();
            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine("Voer de naam van Website {i} in:");
                string naamWebsite=Console.ReadLine();
                Console.WriteLine("Geef de URL in vanaf https..............tot en met .Com");
                String url = Console.ReadLine();

                BookMark BijkomendeWebsite= new BookMark();
                {
                    NaamWebsite = naamWebsite;
                    URL = url;
                };
                websites.Add(BijkomendeWebsite);
            }
            return websites;
        }
    }
}
