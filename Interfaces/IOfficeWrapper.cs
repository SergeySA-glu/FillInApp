using System.Collections.Generic;

namespace FillInApp.Interfaces
{
    /// <summary>
    /// Оболочка для данных о заполняемом документе
    /// </summary>
    public interface IOfficeWrapper
    {
        /// <summary>
        /// Набор закладок, по которым отслеживаются поля для заполнения
        /// </summary>
        ISet<string> BookmarksNames { get; set; }

        /// <summary>
        /// Набор текста для заполнения в соответствии с закладками
        /// </summary>
        IDictionary<string, string> Changes { get; set; }

        /// <summary>
        /// Путь к шаблону документа
        /// </summary>
        string PatternFilePath { get; set; }

        /// <summary>
        /// Путь к заполненному документу
        /// </summary>
        string DocumentFilePath { get; set; }

        /// <summary>
        /// Расширения заполняемых документов
        /// </summary>
        string[] Extensions { get; }
    }
}
