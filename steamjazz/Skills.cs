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

        public string skillRemove(string x)
        {
            return Convert.ToString(Convert.ToInt32(x) - 1);
        }

        private int skillRank(int points, int label)
        {
            if (label == 81)
            {
                return points - bonus73;
            }
            if (label == 82)
            {
                return points - bonus74;
            }
            if (label == 83)
            {
                return points - bonus75;
            }
            if (label == 84)
            {
                return points - bonus76;
            }
            if (label == 85)
            {
                return points - bonus77;
            }
            if (label == 86)
            {
                return points - bonus78;
            }
            if (label == 87)
            {
                return points - bonus79;
            }
            if (label == 88)
            {
                return points - bonus80;
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
        public string pointRefund(string points)
        {
            string tulos = Convert.ToString(Convert.ToInt32(points) + cost);
            cost = 0;
            return tulos;
        }
    }
}
