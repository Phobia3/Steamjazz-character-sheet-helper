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
using Steamjazz.Properties;
using System.Reflection;



namespace Steamjazz
{

    
    public partial class Form1 : Form
        
    {
        cBackground Background = new cBackground();
        Skills Skill = new Skills();
        cCareer Career = new cCareer();
        cAttributes Attributes = new cAttributes();

        object previous;
        object previous2;
        int backPrevious1 = -1;
        int backPrevious2 = -1;
        int backPrevious3 = -1;

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

        /// <summary>
        /// Combobox1 sisältää tiedon hahmon rodusta. Rotu vaikuttaa atribuuttien lisäksi muutamaan uniikkiin taustavaihtoehtoon.
        /// Richtextbox:lle lähetetään tuloste combobox1:n valitusta rodusta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        { 
            groupBoxInit();
            backAttribute();
           
           


            
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
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
                case 1:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Beastfolk" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
                case 2:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Dracosaurian" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }

                case 3:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Goliath" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
                case 4:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Kharzul Dwarf" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
                case 5:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Sylph" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
                case 6:
                    {
                        string[] background = new string[] { "Basic", "Buttler", "Copper", "Craftsmann", "Doll", "Heavy Worker" };
                        comboBox2.Items.AddRange(background);
                        break;
                    }
            }
            RichTextBoxTulostus(Background.Race(comboBox1.SelectedIndex));
            
            
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
            
