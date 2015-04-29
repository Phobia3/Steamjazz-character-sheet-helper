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
        public Skills()
        {
            
        }
        public string attBonus(string labelSkill, string labelBonus)
        {
            int bonus = Convert.ToInt32(labelBonus) - Convert.ToInt32(prevBonus);
            labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + bonus);
            prevBonus = labelBonus; 
            return labelSkill;
        }

    }
}
