using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamjazz.Properties;
using System.Reflection;

namespace Steamjazz
{
    class cBackground
    {
        public cBackground()
        {

        }
        private string palautus;
        public string Palautus
        {
            get
            { return palautus; }
            set
            { palautus = value; }
        }
        public string Race(int Box1SelectedIndex)
        {

            if(Box1SelectedIndex==0)
            {
                Palautus = "Steamjazz.Human.txt";
            }
            if (Box1SelectedIndex == 1)
            {
                Palautus = "Steamjazz.Dracosaurian.txt";
            }
            if (Box1SelectedIndex == 2)
            {
                Palautus = "Steamjazz.Sylph.txt";
            }
            if (Box1SelectedIndex == 3)
            {
                Palautus = "Steamjazz.KharzulDwarf.txt";
            }
            if (Box1SelectedIndex == 4)
            {
                Palautus = "Steamjazz.beastfolk.txt";
            }
            if (Box1SelectedIndex == 5)
            {
                Palautus = "Steamjazz.Goliath.txt";
            }
            if (Box1SelectedIndex == 6)
            {
                Palautus = "Steamjazz.Automaton.txt";
            }
            
            return Palautus;
        }
        public string Nationality(int Box2SelectedIndex, int Box1SelectedIndex)
        {
            if (Box1SelectedIndex != 6)
            {

                if (Box2SelectedIndex == 6)
                {
                    switch (Box1SelectedIndex)
                    {
                        case 1:
                            {
                                Palautus = "Steamjazz.BeastfolkBack.txt";
                                break;
                            }
                        case 2:
                            {

                                Palautus = "Steamjazz.DracosaurianBack.txt";
                                break;
                            }
                        case 3:
                            {

                                Palautus = "Steamjazz.GoliathBack.txt";
                                break;
                            }
                        case 4:
                            {

                                Palautus = "Steamjazz.KharzulDwarfBack.txt";
                                break;
                            }
                        case 5:
                            {

                                Palautus = "Steamjazz.SylphBack.txt";
                                break;
                            }
                    }

                }
                //"Victoria", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", muties
                switch(Box2SelectedIndex)
                {
                    case 0:
                        {
                            Palautus = "Steamjazz.Victora.txt";
                            break;
                        }
                    case 1:
                        {
                            Palautus = "Steamjazz.Wolfgart.txt";
                            break;
                        }
                    case 2:
                        {
                            Palautus = "Steamjazz.Hanseburg.txt";
                            break;
                        }
                    case 3:
                        {
                            Palautus = "Steamjazz.FreeIsland.txt";
                            break;
                        }
                    case 4:
                        {
                            Palautus = "Steamjazz.Kheiman.txt";
                            break;
                        }
                        
                    case 5:
                        {
                            Palautus = "Steamjazz.Crimson.txt";
                            break;
                        }

                }
            }
            return Palautus;
        }

        /// <summary>
        /// Palauttaa toivotun resurssinimen
        /// </summary>
        /// <param name="Box2SelectedIndex"></param>
        /// comboBox2.SelectedIndex:n arvo
        /// <param name="Box3SelectedIndex"></param>
        /// comboBox3.SelectedIndex:n arvo
        /// <returns></returns>
        
        public string SocialClass(int Box2SelectedIndex, int Box3SelectedIndex)
        {
            
            //string teksti;
            if (Box2SelectedIndex==0)
            {
                //victoria
                if (Box3SelectedIndex==0)
                {
                    //low class
                    Palautus = "Steamjazz.VictoranLow.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //middle clas
                    Palautus = "Steamjazz.VictoraMiddle.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    Palautus = "Steamjazz.VictoraUpper.txt";
                }
            }
            if (Box2SelectedIndex==1)
            {
                if (Box3SelectedIndex==0)
                {
                    //worker
                    Palautus = "Steamjazz.WolfgartWorker.txt";
                }
                // wolfgart
                if (Box3SelectedIndex==1)
                {
                    Palautus = "Steamjazz.WolfgartMilitary.txt";
                }
                
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    Palautus = "Steamjazz.WolfgartUpper.txt";
                }
            }
            if (Box2SelectedIndex==2)
            {
                //kheiman empire
                if (Box3SelectedIndex==0)
                {
                    // Worker
                    Palautus = "Steamjazz.KheimanWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //warior
                    Palautus = "Steamjazz.KheimanWarior.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //clergy
                    Palautus = "Steamjazz.KheimanClergy.txt";
                }
            }
            if (Box2SelectedIndex==3)
            {
                //hanseburg
                if (Box3SelectedIndex==0)
                {
                    //Worker
                    Palautus = "Steamjazz.HanseburgWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //merchant
                    Palautus = "Steamjazz.HanseburgMerchant.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //noble
                    Palautus = "Steamjazz.HanseburgNoble.txt";
                }
            }
            if (Box2SelectedIndex==4)
            {
                //crimson empire
                if (Box3SelectedIndex==0)
                {
                    //Monk
                    Palautus = "Steamjazz.CrimsonCommoner.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //military
                    Palautus = "Steamjazz.CrimsonMilitary.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //commoner
                    Palautus = "Steamjazz.CrimsonMonk.txt";
                }
            }
            if (Box2SelectedIndex==5)
            {
                if (Box3SelectedIndex==1)
                {
                    //island folk
                    Palautus = "Steamjazz.FreeIslandFolk.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //pirate
                    Palautus = "Steamjazz.FreePirate.txt";
                }
                //free islands
                if (Box3SelectedIndex==2)
                {
                    //Pelethok
                    Palautus = "Steamjazz.FreePelethok.txt";
                }
                
                
                
            }
            return Palautus;
        }

    }
}

