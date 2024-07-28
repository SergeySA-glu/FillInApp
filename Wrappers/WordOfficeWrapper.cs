using FillInApp.Interfaces;
using System.Collections.Generic;

namespace FillInApp
{
    public class WordOfficeWrapper : IOfficeWrapper
    {
        public ISet<string> BookmarksNames { get; set; }

        public IDictionary<string, string> Changes { get; set; }

        public string PatternFilePath { get; set; }
        public string DocumentFilePath { get; set; }

        private string[] _extensions = new[] { "doc", "docx" };
        public string[] Extensions => _extensions;
    }
}
