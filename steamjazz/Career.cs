using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steamjazz
{
    class cCareer
    {
       
        
        public cCareer()
        {

        }
        string[] Names =  new string[12];
        public string[] CareerSkillNames(int Box4SelectedIndex)
        {

            
            if(Box4SelectedIndex ==0)
            {

                Names[0]="Charm"; 
                Names[1]="Etiquette";
                Names[2]="Dancing";
                Names[3]="Leadership";
                Names[4]="Finesse";
                Names[5]="Negotiate";
                Names[6]="Persuade";
                Names[7]="Ride";
                Names[8]="Sense Motive";
                Names[9]="Charm";
                Names[10]="Charm";
                Names[11]="Charm";
                
            }
            return Names;
        }
    }
    
}
