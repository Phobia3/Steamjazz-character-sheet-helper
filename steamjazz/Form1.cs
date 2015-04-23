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
        object previous;
        object previous2;
        int backPrevious1 = -1;
        int backPrevious2 = -1;
        int backPrevious3 = -1;
        
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
            backAttribute();
            //pohjustuksia
            //attributeChange("10", "10", "10", "10", "10", "10", "10", "10");
            //label39.Text = "72";
            groupBox1.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            groupBox2.Visible = false;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;


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
                
               
                groupBox1.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                
               
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
            {

               

                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Basic.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                
                
                break;

                /*
                "Human","Dracosaurian","Basic","Sylph","Kharzul Dwarf"
            ,"Beastfolk","Goliath","Butler","Copper","Craftsman","Doll","Heavy Worker"*/
            }
                case 7:
            {

                 
                

                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Butler.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 8:
            {

                

                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Copper.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 9:
            {

                
                

                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Craftsman.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 10:
            {

                

                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.Doll.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
                break;
            }
                case 11:
            {


                
                


                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);

                var assembly = Assembly.GetExecutingAssembly();
                List<string> rs = new List<string>(assembly.GetManifestResourceNames());
                var resourceName = "steamjazz.HeavyWorker.txt";

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
               
                
                string[] list = new string[] { "STR", "CON", "DEX","REF","WIT" };
                
                groupBox2.Visible = true;
                radioButton13.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                groupBox1.Visible = true;
                radioButton5.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                

                
                
                

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
            backAttribute();
            // riippuen kansalaisuudesta, luokkavaihtoehdot vaihtuvat. Valinnoista riippuen label5 saa eri tekstin. nuthing more to see here - moving along
            
            if (comboBox2.SelectedIndex == 1 || comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            switch (comboBox2.SelectedIndex)
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
           
        }


        private void button3_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("INSERT INTO info (name, race, background, career, occupation, gender, age, player) VALUES ('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "',' ',' ',' ',' ')");
              
        }


        private void button1_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("UPDATE info SET name='" + textBox1.Text + "', race='" + comboBox1.Text + "', background='" + comboBox3.Text + "', career='" + comboBox4.Text + "', occupation='" + comboBox4.Text + "', gender='', age='', player='' WHERE ID=''");
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
            backAttribute();
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
        private void backAttribute()
        {
            backAttributeTake();
            switch(comboBox1.SelectedIndex)
            {
                    
                case 0:
                    {      
                        // Human
                        break;
                    }
                case 1:
                    {
                        //Dracosaurian
                        attributeChange("cha", -2);
                        attributeChange("ref", 1);
                        break;
                    }
                case 2:
                    {
                        // Basic
                        attributeChange("str", 1);
                        attributeChange("con", 1);
                        attributeChange("emp", -1);
                        break;
                    }
                case 3:
                    {
                        //Sylph
                        attributeChange("str", -1);
                        attributeChange("dex", 1);
                        break;
                    }
                case 4:
                    {
                        // Kharzul Dwarf
                        attributeChange("cha", -2);
                        attributeChange("con", 2);
                        break;
                    }
                case 5:
                    {
                        //Beatfolk
                        attributeChange("emp", -1);
                        attributeChange("cha", -2);
                        break;
                    }
                case 6:
                    {
                        //Goliath
                        attributeChange("str", 3);
                        attributeChange("con", 3);
                        attributeChange("dex", -2);
                        attributeChange("ref", -2);
                        attributeChange("int", -1);
                        attributeChange("wit", -1);
                        attributeChange("emp", -3);
                        break;
                    }
                case 7:
                    {
                        //Buttler
                        attributeChange("str", -1);
                        attributeChange("con", -1);
                        attributeChange("int", 1);
                        attributeChange("cha", 1);
                        attributeChange("emp", 1);
                        break;
                    }
                case 8:
                    {
                        // Copper
                        attributeChange("str", 2);
                        attributeChange("con", 2);
                        attributeChange("emp", -2);
                        attributeChange("cha", -1);
                        break;
                    }
                case 9:
                    {
                        // Craftsman
                        attributeChange("str", 1);
                        attributeChange("con", 1);
                        attributeChange("dex", 1);
                        attributeChange("emp", -1);
                        attributeChange("cha", -1);
                        break;
                    }
                case 10:
                    {
                        //Doll
                        attributeChange("str", -1);
                        attributeChange("con", -1);
                        attributeChange("emp", 1);
                        attributeChange("cha", 2);

                        break;
                    }
                case 11:
                    {
                        //Heavy Worker
                        attributeChange("str", 3);
                        attributeChange("con", 3);
                        attributeChange("dex", -2);
                        attributeChange("ref", -2);
                        attributeChange("emp", -3);
                        attributeChange("cha", -1);
                        break;
                    }
            }
            switch (comboBox2.SelectedIndex)
            {
                    
                case 0:
                    {
                        //Victoria
                        switch(comboBox3.SelectedIndex)
                        {
                            case 0:
                                { 
                                    attributeChange("con", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("wit", 1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", 1);

                                    break;
                                }
                        }
                       
                        break;
                    }
                case 1:
                    {
                        //Wolfgart
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    attributeChange("str", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("con", 1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", 1);

                                    break;
                                }
                        } break;
                    }
                case 2:
                    {
                        //Kheiman Empire                        
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    attributeChange("con", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("str", 1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("int", 1);

                                    break;
                                }
                        } break;
                    }
                case 3:
                    {
                        //Hansenburg
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    attributeChange("int", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("wit", 1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", 1);

                                    break;
                                }
                        } break;
                    }
                case 4:
                    {
                        //Crimson Empire
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    attributeChange("int", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("dex", 1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("con", 1);

                                    break;
                                }
                        } break;
                    }
                case 5:
                    {
                        //Free Islands
                        switch (comboBox3.SelectedIndex)
                        {
                            case 0:
                                {
                                    attributeChange("int", 1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("ref", 1);

                                    break;
                                }
                            case 2:
                                {
                                    groupBox1.Visible = true;
                                    radioButton1.Visible = false;
                                    radioButton2.Visible = true;
                                    radioButton3.Visible = false;
                                    radioButton4.Visible = true;
                                    radioButton5.Visible = false;
                                    radioButton6.Visible = true;
                                    radioButton7.Visible = false;
                                    radioButton8.Visible = true;

                                    break;
                                }
                        } break;
                    }
                case 6:
                    {

                        if (comboBox1.SelectedIndex == 1)
                        {
                            attributeChange("int", 1);
                            

                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            attributeChange("ref", 1);
                           
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            attributeChange("int", 1);
                            
                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            attributeChange("con", 1);
                           
                        }
                        if (comboBox1.SelectedIndex == 6)
                        {
                            attributeChange("con", 1);
                            attributeChange("cha", -1);
                            
                        }

                        }
                        break;
                    }
            backPrevious1 = comboBox1.SelectedIndex;
            backPrevious2 = comboBox2.SelectedIndex;
            backPrevious3 = comboBox3.SelectedIndex;
            }
        private void backAttributeTake()
        {
            switch (backPrevious1)
            {

                case 0:
                    {
                        // Human
                        break;
                    }
                case 1:
                    {
                        //Dracosaurian
                        attributeChange("cha", 2);
                        attributeChange("ref", -1);
                        break;
                    }
                case 2:
                    {
                        // Basic
                        attributeChange("str", -1);
                        attributeChange("con", -1);
                        attributeChange("emp", 1);
                        break;
                    }
                case 3:
                    {
                        //Sylph
                        attributeChange("str", 1);
                        attributeChange("dex", -1);
                        break;
                    }
                case 4:
                    {
                        // Kharzul Dwarf
                        attributeChange("cha", 2);
                        attributeChange("con", -2);
                        break;
                    }
                case 5:
                    {
                        //Beatfolk
                        attributeChange("emp", 1);
                        attributeChange("cha", 2);
                        break;
                    }
                case 6:
                    {
                        //Goliath
                        attributeChange("str", -3);
                        attributeChange("con", -3);
                        attributeChange("dex", 2);
                        attributeChange("ref", 2);
                        attributeChange("int", 1);
                        attributeChange("wit", 1);
                        attributeChange("emp", 3);
                        break;
                    }
                case 7:
                    {
                        //Buttler
                        attributeChange("str", 1);
                        attributeChange("con", 1);
                        attributeChange("int", -1);
                        attributeChange("cha", -1);
                        attributeChange("emp", -1);
                        break;
                    }
                case 8:
                    {
                        // Copper
                        attributeChange("str", -2);
                        attributeChange("con", -2);
                        attributeChange("emp", 2);
                        attributeChange("cha", 1);
                        break;
                    }
                case 9:
                    {
                        // Craftsman
                        attributeChange("str", -1);
                        attributeChange("con", -1);
                        attributeChange("dex", -1);
                        attributeChange("emp", 1);
                        attributeChange("cha", 1);
                        break;
                    }
                case 10:
                    {
                        //Doll
                        attributeChange("str", 1);
                        attributeChange("con", 1);
                        attributeChange("emp", -1);
                        attributeChange("cha", -2);

                        break;
                    }
                case 11:
                    {
                        //Heavy Worker
                        attributeChange("str", -3);
                        attributeChange("con", -3);
                        attributeChange("dex", 2);
                        attributeChange("ref", 2);
                        attributeChange("emp", 3);
                        attributeChange("cha", 1);
                        break;
                    }
            }
            switch (backPrevious2)
            {
                case 0:
                    {
                        //Victoria
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("con", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("wit", -1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", -1);

                                    break;
                                }
                        }

                        break;
                    }
                case 1:
                    {
                        //Wolfgart
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("str", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("con", -1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", -1);

                                    break;
                                }
                        } break;
                    }
                case 2:
                    {
                        //Kheiman Empire                        
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("con", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("str", -1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("int", -1);

                                    break;
                                }
                        } break;
                    }
                case 3:
                    {
                        //Hansenburg
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("int", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("wit", -1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("cha", -1);

                                    break;
                                }
                        } break;
                    }
                case 4:
                    {
                        //Crimson Empire
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("int", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("dex", -1);

                                    break;
                                }
                            case 2:
                                {
                                    attributeChange("con", -1);

                                    break;
                                }
                        } break;
                    }
                case 5:
                    {
                        //Free Islands
                        switch (backPrevious3)
                        {
                            case 0:
                                {
                                    attributeChange("int", -1);

                                    break;
                                }
                            case 1:
                                {
                                    attributeChange("ref", -1);

                                    break;
                                }
                            case 2:
                                {
                                    groupBox1.Visible = true;
                                    radioButton1.Visible = false;
                                    radioButton2.Visible = true;
                                    radioButton3.Visible = false;
                                    radioButton4.Visible = true;
                                    radioButton5.Visible = false;
                                    radioButton6.Visible = true;
                                    radioButton7.Visible = false;
                                    radioButton8.Visible = true;

                                    break;
                                }
                        } break;
                    }
                case 6:
                    {

                        if (backPrevious1 == 1)
                        {
                            attributeChange("int", -1);


                        }
                        if (backPrevious1 == 3)
                        {
                            attributeChange("ref", -1);

                        }
                        if (backPrevious1 == 4)
                        {
                            attributeChange("int", -1);

                        }
                        if (backPrevious1 == 5)
                        {
                            attributeChange("con", -1);

                        }
                        if (backPrevious1 == 6)
                        {
                            attributeChange("con", -1);
                            attributeChange("cha", 1);

                        }

                    }
                    break;
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
        private int pointCalc(int x,int points, int change)
        {
            int[] hinta = new int[] {0,1,4,9,16,25,36,49,64 };
            
            if (x<10)
            {
                    points = points - change * 5;
            }
            if(x==10 && change <0)
            {
                points = points - change * 5;
            }
            if (x == 10 && change >0)
            {
                while(change>0)
                {

                    points = points - hinta[change];
                    change--;
                }
            }
            if(x>10)
            {
                if (change > 0)
                {
                    
                    int diff = 0;
                    diff = x - 10;
                    
                    points = points - hinta[diff+change];

                }
                if(change<0)
                {
                    int diff = 0;
                    diff = x - 10;
                    points = points + hinta[diff];


                }
            }
            return points;
        }
        private void attributeChange(string att, int change, int points)
        {
            
            switch (att)
            {
                case "str":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label6.Text), points, change));
                        label6.Text = Convert.ToString(Convert.ToInt32(label6.Text) + change);
                        break;
                    }
                case "con":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label8.Text), points, change));
                        label8.Text = Convert.ToString(Convert.ToInt32(label8.Text) + change);
                        break;
                    }
                case "dex":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label10.Text), points, change));
                        label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + change);
                        break;
                    }
                case "ref":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label12.Text), points, change));
                        label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + change);
                        break;
                    }
                case "int":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label30.Text), points, change));
                        label30.Text = Convert.ToString(Convert.ToInt32(label30.Text) + change);
                        break;
                    }
                case "wit":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label33.Text), points, change));
                        label33.Text = Convert.ToString(Convert.ToInt32(label33.Text) + change);
                        break;
                    }
                case "cha":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label35.Text), points, change));
                        label35.Text = Convert.ToString(Convert.ToInt32(label35.Text) + change);
                        break;
                    }
                case "emp":
                    {
                        label39.Text= Convert.ToString(pointCalc(Convert.ToInt32(label37.Text), points, change));
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
         private void radioAdd(Object sender, EventArgs e)
        {
            if (sender == radioButton1 )
            {//str
                attributeChange("str", 1);
            }
            if (sender == radioButton2)
            {
                attributeChange("con", 1);
            }
            if (sender == radioButton3 )
            {
                attributeChange("dex", 1);
            }
            if (sender == radioButton4)
            {
                attributeChange("ref", 1);
            }
            if (sender == radioButton5)
            {
                attributeChange("int", 1);
            }
            if (sender == radioButton6)
            {
                attributeChange("wit", 1);
            }
            if (sender == radioButton7)
            {
                attributeChange("cha", 1);
            }
            if (sender == radioButton8)
            {
                attributeChange("emp", 1);
            }

            
            radioTake(previous);
            previous = sender;
        }
        private void radioAdd2(object sender, EventArgs e)
         {
             if (sender == radioButton9)
             {//str
                 attributeChange("str", 2);
                 radioButton1.Visible = false;
             }
             if (sender == radioButton10)
             {
                 attributeChange("con", 2);
                 radioButton2.Visible = false;
             }
             if (sender == radioButton11)
             {
                 attributeChange("dex", 2);
                 radioButton3.Visible = false;
             }
             if (sender == radioButton12)
             {
                 attributeChange("ref", 2);
                 radioButton4.Visible = false;
             }
             if (sender == radioButton13)
             {
                 attributeChange("int", 2);
                 radioButton5.Visible = false;
             }
             if (sender == radioButton14)
             {
                 attributeChange("wit", 2);
                 radioButton6.Visible = false;
             }
             if (sender == radioButton15)
             {
                 attributeChange("cha", 2);
                 radioButton7.Visible = false;
             }
             if (sender == radioButton16)
             {
                 attributeChange("emp", 2);
                 radioButton8.Visible = false;
             }
             radioTake2(previous2);
             previous2 = sender;
         }
         private void radioTake2(object previous)
         {
             if (previous == radioButton9)
             {//str
                 attributeChange("str", -2);
                 radioButton1.Visible = true;
             }
             if (previous == radioButton10)
             {
                 attributeChange("con", -2);
                 radioButton2.Visible = true;
             }
             if (previous == radioButton11)
             {
                 attributeChange("dex", -2);
                 radioButton3.Visible = true;
             }
             if (previous == radioButton12)
             {
                 attributeChange("ref", -2);
                 radioButton4.Visible = true;
             }
             if (previous == radioButton13)
             {
                 attributeChange("int", -2);
                 radioButton5.Visible = true;
             }
             if (previous == radioButton14)
             {
                 attributeChange("wit", -2);
                 radioButton6.Visible = true;
             }
             if (previous == radioButton15)
             {
                 attributeChange("cha", -2);
                 radioButton7.Visible = true;
             }
             if (previous == radioButton16)
             {
                 attributeChange("emp", -2);
                 radioButton8.Visible = true;
             }
         }
        private void radioTake(object previous)
         {
             if (previous == radioButton1)
             {//str
                 attributeChange("str", -1);
             }
             if (previous == radioButton2)
             {
                 attributeChange("con", -1);
             }
             if (previous == radioButton3)
             {
                 attributeChange("dex", -1);
             }
             if (previous == radioButton4)
             {
                 attributeChange("ref", -1);
             }
             if (previous == radioButton5)
             {
                 attributeChange("int", -1);
             }
             if (previous == radioButton6)
             {
                 attributeChange("wit", -1);
             }
             if (previous == radioButton7)
             {
                 attributeChange("cha", -1);
             }
             if (previous == radioButton8)
             {
                 attributeChange("emp", -1);
             }

             
         }
        private int Calc(int x)
        {

            int y = 0;

            if (x > 0)
            {
                while (x > 0)
                {
                    x = x - 2;
                    y++;
                }
            }
            if (x < 0)
            {
                do
                {
                    x = x + 2;
                    y--;
                }

                while (x < 0);

            }

            return y;
        }
        private void label6_TextChanged(object sender, EventArgs e)
        {
            label32.Text = Convert.ToString(Calc(Convert.ToInt32(label6.Text) - 10));
        }
        
        private void label8_TextChanged(object sender, EventArgs e)
        {
            label40.Text = Convert.ToString(Calc(Convert.ToInt32(label8.Text) - 10));
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            label41.Text = Convert.ToString(Calc(Convert.ToInt32(label10.Text) - 10));
            label54.Text = label41.Text;
            label64.Text = label41.Text;
        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            label42.Text = Convert.ToString(Calc(Convert.ToInt32(label12.Text) - 10));
        }

        private void label30_TextChanged(object sender, EventArgs e)
        {
            label43.Text = Convert.ToString(Calc(Convert.ToInt32(label30.Text) - 10));
            label56.Text = label43.Text;
        }

        private void label33_TextChanged(object sender, EventArgs e)
        {
            label44.Text = Convert.ToString(Calc(Convert.ToInt32(label33.Text) - 10));
            label58.Text = label44.Text;
        }

        private void label35_TextChanged(object sender, EventArgs e)
        {
            label45.Text = Convert.ToString(Calc(Convert.ToInt32(label35.Text) - 10));
            label60.Text = label45.Text;
        }

        private void label37_TextChanged(object sender, EventArgs e)
        {
            label46.Text = Convert.ToString(Calc(Convert.ToInt32(label37.Text) - 10));
            label62.Text = label46.Text;
        }

       

      
      
       
    }
}
 
 
