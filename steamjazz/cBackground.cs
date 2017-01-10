namespace Steamjazz
{
    internal class cBackground
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

        private string Wolfgart(int Box3SelectedIndex)
        {
            if (Box3SelectedIndex == 0)
            {
                //worker
                return "Steamjazz.WolfgartWorker.txt";
            }
            // wolfgart
            if (Box3SelectedIndex == 1)
            {
                return "Steamjazz.WolfgartMilitary.txt";
            }

            if (Box3SelectedIndex == 2)
            {
                // upper class
                return "Steamjazz.WolfgartUpper.txt";
            }
            else
            {
                return "Virhe";
            }
        }

        private string Kheiman(int Box3SelectedIndex)
        {
            //kheiman empire
            if (Box3SelectedIndex == 0)
            {
                // Worker
                return "Steamjazz.KheimanWorker.txt";
            }
            if (Box3SelectedIndex == 1)
            {
                //warior
                return "Steamjazz.KheimanWarior.txt";
            }
            if (Box3SelectedIndex == 2)
            {
                //clergy
                return "Steamjazz.KheimanClergy.txt";
            }
            else
            {
                return "Virhe";
            }
        }

        private string Hanseburg(int Box3SelectedIndex)
        {
            //hanseburg
            if (Box3SelectedIndex == 0)
            {
                //Worker
                return "Steamjazz.HanseburgWorker.txt";
            }
            if (Box3SelectedIndex == 1)
            {
                //merchant
                return "Steamjazz.HanseburgMerchant.txt";
            }
            if (Box3SelectedIndex == 2)
            {
                //noble
                return "Steamjazz.HanseburgNoble.txt";
            }
            else
            {
                return "Virhe";
            }
        }

        private string Crimson(int Box3SelectedIndex)
        {
            //crimson empire
            if (Box3SelectedIndex == 0)
            {
                //Monk
                return "Steamjazz.CrimsonCommoner.txt";
            }
            if (Box3SelectedIndex == 1)
            {
                //military
                return "Steamjazz.CrimsonMilitary.txt";
            }
            if (Box3SelectedIndex == 2)
            {
                //commoner
                return "Steamjazz.CrimsonMonk.txt";
            }
            else
            {
                return "Virhe";
            }
        }

        private string Island(int Box3SelectedIndex)
        {
            if (Box3SelectedIndex == 1)
            {
                //island folk
                return "Steamjazz.FreeIslandFolk.txt";
            }
            if (Box3SelectedIndex == 1)
            {
                //pirate
                return "Steamjazz.FreePirate.txt";
            }
            //free islands
            if (Box3SelectedIndex == 2)
            {
                //Pelethok
                return "Steamjazz.FreePelethok.txt";
            }
            else
            {
                return "Virhe";
            }
        }

        public string SocialClass(int Box2SelectedIndex, int Box3SelectedIndex)
        {
            //string teksti;
            if (Box2SelectedIndex == 0) VictoraText();
            if (Box2SelectedIndex == 1)
            {
                Palautus = Wolfgart(Box3SelectedIndex);
            }
            if (Box2SelectedIndex == 4)
            {
                Palautus = Kheiman(Box3SelectedIndex);
            }
            if (Box2SelectedIndex == 2)
            {
                Palautus = Hanseburg(Box3SelectedIndex);
            }
            if (Box2SelectedIndex == 5)
            {
                Palautus = Crimson(Box3SelectedIndex);
            }
            if (Box2SelectedIndex == 3)
            {
                Palautus = Island(Box3SelectedIndex);
            }
            return Palautus;
        }
    }
}