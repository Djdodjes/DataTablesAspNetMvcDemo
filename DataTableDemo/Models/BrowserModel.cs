using System.Collections.Generic;

namespace DataTableDemo.Models
{
    public class BrowserModel
    {
        public string Engine { get; set; }
        public string Browser { get; set; }
        public string Platform { get; set; }
        public string Version { get; set; }
        public string Grade { get; set; }

        public BrowserModel() { }
        public BrowserModel(string engine, string browser, string platform, string version, string grade)
        {
            Engine = engine;
            Browser = browser;
            Platform = platform;
            Version = version;
            Grade = grade;
        }
    }

}