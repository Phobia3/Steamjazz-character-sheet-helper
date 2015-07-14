using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steamjazz
{
    class cNation
    {
        public cNation(string textFile)
        {
            textFileString = textFile;
        }
        private string textFileString;
        public string TextFileString { get { return textFileString; } }
    }

}
