using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steamjazz
{
    class Skills
    {
        //agility
        int bonus73 = 8;
        int bonus74 = 8;
        int bonus75 = 8;
        int bonus76 = 8;
        int bonus77 = 8;
        int bonus78 = 8;
        int bonus79 = 8;
        int bonus80 = 7;
        //social
        int bonus161 = 8;
        int bonus162 = 8;
        int bonus163 = 8;
        int bonus164 = 8;
        int bonus165 = 8;
        int bonus166 = 8;
        //Intuition
        int bonus167 = 8;
        int bonus168 = 10;
        int bonus169 = 7;
        int bonus170 = 7;
        int bonus171 = 8;
        int bonus172 = 8;
        int bonus173 = 8;
        //combat skills
        int bonus174 = 8;
        int bonus175 = 7;
        int bonus176 = 8;
        int bonus177 = 7;
        int bonus178 = 8;
        int bonus179 = 7;
        int bonus180 = 7;
        int bonus181 = 6;
        int bonus182 = 7;
        int bonus183 = 7;
        int bonus184 = 7;
        int bonus185 = 7;
        int bonus186 = 6;
        int bonus187 = 7;
        //empatia
        int bonus188 = 7;
        int bonus189 = 7;
        int bonus190 = 7;
        int bonus191 = 7;
        //int
        int bonus192 = 7;
        int bonus193 = 8;
        int bonus194 = 7;
        int bonus195 = 8;
        int bonus196 = 8;
        int bonus197 = 8;
        int bonus198 = 7;
        int bonus199 = 7;
        int bonus200 = 8;
        int bonus201 = 7;
        int bonus202 = 8;
        int bonus203 = 7;
        int bonus204 = 8;
        int bonus205 = 6;
        int bonus206 = 8;
        int bonus207 = 7;
        int bonus208 = 7;
        int bonus209 = 8;
        int bonus210 = 8;
        int bonus211 = 7;
        int bonus212 = 8;
        string prevBonus= "0";
        int cost = 0;
        public Skills()
        {
          
        }
        /// <summary>
        /// laskee attribuuttiboonuksen vaikutuksen taitoihin
        /// </summary>
        /// <param name="labelSkill"></param>
        /// sisältää attribuutti boonuksen vaikutuksen taitoihin
        /// <param name="labelBonus"></param>
        /// varsinainen attribuutti boonus
        /// <returns></returns>
        public string attBonus(string labelSkill, string labelBonus)
        {
            int bonus = Convert.ToInt32(labelBonus) - Convert.ToInt32(prevBonus);
            labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + bonus);
            prevBonus = labelBonus; 
            return labelSkill;
        }
        public string skillAdd(string x)
        {
            return Convert.ToString(Convert.ToInt32(x) + 1);
        }
        private int skillRank(int points, int label)
        {
            if (label == 73)
            {
                return points - bonus73;
            }
            if (label == 74)
            {
                return points - bonus74;
            }
            if (label == 75)
            {
                return points - bonus75;
            }
            if (label == 76)
            {
                return points - bonus76;
            }
            if (label == 77)
            {
                return points - bonus77;
            }
            if (label == 78)
            {
                return points - bonus78;
            }
            if (label == 79)
            {
                return points - bonus79;
            }
            if (label == 80)
            {
                return points - bonus80;
            }
            if (label == 161)
            {
                return points - bonus161;
            }
            if (label == 162)
            {
                return points - bonus162;
            }
            if (label == 163)
            {
                return points - bonus163;
            }
            if (label == 164)
            {
                return points - bonus164;
            }
            if (label == 165)
            {
                return points - bonus165;
            }
            if (label == 166)
            {
                return points - bonus166;
            }
            if (label == 167)
            {
                return points - bonus167;
            }
            if (label == 168)
            {
                return points - bonus168;
            }
            if (label == 169)
            {
                return points - bonus169;
            }
            if (label == 170)
            {
                return points - bonus170;
            }
            if (label == 171)
            {
                return points - bonus171;
            }
            if (label == 172)
            {
                return points - bonus172;
            }
            if (label == 173)
            {
                return points - bonus173;
            }
            if (label == 174)
            {
                return points - bonus174;
            }
            if (label == 175)
            {
                return points - bonus175;
            }
            if (label == 176)
            {
                return points - bonus176;
            }
            if (label == 177)
            {
                return points - bonus177;
            }
            if (label == 178)
            {
                return points - bonus178;
            }
            if (label == 179)
            {
                return points - bonus179;
            }
            if (label == 180)
            {
                return points - bonus180;
            }
            if (label == 181)
            {
                return points - bonus181;
            }
            if (label == 182)
            {
                return points - bonus182;
            }
            if (label == 183)
            {
                return points - bonus183;
            }
            if (label == 184)
            {
                return points - bonus184;
            }
            if (label == 185)
            {
                return points - bonus185;
            }
            if (label == 186)
            {
                return points - bonus186;
            }
            if (label == 187)
            {
                return points - bonus187;
            }
            if (label == 188)
            {
                return points - bonus188;
            }
            if (label == 189)
            {
                return points - bonus189;
            }
            if (label == 190)
            {
                return points - bonus190;
            }

            else
            {
                return -1337;
            }
        }
        /// <summary>
        /// Laskee mahdollisuuden ostaa lisää taitoja, palauttaa true jos on.
        /// </summary>
        /// <param name="points"></param>
        /// taidon tämänhetkinen tila
        /// <param name="pointsBuy"></param>
        /// kuinka monta ostopistettä on jäljellä tällä hetkellä
        /// <returns></returns>
        public bool enough(string points, string pointsBuy, int label)
        {

            int point = skillRank(Convert.ToInt32(points),label);
            int pointBuy = Convert.ToInt32(pointsBuy);
            cost = 0;
            int add = point + 1;
            while(point>0)
            {
                cost = cost + point;
                point--;
            }
            cost= cost+add;
            if(pointBuy>=cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string pointBuy(string points)
        {
            string tulos = Convert.ToString(Convert.ToInt32(points) - cost);
            cost = 0;
            return tulos;
        }
    }
}
