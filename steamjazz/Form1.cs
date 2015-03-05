using System;
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
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
                comboBox2.Items.AddRange(background);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Dracosaurian" };
                comboBox2.Items.AddRange(background);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Sylph" };
                comboBox2.Items.AddRange(background);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Kharzul Dwarf" };
                comboBox2.Items.AddRange(background);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Beastfolk" };
                comboBox2.Items.AddRange(background);
            }
            if (comboBox1.SelectedIndex == 6)
            {
                string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands", "Goliath" };
                comboBox2.Items.AddRange(background);
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // riippuen kansalaisuudesta, luokkavaihtoehdot vaihtuvat. Valinnoista riippuen label5 saa eri tekstin. nuthing more to see here - moving along
            int backgroundcase = comboBox2.SelectedIndex;
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
                        comboBox3.Visible = true;
                        comboBox3.SelectedIndex = 0;
                        switch(comboBox1.SelectedIndex)
                        {
                            //13456
                            case 1:
                                {
                                    comboBox3.Items.Add("Dracosaurian");
                                    break;
                                }
                            case 3:
                                {
                                    comboBox3.Items.Add("Sylph");
                                    break;
                                }
                            case 4:
                                {
                                    comboBox3.Items.Add("Kharzul Dwarf");
                                    break;
                                }
                            case 5:
                                {
                                    comboBox3.Items.Add("Beastfolk");
                                    break;
                                }
                            case 6:
                                {
                                    comboBox3.Items.Add("Goliath");
                                    break;
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
            //Combobox2 info Default
            //
            string[] background = new string[] { "Victoria", "Wolfgart", "Kheiman Empire", "Hanseburg", "Crimson Empire", "Free Islands" };
            comboBox2.Items.AddRange(background);

            
            //
            //Combobox4 info
            //
            string[] career = new string[] { "Aristocrat","Artist","Assassin","Banker","Butler","Con Artist","Craftsman","Detective","Druid",
                "Entertainer","Gangster","Gunner","Hunter","Inventor","Journalist","Law Enforcer","Lawyer","Martial Artist","Mechanic","Mercenary",
                "Merchant","Musketeer","Officer","Personal Entertainer","Physician","Pirate","Politician","Ranger","Rogue","Sailor","Scholar",
                "Scout","Servant","Soldier","Spy","Warrior","Wyrodian Priest"};
            comboBox4.Items.AddRange(career);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                        //"Dracosaurian","Basic","Sylph","Kharzul Dwarf" ,"Beastfolk","Goliath"
                        break;
                    }
                case 6:
                    {
                        //free islands
                        switch (comboBox1.SelectedIndex)
                        {
                            case 1:
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
                                    break;
                                }
                            case 3:
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
                                    break;
                                }
                            case 4:
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
                                    break;
                                }
                            case 5:
                                {
                                    comboBox3.Items.Add("Beastfolk");
                                    break;
                                }
                            case 6:
                                {
                                    comboBox3.Items.Add("Goliath");
                                    break;
                                }
                                 
                        }
                        
                        //"Dracosaurian","Basic","Sylph","Kharzul Dwarf" ,"Beastfolk","Goliath"
                        break;
                    }
            }
        }
      
       
    }
}
