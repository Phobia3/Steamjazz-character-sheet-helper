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
        public cBackground()
        {

        }
        private string palautus;
        public string Palautus
        {
            get
            { return palautus; }
            set
            { palautus = value; }
        }
        public string Race(int Box1SelectedIndex)
        {

            if(Box1SelectedIndex==0)
            {
                Palautus = "Steamjazz.Human.txt";
            }
            if (Box1SelectedIndex == 1)
            {
                Palautus = "Steamjazz.Dracosaurian.txt";
            }
            if (Box1SelectedIndex == 2)
            {
                Palautus = "Steamjazz.Sylph.txt";
            }
            if (Box1SelectedIndex == 3)
            {
                Palautus = "Steamjazz.KharzulDwarf.txt";
            }
            if (Box1SelectedIndex == 4)
            {
                Palautus = "Steamjazz.beastfolk.txt";
            }
            if (Box1SelectedIndex == 5)
            {
                Palautus = "Steamjazz.Goliath.txt";
            }
            if (Box1SelectedIndex == 6)
            {
                Palautus = "Steamjazz.Automaton.txt";
            }
            
            return Palautus;
        }
        public string Nationality(int Box2SelectedIndex, int Box1SelectedIndex)
        {
            if (Box1SelectedIndex != 6)
            {

                if (Box2SelectedIndex == 6)
                {
                    switch (Box1SelectedIndex)
                    {
                        case 1:
                            {
                                Palautus = "Steamjazz.BeastfolkBack.txt";
                                break;
                            }
                        case 2:
                            {

                                Palautus = "Steamjazz.DracosaurianBack.txt";
                                break;
                            }
                        case 3:
                            {

                                Palautus = "Steamjazz.GoliathBack.txt";
                                break;
                            }
                        case 4:
                            {

                                Palautus = "Steamjazz.KharzulDwarfBack.txt";
                                break;
                            }
                        case 5:
                            {

                                Palautus = "Steamjazz.SylphBack.txt";
                                break;
                            }
                    }

                }
                //"Victoria", "Wolfgart", "Hanseburg", "Free Islands", "Kheiman Empire", "Crimson Empire", muties
                switch(Box2SelectedIndex)
                {
                    case 0:
                        {
                            Palautus = "Steamjazz.Victora.txt";
                            break;
                        }
                    case 1:
                        {
                            Palautus = "Steamjazz.Wolfgart.txt";
                            break;
                        }
                    case 2:
                        {
                            Palautus = "Steamjazz.Hanseburg.txt";
                            break;
                        }
                    case 3:
                        {
                            Palautus = "Steamjazz.FreeIsland.txt";
                            break;
                        }
                    case 4:
                        {
                            Palautus = "Steamjazz.Kheiman.txt";
                            break;
                        }
                        
                    case 5:
                        {
                            Palautus = "Steamjazz.Crimson.txt";
                            break;
                        }

                }
            }
            return Palautus;
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
        public void BackgroundModifiers()
        {
            RaceModifiers();
            SocialModifiers();
        }
        private void RaceModifiers()
        {
            Form1 formi = new Form1();
            switch (formi.ComboBox1.SelectedIndex)
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
                        formi.attributeChange("emp", -1);
                        formi.attributeChange("cha", -2);
                        //allocate +2 to one of the following attributes: STR, CON, DEX, REF, WIT and +1 to another attribute from the list.
                        formi.groupBox2Visibility("str", "con", "dex", "ref", "wit");
                        break;
                    }
                case 2:
                    {
                        //Dracosaurian CHA -2, REF +1; allocate +1 to one of the following: STR, CON or DEX
                        formi.attributeChange("cha", -2);
                        formi.attributeChange("ref", 1);
                        formi.groupBox1Visibility("str", "con", "dex");
                        break;
                    }
                case 3:
                    {
                        //Goliath STR +3, CON +3, REF -2, INT -2, WIT -2, CHA -2 Initial STR and CON must be at least 10.
                        formi.attributeChange("str", 3);
                        formi.attributeChange("con", 3);
                        formi.attributeChange("ref", -2);
                        formi.attributeChange("int", -2);
                        formi.attributeChange("wit", -2);
                        formi.attributeChange("cha", -2);
                        break;
                    }
                case 4:
                    {
                        //Kharzul Dwarf CON +2, CHA -2 Advantage: low light vision Advantage: mule Disadvantage: slow
                        formi.attributeChange("con", 2);
                        formi.attributeChange("cha", -2);
                        break;
                    }
                case 5:
                    {
                        // Sylph STR -1, DEX +1 Sylphs can jump twice as high and far as humans. Sylphs gain a +1 racial bonus to dodge and athletics. The dodge bonus counts as a rank in the dodge skill for increasing PDM. Disadvantage: Frail
                        formi.attributeChange("str", -1);
                        formi.attributeChange("dex", 1);
                        break;
                    }
                case 6:
                    {
                        //Automaton
                        break;
                    }

            }
        }
        private void SocialModifiers()
        {
            using (Form1 formi = new Form1())
            {
                switch (formi.ComboBox2.SelectedIndex)
                {

                    case 0:
                        {
                            //Victoria
                            switch (formi.ComboBox3.SelectedIndex)
                            {
                                case 0:
                                    {
                                        // Low  CON, REF or EMP +1 Initial skill ranks: Survival 2, Brawl 1, Stealth 1 15 CP can be used to buy ranks in the following skills: Athletics, Animal Handling, Bluff, Brawl, Cooking, Dodge, First Aid, Forgery, Gaming, Grappling, Handguns, Intimidate, Listen, Melee (Balanced), Melee (Powerful), Spot, Stealth, Survival, Throw or to purchase up to 10 CP worth of acquirable advantages. Starting Wealth level cannot be higher than ‘Well off’.
                                        formi.groupBox4Visibility("con", "ref", "emp");
                                        break;
                                    }
                                case 1:
                                    {
                                        // Middle DEX, INT or WIT +1 Initial skill ranks: Appraise 2, Persuade 1, Negotiate 1 15 CP can be used to buy ranks in the following skills: Appraise, Bluff, Brawl, Craft (any), Cooking, Negotiate, Etiquette, Handguns, Intimidate, Martial Arts (Victoran Pugilism), Mechanics, Perform (dancing), Persuade, Profession (any), Ride.
                                        formi.groupBox4Visibility("dex", "int", "wit");
                                        break;
                                    }
                                case 2:
                                    {
                                        // Upper Cost to play: 10CP INT or CHA +1 Initial skill ranks: Etiquette 3, Negotiate 2, Language: Victoran 1 The Starting wealth level of Victoran upper class characters must be Drifter or higher. The 5 CP cost of Drifter has already been calculated into the Background cost and can be further increased with CP during character creation. 15 CP can be used to buy ranks in the following skills: Art (any), Charm, Negotiate, Etiquette, Knowledge: Heraldry, Language (Victoran), Long Guns, Martial Arts (Fencing), Melee (Finesse), Melee (Balanced), Perform (Dancing), Perform (Oratory), Ride, or to improve the Starting wealth level by 10 CP or to purchase the Noble, Victoran advantage.
                                       formi.groupBox4Visibility("dex", "int", "wit");
                                        break;
                                    }
                            }

                            break;
                        }
                    case 1:
                        {
                            //Wolfgart
                            switch (formi.ComboBox3.SelectedIndex)
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
                                       formi.groupBox4Visibility("str", "con", "int");

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
                                       formi.groupBox4Visibility("str", "dex");

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
                                       formi.groupBox4Visibility("int", "cha");

                                        break;
                                    }
                            } break;
                        }
                    case 4:
                        {
                            //Kheiman Empire                        
                            switch (formi.ComboBox3.SelectedIndex)
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
                                       formi.groupBox4Visibility("str", "con", "int");

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
                                       formi.groupBox4Visibility("str", "dex", "wit");

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
                                       formi.groupBox4Visibility("int", "wit", "emp", "cha");

                                        break;
                                    }
                            } break;
                        }
                    case 2:
                        {
                            //Hansenburg
                            switch (formi.ComboBox3.SelectedIndex)
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
                                       formi.groupBox4Visibility("con", "int", "emp");

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
                                       formi.groupBox4Visibility("dex", "wit", "cha");

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
                                       formi.groupBox4Visibility("dex", "cha", "emp");

                                        break;
                                    }
                            } break;
                        }
                    case 5:
                        {
                            //Crimson Empire
                            switch (formi.ComboBox3.SelectedIndex)
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
                                       formi.groupBox4Visibility("str", "con", "emp");

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
                                       formi.groupBox4Visibility("str", "dex", "cha");

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
                                       formi.groupBox4Visibility("dex", "int", "wit");

                                        break;
                                    }
                            } break;
                        }
                    case 3:
                        {
                            //Free Islands
                            switch (formi.ComboBox3.SelectedIndex)
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
                                       formi.groupBox4Visibility("str", "con", "dex", "ref", "int", "wit", "cha", "emp");

                                        break;
                                    }
                                case 1:
                                    {
                                       formi.attributeChange("ref", 1);

                                        break;
                                    }
                                case 2:
                                    {
                                       formi.GroupBox1.Visible = true;
                                       formi.RadioButton1.Visible = false;
                                       formi.RadioButton2.Visible = true;
                                       formi.RadioButton3.Visible = false;
                                       formi.RadioButton4.Visible = true;
                                       formi.RadioButton5.Visible = false;
                                       formi.RadioButton6.Visible = true;
                                       formi.RadioButton7.Visible = false;
                                       formi.RadioButton8.Visible = true;

                                        break;
                                    }
                            } break;
                        }
                    case 6:
                        {

                            if (formi.ComboBox3.SelectedIndex == 1)
                            {
                               formi.attributeChange("int", 1);


                            }
                            if (formi.ComboBox3.SelectedIndex == 3)
                            {
                               formi.attributeChange("ref", 1);

                            }
                            if (formi.ComboBox3.SelectedIndex == 4)
                            {
                               formi.attributeChange("int", 1);

                            }
                            if (formi.ComboBox3.SelectedIndex == 5)
                            {
                               formi.attributeChange("con", 1);

                            }
                            if (formi.ComboBox3.SelectedIndex == 6)
                            {
                               formi.attributeChange("con", 1);
                               formi.attributeChange("cha", -1);

                            }

                        }
                        break;
                }
            }
        }
    }
}