            if (comboBox2.SelectedIndex == 1 || comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)
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
                        combobox3init("Worker", "Military", "Upper Class");
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
                        combobox3init("Commoner", "Military", "Monk");
                        break;
                    }
                case 5:
                    {
                        //Free Islands
                        combobox3init("Island Folk", "Pirate", "Pelethok");
                        break;
                    }
               
                default:
                    comboBox3.Visible = false;
                    break;
            }
            RichTextBoxTulostus(Background.Nationality(comboBox2.SelectedIndex,comboBox1.SelectedIndex));

        }
        /// <summary>
        /// alustaa combobox:t joiden sisältö ei vaihdu.
        /// </summary>
        private void InitializeComboBox()
        {
            // Combobox1 info 
            string[] race = new string[]{"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph"
            ,"Automaton"};
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
            komento.Insert("UPDATE info SET name='" + textBox1.Text + "', race='" + comboBox1.Text + "', background='" + comboBox3.Text + "', career='" + comboBox4.Text + "', occupation='" + comboBox4.Text + "', gender='', age='', player='' WHERE ID='" +"'");
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
        /// Tulostaa RichTextBox1:n annetun resurssin mukaisen datan
        /// </summary>
        /// <param name="resurssi"></param>
        /// tulostettavan resurssin nimi.
        private void RichTextBoxTulostus(string resurssi)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = null;
            try
            {
                stream = assembly.GetManifestResourceStream(resurssi);
                using (StreamReader sr = new StreamReader(stream))
                    {
                        stream = null;
                        String line = sr.ReadToEnd();
                        richTextBox1.Text = line;
                    }
            }
            finally
            {
                if (stream != null)
                { stream.Dispose(); }
            }
            
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
            RichTextBoxTulostus(Background.SocialClass(comboBox2.SelectedIndex, comboBox3.SelectedIndex));
            
        }
        /// <summary>
        /// Tarkistaa combobox1, -2 ja -3 arvot ja muokkaa attribuutteja sen mukaisesti. KESKEN
        /// </summary>
        private void backAttribute()
        {
            backAttributeTake();
            groupBoxInit();
            switch(comboBox1.SelectedIndex)
            {
                    //"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph" ,"Automaton"
                case 0:
                    {      
                        //Human
                        break;
                    }
                case 1:
                    {
                        // Beastfolk
                        attributeChange("emp", -1);
                        attributeChange("cha", -2);
                        //allocate +2 to one of the following attributes: STR, CON, DEX, REF, WIT and +1 to another attribute from the list.
                        groupBox2Visibility("str", "con", "dex", "ref", "wit");
                        break;
                    }
                case 2:
                    {
                        //Dracosaurian CHA -2, REF +1; allocate +1 to one of the following: STR, CON or DEX
                        attributeChange("cha", -2);
                        attributeChange("ref", 1);
                        groupBox1Visibility("str", "con", "dex");
                        break;
                    } 
                case 3:
                    {
                        //Goliath STR +3, CON +3, REF -2, INT -2, WIT -2, CHA -2 Initial STR and CON must be at least 10.
                        attributeChange("str", 3);
                        attributeChange("con", 3);
                        attributeChange("ref", -2);
                        attributeChange("int", -2);
                        attributeChange("wit", -2);
                        attributeChange("cha", -2);
                        break;
                    } 
                case 4:
                    {
                        //Kharzul Dwarf CON +2, CHA -2 Advantage: low light vision Advantage: mule Disadvantage: slow
                        attributeChange("con", 2);
                        attributeChange("cha", -2);
                        break;
                    }
                case 5:
                    {
                        // Sylph STR -1, DEX +1 Sylphs can jump twice as high and far as humans. Sylphs gain a +1 racial bonus to dodge and athletics. The dodge bonus counts as a rank in the dodge skill for increasing PDM. Disadvantage: Frail
                        attributeChange("str", -1);
                        attributeChange("dex", 1);
                        break;
                    }
               
                
               
                case 6:
                    {
                        //Automaton
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
                                    // Low  CON, REF or EMP +1 Initial skill ranks: Survival 2, Brawl 1, Stealth 1 15 CP can be used to buy ranks in the following skills: Athletics, Animal Handling, Bluff, Brawl, Cooking, Dodge, First Aid, Forgery, Gaming, Grappling, Handguns, Intimidate, Listen, Melee (Balanced), Melee (Powerful), Spot, Stealth, Survival, Throw or to purchase up to 10 CP worth of acquirable advantages. Starting Wealth level cannot be higher than ‘Well off’.
                                    groupBox4Visibility("con", "ref", "emp");
                                    break;
                                }
                            case 1:
                                {
                                    // Middle DEX, INT or WIT +1 Initial skill ranks: Appraise 2, Persuade 1, Negotiate 1 15 CP can be used to buy ranks in the following skills: Appraise, Bluff, Brawl, Craft (any), Cooking, Negotiate, Etiquette, Handguns, Intimidate, Martial Arts (Victoran Pugilism), Mechanics, Perform (dancing), Persuade, Profession (any), Ride.
                                    groupBox4Visibility("dex", "int", "wit");
                                    break;
                                }
                            case 2:
                                {
                                    // Upper Cost to play: 10CP INT or CHA +1 Initial skill ranks: Etiquette 3, Negotiate 2, Language: Victoran 1 The Starting wealth level of Victoran upper class characters must be Drifter or higher. The 5 CP cost of Drifter has already been calculated into the Background cost and can be further increased with CP during character creation. 15 CP can be used to buy ranks in the following skills: Art (any), Charm, Negotiate, Etiquette, Knowledge: Heraldry, Language (Victoran), Long Guns, Martial Arts (Fencing), Melee (Finesse), Melee (Balanced), Perform (Dancing), Perform (Oratory), Ride, or to improve the Starting wealth level by 10 CP or to purchase the Noble, Victoran advantage.
                                    groupBox4Visibility("dex", "int", "wit");
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
                                    /*STR, CON or INT +1
                                    Initial skill ranks: Craft (Gunsmithing 2), Craft (any) 1,
                                    Mechanics 1
                                    10 CP can be used to buy ranks in the following skills: Animal
                                    Handling, Brawl, Clockwork, Cooking, Craft (any), Drive, 
                                    First Aid, Locksmithing, Mechanics, Persuade, Profession (any),
                                    Ride.
                                    */
                                    groupBox4Visibility("str", "con", "int");

                                    break;
                                }
                            case 1:
                                {
                                    /*STR or DEX +1
                                    Initial skill ranks: Law: Wulffgart 2, Etiquette 1, Intimidate 1.
                                    10 CP can be used to buy ranks in the following skills: Animal
                                    Handling, Athletics, Brawl, Craft (Gunsmithing), Explosives &
                                    Demolitions, First Aid, Handguns, Intimidate, Law (Wulffgart),
                                    Leadership, Long Guns, Martial Arts (Wolfbite), Melee
                                    (Powerful), Ride, Stealth, Strategy/Tactics.
                                    */
                                    groupBox4Visibility("str", "dex");

                                    break;
                                }
                            case 2:
                                {
                                    /*INT or CHA +1
                                    Initial skill ranks: Etiquette 2, Negotiate 1, Language:
                                    Wulffgartian 1
                                    10 CP can be used to buy ranks in the following skills: Charm,
                                    Negotiate, Etiquette, Intimidate, Language (Wulffgartian), Law
                                    (Wulffgart), Long Guns, Perform (Dancing), Perform (Oratory),
                                    Ride, or to improve the Starting wealth level or to purchase the
                                    Noble, Wulffgartian advantage.
                                    */
                                    groupBox4Visibility("int", "cha");

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
                                    /*STR, CON or INT +1
                                    Initial skill ranks: Craft or Profession (any) 2, Knowledge
                                    (Kheiman religion) 1, Art (any) 1
                                    15 CP can be used to buy ranks in the following skills: Art
                                    (any), Athletics, Brawl, Craft (any), Dodge, Mechanics,
                                    Perform (Dancing), Persuade, Profession (any), Survival.
                                    */
                                    groupBox4Visibility("str", "con", "int");

                                    break;
                                }
                            case 1:
                                {
                                    /* STR, DEX or WIT +1
                                    Initial skill ranks: Melee (Powerful) 2, Knowledge (Kheiman
                                    religion) 1, Martial Arts (Kheiman spear) 1
                                    15 CP can be used to buy ranks in the following skills:
                                    Athletics, Block, Brawl, Craft (Blacksmithing), Gunsmithing,
                                    Law (Kheiman), Leadership, Listen, Long Guns, Martial Arts
                                    (Kheiman spear), Ride, Spot, Survival, Throw, Melee
                                    (Powerful).
                                    */
                                    groupBox4Visibility("str", "dex", "wit");

                                    break;
                                }
                            case 2:
                                {
                                    /*
                                     *  INT, WIT, EMP or CHA +1
                                        Initial skill ranks: Knowledge: Kheiman religion 2, Negotiate 1,
                                        Language: Kheiman 1.
                                        15 CP can be used to buy ranks in the following skills:
                                        Alchemy, Art (any), Clockwork, Negotiate, Etiquette, First Aid,
                                        Knowledge (any), Law (Kheiman), Leadership, Mechanics,
                                        Medicine and surgery, Persuade, Teaching, or to improve the
                                        Starting wealth level.
                                      */
                                    groupBox4Visibility("int", "wit", "emp","cha");

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
                                    /*CON, INT or EMP +1
                                    Initial skill ranks: Craft (any) or Profession (any) 2, Appraise 1,
                                    Persuade 1
                                    15 CP can be used to buy ranks in the following skills:
                                    Appraise, Brawl, Clockwork, Cooking, Craft (any), Negotiate,
                                    Drive, Locksmithing, Mechanics, Melee (Powerful), Persuade,
                                    Profession (any), Ride.
                                    */
                                    groupBox4Visibility("con", "int", "emp");

                                    break;
                                }
                            case 1:
                                {
                                    /*DEX, WIT or CHA +1
                                    Initial skill ranks: Appraise 2, Negotiate 1, Persuade 1
                                    15 CP can be used to buy ranks in the following skills:
                                    Appraise, Bluff, Cooking, Craft (any), Etiquette, Intimidate,
                                    Martial Arts (Fencing), Mechanics, Melee (Finesse), Negotiate,
                                    Persuade, Profession (any), Ride, or to improve the Starting
                                    wealth level.
                                    */
                                    groupBox4Visibility( "dex", "wit", "cha");

                                    break;
                                }
                            case 2:
                                {
                                    /*Cost to play: 20CP
                                    DEX, CHA or EMP +1
                                    Initial skill ranks: Appraise 2, Charm 2, Negotiate 2, Etiquette 1.
                                    Advantage: Noble, Hanseburg
                                    Starting wealth level: Drifter. This can be further raised with CP
                                    during character creation.
                                    15 CP can be used to buy ranks in the following skills:
                                    Appraise, Art (any), Charm, Etiquette, Knowledge (Heraldry),
                                    Language (Victoran), Language (Wulffgartian), Martial Arts
                                    (Fencing), Martial Arts (Hanseburgian Musketeer Fencing),
                                    Melee (Finesse), Negotiate, Perform (Dancing), Perform
                                    (Oratory), Persuade, Ride, or to improve the starting wealth
                                    level.
                                    */
                                    groupBox4Visibility("dex", "cha", "emp");

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
                                    /*
                                     * STR, CON or EMP +1
                                        Initial skill ranks: Persuade 2, Animal Handling 1, Profession
                                        (farmer) 1
                                        15 CP can be used to buy ranks in the following skills:
                                        Animal handling, Brawl, Cooking, Craft (any), Listen, Melee
                                        (Balanced), Melee (Powerful), Persuade, Profession (farmer),
                                        Spot, Survival.
                                        */
                                    groupBox4Visibility("str", "con", "emp");

                                    break;
                                }
                            case 1:
                                {
                                    /* STR, DEX or CHA +1
                                    Initial skill ranks: Melee (Balanced) 2, Dodge 1, Law
                                    (Crimson) 1
                                    15 CP can be used to buy ranks in the following skills:
                                    Archery, Athletics, Brawl, Craft (Blacksmithing), Negotiate,
                                    Dodge, Intimidate, Law (Crimson), Listen, Martial Art (one
                                    from Crimson), Melee (Balanced), Melee (Powerful), Persuade,
                                    Ride, Spot, Strategy/Tactics
                                    */
                                    groupBox4Visibility("str", "dex", "cha");

                                    break;
                                }
                            case 2:
                                {
                                    /*Cost to play: 20 CP
                                    DEX, INT or WIT +1
                                    Initial skill ranks: Law (Crimson) 3, Brawl 2, First aid 2,
                                    Martial Art (any Crimson) 2, Teaching 2, Clockwork 1, Dodge 1
                                    10 CP can be used to buy ranks in the following skills:
                                    Athletics, Brawl, Clockwork, Dodge, First aid, Knowledge
                                    (any), Law (Crimson), Listen, Persuade, Martial art (one from
                                    Crimson), Melee (Balanced), Melee (Finesse), Melee
                                    (Powerful), Negotiate, Sense motive, Survival, Teaching,
                                    Advantage: Crimson monk status
                                    All characters of the Way of the Black Dragon have this
                                    advatage. It is worth 10CP and the cost is already calculated
                                    into the cost of this background package.
                                    */
                                    groupBox4Visibility("dex", "int", "wit");

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
                                    /*Any attribute +1
                                    Initial skill ranks: Athletics 1, Negotiate 1, Persuade 1, Sailing
                                    1, Sense Motive 1
                                    15 CP can be used to buy ranks in the following skills:
                                    Appraise, Athletics, Bluff, Brawl, Craft (any), Navigation,
                                    Melee (any), Negotiate, Perform (Dancing), Persuade, Sailing,
                                    Sailing (Airship), Sense Motive, Spot, Survival.
*/
                                    groupBox4Visibility("str", "con", "dex", "ref", "int", "wit", "cha", "emp");

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
        /// Poistaa edeltävän valinnan muutokset atribuutteihin. KESKEN
        /// </summary>
        private void backAttributeTake()
        {
            RaceTake();
            switch (backPrevious2)
            {
                case 0:
                    {
                        VictoraTake();
                        break;
                    }
                case 1:
                    {
                        WolfgartTake();
                        break;
                    }
                case 2:
                    {
                        KheimanTake();                       
                        break;
                    }
                case 3:
                    {
                        HanseburgTake();
                        break;
                    }
                case 4:
                    {
                        CrimsonTake();
                        break;
                    }
                case 5:
                    {
                        FreeIslandTake();
                        break;
                    }
                case 6:
                    {
                        AutomatonTake();
                        break;
                    }
            }
            
        }
        private void RaceTake()
        {
            switch (backPrevious1)
            {
                //"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph" ,"Automaton"

                case 0:
                    {
                        // Human
                        break;
                    }
                case 1:
                    {
                        //Beatfolk
                        attributeChange("emp", 1);
                        attributeChange("cha", 2);
                        break;
                    }
                case 2:
                    {
                        //Dracosaurian
                        attributeChange("cha", 2);
                        attributeChange("ref", -1);
                        break;
                    }
                case 3:
                    {
                        //Goliath STR +3, CON +3, REF -2, INT -2, WIT -2, CHA -2
                        attributeChange("str", -3);
                        attributeChange("con", -3);
                        attributeChange("ref", 2);
                        attributeChange("int", 2);
                        attributeChange("wit", 2);
                        attributeChange("cha", 2);
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
                        //Sylph
                        attributeChange("str", 1);
                        attributeChange("dex", -1);
                        break;
                    }
                case 6:
                    {
                        // Automaton
                        break;
                    }
            }
        }
        /// <summary>
        /// Victoria placeholder until I get something to remove
        /// </summary>
        private void VictoraTake()
        {
            switch (backPrevious3)
            {
                case 0:
                    {


                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {

                        break;
                    }
            }
        }
        /// <summary>
        /// Wolfgart placeholder
        /// </summary>
        private void WolfgartTake()
        {
            switch (backPrevious3)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {


                        break;
                    }
                case 2:
                    {


                        break;
                    }
            }
        }
        /// <summary>
        /// Placeholder for Kheiman Empire
        /// </summary>
        private void KheimanTake()
        {
            switch (backPrevious3)
            {
                case 0:
                    {


                        break;
                    }
                case 1:
                    {


                        break;
                    }
                case 2:
                    {


                        break;
                    }
            }
        }
        /// <summary>
        /// Placeholder for Hanseburg
        /// </summary>
        private void HanseburgTake()
        {
            switch (backPrevious3)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            } 
        }
        /// <summary>
        /// Placeholder for Crimson Empire
        /// </summary>
        private void CrimsonTake()
        {

            switch (backPrevious3)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            } 
        }
        /// <summary>
        /// Placeholder for Free Islands
        /// </summary>

        private void FreeIslandTake()
        {
            switch (backPrevious3)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            } 
        }
        /// <summary>
        /// placeholder for Automatons
        /// </summary>
        private void AutomatonTake()
        {
            if (backPrevious1 == 1)
            {
            }
            if (backPrevious1 == 3)
            {
            }
            if (backPrevious1 == 4)
            {
            }
            if (backPrevious1 == 5)
            {
            }
            if (backPrevious1 == 6)
            {
            }
        }
        /// <summary>
        /// Pieni erillinen funktio kuvaamaan wolfgartin asepalveluksen vaikutuksia hahmon taitoihin KESKEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // 
            var resourceName = "steamjazz.WolffgartService.txt";
            Stream stream1 = null;
            try
            {
                stream1 = assembly.GetManifestResourceStream(resourceName);
            
                using (StreamReader sr = new StreamReader(stream1))
                {
                    stream1 = null;
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = line;
                }
            }
            finally
            {
                if (stream1 != null)
                    stream1.Dispose();
            }
            
        }

        /// <summary>
        /// Määrittelee kaikki attribuutit suoraan.
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="Con"></param>
        /// <param name="Dex"></param>
        /// <param name="Ref"></param>
        /// <param name="Int"></param>
        /// <param name="Wit"></param>
        /// <param name="Cha"></param>
        /// <param name="Emp"></param>
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
        /// <summary>
        /// Muuttaa haluttua attribuuttia halutun määrän verran
        /// </summary>
        /// <param name="att"></param>
        /// halutun attribuutin lyhenne
        /// <param name="change"></param>
        /// haluttu muutos
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
        /// Lisää toiminnallisuuden + merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attributeAdd(Object sender, EventArgs e)
        {
            if (sender==label13)
            {
                Attributes.attributeChange("str", 1, Convert.ToInt32(label39.Text), label6, label39);
            }
            if (sender == label15)
            {
                Attributes.attributeChange("con", 1, Convert.ToInt32(label39.Text), label8, label39);
            }
            if (sender == label17)
            {
                Attributes.attributeChange("dex", 1, Convert.ToInt32(label39.Text), label10, label39);
            }
            if (sender == label19)
            {
                Attributes.attributeChange("ref", 1, Convert.ToInt32(label39.Text), label12, label39);
            }
            if (sender == label21)
            {
                Attributes.attributeChange("int", 1, Convert.ToInt32(label39.Text), label30, label39);
            }
            if (sender == label23)
            {
                Attributes.attributeChange("wit", 1, Convert.ToInt32(label39.Text), label33, label39);
            }
            if (sender == label25)
            {
                Attributes.attributeChange("cha", 1, Convert.ToInt32(label39.Text), label35, label39);
            }
            if (sender == label27)
            {
                Attributes.attributeChange("emp", 1, Convert.ToInt32(label39.Text), label37, label39);
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
                Attributes.attributeChange("str", -1, Convert.ToInt32(label39.Text),label6, label39);
            }
            if (sender == label16)
            {
                Attributes.attributeChange("con", -1, Convert.ToInt32(label39.Text),label8, label39);
            }
            if (sender == label18)
            {
                Attributes.attributeChange("dex", -1, Convert.ToInt32(label39.Text), label10, label39);
            }
            if (sender == label20)
            {
                Attributes.attributeChange("ref", -1, Convert.ToInt32(label39.Text), label12, label39);
            }
            if (sender == label22)
            {
                Attributes.attributeChange("int", -1, Convert.ToInt32(label39.Text), label30, label39);
            }
            if (sender == label24)
            {
                Attributes.attributeChange("wit", -1, Convert.ToInt32(label39.Text), label33, label39);
            }
            if (sender == label26)
            {
                Attributes.attributeChange("cha", -1, Convert.ToInt32(label39.Text), label35, label39);
            }
            if (sender == label28)
            {
                Attributes.attributeChange("emp", -1, Convert.ToInt32(label39.Text), label37, label39);
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

            if (sender == radioButton25)
            {//str
                attributeChange("str", 1);
            }
            if (sender == radioButton27)
            {
                attributeChange("con", 1);
            }
            if (sender == radioButton29)
            {
                attributeChange("dex", 1);
            }
            if (sender == radioButton31)
            {
                attributeChange("ref", 1);
            }
            if (sender == radioButton32)
            {
                attributeChange("int", 1);
            }
            if (sender == radioButton30)
            {
                attributeChange("wit", 1);
            }
            if (sender == radioButton28)
            {
                attributeChange("cha", 1);
            }
            if (sender == radioButton26)
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
             if (sender == radioButton9 )
             {//str
                 attributeChange("str", 2);
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
             if (previous == radioButton25)
             {//str
                 attributeChange("str", -1);
             }
             if (previous == radioButton27)
             {
                 attributeChange("con", -1);
             }
             if (previous == radioButton29)
             {
                 attributeChange("dex", -1);
             }
             if (previous == radioButton31)
             {
                 attributeChange("ref", -1);
             }
             if (previous == radioButton32)
             {
                 attributeChange("int", -1);
             }
             if (previous == radioButton30)
             {
                 attributeChange("wit", -1);
             }
             if (previous == radioButton28)
             {
                 attributeChange("cha", -1);
             }
             if (previous == radioButton26)
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

        /// <summary>
        /// Vastaa attribuuttibonusten laskemisesta taitoihin, attrtibuuttibonusten laskusta sekä laskettujen attribuuttien laskemisesta.
        /// Kutsutaan attribuutin arvon muuttuessa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                label73.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(73, label73.Text, label54.Text)));
                label74.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(74,label74.Text, label54.Text)));
                label75.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(75,label75.Text, label54.Text)));
                label76.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(76,label76.Text, label54.Text)));
                label77.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(77,label77.Text, label54.Text)));
                label78.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(78,label78.Text, label54.Text)));
                label79.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(79,label79.Text, label54.Text)));
                label80.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(80,label80.Text, label54.Text)));
                //combat skills 2.pt. of agility
                label174.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(174,label174.Text, label54.Text)));
                label175.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(175,label175.Text, label54.Text)));
                label176.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(176,label176.Text, label54.Text)));
                label177.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(177,label177.Text, label54.Text)));
                label178.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(178,label178.Text, label54.Text)));
                label179.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(179,label179.Text, label54.Text)));
                label180.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(180,label180.Text, label54.Text)));
                label181.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(181,label181.Text, label54.Text)));
                label182.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(182,label182.Text, label54.Text)));
                label183.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(183,label183.Text, label54.Text)));
                label184.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(184,label184.Text, label54.Text)));
                label185.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(185,label185.Text, label54.Text)));
                label186.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(186,label186.Text, label54.Text)));
                label187.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(187,label187.Text, label54.Text)));
            
                
            }

            if ( sender==label12)
            {
                label42.Text = Convert.ToString(Calc(Convert.ToInt32(label12.Text) - 10));
            }
            
            if ( sender==label30)
            {
                //int
                label43.Text = Convert.ToString(Calc(Convert.ToInt32(label30.Text) - 10));
                label56.Text = label43.Text;
                label192.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(192,label192.Text, label56.Text)));
                label193.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(193,label193.Text, label56.Text)));
                label194.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(194,label194.Text, label56.Text))); 
                label195.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(195,label195.Text, label56.Text)));
                label196.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(196,label196.Text, label56.Text)));
                label197.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(197,label197.Text, label56.Text)));
                label198.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(198,label198.Text, label56.Text)));
                label199.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(199,label199.Text, label56.Text)));
                label200.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(200,label200.Text, label56.Text)));
                label201.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(201,label201.Text, label56.Text)));
                label202.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(202,label202.Text, label56.Text)));
                label203.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(203,label203.Text, label56.Text)));
                label204.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(204,label204.Text, label56.Text)));
                label205.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(205,label205.Text, label56.Text)));
                label206.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(206,label206.Text, label56.Text)));
                label207.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(207,label207.Text, label56.Text)));
                label208.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(208,label208.Text, label56.Text)));
                label209.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(209,label209.Text, label56.Text)));
                label210.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(210,label210.Text, label56.Text)));
                label211.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(211,label211.Text, label56.Text)));
                label212.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(212,label212.Text, label56.Text)));

            }
            if ( sender==label33)
            {
                label44.Text = Convert.ToString(Calc(Convert.ToInt32(label33.Text) - 10));
                label58.Text = label44.Text;
                //WIT
                label167.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(167,label167.Text, label58.Text)));
                label168.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(168,label168.Text, label58.Text)));
                label169.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(169,label169.Text, label58.Text)));
                label170.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(170,label170.Text, label58.Text)));
                label171.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(171,label171.Text, label58.Text)));
                label172.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(172,label172.Text, label58.Text)));
                label173.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(173,label173.Text, label58.Text)));
            }
            if (sender == label35)
            {
                label45.Text = Convert.ToString(Calc(Convert.ToInt32(label35.Text) - 10));
                label60.Text = label45.Text;
                //Social
                label161.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(161,label161.Text, label54.Text)));
                label162.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(162,label162.Text, label54.Text)));
                label163.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(163,label163.Text, label54.Text)));
                label164.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(164,label164.Text, label54.Text)));
                label165.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(165,label165.Text, label54.Text)));
                label166.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(166,label166.Text, label54.Text)));
            }
            if (sender == label37)
            {

                //EMP
                label46.Text = Convert.ToString(Calc(Convert.ToInt32(label37.Text) - 10));
                label62.Text = label46.Text;
                label188.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(188,label188.Text, label46.Text)));
                label189.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(189,label189.Text, label46.Text)));
                label190.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(190,label190.Text, label46.Text)));
                label191.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(191,label191.Text, label46.Text)));
                SDM();
            }
            if (sender == label190)
            {

                SDM();

            }
        }      
        /// <summary>
        /// Laskee SDM lasketun attribuutin. 
        /// </summary>
        private void SDM ()
        { 
            label108.Text = Convert.ToString(12-Convert.ToInt32(label37.Text)-0.5*Convert.ToInt32(label190.Text));
        }
        private void CareerClick(object sender, EventArgs e)
        {
            if (sender == label346)
            {
                Label334 = Convert.ToString(Convert.ToInt32(Label334) + 1);
                if(comboBox4.SelectedIndex==0)
                {
                    label163.Text = Label334;
                }
            }
        }
        
        /// <summary>
        /// Tarkastelee skill välilehden + ja - merkkien painalluksia. Tarkistaa painetun labelin ja toimii sen mukaisesti
        /// </summary>
        /// <param name="sender"></param>
        /// Klikattu label
        /// <param name="e"></param>
        /// perus e event argumentti
        private void SkillClick(object sender, EventArgs e)
        {
            if (sender == label81)
            {
                Skill.SkillLabelMod(label213.Text, 73, label73);
            }
            if (sender == label82)
            {
                Skill.SkillLabelMod(label213.Text, 74, label74);
            }
            if (sender == label83)
            {
                Skill.SkillLabelMod(label213.Text, 75, label75);
            }
            if (sender == label84)
            {
                Skill.SkillLabelMod(label213.Text, 76, label76);
            }
            if (sender == label85)
            {
                Skill.SkillLabelMod(label213.Text, 77, label77);
            }
            if (sender == label86)
            {
                Skill.SkillLabelMod(label213.Text, 78, label78);
            }
            if (sender == label87)
            {
                Skill.SkillLabelMod(label213.Text, 79, label79);
            }
            if (sender == label88)
            {
                Skill.SkillLabelMod(label213.Text, 80, label80);
            }
            //Social Skills
            if( sender == label214)
            {
                Skill.SkillLabelMod(label213.Text, 161, label161);
            }
            if (sender == label215)
            {
                Skill.SkillLabelMod(label213.Text, 162, label162);
            }
            if (sender == label216)
            {
                Skill.SkillLabelMod(label213.Text, 163, label163);
            }
            if (sender == label217)
            {
                Skill.SkillLabelMod(label213.Text, 164, label164);
            }
            if (sender == label218)
            {
                Skill.SkillLabelMod(label213.Text, 165, label165);
            }
            if (sender == label219)
            {
                Skill.SkillLabelMod(label213.Text, 166, label166);
            }
            // Intution

            if (sender == label220)
            {
                Skill.SkillLabelMod(label213.Text, 167, label167);
            } 
            
            if (sender == label221)
            {
                Skill.SkillLabelMod(label213.Text, 168, label168);
            } 
            
            if (sender == label222)
            {
                Skill.SkillLabelMod(label213.Text, 169, label169);
            } 
            
            if (sender == label223)
            {
                Skill.SkillLabelMod(label213.Text, 170, label170);
            } 
            
            if (sender == label224)
            {
                Skill.SkillLabelMod(label213.Text, 171, label171);
            } 

            if (sender == label225)
            {
                Skill.SkillLabelMod(label213.Text, 172, label172);
            } 
           
            if (sender == label226)
            {
                Skill.SkillLabelMod(label213.Text, 173, label173);
            }

            //combat
            if (sender == label227)
            {
                Skill.SkillLabelMod(label213.Text, 174, label174);
            }
            if (sender == label228)
            {
                Skill.SkillLabelMod(label213.Text, 175, label175);
            }
            if (sender == label229)
            {
                Skill.SkillLabelMod(label213.Text, 176, label176);
            }
            if (sender == label230)
            {
                Skill.SkillLabelMod(label213.Text, 177, label177);
            }
            if (sender == label231)
            {
                Skill.SkillLabelMod(label213.Text, 178, label178);
            }
            if (sender == label232)
            {
                Skill.SkillLabelMod(label213.Text, 179, label179);
            }
            if (sender == label233)
            {
                Skill.SkillLabelMod(label213.Text, 180, label180);
            }
            if (sender == label234)
            {
                Skill.SkillLabelMod(label213.Text, 181, label181);
            }
            if (sender == label235)
            {
                Skill.SkillLabelMod(label213.Text, 182, label182);
            }
            if (sender == label236)
            {
                Skill.SkillLabelMod(label213.Text, 183, label183);
            }
            if (sender == label237)
            {
                Skill.SkillLabelMod(label213.Text, 184, label184);
            }
            if (sender == label238)
            {
                Skill.SkillLabelMod(label213.Text, 185, label185);
            }
            if (sender == label239)
            {
                Skill.SkillLabelMod(label213.Text, 186, label186);
            }
            if (sender == label240)
            {
                Skill.SkillLabelMod(label213.Text, 187, label187);
            }

            //Empatia
            if (sender == label241)
            {
                Skill.SkillLabelMod(label213.Text, 188, label188);
            }

            if (sender == label242)
            {
                Skill.SkillLabelMod(label213.Text, 189, label189);
            }

            if (sender == label243)
            {
                Skill.SkillLabelMod(label213.Text, 190, label190);
            }

            if (sender == label244)
            {
                Skill.SkillLabelMod(label213.Text, 191, label191);
            }

            //inteligence
            if (sender == label245)
            {
                Skill.SkillLabelMod(label213.Text, 192, label192);
            }

            if (sender == label246)
            {
                Skill.SkillLabelMod(label213.Text, 193, label193);
            }
            if (sender == label247)
            {
                Skill.SkillLabelMod(label213.Text, 194, label194);
            }
            if (sender == label248)
            {
                Skill.SkillLabelMod(label213.Text, 195, label195);
            }
            if (sender == label249)
            {
                Skill.SkillLabelMod(label213.Text, 196, label196);
            }
            if (sender == label250)
            {
                Skill.SkillLabelMod(label213.Text, 197, label197);
            }
            if (sender == label251)
            {
                Skill.SkillLabelMod(label213.Text, 198, label198);
            }
            if (sender == label252)
            {
                Skill.SkillLabelMod(label213.Text, 199, label199);
            }
            if (sender == label253)
            {
                if (Skill.enough(label213.Text, 200) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 200);
                    label200.Text = Skill.skillAdd(label200.Text,200);
                }
            }
            if (sender == label254)
            {
                if (Skill.enough(label213.Text, 201) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 201);
                    label201.Text = Skill.skillAdd(label201.Text,201);
                }
            }
            if (sender == label255)
            {
                if (Skill.enough(label213.Text, 202) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 202);
                    label202.Text = Skill.skillAdd(label202.Text,202);
                }
            }
            if (sender == label256)
            {
                if (Skill.enough(label213.Text, 203) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 203);
                    label203.Text = Skill.skillAdd(label203.Text,203);
                }
            }
            if (sender == label257)
            {
                if (Skill.enough(label213.Text, 204) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 204);
                    label204.Text = Skill.skillAdd(label204.Text,204);
                }
            }
            if (sender == label258)
            {
                if (Skill.enough(label213.Text, 205) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 205);
                    label205.Text = Skill.skillAdd(label205.Text,205);
                }
            }
            if (sender == label259)
            {
                if (Skill.enough(label213.Text, 206) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 206);
                    label206.Text = Skill.skillAdd(label206.Text,206);
                }
            }
            if (sender == label260)
            {
                if (Skill.enough(label213.Text, 207) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 207);
                    label207.Text = Skill.skillAdd(label207.Text,207);
                }
            }
            if (sender == label261)
            {
                if (Skill.enough(label213.Text, 208) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 208);
                    label208.Text = Skill.skillAdd(label208.Text,208);
                }
            }
            if (sender == label262)
            {
                if (Skill.enough(label213.Text, 209) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 209);
                    label209.Text = Skill.skillAdd(label209.Text,209);
                }
            }
            if (sender == label263)
            {
                if (Skill.enough(label213.Text, 210) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 210);
                    label210.Text = Skill.skillAdd(label210.Text,210);
                }

           if (sender == label264)
           {
                if (Skill.enough(label213.Text, 211) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 211);
                    label211.Text = Skill.skillAdd(label211.Text,211);
                }
                }
            }

            if (sender == label265)
            {
                if (Skill.enough(label213.Text, 212) == true)
                {
                    label213.Text = Skill.pointBuy(label213.Text, 212);
                    label212.Text = Skill.skillAdd(label212.Text,212);
                }
            }


            
            //
            // vähennykset
            //

            //agility 73-80
            if (sender == label89)
            {
                if (Skill.bonus[0,1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text,73);
                    label73.Text = Skill.skillRemove(label73.Text, 73);
                }
            }
            if (sender == label90)
            {
                if (Skill.bonus[1, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 74);
                    label74.Text = Skill.skillRemove(label74.Text,74);
                }
            }
            if (sender == label91)
            {
                if (Skill.bonus[2, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 75);
                    label75.Text = Skill.skillRemove(label75.Text,75);
                }
            }
            if (sender == label92)
            {
                if (Skill.bonus[3, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 76);
                    label76.Text = Skill.skillRemove(label76.Text,76);
                }
            }
            if (sender == label93)
            {
                if (Skill.bonus[4, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 77);
                    label77.Text = Skill.skillRemove(label77.Text,77);
                }
            }
            if (sender == label94)
            {
                if (Skill.bonus[5, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 78);
                    label78.Text = Skill.skillRemove(label78.Text,78);
                }
            }
            if (sender == label95)
            {
                if (Skill.bonus[6, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 79);
                    label79.Text = Skill.skillRemove(label79.Text,79);
                }
            }
            if (sender == label96)
            {
                if (Skill.bonus[7, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 80);
                    label80.Text = Skill.skillRemove(label80.Text,80);
                }
            }
            //social
            if (sender == label266)
            {
                if (Skill.bonus[8, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 161);
                    label161.Text = Skill.skillRemove(label161.Text, 161);
                }
            } 
            if (sender == label267)
            {
                if (Skill.bonus[9, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 162);
                    label162.Text = Skill.skillRemove(label162.Text, 162);
                }
            } 
            if (sender == label268)
            {
                if (Skill.bonus[10, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 163);
                    label163.Text = Skill.skillRemove(label163.Text, 163);
                }
            } 
            if (sender == label269)
            {
                if (Skill.bonus[11, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 164);
                    label164.Text = Skill.skillRemove(label164.Text, 164);
                }
            }
            if (sender == label270)
            {
                if (Skill.bonus[12, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 165);
                    label165.Text = Skill.skillRemove(label165.Text, 165);
                }
            }
            if (sender == label271)
            {
                if (Skill.bonus[13, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 166);
                    label166.Text = Skill.skillRemove(label166.Text, 166);
                }
            }
            //Intuition
            if (sender == label272)
            {
                if (Skill.bonus[14, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 167);
                    label167.Text = Skill.skillRemove(label167.Text, 167);
                }
            } 
            if (sender == label273)
            {
                if (Skill.bonus[15, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 168);
                    label168.Text = Skill.skillRemove(label168.Text, 168);
                }
            } 
            if (sender == label274)
            {
                if (Skill.bonus[16, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 169);
                    label169.Text = Skill.skillRemove(label169.Text, 169);
                }
            } 
            if (sender == label275)
            {
                if (Skill.bonus[17, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 170);
                    label170.Text = Skill.skillRemove(label170.Text, 170);
                }
            }
            if (sender == label276)
            {
                if (Skill.bonus[18, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 171);
                    label171.Text = Skill.skillRemove(label171.Text, 171);
                }
            } 
            if (sender == label277)
            {
                if (Skill.bonus[19, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 172);
                    label172.Text = Skill.skillRemove(label172.Text, 172);
                }
            }
            
            if (sender == label278)
            {
                if (Skill.bonus[20, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 173);
                    label173.Text = Skill.skillRemove(label173.Text, 173);
                }
            } //combat
            
            if (sender == label279)
            {
                if (Skill.bonus[21, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 174);
                    label174.Text = Skill.skillRemove(label174.Text, 174);
                }
            }
            if (sender == label280)
            {
                if (Skill.bonus[22, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 175);
                    label175.Text = Skill.skillRemove(label175.Text, 175);
                }
            } 
            if (sender == label281)
            {
                if (Skill.bonus[23, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 176);
                    label176.Text = Skill.skillRemove(label176.Text, 176);
                }
            } 
            if (sender == label282)
            {
                if (Skill.bonus[24, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 177);
                    label177.Text = Skill.skillRemove(label177.Text, 177);
                }
            }
            if (sender == label283)
            {
                if (Skill.bonus[25, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 178);
                    label178.Text = Skill.skillRemove(label178.Text, 178);
                }
            } 
            if (sender == label284)
            {
                if (Skill.bonus[26, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 179);
                    label179.Text = Skill.skillRemove(label179.Text, 179);
                }
            }
            if (sender == label285)
            {
                if (Skill.bonus[27, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 180);
                    label180.Text = Skill.skillRemove(label180.Text, 180);
                }
            }
            if (sender == label286)
            {
                if (Skill.bonus[28, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 181);
                    label181.Text = Skill.skillRemove(label181.Text, 181);
                }
            }
            if (sender == label287)
            {
                if (Skill.bonus[29, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 182);
                    label182.Text = Skill.skillRemove(label182.Text, 182);
                }
            }
            if (sender == label288)
            {
                if (Skill.bonus[30,1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 183);
                    label183.Text = Skill.skillRemove(label183.Text, 183);
                }
            }
            if (sender == label289)
            {
                if (Skill.bonus[31, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 184);
                    label184.Text = Skill.skillRemove(label184.Text, 184);
                }
            }
            if (sender == label290)
            {
                if (Skill.bonus[32, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 185);
                    label185.Text = Skill.skillRemove(label185.Text, 185);
                }
            }
            if (sender == label291)
            {
                if (Skill.bonus[33, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 186);
                    label186.Text = Skill.skillRemove(label186.Text, 186);
                }
            }
            if (sender == label292)
            {
                if (Skill.bonus[34, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 187);
                    label187.Text = Skill.skillRemove(label187.Text, 187);
                }
            }
            // empatia ->
            if (sender == label293)
            {
                if (Skill.bonus[35, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 188);
                    label188.Text = Skill.skillRemove(label188.Text,188);
                }
            }

            if (sender == label294)
            {
                if (Skill.bonus[36, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 189);
                    label189.Text = Skill.skillRemove(label189.Text,189);
                }
            }

            if (sender == label295)
            {
                if (Skill.bonus[37, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 190);
                    label190.Text = Skill.skillRemove(label190.Text,190);
                }
            }

            if (sender == label296)
            {
                if (Skill.bonus[38, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 191);
                    label191.Text = Skill.skillRemove(label191.Text,191);
                }
            }
            //inteligence 192-212
            if (sender == label297)
            {
                if (Skill.bonus[39, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 192);
                    label192.Text = Skill.skillRemove(label192.Text,192);
                }
            }

            if (sender == label298)
            {
                if (Skill.bonus[40, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 193);
                    label193.Text = Skill.skillRemove(label193.Text,193);
                }
            }
            if (sender == label299)
            {
                if (Skill.bonus[41, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 194);
                    label194.Text = Skill.skillRemove(label194.Text,194);
                }
            }
            if (sender == label300)
            {
                if (Skill.bonus[42, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 195);
                    label195.Text = Skill.skillRemove(label195.Text,195);
                }
            }
            if (sender == label301)
            {
                if (Skill.bonus[43, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 196);
                    label196.Text = Skill.skillRemove(label196.Text,196);
                }
            }
            if (sender == label302)
            {
                if (Skill.bonus[44, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 197);
                    label197.Text = Skill.skillRemove(label197.Text,197);
                }
            }
            if (sender == label303)
            {
                if (Skill.bonus[45, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 198);
                    label198.Text = Skill.skillRemove(label198.Text,198);
                }
            }
            if (sender == label304)
            {
                if (Skill.bonus[46, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 199);
                    label199.Text = Skill.skillRemove(label199.Text,199);
                }
            }
            if (sender == label305)
            {
                if (Skill.bonus[47, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 200);
                    label200.Text = Skill.skillRemove(label200.Text,200);
                }
            }
            if (sender == label306)
            {
                if (Skill.bonus[48, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 201);
                    label201.Text = Skill.skillRemove(label201.Text,201);
                }
            }
            if (sender == label307)
            {
                if (Skill.bonus[49, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 202);
                    label202.Text = Skill.skillRemove(label202.Text,202);
                }
            }
            if (sender == label308)
            {
                if (Skill.bonus[50, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 203);
                    label203.Text = Skill.skillRemove(label203.Text,203);
                }
            }
            if (sender == label309)
            {
                if (Skill.bonus[51, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 204);
                    label204.Text = Skill.skillRemove(label204.Text,204);
                }
            }
            if (sender == label310)
            {
                if (Skill.bonus[52, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 205);
                    label205.Text = Skill.skillRemove(label205.Text,205);
                }
            }
            if (sender == label311)
            {
                if (Skill.bonus[53, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 206);
                    label206.Text = Skill.skillRemove(label206.Text,206);
                }
            }
            if (sender == label312)
            {
                if (Skill.bonus[54, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 207);
                    label207.Text = Skill.skillRemove(label207.Text,207);
                }
            }
            if (sender == label313)
            {
                if (Skill.bonus[55,1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 208);
                    label208.Text = Skill.skillRemove(label208.Text,208);
                }
            }
            if (sender == label314)
            {
                if (Skill.bonus[56, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 209);
                    label209.Text = Skill.skillRemove(label209.Text,209);
                }
            }
            if (sender == label315)
            {
                if (Skill.bonus[57, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 210);
                    label210.Text = Skill.skillRemove(label210.Text,210);
                }
            }
            if (sender == label316)
            {
                if (Skill.bonus[58, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 211);
                    label211.Text = Skill.skillRemove(label211.Text,211);
                }
            }
            if (sender == label317)
            {
                if (Skill.bonus[59, 1]>0)
                {
                    label213.Text = Skill.pointRefund(label213.Text, 212);
                    label212.Text = Skill.skillRemove(label212.Text,212);
                }
            }


        }
        /// <summary>
        /// Laskee todennäköisyydet onnistumiselle, sekä kriittiselle onnistumiselle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prob (object sender,EventArgs e )
        {
            double[] prob3d6 ={0, 0 ,0, 0.46, 1.85, 4.63, 9.26, 16.2, 25.93, 37.5, 50, 62.5, 74.1, 83.83, 90.74, 95.37, 98.15, 99.54, 100 }  ;
            double[] prob2d6 = { 0, 0, 0, 0, 0, 0, 0, 0, 2.78, 8.33, 16.67, 27.78, 41.67, 58.33, 72.22, 83.33, 91.67, 97.22, 100 };

            //agility
            if(sender ==label73)
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label73.Text)]);
            }
            if (sender == label74)
            {
                label319.Text = Convert.ToString(prob3d6[Convert.ToInt32(label74.Text)]);
            }
            if(sender ==label75 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label75.Text)]);
            }
            if(sender ==label76 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label76.Text)]);
            }
            if(sender ==label77 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label77.Text)]);
            }
            if(sender ==label78 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label78.Text)]);
            }
            if(sender ==label79 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label79.Text)]);
            }
            if(sender ==label80 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label80.Text)]);
            }
            //social
            if(sender ==label161 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label161.Text)]);
            }
            if(sender ==label162 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label162.Text)]);
            }
            if(sender ==label163 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label163.Text)]);
            }
            if(sender ==label164)
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label164.Text)]);
            }
            if(sender ==label165)
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label165.Text)]);
            }
            if(sender ==label166 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label166.Text)]);
            }
            //Intuition
            if(sender ==label167 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label167.Text)]);
            }
            if(sender ==label168 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label168.Text)]);
            }
            if(sender ==label169 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label169.Text)]);
            }
            if(sender ==label170 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label170.Text)]);
            }
            if(sender ==label171 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label171.Text)]);
            }
            if(sender ==label172 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label172.Text)]);
            }
            if(sender ==label173 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label173.Text)]);
            }
            //combat skills
            if(sender ==label174 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label174.Text)]);
            }
            if(sender ==label175 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label175.Text)]);
            }
            if(sender ==label176 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label176.Text)]);
            }
            if(sender ==label177 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label177.Text)]);
            }
            if(sender ==label178 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label178.Text)]);
            }
            if(sender ==label179 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label179.Text)]);
            }
            if(sender ==label180 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label180.Text)]);
            }
            if(sender ==label181 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label181.Text)]);
            }
            if(sender ==label182 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label182.Text)]);
            }
            if(sender ==label183 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label183.Text)]);
            }
            if(sender ==label184 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label184.Text)]);
            }
            if(sender ==label185 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label185.Text)]);
            }
            if(sender ==label186 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label186.Text)]);
            }
            if(sender ==label187 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label187.Text)]);
            }
            //empatia
            if(sender ==label188 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label188.Text)]);
            }
            if(sender ==label189 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label189.Text)]);
            }
            if(sender ==label190 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label190.Text)]);
            }
            if(sender ==label191 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label191.Text)]);
            }
            //int
            if(sender ==label192 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label192.Text)]);
            }
            if(sender ==label193 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label193.Text)]);
            }
            if(sender ==label194 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label194.Text)]);
            }
            if(sender ==label195 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label195.Text)]);
            }
            if(sender ==label196 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label196.Text)]);
            }
            if(sender ==label197 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label197.Text)]);
            }
            if(sender ==label198 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label198.Text)]);
            }
            if(sender ==label199 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label199.Text)]);
            }
            if(sender ==label200 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label200.Text)]);
            }
            if(sender ==label201 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label201.Text)]);
            }
            if(sender ==label202 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label202.Text)]);
            }
            if(sender ==label203 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label203.Text)]);
            }
            if(sender ==label204 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label204.Text)]);
            }
            if(sender ==label205 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label205.Text)]);
            }
            if(sender ==label206 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label206.Text)]);
            }
            if(sender ==label207 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label207.Text)]);
            }
            if(sender ==label208 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label208.Text)]);
            }
            if(sender ==label209 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label209.Text)]);
            }
            if(sender ==label210 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label210.Text)]);
            }
            if(sender ==label211 )
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label211.Text)]);
            }
            if(sender ==label212)
            {
                label319.Text=Convert.ToString(prob3d6[Convert.ToInt32(label212.Text)]);
            }

            // HOX POX
            if (sender == label73)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label73.Text)]);
            }
            if (sender == label74)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label74.Text)]);
            }
            if (sender == label75)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label75.Text)]);
            }
            if (sender == label76)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label76.Text)]);
            }
            if (sender == label77)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label77.Text)]);
            }
            if (sender == label78)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label78.Text)]);
            }
            if (sender == label79)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label79.Text)]);
            }
            if (sender == label80)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label80.Text)]);
            }
            //social
            if (sender == label161)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label161.Text)]);
            }
            if (sender == label162)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label162.Text)]);
            }
            if (sender == label163)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label163.Text)]);
            }
            if (sender == label164)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label164.Text)]);
            }
            if (sender == label165)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label165.Text)]);
            }
            if (sender == label166)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label166.Text)]);
            }
            //Intuition
            if (sender == label167)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label167.Text)]);
            }
            if (sender == label168)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label168.Text)]);
            }
            if (sender == label169)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label169.Text)]);
            }
            if (sender == label170)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label170.Text)]);
            }
            if (sender == label171)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label171.Text)]);
            }
            if (sender == label172)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label172.Text)]);
            }
            if (sender == label173)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label173.Text)]);
            }
            //combat skills
            if (sender == label174)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label174.Text)]);
            }
            if (sender == label175)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label175.Text)]);
            }
            if (sender == label176)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label176.Text)]);
            }
            if (sender == label177)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label177.Text)]);
            }
            if (sender == label178)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label178.Text)]);
            }
            if (sender == label179)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label179.Text)]);
            }
            if (sender == label180)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label180.Text)]);
            }
            if (sender == label181)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label181.Text)]);
            }
            if (sender == label182)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label182.Text)]);
            }
            if (sender == label183)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label183.Text)]);
            }
            if (sender == label184)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label184.Text)]);
            }
            if (sender == label185)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label185.Text)]);
            }
            if (sender == label186)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label186.Text)]);
            }
            if (sender == label187)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label187.Text)]);
            }
            //empatia
            if (sender == label188)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label188.Text)]);
            }
            if (sender == label189)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label189.Text)]);
            }
            if (sender == label190)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label190.Text)]);
            }
            if (sender == label191)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label191.Text)]);
            }
            //int
            if (sender == label192)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label192.Text)]);
            }
            if (sender == label193)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label193.Text)]);
            }
            if (sender == label194)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label194.Text)]);
            }
            if (sender == label195)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label195.Text)]);
            }
            if (sender == label196)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label196.Text)]);
            }
            if (sender == label197)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label197.Text)]);
            }
            if (sender == label198)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label198.Text)]);
            }
            if (sender == label199)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label199.Text)]);
            }
            if (sender == label200)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label200.Text)]);
            }
            if (sender == label201)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label201.Text)]);
            }
            if (sender == label202)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label202.Text)]);
            }
            if (sender == label203)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label203.Text)]);
            }
            if (sender == label204)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label204.Text)]);
            }
            if (sender == label205)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label205.Text)]);
            }
            if (sender == label206)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label206.Text)]);
            }
            if (sender == label207)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label207.Text)]);
            }
            if (sender == label208)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label208.Text)]);
            }
            if (sender == label209)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label209.Text)]);
            }
            if (sender == label210)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label210.Text)]);
            }
            if (sender == label211)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label211.Text)]);
            }
            if (sender == label212)
            {
                label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(label212.Text)]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Label322 = Career.CareerSkillNames(comboBox4.SelectedIndex)[0];
            Label323 = Career.CareerSkillNames(comboBox4.SelectedIndex)[1];
            Label324 = Career.CareerSkillNames(comboBox4.SelectedIndex)[2];
            Label325 = Career.CareerSkillNames(comboBox4.SelectedIndex)[3];
            Label326 = Career.CareerSkillNames(comboBox4.SelectedIndex)[4];
            Label327 = Career.CareerSkillNames(comboBox4.SelectedIndex)[5];
            Label328 = Career.CareerSkillNames(comboBox4.SelectedIndex)[6];
            Label329 = Career.CareerSkillNames(comboBox4.SelectedIndex)[7];
            Label330 = Career.CareerSkillNames(comboBox4.SelectedIndex)[8];
            Label331 = Career.CareerSkillNames(comboBox4.SelectedIndex)[9];
            Label332 = Career.CareerSkillNames(comboBox4.SelectedIndex)[10];
            Label333 = Career.CareerSkillNames(comboBox4.SelectedIndex)[11];
            switch(comboBox4.SelectedIndex)
            {
                case 0:
                    {
                        Label334 = label163.Text;
                        Label335 = label199.Text;
                        Label337 = label165.Text;
                        Label338 = label184.Text;
                        Label340 = label166.Text;
                        Label341 = label76.Text;
                        Label342 = label190.Text;
                        break;
                    }
            }
        }
        private void groupBoxInit()
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;            
            radioButton25.Visible = false;
            radioButton26.Visible = false;
            radioButton27.Visible = false;
            radioButton28.Visible = false;
            radioButton29.Visible = false;
            radioButton30.Visible = false;
            radioButton31.Visible = false;
            radioButton32.Visible = false;
        }
        /// <summary>
        /// muttaa halutun radiobuttonin näkyvyyden todeksi
        /// </summary>
        /// <param name="att"></param>
        /// attribuutin kolmikirjaiminen lyhenne
        /// <param name="x"></param>
        /// 1 tai 2 riippuen kumman groupBoxin radiobutton on kyseessä
        /// 
        private void attributeVisibility(string att, int x)
        {
            
            if (x==1)
            {
                groupBox1.Visible = true;
                switch (att)
                {
                    case "str":
                        {
                            radioButton1.Visible = true;
                            break;
                        }
                    case "con":
                        {
                            radioButton2.Visible = true;
                            break;
                        }
                    case "dex":
                        {
                            radioButton3.Visible = true;
                            break;
                        }
                    case "ref":
                        {
                            radioButton4.Visible = true;
                            break;
                        }
                    case "int":
                        {
                            radioButton5.Visible = true;
                            break;
                        }
                    case "wit":
                        {
                            radioButton6.Visible = true;
                            break;
                        }
                    case "cha":
                        {
                            radioButton7.Visible = true;
                            break;
                        }
                    case "emp":
                        {
                            radioButton8.Visible = true;
                            break;
                        }
                } 
            }
            if (x == 2)
            {
                groupBox2.Visible = true;
                switch (att)
                {
                    case "str":
                        {
                            radioButton9.Visible = true;
                            break;
                        }
                    case "con":
                        {
                            radioButton10.Visible = true;
                            break;
                        }
                    case "dex":
                        {
                            radioButton11.Visible = true;
                            break;
                        }
                    case "ref":
                        {
                            radioButton12.Visible = true;
                            break;
                        }
                    case "int":
                        {
                            radioButton13.Visible = true;
                            break;
                        }
                    case "wit":
                        {
                            radioButton14.Visible = true;
                            break;
                        }
                    case "cha":
                        {
                            radioButton15.Visible = true;
                            break;
                        }
                    case "emp":
                        {
                            radioButton16.Visible = true;
                            break;
                        }
                }
            }
            //groupbox4
            if (x == 4)
            {
                groupBox4.Visible = true;
                switch (att)
                {
                    case "str":
                        {
                            radioButton25.Visible = true;
                            break;
                        }
                    case "con":
                        {
                            radioButton27.Visible = true;
                            break;
                        }
                    case "dex":
                        {
                            radioButton29.Visible = true;
                            break;
                        }
                    case "ref":
                        {
                            radioButton31.Visible = true;
                            break;
                        }
                    case "int":
                        {
                            radioButton32.Visible = true;
                            break;
                        }
                    case "wit":
                        {
                            radioButton30.Visible = true;
                            break;
                        }
                    case "cha":
                        {
                            radioButton28.Visible = true;
                            break;
                        }
                    case "emp":
                        {
                            radioButton26.Visible = true;
                            break;
                        }
                }
            }
        }
        private void groupBox1Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 1);
            attributeVisibility(att2, 1);
            attributeVisibility(att3, 1);
        }
        private void groupBox2Visibility(string att1, string att2, string att3, string att4, string att5)
        {
            attributeVisibility(att1, 2);
            attributeVisibility(att2, 2);
            attributeVisibility(att3, 2);
            attributeVisibility(att4, 2);
            attributeVisibility(att5, 2);
        }
        private void groupBox4Visibility(string att1, string att2)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
        }
        private void groupBox4Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
        }
        private void groupBox4Visibility(string att1, string att2, string att3, string att4)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
            attributeVisibility(att4, 4);
        }
        private void groupBox4Visibility(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            attributeVisibility(p1, 4);
            attributeVisibility(p2, 4);
            attributeVisibility(p3, 4);
            attributeVisibility(p4, 4);
            attributeVisibility(p5, 4);
            attributeVisibility(p6, 4);
            attributeVisibility(p7, 4);
            attributeVisibility(p8, 4);
        }
    }
}
 
 
