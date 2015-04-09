﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using steamjazz.Properties;
using System.Reflection;



namespace steamjazz
{
    public partial class Form1 : Form
        
    {
        public void tabbi()
        {
            
            string title = "Create " + (tabControl1.TabCount + 1).ToString();
            TabPage Create = new TabPage(title);
            tabControl1.TabPages.Add(Create);
        }
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            attributeChange("10","10","10","10","10","10","10","10");
        }
       
        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            attributeChange("10", "10", "10", "10", "10", "10", "10", "10");
            int backgroundcase = comboBox2.SelectedIndex;
            if (backgroundcase == 1 || comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            comboBox2.Items.Clear();
            switch(comboBox1.SelectedIndex)
            {// rodun infon näyttäminen, sekä rodullisten erikoistaustojen lisääminen taustalistoihin
                case 0:
                    {
                        string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                        comboBox2.Items.AddRange(background);

                        var assembly = Assembly.GetExecutingAssembly();
                        List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                        var resourceName = "steamjazz.Human.txt";

                        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                        using (StreamReader sr = new StreamReader(stream))
                        {
                            String line = sr.ReadToEnd();
                            richTextBox1.Text = line;
                        }

                        break;
                    }
                case 1:
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Dracosaurian" };
                comboBox2.Items.AddRange(background);
                /*
                 * CHA -2, REF +1; allocate +1 to one of the following: STR,
                 * CON or DEX
                 */
               
                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Dracosaurian.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                    //automationeiden yhteinen rotuinfo
                case 2:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Automatons.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 3:
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Sylph" };
                comboBox2.Items.AddRange(background);

                attributeChange("str", -1);
                attributeChange("dex", 1);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Sylph.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 4:
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Kharzul Dwarf" };
                comboBox2.Items.AddRange(background);

                attributeChange("cha", -2);
                attributeChange("con", 2);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.KharzulDwarf.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 5:
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Beastfolk" };
                comboBox2.Items.AddRange(background);
                attributeChange("emp", -1);
                attributeChange("cha", -2);
                
                string[] list = new string[] { "STR", "CON", "DEX","REF","WIT" };
                /*
                     * EMP -1, CHA -2, allocate +2 to one of the following attributes:
                     * STR, CON, DEX, REF, WIT and +1 to another attribute from
                     * the list.
                     */
                groupBox2.Visible = true;
                radioButton12.Visible = false;

                
                
                

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.beastfolk.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 6:
            {
                attributeChange("str", 3);
                attributeChange("con", 3);
                attributeChange("dex", -2);
                attributeChange("ref", -2);
                attributeChange("int", -1);
                attributeChange("wit", -1);
                attributeChange("emp", -3);
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Goliath" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Goliath.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
        }
            
        }
        
        private void combobox3init(string eka, string toka, string kolme)
        {
            //Valmistellaan comboBox3 vastaanottamaan eri kansalaisuuksien luokkamahdollisuudet
            comboBox3.Items.Clear();
            string[] race = new string[]{eka,toka,kolme};
            comboBox3.Items.AddRange(race);
            comboBox3.Visible = true;
            comboBox3.SelectedIndex = 0;
        }

        private void combobox5init(string militarybg)
        {
            //Valmistellaan comboBox5 vastaanottamaan eri kansalaisuuksien luokkamahdollisuudet
            comboBox5.Items.Clear();
            string[] mili = new string[] { militarybg };
            comboBox5.Items.AddRange(mili);

            comboBox5.Visible = false;
            comboBox5.SelectedIndex = 0;
        }
	
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // riippuen kansalaisuudesta, luokkavaihtoehdot vaihtuvat. Valinnoista riippuen label5 saa eri tekstin. nuthing more to see here - moving along
            int backgroundcase = comboBox2.SelectedIndex;
            if (backgroundcase == 1 || comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            switch (backgroundcase)
            {
                case 0:
                    {
                        //Victoria
                        combobox3init("Lower Class","Middle Class","Upper Class");
                        
                        break;
                    }
                case 1:
                    {
                        //Wolfgart
                        combobox3init("Military","Worker","Upper Class");
                        
                        break;
                    }
                case 2:
                    {
                        //Kheiman Empire                        
                        combobox3init("Worker","Warrior","Clergy");
                       
                        break;
                    }
                case 3:
                    {
                        //Hansenburg
                        combobox3init("Worker","Merchant","Noble");
                        
                        break;
                    }
                case 4:
                    {
                        //Crimson Empire
                        combobox3init("Monk","Military","Commoner");
                        
                        break;
                    }
                case 5:
                    {
                        //Free Islands
                        combobox3init("Pelethok","Pirate","Island Folk");
                       
                        break;
                    }
                case 6:
                    {
                       
                        if (comboBox1.SelectedIndex == 1)
                        {
                            attributeChange("int", 1);
                            var assembly = Assembly.GetExecutingAssembly();
                            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                            var resourceName = "steamjazz.DracosaurianBack.txt";

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                String line = sr.ReadToEnd();
                                richTextBox1.Text = line;
                            }

                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            attributeChange("ref", 1);
                            var assembly = Assembly.GetExecutingAssembly();
                            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                            var resourceName = "steamjazz.SylphBack.txt";

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                String line = sr.ReadToEnd();
                                richTextBox1.Text = line;
                            }

                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            attributeChange("int", 1);
                            var assembly = Assembly.GetExecutingAssembly();
                            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                            var resourceName = "steamjazz.KharzulDwarfBack.txt";

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                String line = sr.ReadToEnd();
                                richTextBox1.Text = line;
                            }

                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            attributeChange("con", 1);
                            var assembly = Assembly.GetExecutingAssembly();
                            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                            var resourceName = "steamjazz.BeastfolkBack.txt";

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                String line = sr.ReadToEnd();
                                richTextBox1.Text = line;
                            }

                        }
                        if (comboBox1.SelectedIndex == 6)
                        {
                            attributeChange("con", 1);
                            attributeChange("cha", -1);
                            var assembly = Assembly.GetExecutingAssembly();
                            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                            var resourceName = "steamjazz.GoliathBack.txt";

                            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                String line = sr.ReadToEnd();
                                richTextBox1.Text = line;
                            }

                        }
                        break;
                    }
              
                default:
                    comboBox3.Visible = false;
                    break;
            }
        }
        private void InitializeComboBox()
        {
            // Combobox1 info 
            string[] race = new string[]{"Human","Dracosaurian","Basic","Sylph","Kharzul Dwarf"
            ,"Beastfolk","Goliath","Butler","Copper","Craftsman","Doll","Heavy Worker"};
            comboBox1.Items.AddRange(race);
            //
            //Combobox2 info Default tehdään comboBox1_SelectedIndexChanged funktiossa
            //
            /*
            * string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
            * comboBox2.Items.AddRange(background);
            */
            
            //
            //Combobox4 info
            //
            string[] career = new string[] { "Aristocrat","Artist","Assassin","Banker","Butler","Con Artist","Craftsman","Detective","Druid",
                "Entertainer","Gangster","Gunner","Hunter","Inventor","Journalist","Law Enforcer","Lawyer","Martial Artist","Mechanic","Mercenary",
                "Merchant","Musketeer","Officer","Personal Entertainer","Physician","Pirate","Politician","Ranger","Rogue","Sailor","Scholar",
                "Scout","Servant","Soldier","Spy","Warrior","Wyrodian Priest"};
            comboBox4.Items.AddRange(career);

            string[] mili = new string[] { "Deserter", "Military Service", "Non-military Service" };
            comboBox5.Items.AddRange(mili);
            //
            //Combobox5 info
            //
        }


          private void Seivi(Object sender, EventArgs e)
        {
            button3.Click += new EventHandler(this.button3_Click);
            DBConnect komento = new DBConnect();
            komento.Insert("INSERT INTO info (name, race, background, career, occupation, gender, age, player) VALUES('JP', 'Human', 'Noble', 'Smith', 'Smith', 'Male', '25', 'JP')");
        }

        private void button3_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("INSERT into info (name, race, background, career, occupation, gender, age, player) VALUES('JP', 'Human', 'Noble', 'Smith', 'Smith', 'Male', '25', 'JP')");
        }

       // private void Update(Object sender, EventArgs e)
       // {
       // button1.Click += new EventHandler(this.button1_Click);
       //    DBConnect komento = new DBConnect();
       //   komento.Insert("UPDATE info SET name="+textBox1.Text+", race="+comboBox1.Text+", background="+comboBox2.Text+", career="+comboBox3.Text+", occupation="+comboBox4.Text+", gender, age, player WHERE name="+textBox1.Text+"");
       // }
        public void tulostus (string e)
        {
            richTextBox1.Text = e;
        
        }
        /// <summary>
        /// Taustan valinta tapahtuu combobox3:ssa. RichTextBox tulostaa tarvittavan informaation taustoista
        /// </summary>
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int backgroundcase = comboBox2.SelectedIndex;
            if (backgroundcase == 1 || comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            //string teksti;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        //victoria
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    //low class
                                    attributeChange("con", 1);
                                    richTextBox1.Text = "CON +1\r\n" +
                                                    "Initial skill ranks: Survival 2, Brawl 1, Stealth 1\r\n" +
                                                    "15 CP can be used to buy ranks in the following skills: Animal\r\n" +
                                                    "Handling, Bluff, Brawl, Climb, Cooking, First Aid, Gaming,\r\n" +
                                                    "Handguns, Intimidate, Listen, Melee (Balanced), Melee\r\n" +
                                                    "(Powerful), Spot, Stealth, Survival, Throw, Track.\r\n" +
                                                    "Starting Wealth level\r\n" +
                                                    "cannot be higher than ‘Well off’\r\n\r\n" +
                                                    "Adventuring as a Lower Class Victoran:\r\n" +
                                                    "It isn’t hard to find reasons for a lower class Victoran to leave" +
                                                    "her normal life behind and starting a career as an adventurer." +
                                                    "Almost any alternative would be an improvement to the" +
                                                   " monotony of endless labour. If given the chance, many Victoran" +
                                                    "lower class people would take up the offer to join a mercenary" +
                                                    "group or another adventuring opportunity, but many of the" +
                                                    "downtrodden lack the imagination or the ambition to rise above" +
                                                    "the squalor that is the only life they have ever known.\r\n\r\n" +
                                                    "Suggested careers: Con Artist, Craftsman, Hunter, Mercenary," +
                                                    "Rogue, Sailor, Scout, Soldier, Warrior\r\n\r\n" +
                                                    "Typical names:\r\n" +
                                                    "Victoran lower class people have short, typically English" +
                                                    "sounding names. Southern Victoran names have a more French" +
                                                    "or South European flavour. Female names include Amy, Brett," +
                                                    "Hannah, Katie and Pepper, male names include Ash, Bob, Brad," +
                                                    "Cole, John and Stan. Surnames are simple, and often describe" +
                                                    "the family trade or are otherwise descriptive, like Brown, Hill," +
                                                    "Miller, Smith and Tanner.\r\n";
                                    break;
                                }
                            case 1:
                                {
                                    //middle clas
                                    attributeChange("wit", 1);
                                    richTextBox1.Text = "WIT +1\r\n" +
                                                    "Initial skill ranks: Appraise 2, Bargain 1, Diplomacy 1\r\n" +
                                                    "15 CP can be used to buy ranks in the following skills:\r\n" +
                                                    "Appraise, Bargain, Bluff, Brawl, Craft (any), Cooking," +
                                                    "Diplomacy, Etiquette, Handguns, Intimidate, Martial Arts" +
                                                    "(Victoran Pugilism), Mechanics, Perform (dancing), Persuade," +
                                                    "Profession (any), Ride.\r\n\r\n" +
                                                    "Adventuring as Middle Class Victoran: \r\n " +
                                                    "Many reasons could encourage a middle class Victoran to start" +
                                                    "a career as an adventurer. She could see it as an opportunity to" +
                                                    "earn a large amount of wealth quickly in order to improve her" +
                                                    "lifestyle and perhaps reach the status as a member of the upper" +
                                                    "class. She may wish to break the dull everyday routines of life" +
                                                    "at work and get to see the world. Some do it for love, some do" +
                                                    "it for hate. Some are driven by betrayal, oath or wager, and" +
                                                    "some do it just to experience something new and maybe have" +
                                                    "some fun in the meantime.r\n\r\n" +
                                                    "Suggested careers:\r\n Artist, Banker, Butler, Craftsman," +
                                                    "Detective, Inventor, Journalist, Law Enforcer, Mechanic," +
                                                    "Merchant, Scholar, Spy, Wyrodian Priestr\n\r\n" +
                                                    "Typical names:r\n" +
                                                    "The Victoran middle class people have a wide variety of names," +
                                                    "mostly somewhat longer English-sounding names than the" +
                                                    "lower class. Southern Victoran names have a more French or" +
                                                    "Southern European flavour. Female names include Aileen," +
                                                    "Caitlin, Diana, Fanny, Isabel and Perlie, male names include" +
                                                    "Alexis, Barney, Eddie, Harold, Jayson and Norbert . Surnames" +
                                                    "are usually carried by the families over generations and often" +
                                                    "refer to the business or craft of the family or the place from" +
                                                    "which they originate, such as Allclock, Blackwood, Taylor and" +
                                                    "Wright. Patronymics (although usually from an ancestor from" +
                                                    "several generations ago), such as Stevenson, are also common.";
                                    break;
                                }
                            case 2:
                                {
                                    // upper class
                                    attributeChange("cha", 1);
                                    richTextBox1.Text = "Cost to play: 10CP\r\n" +
                                                    "CHA +1\r\n" +
                                                    "Initial skill ranks: Etiquette 3, Diplomacy 2, Language: Victoran 1" +
                                                    "The Starting wealth level of Victoran upper class characters" +
                                                    "must be Drifter or higher. The 5 CP cost of Drifter has already" +
                                                    "been calculated into the Background cost and can be further" +
                                                    "increased with CP during character creation.15 CP can be used " +
                                                    "to buy ranks in the following skills: Art (any), Charm, Diplomacy," +
                                                    "Etiquette, Knowledge: Heraldry," +
                                                    "Language (Victoran), Long Guns, Martial Arts (Fencing)," +
                                                    "Melee (Finesse), Melee (Balanced), Perform (Dancing)," +
                                                    "Perform (Oratory), Ride, or to improve the" +
                                                    "Starting wealth level by 10 CP or to purchase the" +
                                                    "Noble, Victoran advantager\r\n\r\n" +
                                                    "Adventuring as Upper Class Victoran:\r\n" +
                                                    "Some of the upper class Victorans have duties that lead them to" +
                                                    "an adventurer’s life, such as diplomatic missions to foreign" +
                                                    "countries, working as spies or leading expeditions to conquer" +
                                                    "new lands. Business may take some of the more hands-on" +
                                                    "industrialists onto long trips and adventures. However, most of" +
                                                    "the upper class Victorans who have taken up adventuring are" +
                                                    "those youngsters who have gotten tired of the strict regulations" +
                                                    "of upper class life and have left it behind to see the world.\r\n\r\n" +
                                                    "Suggested careers: Assassin, Inventor, Journalist, Lawyer," +
                                                    "Officer, Physician, Politician, Scholar, Spy\r\n\r\n" +
                                                    "Typical names:\r\n" +
                                                    "The Victoran upper class people prefer long, elaborate names." +
                                                    "The differences between northern and southern naming" +
                                                    "conventions are less prominent among the upper class, as many" +
                                                    "upper class families have merged through marriage across the" +
                                                    "whole country. Female names include Annabelle, Eleanora," +
                                                    "Ophelia, Patricia, Ravenna and Seraphina, male names include" +
                                                    "Alexander, Beaumont, Leonard, Quentin, Radclyffe and" +
                                                    "Theodore. Family names are important, and are presented with" +
                                                    "pride, as the name carries with it the power behind the" +
                                                    "individual. Notable noble surnames include the names of the" +
                                                    "ducal families: Charleston, MacLachlan, O’Callaghan and" +
                                                    "Neville.";
                                    break;
                                }
                        }
                        break;
                    }
                case 1:
                    {
                        // wolfgart
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    // Military
                                    attributeChange("str", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.WolfgartMilitary.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    
                                    break;
                                }
                            case 1:
                                {
                                    //worker
                                    attributeChange("con", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.WolfgartWorker.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    // upper class
                                    attributeChange("cha", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.WolfgartUpper.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        //kheiman empire
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    // Worker
                                    attributeChange("con", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.KheimanWorker.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                     using (StreamReader sr = new StreamReader(stream))
                                     {
                                         String line = sr.ReadToEnd();
                                         richTextBox1.Text = line;
                                     }
                                    break;
                                }
                            case 1:
                                {
                                    //warior
                                    attributeChange("str", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.KheimanWarior.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                    
                                }
                            case 2:
                                {
                                    //clergy
                                    attributeChange("int", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.KheimanClergy.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        //hanseburg
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    //Worker
                                    attributeChange("int", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.HanseburgWorker.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    //merchant
                                    attributeChange("wit", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.HanseburgMerchant.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    //noble
                                    attributeChange("cha", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.HanseburgNoble.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        //crimson empire
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    //Monk
                                    attributeChange("int", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.CrimsonCommoner.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    //military
                                    attributeChange("dex", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.CrimsonMilitary.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    //commoner
                                    attributeChange("con", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.CrimsonMonk.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 5:
                    {
                        //free islands
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    //Pelethok
                                    attributeChange("int", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.FreePelethok.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    //pirate
                                    attributeChange("ref", 1);
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.FreePirate.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    //island folk
                                   
                                    var assembly = Assembly.GetExecutingAssembly();
                                    List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                                    var resourceName = "steamjazz.FreeIslandFolk.txt";

                                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                                    using (StreamReader sr = new StreamReader(stream))
                                    {
                                        String line = sr.ReadToEnd();
                                        richTextBox1.Text = line;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                
                      
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            List<string> rs = new List<string>(assembly.GetManifestResourceNames());
            var resourceName = "steamjazz.WolffgartService.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader sr = new StreamReader(stream))
            {
                String line = sr.ReadToEnd();
                richTextBox1.Text = line;
            }
        }

        /// <summary>
        /// Attribuuttien sähellykset alkaa tästä
        /// todo:
        /// attributeAdd tarkistaa kutsuneen objektin ja sen mukaan lisää oikeata attribuuttia
        /// attributeAdd poistaa lisäyksen vaativan pistemäärän
        /// attributeAdd tarkistaa voiko samaa attribuuttia lisätä vielä kertaalleen, mikäli ei lähettävä objecti enabled=false
        /// AttributeTake vähentää kutsuneen objektiin liittyvää attribuuttia
        /// attributeTake antaa kyseisen attribuutin lisäävälle objektille enabled=true
        /// attributeTake antaa poiston mukaisen pistemäärän.
        /// </summary>
       
        private void attributeChange(string Str, string Con, string Dex, string Ref, string Int, string Wit, string Cha, string Emp )
        {
            
            label6.Text = Str;
            label8.Text = Con;
            label10.Text = Dex;
            label12.Text = Ref;
            label30.Text = Int;
            label33.Text = Wit;
            label35.Text = Cha;
            label37.Text = Emp;

        }
        private void attributeChange(string att, int change)
        {
            switch (att)
            {
                case "str":
                    {
                        label6.Text = Convert.ToString(Convert.ToInt32(label6.Text) + change);
                        break;
                    }
                case "con":
                    {
                        label8.Text = Convert.ToString(Convert.ToInt32(label8.Text) + change);
                        break;
                    }
                case "dex":
                    {
                        label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + change);
                        break;
                    }
                case "ref":
                    {
                        label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + change);
                        break;
                    }
                case "int":
                    {
                        label30.Text = Convert.ToString(Convert.ToInt32(label30.Text) + change);
                        break;
                    }
                case "wit":
                    {
                        label33.Text = Convert.ToString(Convert.ToInt32(label33.Text) + change);
                        break;
                    }
                case "cha":
                    {
                        label35.Text = Convert.ToString(Convert.ToInt32(label35.Text) + change);
                        break;
                    }
                case "emp":
                    {
                        label37.Text = Convert.ToString(Convert.ToInt32(label37.Text) + change);
                        break;
                    }
            }
        }
        private void attributeChange(string att, int change, int points)
        {
            switch (att)
            {
                case "str":
                    {
                        label6.Text = Convert.ToString(Convert.ToInt32(label6.Text) + change);
                        break;
                    }
                case "con":
                    {
                        label8.Text = Convert.ToString(Convert.ToInt32(label8.Text) + change);
                        break;
                    }
                case "dex":
                    {
                        label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + change);
                        break;
                    }
                case "ref":
                    {
                        label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + change);
                        break;
                    }
                case "int":
                    {
                        label30.Text = Convert.ToString(Convert.ToInt32(label30.Text) + change);
                        break;
                    }
                case "wit":
                    {
                        label33.Text = Convert.ToString(Convert.ToInt32(label33.Text) + change);
                        break;
                    }
                case "cha":
                    {
                        label35.Text = Convert.ToString(Convert.ToInt32(label35.Text) + change);
                        break;
                    }
                case "emp":
                    {
                        label37.Text = Convert.ToString(Convert.ToInt32(label37.Text) + change);
                        break;
                    }
            }
        }
        
        private void attributeAdd(Object sender, EventArgs e)
        {
            if (sender==label13)
            {
                attributeChange("str", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label15)
            {
                attributeChange("con", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label17)
            {
                attributeChange("dex", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label19)
            {
                attributeChange("ref", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label21)
            {
                attributeChange("int", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label23)
            {
                attributeChange("wit", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label25)
            {
                attributeChange("cha", 1, Convert.ToInt32(label39.Text));
            }
            if (sender == label27)
            {
                attributeChange("emp", 1, Convert.ToInt32(label39.Text));
            }
        }
        private void attributeTake(Object sender, EventArgs e)
        {
            if (sender == label14)
            {//str
                attributeChange("str", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label16)
            {
                attributeChange("con", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label18)
            {
                attributeChange("dex", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label20)
            {
                attributeChange("ref", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label22)
            {
                attributeChange("int", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label24)
            {
                attributeChange("wit", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label26)
            {
                attributeChange("cha", -1, Convert.ToInt32(label39.Text));
            }
            if (sender == label28)
            {
                attributeChange("emp", -1, Convert.ToInt32(label39.Text));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("str", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("str", -1);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("emp", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("emp", -1);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("cha", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("cha", -1);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("wit", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("wit", -1);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("int", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("int", -1);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("ref", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("ref", -1);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("dex", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("dex", -1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("con", 1);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("con", -1);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("str", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("str", -2);
            }
           }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("emp", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("emp", -2);
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("cha", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("cha", -2);
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("wit", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("wit", -2);
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("int", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("int", -2);
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("ref", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("ref", -2);
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("dex", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("dex", -2);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                attributeChange("con", 2);
            }
            if (radioButton9.Checked == false)
            {
                attributeChange("con", -2);
            }
        }




       

      
      
       
    }
}
 
 
