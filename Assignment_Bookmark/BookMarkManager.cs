using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Bookmark
{
    internal class BookMarkManager
    {

        List<BookMark> websites = new List<BookMark>(5);
        public void HuidigeBookMarks()
        {
            if (websites.Count == 0)
            {
                Console.WriteLine($"Er zijn geen websites ingegeven");
                return;
            }
            
            for (int i = 0; i < websites.Count; i++)
            {
                BookMark? bookmark = websites[i];
                Console.WriteLine($"{i+1} {bookmark.NaamWebsite}");
            }
        }
        public void StartBookMarkNummer(int nummer) => websites[nummer-1].LinkNaarDeWebsite();
        public void RemoveBookMark(int nummer) => websites.RemoveAt(nummer-1);

        public void AdjustBookMark(int nummer)
        {
            Console.WriteLine($"Pas hier bookmark {nummer} aan met de nieuwe website :");
            string? naamWebsite = Console.ReadLine();
            if (Uri.TryCreate(naamWebsite, UriKind.Absolute, out var url))
            {
               websites[nummer - 1].Update(url);
            }
        }
        public void LijstVullenMetFavorieten()
        {
            if (websites.Count > 5)
            {
                return;
            }
            Console.WriteLine($"Geef je {5-websites.Count} Top Websites in aub:");

                
            do
            {
                Console.WriteLine($"Voer de naam van Website {websites.Count+1} in van in totaal 5:");
                string? naamWebsite = Console.ReadLine();
                if (Uri.TryCreate(naamWebsite, UriKind.Absolute, out var url))
                {
                    BookMark BijkomendeWebsite = new BookMark(url);
                    websites.Add(BijkomendeWebsite);
                }

                else
                {
                    Console.WriteLine($"Geef juiste website in : adres : {naamWebsite} is niet geldig");
                }
            }
            while (websites.Count < 5);
                                 
            
         }
    }
}
