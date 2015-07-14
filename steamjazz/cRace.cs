using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steamjazz
{
    class cRace
    {
        private cNation[] aNation= new cNation[7];
        public string NationTextFile(int index) { return aNation[index].TextFileString ; }
        public cRace(string textFile,int selectedIndex)
        {
            textFileString = textFile;
            if (selectedIndex != 6)
            {
                aNation[0] = new cNation("Steamjazz.Victora.txt");
                aNation[1] = new cNation("Steamjazz.Wolfgart.txt");
                aNation[2] = new cNation("Steamjazz.Hanseburg.txt");
                aNation[3] = new cNation("Steamjazz.FreeIsland.txt");
                aNation[4] = new cNation("Steamjazz.Kheiman.txt");
                aNation[5] = new cNation("Steamjazz.Crimson.txt");
                switch (selectedIndex)
                {
                    case 1:
                        {
                            aNation[6] = new cNation("Steamjazz.BeastfolkBack.txt");
                            break; 
                        }
                    case 2:
                        {
                            aNation[6] = new cNation("Steamjazz.DracosaurianBack.txt");
                            break; 
                        }
                    case 3:
                        {
                            aNation[6] = new cNation("Steamjazz.GoliathBack.txt");
                            break; 
                        }
                    case 4:
                        {
                            aNation[6] = new cNation("Steamjazz.KharzulDwarfBack.txt");
                            break; 
                        }
                    case 5:
                        {
                            aNation[6] = new cNation("Steamjazz.SylphBack.txt");
                            break;
                        }
                }
            }
        }
        private string textFileString;
        public string TextFileString { get { return textFileString; } }

    }
}
