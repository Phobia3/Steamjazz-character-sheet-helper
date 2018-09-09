using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Steamjazz
{
    public partial class Form1 : Form

    {
        private cAttributes Attributes = new cAttributes();
        private cBackground Background = new cBackground();
        private int backPrevious1 = -1;
        private int backPrevious2 = -1;
        private int backPrevious3 = -1;
        private cCareer Careers = new cCareer();
        private object previous;
        private object previous2;
        private cSkills Skill = new cSkills();

        /// <summary>
        /// ensimmäiset alustukset
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //InitializeSkills();
            AttributeChange("10", "10", "10", "10", "10", "10", "10", "10");
            InitializeComboBox();
        }

        /// <summary>
        /// Lisää toiminnallisuuden + merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AttributeAdd(Object sender, EventArgs e)
        {
            if (sender == Label13)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label6, Label39);
            }
            if (sender == Label15)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label8, Label39);
            }
            if (sender == Label17)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label10, Label39);
            }
            if (sender == Label19)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label12, Label39);
            }
            if (sender == Label21)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label30, Label39);
            }
            if (sender == Label23)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label33, Label39);
            }
            if (sender == Label25)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label35, Label39);
            }
            if (sender == Label27)
            {
                Attributes.AttributeChange(1, Convert.ToInt32(Label39.Text), Label37, Label39);
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
        public void AttributeChange(string str, string con, string dex, string refl, string inte, string wit, string cha, string emp)
        {
            Label6.Text = str;
            Label8.Text = con;
            Label10.Text = dex;
            Label12.Text = refl;
            Label30.Text = inte;
            Label33.Text = wit;
            Label35.Text = cha;
            Label37.Text = emp;
        }

        /// <summary>
        /// Muuttaa haluttua attribuuttia halutun määrän verran
        /// </summary>
        /// <param name="att"></param>
        /// halutun attribuutin lyhenne
        /// <param name="change"></param>
        /// haluttu muutos
        public void AttributeChange(string att, int change)
        {
            if (att == "str") Label6.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + change);
            if (att == "con") Label8.Text = Convert.ToString(Convert.ToInt32(Label8.Text) + change);
            if (att == "dex") Label10.Text = Convert.ToString(Convert.ToInt32(Label10.Text) + change);
            if (att == "ref") Label12.Text = Convert.ToString(Convert.ToInt32(Label12.Text) + change);
            if (att == "int") Label30.Text = Convert.ToString(Convert.ToInt32(Label30.Text) + change);
            if (att == "wit") Label33.Text = Convert.ToString(Convert.ToInt32(Label33.Text) + change);
            if (att == "cha") Label35.Text = Convert.ToString(Convert.ToInt32(Label35.Text) + change);
            if (att == "emp") Label37.Text = Convert.ToString(Convert.ToInt32(Label37.Text) + change);
        }

        /// <summary>
        /// Lisää toiminnallisuutta - merkkisiin label:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AttributeTake(Object sender, EventArgs e)
        {
            if (sender == Label14)
            {//str
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label6, Label39);
            }
            if (sender == Label16)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label8, Label39);
            }
            if (sender == Label18)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label10, Label39);
            }
            if (sender == Label20)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label12, Label39);
            }
            if (sender == Label22)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label30, Label39);
            }
            if (sender == Label24)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label33, Label39);
            }
            if (sender == Label26)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label35, Label39);
            }
            if (sender == Label28)
            {
                Attributes.AttributeChange(-1, Convert.ToInt32(Label39.Text), Label37, Label39);
            }
        }

        public void BackgroundModifiers()
        {
            RaceModifiers();
            SocialModifiers();
        }

        public void groupBox1Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 1);
            attributeVisibility(att2, 1);
            attributeVisibility(att3, 1);
        }

        public void GroupBox2Visibility(string att1, string att2, string att3, string att4, string att5)
        {
            attributeVisibility(att1, 2);
            attributeVisibility(att2, 2);
            attributeVisibility(att3, 2);
            attributeVisibility(att4, 2);
            attributeVisibility(att5, 2);
        }

        public void GroupBox4Visibility(string att1, string att2)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
        }

        public void GroupBox4Visibility(string att1, string att2, string att3)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
        }

        public void GroupBox4Visibility(string att1, string att2, string att3, string att4)
        {
            attributeVisibility(att1, 4);
            attributeVisibility(att2, 4);
            attributeVisibility(att3, 4);
            attributeVisibility(att4, 4);
        }

        public void GroupBox4Visibility(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
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

        /// <summary>
        /// tulosteita mahdollisten virheiden varalta.
        /// </summary>
        /// <param name="e"></param>
        public void tulostus(string text)
        {
            richTextBox1.Text = text;
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

        private void AgilitySkillClick(object sender, int change)
        {
            if (sender == Label81 || sender == Label89) Skill.SkillLabelMod(change, Label213.Text, 73, Label73);
            if (sender == Label82 || sender == Label90) Skill.SkillLabelMod(change, Label213.Text, 74, Label74);
            if (sender == Label83 || sender == Label91) Skill.SkillLabelMod(change, Label213.Text, 75, Label75);
            if (sender == Label84 || sender == Label92) Skill.SkillLabelMod(change, Label213.Text, 76, Label76);
            if (sender == Label85 || sender == Label93) Skill.SkillLabelMod(change, Label213.Text, 77, Label77);
            if (sender == Label86 || sender == Label94) Skill.SkillLabelMod(change, Label213.Text, 78, Label78);
        }
        private void singlePointVisibility(string att)
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
        private void doublePointVisibility(string att)
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
            if (x == 1)
            {
                singlePointVisibility(att);

            }
            if (x == 2)
            {
                doublePointVisibility(att);
                
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
        /// Tarkistaa combobox1, -2 ja -3 arvot ja muokkaa attribuutteja sen mukaisesti. KESKEN
        /// </summary>
        private void backAttribute()
        {
            backAttributeTake();
            groupBoxInit();
            BackgroundModifiers();

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

        private void burden(string x, string y)
        {
            double tulos2 = Convert.ToInt32(x) + Convert.ToInt32(y);
            Label105.Text = Convert.ToString(tulos2 * 2) + "kg";
            Label106.Text = Convert.ToString(tulos2 * 4) + "kg";
            Label107.Text = Convert.ToString(tulos2 * 6) + "kg";
        }

        /// <summary>
        /// Tallennusfunktio, päivittää aikaisemmin talteen otetun id:n mukaiset rivit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(Object sender, EventArgs e)
        {
            cDBConnect komento = new cDBConnect();
            komento.Insert("UPDATE info SET name='" + textBox1.Text + "', race='" + ComboBox1.Text + "', background='" + ComboBox3.Text + "', career='" + ComboBox4.Text + "', occupation='" + ComboBox4.Text + "', gender='', age='', player='' WHERE ID='" + "'");
        }

        /// <summary>
        /// Luo uuden rivin steamjazz tietokannan tauluihin, ottaen samalla talteen info taulun id arvon. Id arvoa tullaan myöhemmin
        /// hyödyntämään hahmon tallennuksessa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(Object sender, EventArgs e)
        {
            cDBConnect komento = new cDBConnect();
            komento.Insert("INSERT INTO info (name, race, background, career, occupation, gender, age, player) VALUES ('" + textBox1.Text + "','" + ComboBox1.Text + "','" + ComboBox3.Text + "','" + ComboBox4.Text + "',' ',' ',' ',' ')");
        }

        private void CombatSkillClick(object sender, int change)
        {
            if (sender == label227 || sender == label279) Skill.SkillLabelMod(change, Label213.Text, 174, Label174);
            if (sender == label228 || sender == label280) Skill.SkillLabelMod(change, Label213.Text, 175, Label175);
            if (sender == label229 || sender == label281) Skill.SkillLabelMod(change, Label213.Text, 176, Label176);
            if (sender == label230 || sender == label282) Skill.SkillLabelMod(change, Label213.Text, 177, Label177);
            if (sender == label231 || sender == label283) Skill.SkillLabelMod(change, Label213.Text, 178, Label178);
            if (sender == label232 || sender == label284) Skill.SkillLabelMod(change, Label213.Text, 179, Label179);
            if (sender == label233 || sender == label285) Skill.SkillLabelMod(change, Label213.Text, 180, Label180);
            if (sender == label234 || sender == label286) Skill.SkillLabelMod(change, Label213.Text, 181, Label181);
            if (sender == label235 || sender == label287) Skill.SkillLabelMod(change, Label213.Text, 182, Label182);
            if (sender == label236 || sender == label288) Skill.SkillLabelMod(change, Label213.Text, 183, Label183);
            if (sender == label237 || sender == label289) Skill.SkillLabelMod(change, Label213.Text, 184, Label184);
            if (sender == label238 || sender == label290) Skill.SkillLabelMod(change, Label213.Text, 185, Label185);
            if (sender == label239 || sender == label291) Skill.SkillLabelMod(change, Label213.Text, 186, Label186);
            if (sender == label240 || sender == label292) Skill.SkillLabelMod(change, Label213.Text, 187, Label187);
        }

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
            combobox1Strings(ComboBox1.SelectedIndex);

            RichTextBoxTulostus(Background.Race(ComboBox1.SelectedIndex));
        }

        /// <summary>
        /// Combobox1 sisältää tiedon hahmon rodusta. Rotu vaikuttaa atribuuttien lisäksi muutamaan uniikkiin taustavaihtoehtoon.
        /// Richtextbox:lle lähetetään tuloste combobox1:n valitusta rodusta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combobox1Strings(int SelectedIndex)
        {
            switch (SelectedIndex)
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
            combobox2Strings(ComboBox2.SelectedIndex);

            RichTextBoxTulostus(Background.Nationality(ComboBox1.SelectedIndex, ComboBox2.SelectedIndex));
        }

        private void combobox2Strings(int SelectedIndex)
        {
            switch (SelectedIndex)
            {
                case 0:
                    {
                        //Victoria
                        combobox3init("Lower Class", "Middle Class", "Upper Class");
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
                        combobox3init("Worker", "Warrior", "Clergy");
                        break;
                    }
                case 3:
                    {
                        //Hansenburg
                        combobox3init("Worker", "Merchant", "Noble");
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
        }

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
        /// Valmistellaan comboBox3 vastaanottamaan eri kansalaisuuksien luokkamahdollisuudet
        /// </summary>
        /// <param name="eka"></param>
        /// valitun maan kolme eri luokkatasoa, eroteltuna kolmeen eri string muuttujaan
        /// <param name="toka"></param>
        /// <param name="kolme"></param>
        private void combobox3init(string eka, string toka, string kolme)
        {
            ComboBox3.Items.Clear();
            string[] race = new string[] { eka, toka, kolme };
            ComboBox3.Items.AddRange(race);
            ComboBox3.Visible = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label322.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[0];
            Label323.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[1];
            Label324.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[2];
            Label325.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[3];
            Label326.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[4];
            Label327.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[5];
            Label328.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[6];
            Label329.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[7];
            Label330.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[8];
            Label331.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[9];
            Label332.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[10];
            Label333.Text = Careers.CareerSkillNames(ComboBox4.SelectedIndex)[11];
            switch (ComboBox4.SelectedIndex)
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

        private void EmpathySkillClick(object sender, int change)
        {
            if (sender == label241 || sender == label293) Skill.SkillLabelMod(change, Label213.Text, 188, Label188);
            if (sender == label242 || sender == label294) Skill.SkillLabelMod(change, Label213.Text, 189, Label189);
            if (sender == label243 || sender == label295) Skill.SkillLabelMod(change, Label213.Text, 190, Label190);
            if (sender == label244 || sender == label296) Skill.SkillLabelMod(change, Label213.Text, 191, Label191);
        }

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

        private void HanseburgSocialMod(int SelectedIndex)
        {
            switch (SelectedIndex)
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
                        GroupBox4Visibility("con", "int", "emp");

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
                        GroupBox4Visibility("dex", "wit", "cha");

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
                        GroupBox4Visibility("dex", "cha", "emp");

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
        /// alustaa combobox:t joiden sisältö ei vaihdu.
        /// </summary>
        private void InitializeComboBox()
        {
            string[] race = new string[]{"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph"
            ,"Automaton"};

            string[] mili = new string[] { "Deserter", "Military Service", "Non-military Service" };
            ComboBox1.Items.AddRange(race);
            ComboBox4.Items.AddRange(Careers.Career);
            comboBox5.Items.AddRange(mili);
        }

        private void InteligenceSkillClick(object sender, int change)
        {
            if (sender == label245 || sender == label297) Skill.SkillLabelMod(change, Label213.Text, 192, Label192);
            if (sender == label246 || sender == label298) Skill.SkillLabelMod(change, Label213.Text, 193, Label193);
            if (sender == label247 || sender == label299) Skill.SkillLabelMod(change, Label213.Text, 194, Label194);
            if (sender == label248 || sender == label300) Skill.SkillLabelMod(change, Label213.Text, 195, Label195);
            if (sender == label249 || sender == label301) Skill.SkillLabelMod(change, Label213.Text, 196, Label196);
            if (sender == label250 || sender == label302) Skill.SkillLabelMod(change, Label213.Text, 197, Label197);
            if (sender == label251 || sender == label303) Skill.SkillLabelMod(change, Label213.Text, 198, Label198);
            if (sender == label252 || sender == label304) Skill.SkillLabelMod(change, Label213.Text, 199, Label199);
            if (sender == label253 || sender == label305) Skill.SkillLabelMod(change, Label213.Text, 200, Label200);
            if (sender == label254 || sender == label306) Skill.SkillLabelMod(change, Label213.Text, 201, Label201);
            if (sender == label255 || sender == label307) Skill.SkillLabelMod(change, Label213.Text, 202, Label202);
            if (sender == label256 || sender == label308) Skill.SkillLabelMod(change, Label213.Text, 203, Label203);
            if (sender == label257 || sender == label309) Skill.SkillLabelMod(change, Label213.Text, 204, Label204);
            if (sender == label258 || sender == label310) Skill.SkillLabelMod(change, Label213.Text, 205, Label205);
            if (sender == label259 || sender == label311) Skill.SkillLabelMod(change, Label213.Text, 206, Label206);
            if (sender == label260 || sender == label312) Skill.SkillLabelMod(change, Label213.Text, 207, Label207);
            if (sender == label261 || sender == label313) Skill.SkillLabelMod(change, Label213.Text, 208, Label208);
            if (sender == label262 || sender == label314) Skill.SkillLabelMod(change, Label213.Text, 209, Label209);
        }

        private void IntuitionSkillClick(object sender, int change)
        {
            if (sender == label220 || sender == label272) Skill.SkillLabelMod(change, Label213.Text, 167, Label167);
            if (sender == label221 || sender == label273) Skill.SkillLabelMod(change, Label213.Text, 168, Label168);
            if (sender == label222 || sender == label274) Skill.SkillLabelMod(change, Label213.Text, 169, Label169);
            if (sender == label223 || sender == label275) Skill.SkillLabelMod(change, Label213.Text, 170, Label170);
            if (sender == label224 || sender == label276) Skill.SkillLabelMod(change, Label213.Text, 171, Label171);
            if (sender == label225 || sender == label277) Skill.SkillLabelMod(change, Label213.Text, 172, Label172);
            if (sender == label226 || sender == label278) Skill.SkillLabelMod(change, Label213.Text, 173, Label173);
        }

        private void KheimanSocialMod(int SelectedIndex)
        {
            //Kheiman Empire
            switch (SelectedIndex)
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
                        GroupBox4Visibility("str", "con", "int");

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
                        GroupBox4Visibility("str", "dex", "wit");

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
                        GroupBox4Visibility("int", "wit", "emp", "cha");

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
        /// Vastaa attribuuttibonusten laskemisesta taitoihin, attrtibuuttibonusten laskusta sekä laskettujen attribuuttien laskemisesta.
        /// Kutsutaan attribuutin arvon muuttuessa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_TextChanged(object sender, EventArgs e)
        {
            if (sender == Label6)
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
                Label73.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(73, Label54.Text)));
                Label74.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(74, Label54.Text)));
                Label75.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(75, Label54.Text)));
                Label76.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(76, Label54.Text)));
                Label77.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(77, Label54.Text)));
                Label78.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(78, Label54.Text)));
                Label174.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(174, Label54.Text)));
                Label175.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(175, Label54.Text)));
                Label176.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(176, Label54.Text)));
                Label177.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(177, Label54.Text)));
                Label178.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(178, Label54.Text)));
                Label179.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(179, Label54.Text)));
                Label180.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(180, Label54.Text)));
                Label181.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(181, Label54.Text)));
                Label182.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(182, Label54.Text)));
                Label183.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(183, Label54.Text)));
                Label184.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(184, Label54.Text)));
                Label185.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(185, Label54.Text)));
                Label186.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(186, Label54.Text)));
                Label187.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(187, Label54.Text)));
            }

            if (sender == Label12)
            {
                Label42.Text = Convert.ToString(Calc(Convert.ToInt32(Label12.Text) - 10));
            }

            if (sender == Label30)
            {
                //int
                Label43.Text = Convert.ToString(Calc(Convert.ToInt32(Label30.Text) - 10));
                Label56.Text = Label43.Text;
                Label192.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(192, Label56.Text)));
                Label193.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(193, Label56.Text)));
                Label194.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(194, Label56.Text)));
                Label195.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(195, Label56.Text)));
                Label196.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(196, Label56.Text)));
                Label197.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(197, Label56.Text)));
                Label198.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(198, Label56.Text)));
                Label199.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(199, Label56.Text)));
                Label200.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(200, Label56.Text)));
                Label201.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(201, Label56.Text)));
                Label202.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(202, Label56.Text)));
                Label203.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(203, Label56.Text)));
                Label204.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(204, Label56.Text)));
                Label205.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(205, Label56.Text)));
                Label206.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(206, Label56.Text)));
                Label207.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(207, Label56.Text)));
                Label208.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(208, Label56.Text)));
                Label209.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(209, Label56.Text)));
                //label210.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(210,label210.Text, label56.Text)));
                //label211.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(211,label211.Text, label56.Text)));
                //label212.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(212,label212.Text, label56.Text)));
            }
            if (sender == Label33)
            {
                Label44.Text = Convert.ToString(Calc(Convert.ToInt32(Label33.Text) - 10));
                Label58.Text = Label44.Text;
                //WIT
                Label167.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(167, Label58.Text)));
                Label168.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(168, Label58.Text)));
                Label169.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(169, Label58.Text)));
                Label170.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(170, Label58.Text)));
                Label171.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(171, Label58.Text)));
                Label172.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(172, Label58.Text)));
                Label173.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(173, Label58.Text)));
            }
            if (sender == Label35)
            {
                Label45.Text = Convert.ToString(Calc(Convert.ToInt32(Label35.Text) - 10));
                Label60.Text = Label45.Text;
                //Social
                Label161.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(161, Label54.Text)));
                Label162.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(162, Label54.Text)));
                Label163.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(163, Label54.Text)));
                Label164.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(164, Label54.Text)));
                Label165.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(165, Label54.Text)));
                Label166.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(166, Label54.Text)));
            }
            if (sender == Label37)
            {
                //EMP
                Label46.Text = Convert.ToString(Calc(Convert.ToInt32(Label37.Text) - 10));
                Label62.Text = Label46.Text;
                Label188.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(188, Label46.Text)));
                Label189.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(189, Label46.Text)));
                Label190.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(190, Label46.Text)));
                Label191.Text = Convert.ToString(Convert.ToInt32(Skill.attBonus(191, Label46.Text)));
                SDM();
            }
            if (sender == Label190) SDM();
        }

        /// <summary>
        /// Laskee todennäköisyydet onnistumiselle, sekä kriittiselle onnistumiselle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prob(object sender, EventArgs e)
        {
            Label sender1 = new Label();
            sender1 = (Label)sender;
            double[] prob3d6 = { 0, 0, 0, 0.46, 1.85, 4.63, 9.26, 16.2, 25.93, 37.5, 50, 62.5, 74.1, 83.83, 90.74, 95.37, 98.15, 99.54, 100 };
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

        private void RaceModifiers()
        {
            switch (ComboBox1.SelectedIndex)
            {
                //"Human","Beastfolk","Dracosaurian","Goliath","Kharzul Dwarf","Sylph" ,"Automaton"
                case 1:
                    {
                        // Beastfolk
                        AttributeChange("emp", -1);
                        AttributeChange("cha", -2);
                        //allocate +2 to one of the following attributes: STR, CON, DEX, REF, WIT and +1 to another attribute from the list.
                        GroupBox2Visibility("str", "con", "dex", "ref", "wit");
                        break;
                    }
                case 2:
                    {
                        //Dracosaurian CHA -2, REF +1; allocate +1 to one of the following: STR, CON or DEX
                        AttributeChange("cha", -2);
                        AttributeChange("ref", 1);
                        groupBox1Visibility("str", "con", "dex");
                        break;
                    }
                case 3:
                    {
                        //Goliath STR +3, CON +3, REF -2, INT -2, WIT -2, CHA -2 Initial STR and CON must be at least 10.
                        AttributeChange("str", 3);
                        AttributeChange("con", 3);
                        AttributeChange("ref", -2);
                        AttributeChange("int", -2);
                        AttributeChange("wit", -2);
                        AttributeChange("cha", -2);
                        break;
                    }
                case 4:
                    {
                        //Kharzul Dwarf CON +2, CHA -2 Advantage: low light vision Advantage: mule Disadvantage: slow
                        AttributeChange("con", 2);
                        AttributeChange("cha", -2);
                        break;
                    }
                case 5:
                    {
                        // Sylph STR -1, DEX +1 Sylphs can jump twice as high and far as humans. Sylphs gain a +1 racial bonus to dodge and athletics. The dodge bonus counts as a rank in the dodge skill for increasing PDM. Disadvantage: Frail
                        AttributeChange("str", -1);
                        AttributeChange("dex", 1);
                        break;
                    }
                case 6:
                    {
                        //Automaton
                        break;
                    }
            }
        }

        /// <summary>
        /// Taustan valinta tapahtuu combobox3:ssa. RichTextBox tulostaa tarvittavan informaation taustoista. Vaikuttaa atribuutteihin ja muihin
        /// ominaisuuksiin
        /// </summary>
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
                        AttributeChange("emp", 1);
                        AttributeChange("cha", 2);
                        break;
                    }
                case 2:
                    {
                        //Dracosaurian
                        AttributeChange("cha", 2);
                        AttributeChange("ref", -1);
                        break;
                    }
                case 3:
                    {
                        //Goliath STR +3, CON +3, REF -2, INT -2, WIT -2, CHA -2
                        AttributeChange("str", -3);
                        AttributeChange("con", -3);
                        AttributeChange("ref", 2);
                        AttributeChange("int", 2);
                        AttributeChange("wit", 2);
                        AttributeChange("cha", 2);
                        break;
                    }
                case 4:
                    {
                        // Kharzul Dwarf
                        AttributeChange("cha", 2);
                        AttributeChange("con", -2);
                        break;
                    }
                case 5:
                    {
                        //Sylph
                        AttributeChange("str", 1);
                        AttributeChange("dex", -1);
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
        /// Placeholder for Free Islands
        /// </summary>
        /// <summary>
        /// Pieni erillinen funktio kuvaamaan wolfgartin asepalveluksen vaikutuksia hahmon taitoihin KESKEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// Toiminnallisuutta radiobutton:in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioAdd(Object sender, EventArgs e)
        {
            if (sender == RadioButton1) AttributeChange("str", 1);
            if (sender == RadioButton2) AttributeChange("con", 1);
            if (sender == RadioButton3) AttributeChange("dex", 1);
            if (sender == RadioButton4) AttributeChange("ref", 1);
            if (sender == RadioButton5) AttributeChange("int", 1);
            if (sender == RadioButton6) AttributeChange("wit", 1);
            if (sender == RadioButton7) AttributeChange("cha", 1);
            if (sender == RadioButton8) AttributeChange("emp", 1);
            if (sender == radioButton25) AttributeChange("str", 1);
            if (sender == radioButton27) AttributeChange("con", 1);
            if (sender == radioButton29) AttributeChange("dex", 1);
            if (sender == radioButton31) AttributeChange("ref", 1);
            if (sender == radioButton32) AttributeChange("int", 1);
            if (sender == radioButton30) AttributeChange("wit", 1);
            if (sender == radioButton28) AttributeChange("cha", 1);
            if (sender == radioButton26) AttributeChange("emp", 1);
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
                AttributeChange("str", 2);
            }
            if (sender == radioButton10)
            {
                AttributeChange("con", 2);
                RadioButton2.Visible = false;
            }
            if (sender == radioButton11)
            {
                AttributeChange("dex", 2);
                RadioButton3.Visible = false;
            }
            if (sender == radioButton12)
            {
                AttributeChange("ref", 2);
                RadioButton4.Visible = false;
            }
            if (sender == radioButton13)
            {
                AttributeChange("int", 2);
                RadioButton5.Visible = false;
            }
            if (sender == radioButton14)
            {
                AttributeChange("wit", 2);
                RadioButton6.Visible = false;
            }
            if (sender == radioButton15)
            {
                AttributeChange("cha", 2);
                RadioButton7.Visible = false;
            }
            if (sender == radioButton16)
            {
                AttributeChange("emp", 2);
                RadioButton8.Visible = false;
            }
            radioTake2(previous2);
            previous2 = sender;
        }

        /// <summary>
        /// Poistaa edeltävän valinnan muutokset
        /// </summary>
        /// <param name="previous"></param>
        private void radioTake(object earlier)
        {
            if (earlier == RadioButton1)
            {//str
                AttributeChange("str", -1);
            }
            if (earlier == RadioButton2)
            {
                AttributeChange("con", -1);
            }
            if (earlier == RadioButton3)
            {
                AttributeChange("dex", -1);
            }
            if (earlier == RadioButton4)
            {
                AttributeChange("ref", -1);
            }
            if (earlier == RadioButton5)
            {
                AttributeChange("int", -1);
            }
            if (earlier == RadioButton6)
            {
                AttributeChange("wit", -1);
            }
            if (earlier == RadioButton7)
            {
                AttributeChange("cha", -1);
            }
            if (earlier == RadioButton8)
            {
                AttributeChange("emp", -1);
            }
            if (earlier == radioButton25)
            {//str
                AttributeChange("str", -1);
            }
            if (earlier == radioButton27)
            {
                AttributeChange("con", -1);
            }
            if (earlier == radioButton29)
            {
                AttributeChange("dex", -1);
            }
            if (earlier == radioButton31)
            {
                AttributeChange("ref", -1);
            }
            if (earlier == radioButton32)
            {
                AttributeChange("int", -1);
            }
            if (earlier == radioButton30)
            {
                AttributeChange("wit", -1);
            }
            if (earlier == radioButton28)
            {
                AttributeChange("cha", -1);
            }
            if (earlier == radioButton26)
            {
                AttributeChange("emp", -1);
            }
        }

        /// <summary>
        /// Poistaa edeltävän valinnan muutokset
        /// </summary>
        /// <param name="previous"></param>
        private void radioTake2(object previous)
        {
            if (previous == radioButton9)
            {//str
                AttributeChange("str", -2);
                RadioButton1.Visible = true;
            }
            if (previous == radioButton10)
            {
                AttributeChange("con", -2);
                RadioButton2.Visible = true;
            }
            if (previous == radioButton11)
            {
                AttributeChange("dex", -2);
                RadioButton3.Visible = true;
            }
            if (previous == radioButton12)
            {
                AttributeChange("ref", -2);
                RadioButton4.Visible = true;
            }
            if (previous == radioButton13)
            {
                AttributeChange("int", -2);
                RadioButton5.Visible = true;
            }
            if (previous == radioButton14)
            {
                AttributeChange("wit", -2);
                RadioButton6.Visible = true;
            }
            if (previous == radioButton15)
            {
                AttributeChange("cha", -2);
                RadioButton7.Visible = true;
            }
            if (previous == radioButton16)
            {
                AttributeChange("emp", -2);
                RadioButton8.Visible = true;
            }
        }

        /// <summary>
        /// Tulostaa RichTextBox1:n annetun resurssin mukaisen datan
        /// </summary>
        /// <param name="resurssi"></param>
        /// tulostettavan resurssin nimi.
        private void RichTextBoxTulostus(string resurssi)
        {
            if (resurssi != null)
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
        }

        /// <summary>
        /// Laskee SDM lasketun attribuutin.
        /// </summary>
        private void SDM()
        {
            Label108.Text = Convert.ToString(12 - Convert.ToInt32(Label37.Text) - 0.5 * Convert.ToInt32(Label190.Text));
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
            //Agility skills
            if (sender == Label81 || sender == Label82 || sender == Label83 || sender == Label84 || sender == Label85 || sender == Label86 || sender == Label89 || sender == Label90 || sender == Label91 || sender == Label92 || sender == Label93 || sender == Label94) AgilitySkillClick(sender, 1);
            if (sender == Label89 || sender == Label90 || sender == Label91 || sender == Label92 || sender == Label93 || sender == Label94) AgilitySkillClick(sender, -1);

            //Social skills
            if (sender == label214 || sender == label215 || sender == label216 || sender == label217 || sender == label218 || sender == label219) SocialSkillClick(sender, 1);
            if (sender == label266 || sender == label267 || sender == label268 || sender == label269 || sender == label270 || sender == label271) SocialSkillClick(sender, -1);

            //Intuition skills
            if (sender == label220 || sender == label221 || sender == label222 || sender == label223 || sender == label224 || sender == label225 || sender == label226) IntuitionSkillClick(sender, 1);
            if (sender == label272 || sender == label273 || sender == label274 || sender == label275 || sender == label276 || sender == label277 || sender == label278) IntuitionSkillClick(sender, -1);

            //combat skills
            if (sender == label227 || sender == label228 || sender == label229 || sender == label230 || sender == label231 || sender == label232 || sender == label233 || sender == label234 || sender == label235 || sender == label236 || sender == label237 || sender == label238 || sender == label239 || sender == label240) CombatSkillClick(sender, 1);
            if (sender == label279 || sender == label280 || sender == label281 || sender == label282 || sender == label283 || sender == label284 || sender == label285 || sender == label286 || sender == label287 || sender == label288 || sender == label289 || sender == label290 || sender == label291 || sender == label292) CombatSkillClick(sender, -1);

            //Empathy skills
            if (sender == label241 || sender == label242 || sender == label243 || sender == label244) EmpathySkillClick(sender, 1);
            if (sender == label293 || sender == label294 || sender == label295 || sender == label296) EmpathySkillClick(sender, -1);

            //Inteligence skills
            if (sender == label245 || sender == label246 || sender == label247 || sender == label248 || sender == label249 || sender == label250 || sender == label251 || sender == label252 || sender == label253 || sender == label254 || sender == label255 || sender == label256 || sender == label257 || sender == label258 || sender == label259 || sender == label260 || sender == label261 || sender == label262) InteligenceSkillClick(sender, 1);
            if (sender == label297 || sender == label298 || sender == label299 || sender == label300 || sender == label301 || sender == label302 || sender == label303 || sender == label304 || sender == label305 || sender == label306 || sender == label307 || sender == label308 || sender == label309 || sender == label310 || sender == label311 || sender == label312 || sender == label313 || sender == label314) InteligenceSkillClick(sender, -1);
        }

        private void SocialModifiers()
        {
            switch (ComboBox2.SelectedIndex)
            {
                case 0:
                    {
                        VictoriaSocialMod(ComboBox3.SelectedIndex);
                        break;
                    }
                case 1:
                    {
                        WolfgartSocialMod(comboBox3.SelectedIndex);

                        break;
                    }
                case 4:
                    {
                        KheimanSocialMod(ComboBox3.SelectedIndex);

                        break;
                    }
                case 2:
                    {
                        HanseburgSocialMod(ComboBox3.SelectedIndex);
                        break;
                    }
                case 5:
                    {
                        //Crimson Empire
                        switch (ComboBox3.SelectedIndex)
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
                                    GroupBox4Visibility("str", "con", "emp");

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
                                    GroupBox4Visibility("str", "dex", "cha");

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
                                    GroupBox4Visibility("dex", "int", "wit");

                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        //Free Islands
                        switch (ComboBox3.SelectedIndex)
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
                                    GroupBox4Visibility("str", "con", "dex", "ref", "int", "wit", "cha", "emp");

                                    break;
                                }
                            case 1:
                                {
                                    AttributeChange("ref", 1);

                                    break;
                                }
                            case 2:
                                {
                                    GroupBox1.Visible = true;
                                    RadioButton1.Visible = false;
                                    RadioButton2.Visible = true;
                                    RadioButton3.Visible = false;
                                    RadioButton4.Visible = true;
                                    RadioButton5.Visible = false;
                                    RadioButton6.Visible = true;
                                    RadioButton7.Visible = false;
                                    RadioButton8.Visible = true;

                                    break;
                                }
                        }
                        break;
                    }
                case 6:
                    {
                        if (ComboBox3.SelectedIndex == 1)
                        {
                            AttributeChange("int", 1);
                        }
                        if (ComboBox3.SelectedIndex == 3)
                        {
                            AttributeChange("ref", 1);
                        }
                        if (ComboBox3.SelectedIndex == 4)
                        {
                            AttributeChange("int", 1);
                        }
                        if (ComboBox3.SelectedIndex == 5)
                        {
                            AttributeChange("con", 1);
                        }
                        if (ComboBox3.SelectedIndex == 6)
                        {
                            AttributeChange("con", 1);
                            AttributeChange("cha", -1);
                        }
                    }
                    break;
            }
        }

        private void SocialSkillClick(object sender, int change)
        {
            if (sender == label214 || sender == label266) Skill.SkillLabelMod(change, Label213.Text, 161, Label161);
            if (sender == label215 || sender == label267) Skill.SkillLabelMod(change, Label213.Text, 162, Label162);
            if (sender == label216 || sender == label268) Skill.SkillLabelMod(change, Label213.Text, 163, Label163);
            if (sender == label217 || sender == label269) Skill.SkillLabelMod(change, Label213.Text, 164, Label164);
            if (sender == label218 || sender == label270) Skill.SkillLabelMod(change, Label213.Text, 165, Label165);
            if (sender == label219 || sender == label271) Skill.SkillLabelMod(change, Label213.Text, 166, Label166);
        }

        /// <summary>
        /// reagoinnit attribuuttien muutokseen, että attribuuttiboonukset saadaan lasketttua ja tulostettua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speed(string h, string i)
        {
            double x = Convert.ToInt32(h);
            double y = Convert.ToInt32(i);
            double tulos = x * 0.2 + y * 0.2;
            Label104.Text = Convert.ToString(tulos);
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

        private void VictoriaSocialMod(int SelectedIndex)
        {
            //Victoria
            switch (ComboBox3.SelectedIndex)
            {
                case 0:
                    {
                        // Low  CON, REF or EMP +1 Initial skill ranks: Survival 2, Brawl 1, Stealth 1 15 CP can be used to buy ranks in the following skills: Athletics, Animal Handling, Bluff, Brawl, Cooking, Dodge, First Aid, Forgery, Gaming, Grappling, Handguns, Intimidate, Listen, Melee (Balanced), Melee (Powerful), Spot, Stealth, Survival, Throw or to purchase up to 10 CP worth of acquirable advantages. Starting Wealth level cannot be higher than ‘Well off’.
                        GroupBox4Visibility("con", "ref", "emp");
                        break;
                    }
                case 1:
                    {
                        // Middle DEX, INT or WIT +1 Initial skill ranks: Appraise 2, Persuade 1, Negotiate 1 15 CP can be used to buy ranks in the following skills: Appraise, Bluff, Brawl, Craft (any), Cooking, Negotiate, Etiquette, Handguns, Intimidate, Martial Arts (Victoran Pugilism), Mechanics, Perform (dancing), Persuade, Profession (any), Ride.
                        GroupBox4Visibility("dex", "int", "wit");
                        break;
                    }
                case 2:
                    {
                        // Upper Cost to play: 10CP INT or CHA +1 Initial skill ranks: Etiquette 3, Negotiate 2, Language: Victoran 1 The Starting wealth level of Victoran upper class characters must be Drifter or higher. The 5 CP cost of Drifter has already been calculated into the Background cost and can be further increased with CP during character creation. 15 CP can be used to buy ranks in the following skills: Art (any), Charm, Negotiate, Etiquette, Knowledge: Heraldry, Language (Victoran), Long Guns, Martial Arts (Fencing), Melee (Finesse), Melee (Balanced), Perform (Dancing), Perform (Oratory), Ride, or to improve the Starting wealth level by 10 CP or to purchase the Noble, Victoran advantage.
                        GroupBox4Visibility("dex", "int", "wit");
                        break;
                    }
            }
        }

        private void WolfgartSocialMod(int SelectedIndex)
        {
            //Wolfgart
            switch (SelectedIndex)
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
                        GroupBox4Visibility("str", "con", "int");

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
                        GroupBox4Visibility("str", "dex");

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
                        GroupBox4Visibility("int", "cha");

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
    }
}