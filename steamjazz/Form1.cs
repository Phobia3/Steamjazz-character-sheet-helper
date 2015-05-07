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
        Skills Skill = new Skills();
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
        /// <summary>
        /// ensimmäiset alustukset
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //InitializeSkills();
            attributeChange("10", "10", "10", "10", "10", "10", "10", "10");
            
            InitializeComboBox();
            
            
            
        }
        private void InitializeSkills()
        {
            label73.Text = "0";
            label74.Text = "0";
            label75.Text = "0";
            label76.Text = "0";
            label77.Text = "0";
            label78.Text = "0";
            label79.Text = "0";
            label80.Text = "0";
            label190.Text = "0";
        }
       
        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Combobox1 sisältää tiedon hahmon rodusta. Rotu vaikuttaa atribuuttien lisäksi muutamaan uniikkiin taustavaihtoehtoon.
        /// Richtextbox:lle lähetetään tuloste combobox1:n valitusta rodusta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            backAttribute();
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


            
            if (comboBox2.SelectedIndex == 1 || comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
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
                       // // 
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
                // 
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
                // 
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
                // 
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
                // 
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
                // 
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
                // 
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
                // 
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
                // 
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
                // 
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
               
                
                groupBox2.Visible = true;
                radioButton13.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                groupBox1.Visible = true;
                radioButton5.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                

                
                
                

                var assembly = Assembly.GetExecutingAssembly();
                // 
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
                // 
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
        /// <summary>
        /// Valmistellaan comboBox3 vastaanottamaan eri kansalaisuuksien luokkamahdollisuudet
        /// </summary>
        /// <param name="eka"></param>
        /// valitun maan kolme eri luokkatasoa, eroteltuna kolmeen eri string muuttujaan
        /// <param name="toka"></param>
        /// <param name="kolme"></param>
        private void combobox3init(string eka, string toka, string kolme)
        {
            
            comboBox3.Items.Clear();
            string[] race = new string[]{eka,toka,kolme};
            comboBox3.Items.AddRange(race);
            comboBox3.Visible = true;
            comboBox3.SelectedIndex = 0;
        }

	/// <summary>
	/// Hahmon taustanluonnin ensimmäinen pykälä. Mahdollisuus valita kansalaisuus.
    /// Muokkaa combobox3 sisältöä
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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
                            //// 
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
                            // 
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
                            // 
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
                            // 
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
                            // 
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
        /// <summary>
        /// alustaa combobox:t joiden sisältö ei vaihdu.
        /// </summary>
        private void InitializeComboBox()
        {
            // Combobox1 info 
            string[] race = new string[]{"Human","Dracosaurian","Basic","Sylph","Kharzul Dwarf"
            ,"Beastfolk","Goliath","Butler","Copper","Craftsman","Doll","Heavy Worker"};
            comboBox1.Items.AddRange(race);
           
            string[] career = new string[] { "Aristocrat","Artist","Assassin","Banker","Butler","Con Artist","Craftsman","Detective","Druid",
                "Entertainer","Gangster","Gunner","Hunter","Inventor","Journalist","Law Enforcer","Lawyer","Martial Artist","Mechanic","Mercenary",
                "Merchant","Musketeer","Officer","Personal Entertainer","Physician","Pirate","Politician","Ranger","Rogue","Sailor","Scholar",
                "Scout","Servant","Soldier","Spy","Warrior","Wyrodian Priest"};
            comboBox4.Items.AddRange(career);

            string[] mili = new string[] { "Deserter", "Military Service", "Non-military Service" };
            comboBox5.Items.AddRange(mili);
           
        }

        /// <summary>
        /// Luo uuden rivin steamjazz tietokannan tauluihin, ottaen samalla talteen info taulun id arvon. Id arvoa tullaan myöhemmin 
        /// hyödyntämään hahmon tallennuksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("INSERT INTO info (name, race, background, career, occupation, gender, age, player) VALUES ('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "',' ',' ',' ',' ')");
              
        }

        /// <summary>
        /// Tallennusfunktio, päivittää aikaisemmin talteen otetun id:n mukaiset rivit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("UPDATE info SET name='" + textBox1.Text + "', race='" + comboBox1.Text + "', background='" + comboBox3.Text + "', career='" + comboBox4.Text + "', occupation='" + comboBox4.Text + "', gender='', age='', player='' WHERE ID=''");
        }

       /// <summary>
       /// tulosteita mahdollisten virheiden varalta.
       /// </summary>
       /// <param name="e"></param>
        public void tulostus (string e)
        {
            richTextBox1.Text = e;
        
        }
        /// <summary>
        /// Taustan valinta tapahtuu combobox3:ssa. RichTextBox tulostaa tarvittavan informaation taustoista. Vaikuttaa atribuutteihin ja muihin
        /// ominaisuuksiin
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
                                    // 
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
        /// <summary>
        /// Tarkistaa combobox1, -2 ja -3 arvot ja muokkaa attribuutteja sen mukaisesti.
        /// </summary>
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
        /// <summary>
        /// Poistaa edeltävän valinnan muutokset atribuutteihin.
        /// </summary>
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
        /// <summary>
        /// Pieni erillinen funktio kuvaamaan wolffgartin palveluksen vaikutuksia hahmon taitoihin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // 
            var resourceName = "steamjazz.WolffgartService.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader sr = new StreamReader(stream))
            {
                String line = sr.ReadToEnd();
                richTextBox1.Text = line;
            }
        }

        /// <summary>
        /// Laskee muutokset attribuutteihin. Overloaded alustusta ja taustan muutoksia varten.
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
        /// <summary>
        /// Vastaa attribuutin lisäämisen tai vähentämisen vaikutuksesta attribuuttipisteiden määrään.
        /// </summary>
        /// <param name="x"></param>
        /// attribuutin nykyinen arvo
        /// <param name="points"></param>
        /// vapaiden attribuuttipisteiden määrä
        /// <param name="change"></param>
        /// muutoksen määrä
        /// <returns></returns>
        private static int pointCalc(int x,int points, int change)
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
        /// <summary>
        /// Muokkaa attribuuttien määrän ilmoittavien label:n tekstin arvoa
        /// </summary>
        /// <param name="att"></param>
        /// attribuutin nimi
        /// <param name="change"></param>
        /// muutos
        /// <param name="points"></param>
        /// attribuuttipisteiden määrä
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
        /// <summary>
        /// Lisää toiminnallisuuden + merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Lisää toiminnallisuutta - merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Toiminnallisuutta radiobutton:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// samaa kuten radioAdd:sä
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Poistaa edeltävän valinnan muutokset
        /// </summary>
        /// <param name="previous"></param>
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
         /// <summary>
         /// Poistaa edeltävän valinnan muutokset
         /// </summary>
         /// <param name="previous"></param>
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
        /// <summary>
        /// laskee attribbuuttiboonuksen
        /// </summary>
        /// <param name="x">
        /// attribuutin nykyinen arvo
        /// </param>
        /// <returns></returns>
        private static int Calc(int x)
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
        /// <summary>
        /// reagoinnit attribuuttien muutokseen, että attribuuttiboonukset saadaan lasketttua ja tulostettua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void  burden ( string x, string y)
        {
            double tulos2 = Convert.ToInt32(x) + Convert.ToInt32(y);
            label105.Text = Convert.ToString(tulos2 * 2) + "kg";
            label106.Text = Convert.ToString(tulos2 * 4) + "kg";
            label107.Text = Convert.ToString(tulos2 * 6) + "kg";
        }
        private void speed ( string h, string i)
        {
            double x = Convert.ToInt32(h);
            double y = Convert.ToInt32(i);
            double tulos = x * 0.2 + y * 0.2;
            label104.Text = Convert.ToString(tulos);
        }
        private void label_TextChanged ( object sender, EventArgs e)
        {
            if ( sender == label6)
            {
                burden(label6.Text, label8.Text);
                label32.Text = Convert.ToString(Calc(Convert.ToInt32(label6.Text) - 10));
                label103.Text = label32.Text;
                speed(label6.Text, label10.Text);
                
                
            }
            if (sender == label8) 
            {

                burden(label6.Text, label8.Text);
                label40.Text = Convert.ToString(Calc(Convert.ToInt32(label8.Text) - 10));

            }
            if (sender == label10)
             
            {
                
                speed(label6.Text, label10.Text);
                label41.Text = Convert.ToString(Calc(Convert.ToInt32(label10.Text) - 10));
                label54.Text = label41.Text;
                label64.Text = label41.Text;
                //agility
                label73.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label73.Text, label54.Text))+8);
                label74.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label74.Text, label54.Text))+8);
                label75.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label75.Text, label54.Text))+8);
                label76.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label76.Text, label54.Text))+8);
                label77.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label77.Text, label54.Text))+8);
                label78.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label78.Text, label54.Text))+8);
                label79.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label79.Text, label54.Text))+8);
                label80.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label80.Text, label54.Text))+7);
                //combat skills
                label174.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label174.Text, label54.Text)) + 8);
                label175.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label175.Text, label54.Text)) + 7);
                label176.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label176.Text, label54.Text)) + 8);
                label177.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label177.Text, label54.Text)) + 7);
                label178.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label178.Text, label54.Text)) + 8);
                label179.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label179.Text, label54.Text)) + 7);
                label180.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label180.Text, label54.Text)) + 7);
                label181.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label181.Text, label54.Text)) + 6);
                label182.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label182.Text, label54.Text)) + 7);
                label183.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label183.Text, label54.Text)) + 7);
                label184.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label184.Text, label54.Text)) + 7);
                label185.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label185.Text, label54.Text)) + 7);
                label186.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label186.Text, label54.Text)) + 6);
                label187.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(label187.Text, label54.Text)) + 7);
            
            }

            if ( sender==label12)
            {
                label42.Text = Convert.ToString(Calc(Convert.ToInt32(label12.Text) - 10));
            }
            
            if ( sender==label30)
            {
                label43.Text = Convert.ToString(Calc(Convert.ToInt32(label30.Text) - 10));
                label56.Text = label43.Text;
            }
            if ( sender==label33)
            {
                label44.Text = Convert.ToString(Calc(Convert.ToInt32(label33.Text) - 10));
                label58.Text = label44.Text;
            }
            if (sender == label35)
            {
                label45.Text = Convert.ToString(Calc(Convert.ToInt32(label35.Text) - 10));
                label60.Text = label45.Text;
            }
            if (sender == label37)
            {

                //EMP
                label46.Text = Convert.ToString(Calc(Convert.ToInt32(label37.Text) - 10));
                label62.Text = label46.Text;
                SDM();
            }
            if (sender == label190)
            {

                SDM();

            }
        }      
        private void SDM ()
        { 
            label108.Text = Convert.ToString(12-Convert.ToInt32(label37.Text)-0.5*Convert.ToInt32(label190.Text));
        }

        private void skillClick(object sender, EventArgs e)
        {
            if (sender == label81)
            {
                if (Skill.enough(label73.Text, label213.Text,73 ) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label73.Text = Skill.skillAdd(label73.Text);
                }
            }
            if (sender == label82)
            {
                if (Skill.enough(label74.Text, label213.Text, 74) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label74.Text = Skill.skillAdd(label74.Text);
                }
            }
            if (sender == label83)
            {
                if (Skill.enough(label75.Text, label213.Text, 75) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label75.Text = Skill.skillAdd(label75.Text);
                }
            }
            if (sender == label84)
            {
                if (Skill.enough(label76.Text, label213.Text, 76) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label76.Text = Skill.skillAdd(label76.Text);
                }
            }
            if (sender == label85)
            {
                if (Skill.enough(label77.Text, label213.Text, 77) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label77.Text = Skill.skillAdd(label77.Text);
                }
            }
            if (sender == label86)
            {
                if (Skill.enough(label78.Text, label213.Text, 78) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label78.Text = Skill.skillAdd(label78.Text);
                }
            }
            if (sender == label87)
            {
                if (Skill.enough(label79.Text, label213.Text, 79) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label79.Text = Skill.skillAdd(label79.Text);
                }
            }
            if (sender == label88)
            {
                if (Skill.enough(label80.Text, label213.Text, 80) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label80.Text = Skill.skillAdd(label80.Text);
                }
            }
            //Social Skills
            if( sender == label214)
            {
                if (Skill.enough(label161.Text, label213.Text, 161) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label161.Text = Skill.skillAdd(label161.Text);
                }
            }
            if (sender == label215)
            {
                if (Skill.enough(label162.Text, label213.Text, 162) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label162.Text = Skill.skillAdd(label162.Text);
                }
            }
            if (sender == label216)
            {
                if (Skill.enough(label163.Text, label213.Text, 163) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label163.Text = Skill.skillAdd(label163.Text);
                }
            }
            if (sender == label217)
            {
                if (Skill.enough(label164.Text, label213.Text, 164) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label164.Text = Skill.skillAdd(label164.Text);
                }
            }
            if (sender == label218)
            {
                if (Skill.enough(label165.Text, label213.Text, 165) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label165.Text = Skill.skillAdd(label165.Text);
                }
            }
            if (sender == label219)
            {
                if (Skill.enough(label166.Text, label213.Text, 166) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label16.Text = Skill.skillAdd(label166.Text);
                }
            }
            // Intution

            if (sender == label220)
            {
                if (Skill.enough(label167.Text, label213.Text, 167) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label167.Text = Skill.skillAdd(label167.Text);
                }
            } 
            
            if (sender == label221)
            {
                if (Skill.enough(label168.Text, label213.Text, 168) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label168.Text = Skill.skillAdd(label168.Text);
                }
            } 
            
            if (sender == label222)
            {
                if (Skill.enough(label169.Text, label213.Text, 169) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label169.Text = Skill.skillAdd(label169.Text);
                }
            } 
            
            if (sender == label223)
            {
                if (Skill.enough(label170.Text, label213.Text, 170) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label170.Text = Skill.skillAdd(label170.Text);
                }
            } 
            
            if (sender == label224)
            {
                if (Skill.enough(label166.Text, label213.Text, 171) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label171.Text = Skill.skillAdd(label171.Text);
                }
            } 

            if (sender == label225)
            {
                if (Skill.enough(label172.Text, label213.Text, 172) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label172.Text = Skill.skillAdd(label172.Text);
                }
            } 
           
            if (sender == label226)
            {
                if (Skill.enough(label173.Text, label213.Text, 173) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label173.Text = Skill.skillAdd(label173.Text);
                }
            }

            //combat
            if (sender == label227)
            {
                if (Skill.enough(label174.Text, label213.Text, 174) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label174.Text = Skill.skillAdd(label174.Text);
                }
            }
            if (sender == label228)
            {
                if (Skill.enough(label178.Text, label213.Text, 178) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label178.Text = Skill.skillAdd(label178.Text);
                }
            }
            if (sender == label229)
            {
                if (Skill.enough(label179.Text, label213.Text, 179) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label179.Text = Skill.skillAdd(label179.Text);
                }
            }
            if (sender == label230)
            {
                if (Skill.enough(label180.Text, label213.Text, 180) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label180.Text = Skill.skillAdd(label180.Text);
                }
            }
            if (sender == label231)
            {
                if (Skill.enough(label181.Text, label213.Text, 181) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label181.Text = Skill.skillAdd(label181.Text);
                }
            }
            if (sender == label232)
            {
                if (Skill.enough(label182.Text, label213.Text, 182) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label182.Text = Skill.skillAdd(label182.Text);
                }
            }
            if (sender == label233)
            {
                if (Skill.enough(label183.Text, label213.Text, 183) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label183.Text = Skill.skillAdd(label183.Text);
                }
            }
            if (sender == label234)
            {
                if (Skill.enough(label184.Text, label213.Text, 184) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label184.Text = Skill.skillAdd(label184.Text);
                }
            }
            if (sender == label235)
            {
                if (Skill.enough(label185.Text, label213.Text, 185) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label185.Text = Skill.skillAdd(label185.Text);
                }
            }
            if (sender == label236)
            {
                if (Skill.enough(label186.Text, label213.Text, 186) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label186.Text = Skill.skillAdd(label186.Text);
                }
            }
            if (sender == label237)
            {
                if (Skill.enough(label187.Text, label213.Text, 187) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label187.Text = Skill.skillAdd(label187.Text);
                }
            }
            if (sender == label238)
            {
                if (Skill.enough(label188.Text, label213.Text, 188) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label188.Text = Skill.skillAdd(label188.Text);
                }
            }
            if (sender == label239)
            {
                if (Skill.enough(label189.Text, label213.Text, 189) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label189.Text = Skill.skillAdd(label189.Text);
                }
            }
            if (sender == label240)
            {
                if (Skill.enough(label190.Text, label213.Text, 190) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text);
                    label190.Text = Skill.skillAdd(label190.Text);
                }
            }


        }

        
    
    }
}
 
 
