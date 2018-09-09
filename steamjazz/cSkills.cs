using System;
using System.Windows.Forms;

namespace Steamjazz
{
    internal class cSkills
    {
        public cSkill[] aSkill = new cSkill[60];
        private int cost = 0;

        public cSkills()
        {
            //agility
            aSkill[0] = new cSkill(8);
            aSkill[1] = new cSkill(8);
            aSkill[2] = new cSkill(8);
            aSkill[3] = new cSkill(8);
            aSkill[4] = new cSkill(8);
            aSkill[5] = new cSkill(7);
            //Social
            aSkill[6] = new cSkill(8);
            aSkill[7] = new cSkill(8);
            aSkill[8] = new cSkill(8);
            aSkill[9] = new cSkill(8);
            aSkill[10] = new cSkill(8);
            aSkill[11] = new cSkill(8);
            //Intuition
            aSkill[12] = new cSkill(8);
            aSkill[13] = new cSkill(10);
            aSkill[14] = new cSkill(7);
            aSkill[15] = new cSkill(7);
            aSkill[16] = new cSkill(8);
            aSkill[17] = new cSkill(8);
            aSkill[18] = new cSkill(8);
            //combat skills
            aSkill[19] = new cSkill(8);
            aSkill[20] = new cSkill(7);
            aSkill[21] = new cSkill(8);
            aSkill[22] = new cSkill(7);
            aSkill[23] = new cSkill(8);
            aSkill[24] = new cSkill(7);
            aSkill[25] = new cSkill(7);
            aSkill[26] = new cSkill(7);
            aSkill[27] = new cSkill(7);
            aSkill[28] = new cSkill(7);
            aSkill[29] = new cSkill(7);
            aSkill[30] = new cSkill(7);
            aSkill[31] = new cSkill(6);
            aSkill[32] = new cSkill(7);
            //empatia 35-38
            aSkill[33] = new cSkill(8);
            aSkill[34] = new cSkill(8);
            aSkill[35] = new cSkill(8);
            aSkill[36] = new cSkill(8);
            //int 39-59
            aSkill[37] = new cSkill(7);
            aSkill[38] = new cSkill(7);
            aSkill[39] = new cSkill(7);
            aSkill[40] = new cSkill(7);
            aSkill[41] = new cSkill(7);
            aSkill[42] = new cSkill(7);
            aSkill[43] = new cSkill(7);
            aSkill[44] = new cSkill(7);
            aSkill[45] = new cSkill(7);
            aSkill[46] = new cSkill(7);
            aSkill[47] = new cSkill(7);
            aSkill[48] = new cSkill(7);
            aSkill[49] = new cSkill(7);
            aSkill[50] = new cSkill(7);
            aSkill[51] = new cSkill(7);
            aSkill[52] = new cSkill(7);
            aSkill[53] = new cSkill(7);
            aSkill[54] = new cSkill(7);
            aSkill[55] = new cSkill(7);
        }

        /// <summary>
        /// laskee attribuuttiboonuksen vaikutuksen taitoihin
        /// </summary>
        /// <param name="label"></param>
        /// taidon label numero. esim. label73 on siis 73
        /// <param name="labelBonus"></param>
        /// varsinainen attribuutti boonus
        /// <returns></returns>
        public string attBonus(int label, string labelBonus)
        {
            aSkill[ArrayValue(label)].AttributeBonusValue = Convert.ToInt32(labelBonus);
            aSkill[ArrayValue(label)].ValueChanged();
            return Convert.ToString(aSkill[ArrayValue(label)].SkillValue);
        }

        private static int ArrayValue(int label)
        {
            int[] index = new int[210];
            index[73] = 0;
            index[74] = 1;
            index[75] = 2;
            index[76] = 3;
            index[77] = 4;
            index[78] = 5;
            index[161] = 6;
            index[162] = 7;
            index[163] = 8;
            index[164] = 9;
            index[165] = 10;
            index[166] = 11;
            index[167] = 12;
            index[168] = 13;
            index[169] = 14;
            index[170] = 15;
            index[171] = 16;
            index[172] = 17;
            index[173] = 18;
            index[174] = 19;
            index[175] = 20;
            index[176] = 21;
            index[177] = 22;
            index[178] = 23;
            index[179] = 24;
            index[180] = 25;
            index[181] = 26;
            index[182] = 27;
            index[183] = 28;
            index[184] = 29;
            index[185] = 30;
            index[186] = 31;
            index[187] = 32;
            index[188] = 33;
            index[189] = 34;
            index[190] = 35;
            index[191] = 36;
            index[192] = 37;
            index[193] = 38;
            index[194] = 39;
            index[195] = 40;
            index[196] = 41;
            index[197] = 42;
            index[198] = 43;
            index[199] = 44;
            index[200] = 45;
            index[201] = 46;
            index[202] = 47;
            index[203] = 48;
            index[204] = 49;
            index[205] = 50;
            index[206] = 51;
            index[207] = 52;
            index[208] = 53;
            index[209] = 54;
            return index[label];
        }

        private string skillChange(int label, int change)
        {
            aSkill[ArrayValue(label)].SkillRankValue = aSkill[ArrayValue(label)].SkillRankValue + change;
            aSkill[ArrayValue(label)].ValueChanged();
            return Convert.ToString(aSkill[ArrayValue(label)].SkillValue);
        }

        /// <summary>
        /// Laskee mahdollisuuden ostaa lisää taitoja, palauttaa true jos on.
        /// </summary>
        /// <param name="points"></param>
        /// taidon tämänhetkinen tila
        /// <param name="pointsBuy"></param>
        /// kuinka monta ostopistettä on jäljellä tällä hetkellä
        /// <returns></returns>
        private bool enough(string pointsBuy, int label)
        {
            int point = aSkill[ArrayValue(label)].SkillRankValue;
            int pointBuy = Convert.ToInt32(pointsBuy);
            cost = 0;
            int add = point + 1;
            while (point > 0)
            {
                cost = cost + point;
                point--;
            }
            cost = cost + add;
            if (pointBuy >= cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SkillLabelMod(int change, string labelPointsLeft, int labelNumber, Label label)
        {
            if (enough(labelPointsLeft, labelNumber) == true)
            {
                labelPointsLeft = pointBuy(labelPointsLeft, labelNumber);
                label.Text = skillChange(labelNumber, change);
            }
        }

        private string pointBuy(string points, int label)
        {
            string tulos = Convert.ToString(Convert.ToInt32(points) - aSkill[ArrayValue(label)].SkillRankValue - 1);
            return tulos;
        }
    }
}