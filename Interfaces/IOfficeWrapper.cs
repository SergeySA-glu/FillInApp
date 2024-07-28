using System.Collections.Generic;

namespace FillInApp.Interfaces
{
    public interface IOfficeWrapper
    {
        ISet<string> BookmarksNames { get; set; }

        IDictionary<string, string> Changes { get; set; }

        string FilePath { get; set; }
    }
}
