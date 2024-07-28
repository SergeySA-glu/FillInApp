using FillInApp.Interfaces;
using System.Collections.Generic;

namespace FillInApp
{
    public class WordOfficeWrapper : IOfficeWrapper
    {
        public ISet<string> BookmarksNames { get; set; }

        public IDictionary<string, string> Changes { get; set; }

        public string FilePath { get; set; }

    }
}
