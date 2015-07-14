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
        private cRace[] nations = new cRace[7];
        public cBackground()
        {
            nations[0] = new cRace("Steamjazz.Human.txt", 0);
            nations[1] = new cRace("Steamjazz.Dracosaurian.txt", 1);
            nations[2] = new cRace("Steamjazz.Sylph.txt", 2);
            nations[3] = new cRace("Steamjazz.KharzulDwarf.txt", 3);
            nations[4] = new cRace("Steamjazz.beastfolk.txt", 4);
            nations[5] = new cRace("Steamjazz.Goliath.txt", 5);
            nations[6] = new cRace("Steamjazz.Automaton.txt", 6);
        }
        private string palautus;
        public string Palautus
        {
            get
            { return palautus; }
            set
            { palautus = value; }
        }
        public string Race(int box1SelectedIndex)
        {
            
            if (box1SelectedIndex == -1) { return null; }
            else { return nations[box1SelectedIndex].TextFileString; }
            
        }
        public string Nationality(int box1SelectedIndex, int box2SelectedIndex)
        {
            if (box1SelectedIndex == -1) { return null; }
            else { return nations[box1SelectedIndex].NationTextFile(box2SelectedIndex); }
        }

        /// <summary>
        /// Palauttaa toivotun resurssinimen
        /// </summary>
        /// <param name="Box2SelectedIndex"></param>
        /// comboBox2.SelectedIndex:n arvo
        /// <param name="Box3SelectedIndex"></param>
        /// comboBox3.SelectedIndex:n arvo
        /// <returns></returns>
        private void VictoraText()
        {
            Form1 formi = new Form1();
            if (formi.ComboBox3.SelectedIndex == 0)
            {
                //low class
                Palautus = "Steamjazz.VictoranLow.txt";
            }
            if (formi.ComboBox3.SelectedIndex == 1)
            {
                //middle clas
                Palautus = "Steamjazz.VictoraMiddle.txt";
            }
            if (formi.ComboBox3.SelectedIndex == 2)
            {
                // upper class
                Palautus = "Steamjazz.VictoraUpper.txt";
            }
        }
        public string SocialClass(int Box2SelectedIndex, int Box3SelectedIndex)
        {
            
            //string teksti;
            if (Box2SelectedIndex==0) VictoraText();
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
            if (Box2SelectedIndex==4)
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
            if (Box2SelectedIndex==2)
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
            if (Box2SelectedIndex==5)
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
            if (Box2SelectedIndex==3)
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

