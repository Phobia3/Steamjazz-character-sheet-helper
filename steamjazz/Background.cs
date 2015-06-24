using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamjazz.Properties;
using System.Reflection;

namespace steamjazz
{
    class cBackground
    {
        public cBackground()
        {

        }
        public string Race(int Box1SelectedIndex)
        {
            if(Box1SelectedIndex==0)
            {
                return "Steamjazz.Human.txt";
            }
            if (Box1SelectedIndex == 1)
            {
                return "Steamjazz.Dracosaurian.txt";
            }
            if (Box1SelectedIndex == 2)
            {
                return "Steamjazz.Sylph.txt";
            }
            if (Box1SelectedIndex == 3)
            {
                return "Steamjazz.KharzulDwarf.txt";
            }
            if (Box1SelectedIndex == 4)
            {
                return "Steamjazz.beastfolk.txt";
            }
            if (Box1SelectedIndex == 5)
            {
                return "Steamjazz.Goliath.txt";
            }
            if (Box1SelectedIndex == 6)
            {
                return "Steamjazz.Automaton.txt";
            }
            
            return "-1";
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
                                return "Steamjazz.BeastfolkBack.txt";
                            }
                        case 2:
                            {

                                return "Steamjazz.DracosaurianBack.txt";
                            }
                        case 3:
                            {

                                return "Steamjazz.GoliathBack.txt";
                            }
                        case 4:
                            {

                                return "Steamjazz.KharzulDwarfBack.txt";
                            }
                        case 5:
                            {

                                return "Steamjazz.SylphBack.txt";
                            }
                    }

                }
                //"Victoria", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", muties
                switch(Box2SelectedIndex)
                {
                    case 0:
                        return "Steamjazz.Victora.txt";
                    case 1 :
                        return "Steamjazz.Wolfgart.txt";
                    case 2:
                        return "Steamjazz.Hanseburg.txt";
                    case 3:
                        return "Steamjazz.FreeIsland.txt";
                    case 4:
                        return "Steamjazz.Kheiman.txt";
                    case 5:
                        return "Steamjazz.Crimson.txt";
                }
            }
            
            return "-1";
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
                    return "Steamjazz.VictoranLow.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //middle clas
                    return "Steamjazz.VictoranMiddle.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    return "Steamjazz.VictoraUpper.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==1)
            {
                if (Box3SelectedIndex==0)
                {
                    //worker
                    return "Steamjazz.WolfgartWorker.txt";
                }
                // wolfgart
                if (Box3SelectedIndex==1)
                {
                    return "Steamjazz.WolfgartMilitary.txt";
                }
                
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    return "Steamjazz.WolfgartUpper.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==2)
            {
                //kheiman empire
                if (Box3SelectedIndex==0)
                {
                    // Worker
                    return "Steamjazz.KheimanWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //warior
                    return "Steamjazz.KheimanWarior.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //clergy
                    return "Steamjazz.KheimanClergy.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==3)
            {
                //hanseburg
                if (Box3SelectedIndex==0)
                {
                    //Worker
                    return "Steamjazz.HanseburgWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //merchant
                    return "Steamjazz.HanseburgMerchant.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //noble
                    return "Steamjazz.HanseburgNoble.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==4)
            {
                //crimson empire
                if (Box3SelectedIndex==0)
                {
                    //Monk
                    return "Steamjazz.CrimsonCommoner.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //military
                    return "Steamjazz.CrimsonMilitary.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //commoner
                    return "Steamjazz.CrimsonMonk.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==5)
            {
                if (Box3SelectedIndex==1)
                {
                    //island folk
                    return "Steamjazz.FreeIslandFolk.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //pirate
                    return "Steamjazz.FreePirate.txt";
                }
                //free islands
                if (Box3SelectedIndex==2)
                {
                    //Pelethok
                    return "Steamjazz.FreePelethok.txt";
                }
                
                
                return "-1";
            }
            return "-1";
        }

    }
}

