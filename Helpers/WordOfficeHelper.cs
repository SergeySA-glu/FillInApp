using Word = Microsoft.Office.Interop.Word;

namespace FillInApp.Helpers
{
    public static class WordOfficeHelper
    {
        private static Word.Application _application;

        /// <summary>
        /// COM-объект приложения Office Word
        /// </summary>
        public static Word.Application Application => _application ?? (_application = new Word.Application());

        public static void ResetWordApplication()
        {
            _application = null;
        }
    }
}
