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
                return "steamjazz.Human.txt";
            }
            if (Box1SelectedIndex == 1)
            {
                return "steamjazz.Dracosaurian.txt";
            }
            if (Box1SelectedIndex == 2)
            {
                return "steamjazz.Sylph.txt";
            }
            if (Box1SelectedIndex == 3)
            {
                return "steamjazz.KharzulDwarf.txt";
            }
            if (Box1SelectedIndex == 4)
            {
                return "steamjazz.Beastfolk.txt";
            }
            if (Box1SelectedIndex == 5)
            {
                return "steamjazz.Goliath.txt";
            }
            if (Box1SelectedIndex == 6)
            {
                return "steamjazz.Automaton.txt";
            }
            
            return "-1";
        }
        public string Nationality(int Box2SelectedIndex, int Box1SelectedIndex)
        {
            if (Box2SelectedIndex==6)
            {
                switch(Box1SelectedIndex)
                {
                    case 1:
                        {

                            return "steamjazz.DracosaurianBack.txt";
                        }
                    case 2:
                        {

                            return "steamjazz.SylphBack.txt";
                        }
                    case 3:
                        {

                            return "steamjazz.KharzulDwarfBack.txt";
                        }
                    case 4:
                        {

                            return "steamjazz.BeastfolkBack.txt";
                        }
                    case 5:
                        {

                            return "steamjazz.GoliathBack.txt";
                        }
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
                    return "steamjazz.VictoranLow.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //middle clas
                    return "steamjazz.VictoranMiddle.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    return "steamjazz.VictoraUpper.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==1)
            {
                // wolfgart
                if (Box3SelectedIndex==0)
                {
                    return "steamjazz.WolfgartMilitary.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //worker
                    return "steamjazz.WolfgartWorker.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    // upper class
                    return "steamjazz.WolfgartUpper.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==2)
            {
                //kheiman empire
                if (Box3SelectedIndex==0)
                {
                    // Worker
                    return "steamjazz.KheimanWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //warior
                    return "steamjazz.KheimanWarior.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //clergy
                    return "steamjazz.KheimanClergy.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==3)
            {
                //hanseburg
                if (Box3SelectedIndex==0)
                {
                    //Worker
                    return "steamjazz.HanseburgWorker.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //merchant
                    return "steamjazz.HanseburgMerchant.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //noble
                    return "steamjazz.HanseburgNoble.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==4)
            {
                //crimson empire
                if (Box3SelectedIndex==0)
                {
                    //Monk
                    return "steamjazz.CrimsonCommoner.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //military
                    return "steamjazz.CrimsonMilitary.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //commoner
                    return "steamjazz.CrimsonMonk.txt";
                }
                return "-1";
            }
            if (Box2SelectedIndex==5)
            {
                //free islands
                if (Box3SelectedIndex==0)
                {
                    //Pelethok
                    return "steamjazz.FreePelethok.txt";
                }
                if (Box3SelectedIndex==1)
                {
                    //pirate
                    return "steamjazz.FreePirate.txt";
                }
                if (Box3SelectedIndex==2)
                {
                    //island folk
                    return "steamjazz.FreeIslandFolk.txt";
                }
                return "-1";
            }
            return "-1";
        }
    }
}

