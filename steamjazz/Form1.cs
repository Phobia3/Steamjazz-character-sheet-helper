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
           
           


            
            if (ComboBox2.SelectedIndex == 1 || ComboBox1.SelectedIndex == 4 && ComboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            ComboBox2.Items.Clear();
            switch(ComboBox1.SelectedIndex)
            {// rodun infon näyttäminen, sekä rodullisten erikoistaustojen lisääminen taustalistoihin
                case 0:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
                case 1:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Beastfolk" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
                case 2:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Dracosaurian" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }

                case 3:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Goliath" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
                case 4:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Kharzul Dwarf" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
                case 5:
                    {
                        string[] background = new string[] { "Victora", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", "Sylph" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
                case 6:
                    {
                        string[] background = new string[] { "Basic", "Buttler", "Copper", "Craftsmann", "Doll", "Heavy Worker" };
                        ComboBox2.Items.AddRange(background);
                        break;
                    }
            }
            RichTextBoxTulostus(Background.Race(ComboBox1.SelectedIndex));
            
            
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
            
            ComboBox3.Items.Clear();
            string[] race = new string[]{eka,toka,kolme};
            ComboBox3.Items.AddRange(race);
            ComboBox3.Visible = true;
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
            
            if (ComboBox2.SelectedIndex == 1 || ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 5)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            switch (ComboBox2.SelectedIndex)
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
                    ComboBox3.Visible = false;
                    break;
            }
            RichTextBoxTulostus(Background.Nationality(ComboBox2.SelectedIndex,ComboBox1.SelectedIndex));

        }
        /// <summary>
        /// alustaa combobox:t joiden sisältö ei vaihdu.
        /// </summary>
        private void InitializeComboBox()
        {
            // Combobox1 info 
            string[] race = new string[]{"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph"
            ,"Automaton"};
            ComboBox1.Items.AddRange(race);
           
            string[] career = new string[] { "Aristocrat","Artist","Assassin","Banker","Butler","Con Artist","Craftsman","Detective","Druid",
                "Entertainer","Gangster","Gunner","Hunter","Inventor","Journalist","Law Enforcer","Lawyer","Martial Artist","Mechanic","Mercenary",
                "Merchant","Musketeer","Officer","Personal Entertainer","Physician","Pirate","Politician","Ranger","Rogue","Sailor","Scholar",
                "Scout","Servant","Soldier","Spy","Warrior","Wyrodian Priest"};
            ComboBox4.Items.AddRange(career);

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
            komento.Insert("INSERT INTO info (name, race, background, career, occupation, gender, age, player) VALUES ('" + textBox1.Text + "','" + ComboBox1.Text + "','" + ComboBox3.Text + "','" + ComboBox4.Text + "',' ',' ',' ',' ')");
              
        }

        /// <summary>
        /// Tallennusfunktio, päivittää aikaisemmin talteen otetun id:n mukaiset rivit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(Object sender, EventArgs e)
        {
            DBConnect komento = new DBConnect();
            komento.Insert("UPDATE info SET name='" + textBox1.Text + "', race='" + ComboBox1.Text + "', background='" + ComboBox3.Text + "', career='" + ComboBox4.Text + "', occupation='" + ComboBox4.Text + "', gender='', age='', player='' WHERE ID='" +"'");
        }

       /// <summary>
       /// tulosteita mahdollisten virheiden varalta.
       /// </summary>
       /// <param name="e"></param>
        public void tulostus (string text)
        {
            richTextBox1.Text = text;
        
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
            int backgroundcase = ComboBox2.SelectedIndex;
            if (backgroundcase == 1 || ComboBox1.SelectedIndex == 4 && ComboBox2.SelectedIndex == 6)
            {
                comboBox5.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
            }
            RichTextBoxTulostus(Background.SocialClass(ComboBox2.SelectedIndex, ComboBox3.SelectedIndex));
            
        }
        /// <summary>
        /// Tarkistaa combobox1, -2 ja -3 arvot ja muokkaa attribuutteja sen mukaisesti. KESKEN
        /// </summary>
        private void backAttribute()
        {
            backAttributeTake();
            groupBoxInit();
            Background.BackgroundModifiers();
            
            backPrevious1 = ComboBox1.SelectedIndex;
            backPrevious2 = ComboBox2.SelectedIndex;
            backPrevious3 = ComboBox3.SelectedIndex;
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
        public void attributeChange(string Str, string Con, string Dex, string Ref, string Int, string Wit, string Cha, string Emp)
        {
            
            Label6.Text = Str;
            Label8.Text = Con;
            Label10.Text = Dex;
            Label12.Text = Ref;
            Label30.Text = Int;
            Label33.Text = Wit;
            Label35.Text = Cha;
            Label37.Text = Emp;

        }
        /// <summary>
        /// Muuttaa haluttua attribuuttia halutun määrän verran
        /// </summary>
        /// <param name="att"></param>
        /// halutun attribuutin lyhenne
        /// <param name="change"></param>
        /// haluttu muutos
        public void attributeChange(string att, int change)
        {
           
            if(att == "str") Label6.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + change);
            if(att == "con") Label8.Text = Convert.ToString(Convert.ToInt32(Label8.Text) + change);
            if(att == "dex") Label10.Text = Convert.ToString(Convert.ToInt32(Label10.Text) + change);
            if(att == "ref") Label12.Text = Convert.ToString(Convert.ToInt32(Label12.Text) + change);
            if(att == "int") Label30.Text = Convert.ToString(Convert.ToInt32(Label30.Text) + change);
            if(att == "wit") Label33.Text = Convert.ToString(Convert.ToInt32(Label33.Text) + change);
            if(att == "cha") Label35.Text = Convert.ToString(Convert.ToInt32(Label35.Text) + change);
            if(att == "emp") Label37.Text = Convert.ToString(Convert.ToInt32(Label37.Text) + change);

        }

        /// <summary>
        /// Lisää toiminnallisuuden + merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void attributeAdd(Object sender, EventArgs e)
        {
            if (sender==Label13)
            {
                Attributes.attributeChange("str", 1, Convert.ToInt32(label39.Text), Label6, label39);
            }
            if (sender == Label15)
            {
                Attributes.attributeChange("con", 1, Convert.ToInt32(label39.Text), Label8, label39);
            }
            if (sender == Label17)
            {
                Attributes.attributeChange("dex", 1, Convert.ToInt32(label39.Text), Label10, label39);
            }
            if (sender == Label19)
            {
                Attributes.attributeChange("ref", 1, Convert.ToInt32(label39.Text), Label12, label39);
            }
            if (sender == Label21)
            {
                Attributes.attributeChange("int", 1, Convert.ToInt32(label39.Text), Label30, label39);
            }
            if (sender == Label23)
            {
                Attributes.attributeChange("wit", 1, Convert.ToInt32(label39.Text), Label33, label39);
            }
            if (sender == Label25)
            {
                Attributes.attributeChange("cha", 1, Convert.ToInt32(label39.Text), Label35, label39);
            }
            if (sender == Label27)
            {
                Attributes.attributeChange("emp", 1, Convert.ToInt32(label39.Text), Label37, label39);
            }
        }
        /// <summary>
        /// Lisää toiminnallisuutta - merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void attributeTake(Object sender, EventArgs e)
        {
            if (sender == Label14)
            {//str
                Attributes.attributeChange("str", -1, Convert.ToInt32(label39.Text),Label6, label39);
            }
            if (sender == Label16)
            {
                Attributes.attributeChange("con", -1, Convert.ToInt32(label39.Text),Label8, label39);
            }
            if (sender == Label18)
            {
                Attributes.attributeChange("dex", -1, Convert.ToInt32(label39.Text), Label10, label39);
            }
            if (sender == Label20)
            {
                Attributes.attributeChange("ref", -1, Convert.ToInt32(label39.Text), Label12, label39);
            }
            if (sender == Label22)
            {
                Attributes.attributeChange("int", -1, Convert.ToInt32(label39.Text), Label30, label39);
            }
            if (sender == Label24)
            {
                Attributes.attributeChange("wit", -1, Convert.ToInt32(label39.Text), Label33, label39);
            }
            if (sender == Label26)
            {
                Attributes.attributeChange("cha", -1, Convert.ToInt32(label39.Text), Label35, label39);
            }
            if (sender == Label28)
            {
                Attributes.attributeChange("emp", -1, Convert.ToInt32(label39.Text), Label37, label39);
            }
        }
        /// <summary>
        /// Toiminnallisuutta radiobutton:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void radioAdd(Object sender, EventArgs e)
        {
             if (sender == RadioButton1) attributeChange("str", 1);
             if (sender == RadioButton2) attributeChange("con", 1);
             if (sender == RadioButton3 ) attributeChange("dex", 1);
             if (sender == RadioButton4) attributeChange("ref", 1);
             if (sender == RadioButton5) attributeChange("int", 1);
             if (sender == RadioButton6) attributeChange("wit", 1);
             if (sender == RadioButton7) attributeChange("cha", 1);
             if (sender == RadioButton8) attributeChange("emp", 1);
             if (sender == radioButton25) attributeChange("str", 1);
             if (sender == radioButton27) attributeChange("con", 1);
             if (sender == radioButton29) attributeChange("dex", 1);
             if (sender == radioButton31) attributeChange("ref", 1);
             if (sender == radioButton32) attributeChange("int", 1);
             if (sender == radioButton30) attributeChange("wit", 1);
             if (sender == radioButton28) attributeChange("cha", 1);
             if (sender == radioButton26) attributeChange("emp", 1);
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
                 RadioButton2.Visible = false;
             }
             if (sender == radioButton11)
             {
                 attributeChange("dex", 2);
                 RadioButton3.Visible = false;
             }
             if (sender == radioButton12)
             {
                 attributeChange("ref", 2);
                 RadioButton4.Visible = false;
             }
             if (sender == radioButton13)
             {
                 attributeChange("int", 2);
                 RadioButton5.Visible = false;
             }
             if (sender == radioButton14)
             {
                 attributeChange("wit", 2);
                 RadioButton6.Visible = false;
             }
             if (sender == radioButton15)
             {
                 attributeChange("cha", 2);
                 RadioButton7.Visible = false;
             }
             if (sender == radioButton16)
             {
                 attributeChange("emp", 2);
                 RadioButton8.Visible = false;
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
                 RadioButton1.Visible = true;
             }
             if (previous == radioButton10)
             {
                 attributeChange("con", -2);
                 RadioButton2.Visible = true;
             }
             if (previous == radioButton11)
             {
                 attributeChange("dex", -2);
                 RadioButton3.Visible = true;
             }
             if (previous == radioButton12)
             {
                 attributeChange("ref", -2);
                 RadioButton4.Visible = true;
             }
             if (previous == radioButton13)
             {
                 attributeChange("int", -2);
                 RadioButton5.Visible = true;
             }
             if (previous == radioButton14)
             {
                 attributeChange("wit", -2);
                 RadioButton6.Visible = true;
             }
             if (previous == radioButton15)
             {
                 attributeChange("cha", -2);
                 RadioButton7.Visible = true;
             }
             if (previous == radioButton16)
             {
                 attributeChange("emp", -2);
                 RadioButton8.Visible = true;
             }
         }
         /// <summary>
         /// Poistaa edeltävän valinnan muutokset
         /// </summary>
         /// <param name="previous"></param>
        private void radioTake(object previous)
         {
             if (previous == RadioButton1)
             {//str
                 attributeChange("str", -1);
             }
             if (previous == RadioButton2)
             {
                 attributeChange("con", -1);
             }
             if (previous == RadioButton3)
             {
                 attributeChange("dex", -1);
             }
             if (previous == RadioButton4)
             {
                 attributeChange("ref", -1);
             }
             if (previous == RadioButton5)
             {
                 attributeChange("int", -1);
             }
             if (previous == RadioButton6)
             {
                 attributeChange("wit", -1);
             }
             if (previous == RadioButton7)
             {
                 attributeChange("cha", -1);
             }
             if (previous == RadioButton8)
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
            Label105.Text = Convert.ToString(tulos2 * 2) + "kg";
            Label106.Text = Convert.ToString(tulos2 * 4) + "kg";
            Label107.Text = Convert.ToString(tulos2 * 6) + "kg";
        }
        private void speed ( string h, string i)
        {
            double x = Convert.ToInt32(h);
            double y = Convert.ToInt32(i);
            double tulos = x * 0.2 + y * 0.2;
            Label104.Text = Convert.ToString(tulos);
        }

        /// <summary>
        /// Vastaa attribuuttibonusten laskemisesta taitoihin, attrtibuuttibonusten laskusta sekä laskettujen attribuuttien laskemisesta.
        /// Kutsutaan attribuutin arvon muuttuessa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_TextChanged ( object sender, EventArgs e)
        {
            if ( sender == Label6)
            {
                burden(Label6.Text, Label8.Text);
                Label32.Text = Convert.ToString(Calc(Convert.ToInt32(Label6.Text) - 10));
                Label103.Text = Label32.Text;
                speed(Label6.Text, Label10.Text);
                
                
            }
            if (sender == Label8) 
            {

                burden(Label6.Text, Label8.Text);
                Label40.Text = Convert.ToString(Calc(Convert.ToInt32(Label8.Text) - 10));

            }
            if (sender == Label10)
             
            {
                
                speed(Label6.Text, Label10.Text);
                Label41.Text = Convert.ToString(Calc(Convert.ToInt32(Label10.Text) - 10));
                Label54.Text = Label41.Text;
                Label64.Text = Label41.Text;
                //agility
                Label73.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(73, Label73.Text, Label54.Text)));
                Label74.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(74,Label74.Text, Label54.Text)));
                Label75.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(75,Label75.Text, Label54.Text)));
                Label76.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(76,Label76.Text, Label54.Text)));
                Label77.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(77,Label77.Text, Label54.Text)));
                Label78.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(78,Label78.Text, Label54.Text)));
                //label79.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(79,label79.Text, label54.Text)));
                //label80.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(80,label80.Text, label54.Text)));
                //combat skills 2.pt. of agility
                Label174.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(174,Label174.Text, Label54.Text)));
                Label175.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(175,Label175.Text, Label54.Text)));
                Label176.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(176,Label176.Text, Label54.Text)));
                Label177.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(177,Label177.Text, Label54.Text)));
                Label178.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(178,Label178.Text, Label54.Text)));
                Label179.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(179,Label179.Text, Label54.Text)));
                Label180.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(180,Label180.Text, Label54.Text)));
                Label181.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(181,Label181.Text, Label54.Text)));
                Label182.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(182,Label182.Text, Label54.Text)));
                Label183.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(183,Label183.Text, Label54.Text)));
                Label184.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(184,Label184.Text, Label54.Text)));
                Label185.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(185,Label185.Text, Label54.Text)));
                Label186.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(186,Label186.Text, Label54.Text)));
                Label187.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(187,Label187.Text, Label54.Text)));
            
                
            }

            if ( sender==Label12)
            {
                Label42.Text = Convert.ToString(Calc(Convert.ToInt32(Label12.Text) - 10));
            }
            
            if ( sender==Label30)
            {
                //int
                Label43.Text = Convert.ToString(Calc(Convert.ToInt32(Label30.Text) - 10));
                Label56.Text = Label43.Text;
                Label192.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(192,Label192.Text, Label56.Text)));
                Label193.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(193,Label193.Text, Label56.Text)));
                Label194.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(194,Label194.Text, Label56.Text))); 
                Label195.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(195,Label195.Text, Label56.Text)));
                Label196.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(196,Label196.Text, Label56.Text)));
                Label197.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(197,Label197.Text, Label56.Text)));
                Label198.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(198,Label198.Text, Label56.Text)));
                Label199.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(199,Label199.Text, Label56.Text)));
                Label200.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(200,Label200.Text, Label56.Text)));
                Label201.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(201,Label201.Text, Label56.Text)));
                Label202.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(202,Label202.Text, Label56.Text)));
                Label203.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(203,Label203.Text, Label56.Text)));
                Label204.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(204,Label204.Text, Label56.Text)));
                Label205.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(205,Label205.Text, Label56.Text)));
                Label206.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(206,Label206.Text, Label56.Text)));
                Label207.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(207,Label207.Text, Label56.Text)));
                Label208.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(208,Label208.Text, Label56.Text)));
                Label209.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(209,Label209.Text, Label56.Text)));
                //label210.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(210,label210.Text, label56.Text)));
                //label211.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(211,label211.Text, label56.Text)));
                //label212.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(212,label212.Text, label56.Text)));

            }
            if ( sender==Label33)
            {
                Label44.Text = Convert.ToString(Calc(Convert.ToInt32(Label33.Text) - 10));
                Label58.Text = Label44.Text;
                //WIT
                Label167.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(167,Label167.Text, Label58.Text)));
                Label168.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(168,Label168.Text, Label58.Text)));
                Label169.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(169,Label169.Text, Label58.Text)));
                Label170.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(170,Label170.Text, Label58.Text)));
                Label171.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(171,Label171.Text, Label58.Text)));
                Label172.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(172,Label172.Text, Label58.Text)));
                Label173.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(173,Label173.Text, Label58.Text)));
            }
            if (sender == Label35)
            {
                Label45.Text = Convert.ToString(Calc(Convert.ToInt32(Label35.Text) - 10));
                Label60.Text = Label45.Text;
                //Social
                Label161.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(161,Label161.Text, Label54.Text)));
                Label162.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(162,Label162.Text, Label54.Text)));
                Label163.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(163,Label163.Text, Label54.Text)));
                Label164.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(164,Label164.Text, Label54.Text)));
                Label165.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(165,Label165.Text, Label54.Text)));
                Label166.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(166,Label166.Text, Label54.Text)));
            }
            if (sender == Label37)
            {

                //EMP
                Label46.Text = Convert.ToString(Calc(Convert.ToInt32(Label37.Text) - 10));
                Label62.Text = Label46.Text;
                Label188.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(188,Label188.Text, Label46.Text)));
                Label189.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(189,Label189.Text, Label46.Text)));
                Label190.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(190,Label190.Text, Label46.Text)));
                Label191.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(191,Label191.Text, Label46.Text)));
                SDM();
            }
            if (sender == Label190)
            {

                SDM();

            }
        }      
        /// <summary>
        /// Laskee SDM lasketun attribuutin. 
        /// </summary>
        private void SDM ()
        { 
            Label108.Text = Convert.ToString(12-Convert.ToInt32(Label37.Text)-0.5*Convert.ToInt32(Label190.Text));
        }
        private void CareerClick(object sender, EventArgs e)
        {
            if (sender == label346)
            {
                Label334.Text = Convert.ToString(Convert.ToInt32(Label334.Text) + 1);
                if(ComboBox4.SelectedIndex==0)
                {
                    Label163.Text = Label334.Text;
                }
            }
        }
        private void AgilitySkillClick(object sender,int change)
        {
            if (sender == Label81 || sender == Label89) Skill.SkillLabelMod( change, Label213.Text, 73, Label73);
            if (sender == Label82 || sender == Label90) Skill.SkillLabelMod( change, Label213.Text, 74, Label74);
            if (sender == Label83 || sender == Label91) Skill.SkillLabelMod( change, Label213.Text, 75, Label75);
            if (sender == Label84 || sender == Label92) Skill.SkillLabelMod( change, Label213.Text, 76, Label76);
            if (sender == Label85 || sender == Label93) Skill.SkillLabelMod( change, Label213.Text, 77, Label77);
            if (sender == Label86 || sender == Label94) Skill.SkillLabelMod( change, Label213.Text, 78, Label78);

        }
        private void SocialSkillClick(object sender)
        {
            if( sender == label214) Skill.SkillLabelMod( 1, Label213.Text, 161, Label161);
            if (sender == label215) Skill.SkillLabelMod( 1, Label213.Text, 162, Label162);
            if (sender == label216) Skill.SkillLabelMod( 1, Label213.Text, 163, Label163);
            if (sender == label217) Skill.SkillLabelMod( 1, Label213.Text, 164, Label164);
            if (sender == label218) Skill.SkillLabelMod( 1, Label213.Text, 165, Label165);
            if (sender == label219) Skill.SkillLabelMod( 1, Label213.Text, 166, Label166);
        }
        private void IntuitionSkillClick(object sender)
        { 
            if (sender == label220) Skill.SkillLabelMod( 1, Label213.Text, 167, Label167);
            if (sender == label221) Skill.SkillLabelMod( 1, Label213.Text, 168, Label168);
            if (sender == label222) Skill.SkillLabelMod( 1, Label213.Text, 169, Label169);
            if (sender == label223) Skill.SkillLabelMod( 1, Label213.Text, 170, Label170);
            if (sender == label224) Skill.SkillLabelMod( 1, Label213.Text, 171, Label171);
            if (sender == label225) Skill.SkillLabelMod( 1, Label213.Text, 172, Label172);
            if (sender == label226) Skill.SkillLabelMod( 1, Label213.Text, 173, Label173);
        }
        private void CombatSkillClick(object sender)
        {
            if (sender == label227) Skill.SkillLabelMod(1, Label213.Text, 174, Label174);
            if (sender == label228) Skill.SkillLabelMod(1, Label213.Text, 175, Label175);
            if (sender == label229) Skill.SkillLabelMod(1, Label213.Text, 176, Label176);
            if (sender == label230) Skill.SkillLabelMod(1, Label213.Text, 177, Label177);
            if (sender == label231) Skill.SkillLabelMod(1, Label213.Text, 178, Label178);
            if (sender == label232) Skill.SkillLabelMod(1, Label213.Text, 179, Label179);
            if (sender == label233) Skill.SkillLabelMod(1, Label213.Text, 180, Label180);
            if (sender == label234) Skill.SkillLabelMod(1, Label213.Text, 181, Label181);
            if (sender == label235) Skill.SkillLabelMod(1, Label213.Text, 182, Label182);
            if (sender == label236) Skill.SkillLabelMod(1, Label213.Text, 183, Label183);
            if (sender == label237) Skill.SkillLabelMod(1, Label213.Text, 184, Label184);
            if (sender == label238) Skill.SkillLabelMod(1, Label213.Text, 185, Label185);
            if (sender == label239) Skill.SkillLabelMod(1, Label213.Text, 186, Label186);
            if (sender == label240) Skill.SkillLabelMod(1, Label213.Text, 187, Label187);
        }
        private void EmpathySkillClick(object sender)
        {
            if (sender == label241) Skill.SkillLabelMod(1, Label213.Text, 188, Label188);
            if (sender == label242) Skill.SkillLabelMod(1, Label213.Text, 189, Label189);
            if (sender == label243) Skill.SkillLabelMod(1, Label213.Text, 190, Label190);
            if (sender == label244) Skill.SkillLabelMod(1, Label213.Text, 191, Label191);
        }
        private void InteligenceSkillClick(object sender)
        {
            if (sender == label245) Skill.SkillLabelMod(1, Label213.Text, 192, Label192);
            if (sender == label246) Skill.SkillLabelMod(1, Label213.Text, 193, Label193);
            if (sender == label247) Skill.SkillLabelMod(1, Label213.Text, 194, Label194);
            if (sender == label248) Skill.SkillLabelMod(1, Label213.Text, 195, Label195);
            if (sender == label249) Skill.SkillLabelMod(1, Label213.Text, 196, Label196);
            if (sender == label250) Skill.SkillLabelMod(1, Label213.Text, 197, Label197);
            if (sender == label251) Skill.SkillLabelMod(1, Label213.Text, 198, Label198);
            if (sender == label252) Skill.SkillLabelMod(1, Label213.Text, 199, Label199);
            if (sender == label253) Skill.SkillLabelMod(1, Label213.Text, 200, Label200);
            if (sender == label254) Skill.SkillLabelMod(1, Label213.Text, 201, Label201);
            if (sender == label255) Skill.SkillLabelMod(1, Label213.Text, 202, Label202);
            if (sender == label256) Skill.SkillLabelMod(1, Label213.Text, 203, Label203);
            if (sender == label257) Skill.SkillLabelMod(1, Label213.Text, 204, Label204);
            if (sender == label258) Skill.SkillLabelMod(1, Label213.Text, 205, Label205);
            if (sender == label259) Skill.SkillLabelMod(1, Label213.Text, 206, Label206);
            if (sender == label260) Skill.SkillLabelMod(1, Label213.Text, 207, Label207);
            if (sender == label261) Skill.SkillLabelMod(1, Label213.Text, 208, Label208);
            if (sender == label262) Skill.SkillLabelMod(1, Label213.Text, 209, Label209);
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
            if (sender == Label81 || sender == Label82 || sender == Label83 || sender == Label84 || sender == Label85 || sender == Label86 || sender == Label89 || sender == Label90 || sender == Label91 || sender == Label92 || sender == Label93 || sender == Label94) AgilitySkillClick(sender,1);
            if(sender == Label89 || sender == Label90 || sender == Label91 || sender == Label92 || sender == Label93 || sender == Label94) AgilitySkillClick(sender,-1);
            if (sender == label214 || sender == label215 || sender == label216 || sender == label217 || sender == label218 || sender == label219) SocialSkillClick(sender);
            if (sender == label220 || sender == label221 || sender == label222 || sender == label223 || sender == label224 || sender == label225 || sender == label226) IntuitionSkillClick(sender);
            if (sender == label227 || sender == label228 || sender == label229 || sender == label230 || sender == label231 || sender == label232 || sender == label233 || sender == label234 || sender == label235 || sender == label236 || sender == label237 || sender == label238 || sender == label239 || sender == label240) CombatSkillClick(sender);
            if (sender == label241 || sender == label242 || sender == label243 || sender == label244) EmpathySkillClick(sender);
            if (sender == label245 || sender == label246 || sender == label247 || sender == label248 || sender == label249 || sender == label250 || sender == label251 || sender == label252 || sender == label253 || sender == label254 || sender == label255 || sender == label256 || sender == label257 || sender == label258 || sender == label259 || sender == label260 || sender == label261 || sender == label262) InteligenceSkillClick(sender);
            //social
            if (sender == label266)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 161, Label161);
            } 
            if (sender == label267)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 162, Label162);
            } 
            if (sender == label268)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 163, Label163);
            } 
            if (sender == label269)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 164, Label164);
            }
            if (sender == label270)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 165, Label165);
            }
            if (sender == label271)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 166, Label166);
            }
            //Intuition
            if (sender == label272)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 167, Label167);
            } 
            if (sender == label273)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 168, Label168);
            } 
            if (sender == label274)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 169, Label169);
            } 
            if (sender == label275)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 170, Label170);
            }
            if (sender == label276)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 171, Label171);
            } 
            if (sender == label277)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 172, Label172);
            }
            
            if (sender == label278)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 173, Label173);
            } //combat
            
            if (sender == label279)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 174, Label174);
            }
            if (sender == label280)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 175, Label175);
            } 
            if (sender == label281)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 176, Label176);
            } 
            if (sender == label282)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 177, Label177);
            }
            if (sender == label283)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 178, Label178);
            } 
            if (sender == label284)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 179, Label179);
            }
            if (sender == label285)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 180, Label180);
            }
            if (sender == label286)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 181, Label181);
            }
            if (sender == label287)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 182, Label182);
            }
            if (sender == label288)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 183, Label183);
            }
            if (sender == label289)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 184, Label184);
            }
            if (sender == label290)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 185, Label185);
            }
            if (sender == label291)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 186, Label186);
            }
            if (sender == label292)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 187, Label187);
            }
            // empatia ->
            if (sender == label293)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 188, Label188);
            }

            if (sender == label294)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 189, Label189);
            }

            if (sender == label295)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 190, Label190);
            }

            if (sender == label296)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 191, Label191);
            }
            //inteligence 192-212
            if (sender == label297)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 192, Label192);
            }

            if (sender == label298)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 193, Label193);
            }
            if (sender == label299)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 194, Label194);
            }
            if (sender == label300)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 195, Label195);
            }
            if (sender == label301)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 196, Label196);
            }
            if (sender == label302)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 197, Label197);
            }
            if (sender == label303)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 198, Label198);
            }
            if (sender == label304)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 199, Label199);
            }
            if (sender == label305)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 200, Label200);
            }
            if (sender == label306)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 201, Label201);
            }
            if (sender == label307)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 202, Label202);
            }
            if (sender == label308)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 203, Label203);
            }
            if (sender == label309)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 204, Label204);
            }
            if (sender == label310)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 205, Label205);
            }
            if (sender == label311)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 206, Label206);
            }
            if (sender == label312)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 207, Label207);
            }
            if (sender == label313)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 208, Label208);
            }
            if (sender == label314)
            {
                Skill.SkillLabelMod(-1, Label213.Text, 209, Label209);
            }
        }
        
        /// <summary>
        /// Laskee todennäköisyydet onnistumiselle, sekä kriittiselle onnistumiselle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prob (object sender,EventArgs e )
        {
            Label sender1 = new Label(); 
            sender1 = (Label) sender;
            double[] prob3d6 ={0, 0 ,0, 0.46, 1.85, 4.63, 9.26, 16.2, 25.93, 37.5, 50, 62.5, 74.1, 83.83, 90.74, 95.37, 98.15, 99.54, 100 }  ;
            double[] prob2d6 = { 0, 0, 0, 0, 0, 0, 0, 0, 2.78, 8.33, 16.67, 27.78, 41.67, 58.33, 72.22, 83.33, 91.67, 97.22, 100 };
            int value = Convert.ToInt32(sender1.Text);
            if (value < 0)
            {
                label319.Text = "0";
                Label321.Text = "0";
            }
            if (value > 18)
            {
                label319.Text = "100";
                Label321.Text = "100";
            }
            else
            {
                label319.Text = Convert.ToString(prob3d6[Convert.ToInt32(sender1.Text)]);
                Label321.Text = Convert.ToString(prob2d6[Convert.ToInt32(sender1.Text)]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            Label322.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[0];
            Label323.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[1];
            Label324.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[2];
            Label325.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[3];
            Label326.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[4];
            Label327.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[5];
            Label328.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[6];
            Label329.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[7];
            Label330.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[8];
            Label331.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[9];
            Label332.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[10];
            Label333.Text = Career.CareerSkillNames(ComboBox4.SelectedIndex)[11];
            switch(ComboBox4.SelectedIndex)
            {
                case 0:
                    {
                        Label334.Text = Label163.Text;
                        Label335.Text = Label199.Text;
                        Label337.Text = Label165.Text;
                        Label338.Text = Label184.Text;
                        Label340.Text = Label166.Text;
                        Label341.Text = Label76.Text;
                        Label342.Text = Label190.Text;
                        break;
                    }
            }
        }
        private void groupBoxInit()
        {
            groupBox2.Visible = false;
            GroupBox1.Visible = false;
            groupBox4.Visible = false;
            RadioButton1.Visible = false;
            RadioButton2.Visible = false;
            RadioButton3.Visible = false;
            RadioButton4.Visible = false;
            RadioButton5.Visible = false;
            RadioButton6.Visible = false;
            RadioButton7.Visible = false;
            RadioButton8.Visible = false;
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
                GroupBox1.Visible = true;
                switch (att)
                {
                    case "str":
                        {
                            RadioButton1.Visible = true;
                            break;
                        }
                    case "con":
                        {
                            RadioButton2.Visible = true;
                            break;
                        }
                    case "dex":
                        {
                            RadioButton3.Visible = true;
                            break;
                        }
                    case "ref":
                        {
                            RadioButton4.Visible = true;
                            break;
                        }
                    case "int":
                        {
                            RadioButton5.Visible = true;
                            break;
                        }
                    case "wit":
                        {
                            RadioButton6.Visible = true;
                            break;
                        }
                    case "cha":
                        {
                            RadioButton7.Visible = true;
                            break;
                        }
                    case "emp":
                        {
                            RadioButton8.Visible = true;
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
        public void groupBox1Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 1);
            attributeVisibility(att2, 1);
            attributeVisibility(att3, 1);
        }
        public void groupBox2Visibility(string att1, string att2, string att3, string att4, string att5)
        {
            attributeVisibility(att1, 2);
            attributeVisibility(att2, 2);
            attributeVisibility(att3, 2);
            attributeVisibility(att4, 2);
            attributeVisibility(att5, 2);
        }
        public void groupBox4Visibility(string att1, string att2)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
        }
        public void groupBox4Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
        }
        public void groupBox4Visibility(string att1, string att2, string att3, string att4)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
            attributeVisibility(att4, 4);
        }
        public void groupBox4Visibility(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
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
 
 
