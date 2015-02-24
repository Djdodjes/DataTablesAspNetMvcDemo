using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTableDemo.Models;

namespace DataTableDemo.Services
{
    public class ServiceBrowser
    {
        /// <summary>
        /// Return list of browser model
        /// </summary>
        public List<BrowserModel> ListOfBrowsers()
        {
            var lst = new List<BrowserModel>
            {
                new BrowserModel("Trident", "Internet Explorer 4.0", "Win 95+", "4", "X"),
                new BrowserModel("Trident", "Internet Explorer 5.0", "Win 95+", "5", "C"),
                new BrowserModel("Trident", "Internet Explorer 5.5", "Win 95+", "5.5", "A"),
                new BrowserModel("Trident", "Internet Explorer 6", "Win 98+", "6", "A"),
                new BrowserModel("Trident", "Internet Explorer 7", "Win XP SP2+", "7", "A"),
                new BrowserModel("Trident", "AOL browser (AOL desktop)", "Win XP", "6", "A"),
                new BrowserModel("Gecko", "Firefox 1.0", "Win 98+ / OSX.2+", "1.7", "A"),
                new BrowserModel("Gecko", "Firefox 1.5", "Win 98+ / OSX.2+", "1.8", "A"),
                new BrowserModel("Gecko", "Firefox 2.0", "Win 98+ / OSX.2+", "1.8", "A"),
                new BrowserModel("Gecko", "Firefox 3.0", "Win 2k+ / OSX.3+", "1.9", "A"),
                new BrowserModel("Gecko", "Camino 1.0", "OSX.2+", "1.8", "A"),
                new BrowserModel("Gecko", "Camino 1.5", "OSX.3+", "1.8", "A"),
                new BrowserModel("Gecko", "Netscape 7.2", "Win 95+ / Mac OS 8.6-9.2", "1.7", "A"),
                new BrowserModel("Gecko", "Netscape Browser 8", "Win 98SE+", "1.7", "A"),
                new BrowserModel("Gecko", "Netscape Navigator 9", "Win 98+ / OSX.2+", "1.8", "A"),
                new BrowserModel("Gecko", "Mozilla 1.0", "Win 95+ / OSX.1+", "1", "A"),
                new BrowserModel("Gecko", "Mozilla 1.1", "Win 95+ / OSX.1+", "1.1", "A"),
                new BrowserModel("Gecko", "Mozilla 1.2", "Win 95+ / OSX.1+", "1.2", "A"),
                new BrowserModel("Gecko", "Mozilla 1.3", "Win 95+ / OSX.1+", "1.3", "A"),
                new BrowserModel("Gecko", "Mozilla 1.4", "Win 95+ / OSX.1+", "1.4", "A"),
                new BrowserModel("Gecko", "Mozilla 1.5", "Win 95+ / OSX.1+", "1.5", "A"),
                new BrowserModel("Gecko", "Mozilla 1.6", "Win 95+ / OSX.1+", "1.6", "A"),
                new BrowserModel("Gecko", "Mozilla 1.7", "Win 98+ / OSX.1+", "1.7", "A"),
                new BrowserModel("Gecko", "Mozilla 1.8", "Win 98+ / OSX.1+", "1.8", "A"),
                new BrowserModel("Gecko", "Seamonkey 1.1", "Win 98+ / OSX.2+", "1.8", "A"),
                new BrowserModel("Gecko", "Epiphany 2.20", "Gnome", "1.8", "A"),
                new BrowserModel("Webkit", "Safari 1.2", "OSX.3", "125.5", "A"),
                new BrowserModel("Webkit", "Safari 1.3", "OSX.3", "312.8", "A"),
                new BrowserModel("Webkit", "Safari 2.0", "OSX.4+", "419.3", "A"),
                new BrowserModel("Webkit", "Safari 3.0", "OSX.4+", "522.1", "A"),
                new BrowserModel("Webkit", "OmniWeb 5.5", "OSX.4+", "420", "A"),
                new BrowserModel("Webkit", "iPod Touch / iPhone", "iPod", "420.1", "A"),
                new BrowserModel("Webkit", "S60", "S60", "413", "A"),
                new BrowserModel("Presto", "Opera 7.0", "Win 95+ / OSX.1+", "-", "A"),
                new BrowserModel("Presto", "Opera 7.5", "Win 95+ / OSX.2+", "-", "A"),
                new BrowserModel("Presto", "Opera 8.0", "Win 95+ / OSX.2+", "-", "A"),
                new BrowserModel("Presto", "Opera 8.5", "Win 95+ / OSX.2+", "-", "A"),
                new BrowserModel("Presto", "Opera 9.0", "Win 95+ / OSX.3+", "-", "A"),
                new BrowserModel("Presto", "Opera 9.2", "Win 88+ / OSX.3+", "-", "A"),
                new BrowserModel("Presto", "Opera 9.5", "Win 88+ / OSX.3+", "-", "A"),
                new BrowserModel("Presto", "Opera for Wii", "Wii", "-", "A"),
                new BrowserModel("Presto", "Nokia N800", "N800", "-", "A"),
                new BrowserModel("Presto", "Nintendo DS browser", "Nintendo DS", "8.5", "C/A<sup>1</sup>"),
                new BrowserModel("KHTML", "Konqureror 3.1", "KDE 3.1", "3.1", "C"),
                new BrowserModel("KHTML", "Konqureror 3.3", "KDE 3.3", "3.3", "A"),
                new BrowserModel("KHTML", "Konqureror 3.5", "KDE 3.5", "3.5", "A"),
                new BrowserModel("Tasman", "Internet Explorer 4.5", "Mac OS 8-9", "-", "X"),
                new BrowserModel("Tasman", "Internet Explorer 5.1", "Mac OS 7.6-9", "1", "C"),
                new BrowserModel("Tasman", "Internet Explorer 5.2", "Mac OS 8-X", "1", "C"),
                new BrowserModel("Misc", "NetFront 3.1", "Embedded devices", "-", "C"),
                new BrowserModel("Misc", "NetFront 3.4", "Embedded devices", "-", "A"),
                new BrowserModel("Misc", "Dillo 0.8", "Embedded devices", "-", "X"),
                new BrowserModel("Misc", "Links", "Text only", "-", "X"),
                new BrowserModel("Misc", "Lynx", "Text only", "-", "X"),
                new BrowserModel("Misc", "IE Mobile", "Windows Mobile 6", "-", "C"),
                new BrowserModel("Misc", "PSP browser", "PSP", "-", "C"),
                new BrowserModel("Other browsers", "All others", "-", "-", "U")
            };

            return lst;
        }

    }
}
