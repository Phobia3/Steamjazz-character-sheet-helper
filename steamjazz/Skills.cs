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
        /// <summary>
        /// Laskee mahdollisuuden ostaa lisää taitoja, palauttaa true jos on.
        /// </summary>
        /// <param name="points"></param>
        /// taidon tämänhetkinen tila
        /// <param name="pointsBuy"></param>
        /// kuinka monta ostopistettä on jäljellä tällä hetkellä
        /// <returns></returns>
        public bool enough(string points, string pointsBuy)
        {
            int point = Convert.ToInt32(points);
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

        public string pointBuy(string buy)
        {
            string tulos = Convert.ToString(Convert.ToInt32(buy) - cost);
            cost = 0;
            return tulos;
        }
    }
}
