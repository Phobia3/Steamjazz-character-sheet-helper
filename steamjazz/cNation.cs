namespace Steamjazz
{
    internal class cNation
    {
        public cNation(string textFile)
        {
            textFileString = textFile;
        }

        private string textFileString;
        public string TextFileString { get { return textFileString; } }
    }
}