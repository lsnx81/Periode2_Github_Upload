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

        public BookMark(Uri url)
        {
            Update(url);
        }
        public string NaamWebsite { get; set; }
        public string URL { get; set; }

        public void LinkNaarDeWebsite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
        }

        internal void Update(Uri url)
        {
            URL = url.ToString();
            NaamWebsite = url.DnsSafeHost;
        }
    }
}
