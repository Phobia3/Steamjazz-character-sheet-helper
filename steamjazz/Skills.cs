using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steamjazz
{
    class Skills
    {
        //bonus[perusarvo,rank,attribuutin bonus]
        public int[,] bonus = new int[60,3] { { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 10, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 6, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 6, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 6, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0 }, { 7, 0 , 0 }, { 8, 0 , 0 }, { 8, 0 , 0 }, { 7, 0 , 0}, { 8, 0 , 0 } };
        //agility 0-7
        //social 8-13
        //Intuition 14- 20
        //combat skills21-34
        //empatia 35-38
        //int 39-59

        
        int cost = 0;
        public Skills()
        {

        }
        
        /// <summary>
        /// laskee attribuuttiboonuksen vaikutuksen taitoihin
        /// </summary>
        /// <param name="label"></param>
        /// taidon label numero. esim. label73 olisi siis 73
        /// <param name="labelSkill"></param>
        /// sisältää attribuutti boonuksen vaikutuksen taitoihin
        /// <param name="labelBonus"></param>
        /// varsinainen attribuutti boonus
        /// <returns></returns>
        public string attBonus(int label, string labelSkill, string labelBonus)
        {
            int erotus = 0;
            if (label == 73)
            {
                erotus = Convert.ToInt32(labelBonus)-bonus[0,2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[0, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 74)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[1, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[1, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 75)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[2, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[2, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 76)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[3, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[3, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 77)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[4, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[4, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 78)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[5, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[5, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 79)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[6, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[6, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 80)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[7, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[7, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 161)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[8, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[8, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 162)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[9, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[9, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 163)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[10, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[10, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 164)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[11, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[11, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 165)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[12, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[12, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 166)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[13, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[13, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 167)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[14, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[14, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 168)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[15, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[15, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 169)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[16, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[16, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 170)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[17, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[17, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 171)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[18, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[18, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 172)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[19, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[19, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 173)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[20, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[20, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 174)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[21, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[21, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 175)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[22, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[22, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 176)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[23, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[23, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 177)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[24, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[24, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 178)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[25, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[25, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 179)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[26, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[26, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 180)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[27, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[27, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 181)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[28, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[28, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 182)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[29, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[29, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 183)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[30, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[30, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 184)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[31, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[31, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 185)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[32, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[32, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 186)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[33, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[33, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 187)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[34, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[34, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 188)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[35, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[35, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 189)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[36, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[36, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 190)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[37, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[37, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 191)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[38, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[38, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 192)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[39, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[39, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 193)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[40, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[40, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 194)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[41, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[41, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 195)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[42, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[42, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 196)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[43, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[43, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 197)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[44, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[44, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 198)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[45, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[45, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 199)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[46, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[46, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 200)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[47, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[47, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 201)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[48, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[48, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 202)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[49, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[49, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 203)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[50, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[50, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 204)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[51, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[51, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 205)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[52, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[52, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 206)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[53, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[53, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 207)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[54, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[54, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 208)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[55, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[55, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 209)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[56, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[56, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 210)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[57, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[57, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 211)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[58, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[58, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            if (label == 212)
            {
                erotus = Convert.ToInt32(labelBonus) - bonus[59, 2];
                labelSkill = Convert.ToString(Convert.ToInt32(labelSkill) + erotus);
                bonus[59, 2] = Convert.ToInt32(labelBonus);
                return labelSkill;
            }
            return labelSkill;
        }
        public string skillAdd(string x, int label)
        {
            if (label == 73)
            {
                bonus[0, 1] = bonus[0, 1] + 1;
            }
            if (label == 74)
            {
                bonus[1, 1] = bonus[1, 1] + 1;
            }
            if (label == 75)
            {
                bonus[2, 1] = bonus[2, 1] + 1;
            }
            if (label == 76)
            {
                bonus[3, 1] = bonus[3, 1] + 1;
            }
            if (label == 77)
            {
                bonus[4, 1] = bonus[4, 1] + 1;
            }
            if (label == 78)
            {
                bonus[5, 1] = bonus[5, 1] + 1;
            }
            if (label == 79)
            {
                bonus[6, 1] = bonus[6, 1] + 1;
            }
            if (label == 80)
            {
                bonus[7, 1] = bonus[7, 1] + 1;
            }
            if (label == 161)
            {
                bonus[8, 1] = bonus[8, 1] + 1;
            }
            if (label == 162)
            {
                bonus[9, 1] = bonus[9, 1] + 1;
            }
            if (label == 163)
            {
                bonus[10, 1] = bonus[10, 1] + 1;
            }
            if (label == 164)
            {
                bonus[11, 1] = bonus[11, 1] + 1;
            }
            if (label == 165)
            {
                bonus[12, 1] = bonus[12, 1] + 1;
            }
            if (label == 166)
            {
                bonus[13, 1] = bonus[13, 1] + 1;
            }
            if (label == 167)
            {
                bonus[14, 1] = bonus[14, 1] + 1;
            }
            if (label == 168)
            {
                bonus[15, 1] = bonus[15, 1] + 1;
            }
            if (label == 169)
            {
                bonus[16, 1] = bonus[16, 1] + 1;
            }
            if (label == 170)
            {
                bonus[17, 1] = bonus[17, 1] + 1;
            }
            if (label == 171)
            {
                bonus[18, 1] = bonus[18, 1] + 1;
            }
            if (label == 172)
            {
                bonus[19, 1] = bonus[19, 1] + 1;
            }
            if (label == 173)
            {
                bonus[20, 1] = bonus[20, 1] + 1;
            }
            if (label == 174)
            {
                bonus[21, 1] = bonus[21, 1] + 1;
            }
            if (label == 175)
            {
                bonus[22, 1] = bonus[22, 1] + 1;
            }
            if (label == 176)
            {
                bonus[23, 1] = bonus[23, 1] + 1;
            }
            if (label == 177)
            {
                bonus[24, 1] = bonus[24, 1] + 1;
            }
            if (label == 178)
            {
                bonus[25, 1] = bonus[25, 1] + 1;
            }
            if (label == 179)
            {
                bonus[26, 1] = bonus[26, 1] + 1;
            }
            if (label == 180)
            {
                bonus[27, 1] = bonus[27, 1] + 1;
            }
            if (label == 181)
            {
                bonus[28, 1] = bonus[28, 1] + 1;
            }
            if (label == 182)
            {
                bonus[29, 1] = bonus[29, 1] + 1;
            }
            if (label == 183)
            {
                bonus[30, 1] = bonus[30, 1] + 1;
            }
            if (label == 184)
            {
                bonus[31, 1] = bonus[31, 1] + 1;
            }
            if (label == 185)
            {
                bonus[32, 1] = bonus[32, 1] + 1;
            }
            if (label == 186)
            {
                bonus[33, 1] = bonus[33, 1] + 1;
            }
            if (label == 187)
            {
                bonus[34, 1] = bonus[34, 1] + 1;
            }
            if (label == 188)
            {
                bonus[35, 1] = bonus[35, 1] + 1;
            }
            if (label == 189)
            {
                bonus[36, 1] = bonus[36, 1] + 1;
            }
            if (label == 190)
            {
                bonus[37, 1] = bonus[37, 1] + 1;
            }
            if (label == 191)
            {
                bonus[38, 1] = bonus[38, 1] + 1;
            }
            if (label == 192)
            {
                bonus[39, 1] = bonus[39, 1] + 1;
            }
            if (label == 193)
            {
                bonus[40, 1] = bonus[40, 1] + 1;
            }
            if (label == 194)
            {
                bonus[41, 1] = bonus[41, 1] + 1;
            }
            if (label == 195)
            {
                bonus[42, 1] = bonus[42, 1] + 1;
            }
            if (label == 196)
            {
                bonus[43, 1] = bonus[43, 1] + 1;
            }
            if (label == 197)
            {
                bonus[44, 1] = bonus[44, 1] + 1;
            }
            if (label == 198)
            {
                bonus[45, 1] = bonus[45, 1] + 1;
            }
            if (label == 199)
            {
                bonus[46, 1] = bonus[46, 1] + 1;
            }
            if (label == 200)
            {
                bonus[47, 1] = bonus[47, 1] + 1;
            }
            if (label == 201)
            {
                bonus[48, 1] = bonus[48, 1] + 1;
            }
            if (label == 202)
            {
                bonus[49, 1] = bonus[49, 1] + 1;
            }
            if (label == 203)
            {
                bonus[50, 1] = bonus[50, 1] + 1;
            }
            if (label == 204)
            {
                bonus[51, 1] = bonus[51, 1] + 1;
            }
            if (label == 205)
            {
                bonus[52, 1] = bonus[52, 1] + 1;
            }
            if (label == 206)
            {
                bonus[53, 1] = bonus[53, 1] + 1;
            }
            if (label == 207)
            {
                bonus[54, 1] = bonus[54, 1] + 1;
            }
            if (label == 208)
            {
                bonus[55, 1] = bonus[55, 1] + 1;
            }
            if (label == 209)
            {
                bonus[56, 1] = bonus[56, 1] + 1;
            }
            if (label == 210)
            {
                bonus[57, 1] = bonus[57, 1] + 1;
            }
            if (label == 211)
            {
                bonus[58, 1] = bonus[58, 1] + 1;
            }
            if (label == 212)
            {
                bonus[59, 1] = bonus[59, 1] + 1;
            }
            return Convert.ToString(Convert.ToInt32(x) + 1);
        }

        public string skillRemove(string x, int label)
        {
            if (label == 73)
            {
                bonus[0, 1] = bonus[0, 1]-1;
            }
            if (label == 74)
            {
                bonus[1, 1] = bonus[1, 1]-1;
            }
            if (label == 75)
            {
                bonus[2, 1] = bonus[2, 1]-1;
            }
            if (label == 76)
            {
                bonus[3, 1] = bonus[3, 1]-1;
            }
            if (label == 77)
            {
                bonus[4, 1] = bonus[4, 1]-1;
            }
            if (label == 78)
            {
                bonus[5, 1] = bonus[5, 1]-1;
            }
            if (label == 79)
            {
                bonus[6, 1] = bonus[6, 1]-1;
            }
            if (label == 80)
            {
                bonus[7, 1] = bonus[7, 1]-1;
            }
            if (label == 161)
            {
                bonus[8, 1] = bonus[8, 1]-1;
            }
            if (label == 162)
            {
                bonus[9, 1] = bonus[9, 1]-1;
            }
            if (label == 163)
            {
                bonus[10, 1] = bonus[10, 1]-1;
            }
            if (label == 164)
            {
                bonus[11, 1] = bonus[11, 1]-1;
            }
            if (label == 165)
            {
                bonus[12, 1] = bonus[12, 1]-1;
            }
            if (label == 166)
            {
                bonus[13, 1] = bonus[13, 1]-1;
            }
            if (label == 167)
            {
                bonus[14, 1] = bonus[14, 1]-1;
            }
            if (label == 168)
            {
                bonus[15, 1] = bonus[15, 1]-1;
            }
            if (label == 169)
            {
                bonus[16, 1] = bonus[16, 1]-1;
            }
            if (label == 170)
            {
                bonus[17, 1] = bonus[17, 1]-1;
            }
            if (label == 171)
            {
                bonus[18, 1] = bonus[18, 1]-1;
            }
            if (label == 172)
            {
                bonus[19, 1] = bonus[19, 1]-1;
            }
            if (label == 173)
            {
                bonus[20, 1] = bonus[20, 1]-1;
            }
            if (label == 174)
            {
                bonus[21, 1] = bonus[21, 1]-1;
            }
            if (label == 175)
            {
                bonus[22, 1] = bonus[22, 1]-1;
            }
            if (label == 176)
            {
                bonus[23, 1] = bonus[23, 1]-1;
            }
            if (label == 177)
            {
                bonus[24, 1] = bonus[24, 1]-1;
            }
            if (label == 178)
            {
                bonus[25, 1] = bonus[25, 1]-1;
            }
            if (label == 179)
            {
                bonus[26, 1] = bonus[26, 1]-1;
            }
            if (label == 180)
            {
                bonus[27, 1] = bonus[27, 1]-1;
            }
            if (label == 181)
            {
                bonus[28, 1] = bonus[28, 1]-1;
            }
            if (label == 182)
            {
                bonus[29, 1] = bonus[29, 1]-1;
            }
            if (label == 183)
            {
                bonus[30, 1] = bonus[30, 1]-1;
            }
            if (label == 184)
            {
                bonus[31, 1] = bonus[31, 1]-1;
            }
            if (label == 185)
            {
                bonus[32, 1] = bonus[32, 1]-1;
            }
            if (label == 186)
            {
                bonus[33, 1] = bonus[33, 1]-1;
            }
            if (label == 187)
            {
                bonus[34, 1] = bonus[34, 1]-1;
            }
            if (label == 188)
            {
                bonus[35, 1] = bonus[35, 1]-1;
            }
            if (label == 189)
            {
                bonus[36, 1] = bonus[36, 1]-1;
            }
            if (label == 190)
            {
                bonus[37, 1] = bonus[37, 1]-1;
            }
            if (label == 191)
            {
                bonus[38, 1] = bonus[38, 1]-1;
            }
            if (label == 192)
            {
                bonus[39, 1] = bonus[39, 1]-1;
            }
            if (label == 193)
            {
                bonus[40, 1] = bonus[40, 1]-1;
            }
            if (label == 194)
            {
                bonus[41, 1] = bonus[41, 1]-1;
            }
            if (label == 195)
            {
                bonus[42, 1] = bonus[42, 1]-1;
            }
            if (label == 196)
            {
                bonus[43, 1] = bonus[43, 1]-1;
            }
            if (label == 197)
            {
                bonus[44, 1] = bonus[44, 1]-1;
            }
            if (label == 198)
            {
                bonus[45, 1] = bonus[45, 1]-1;
            }
            if (label == 199)
            {
                bonus[46, 1] = bonus[46, 1]-1;
            }
            if (label == 200)
            {
                bonus[47, 1] = bonus[47, 1]-1;
            }
            if (label == 201)
            {
                bonus[48, 1] = bonus[48, 1]-1;
            }
            if (label == 202)
            {
                bonus[49, 1] = bonus[49, 1]-1;
            }
            if (label == 203)
            {
                bonus[50, 1] = bonus[50, 1]-1;
            }
            if (label == 204)
            {
                bonus[51, 1] = bonus[51, 1]-1;
            }
            if (label == 205)
            {
                bonus[52, 1] = bonus[52, 1]-1;
            }
            if (label == 206)
            {
                bonus[53, 1] = bonus[53, 1]-1;
            }
            if (label == 207)
            {
                bonus[54, 1] = bonus[54, 1]-1;
            }
            if (label == 208)
            {
                bonus[55, 1] = bonus[55, 1]-1;
            }
            if (label == 209)
            {
                bonus[56, 1] = bonus[56, 1]-1;
            }
            if (label == 210)
            {
                bonus[57, 1] = bonus[57, 1]-1;
            }
            if (label == 211)
            {
                bonus[58, 1] = bonus[58, 1]-1;
            }
            if (label == 212)
            {
                bonus[59, 1] = bonus[59, 1] - 1;
            }
            return Convert.ToString(Convert.ToInt32(x) - 1);
        }

        private int skillRank(int label)
        {
            if (label == 73)
            {
                return bonus[0,1];
            }
            if (label == 74)
            {
                return bonus[1, 1];
            }
            if (label == 75)
            {
                return bonus[2, 1];
            }
            if (label == 76)
            {
                return bonus[3, 1];
            }
            if (label == 77)
            {
                return bonus[4, 1];
            }
            if (label == 78)
            {
                return bonus[5, 1];
            }
            if (label == 79)
            {
                return bonus[6, 1];
            }
            if (label == 80)
            {
                return bonus[7, 1];
            }
            if (label == 161)
            {
                return bonus[8, 1];
            }
            if (label == 162)
            {
                return bonus[9, 1];
            }
            if (label == 163)
            {
                return bonus[10, 1];
            }
            if (label == 164)
            {
                return bonus[11, 1];
            }
            if (label == 165)
            {
                return bonus[12, 1];
            }
            if (label == 166)
            {
                return bonus[13, 1];
            }
            if (label == 167)
            {
                return bonus[14, 1];
            }
            if (label == 168)
            {
                return bonus[15, 1];
            }
            if (label == 169)
            {
                return bonus[16, 1];
            }
            if (label == 170)
            {
                return bonus[17, 1];
            }
            if (label == 171)
            {
                return bonus[18, 1];
            }
            if (label == 172)
            {
                return bonus[19, 1];
            }
            if (label == 173)
            {
                return bonus[20, 1];
            }
            if (label == 174)
            {
                return bonus[21, 1];
            }
            if (label == 175)
            {
                return bonus[22, 1];
            }
            if (label == 176)
            {
                return bonus[23, 1];
            }
            if (label == 177)
            {
                return bonus[24, 1];
            }
            if (label == 178)
            {
                return bonus[25, 1];
            }
            if (label == 179)
            {
                return bonus[26, 1];
            }
            if (label == 180)
            {
                return bonus[27, 1];
            }
            if (label == 181)
            {
                return bonus[28, 1];
            }
            if (label == 182)
            {
                return bonus[29, 1];
            }
            if (label == 183)
            {
                return bonus[30, 1];
            }
            if (label == 184)
            {
                return bonus[31, 1];
            }
            if (label == 185)
            {
                return bonus[32, 1];
            }
            if (label == 186)
            {
                return bonus[33, 1];
            }
            if (label == 187)
            {
                return bonus[34, 1];
            }
            if (label == 188)
            {
                return bonus[35, 1];
            }
            if (label == 189)
            {
                return bonus[36, 1];
            }
            if (label == 190)
            {
                return bonus[37, 1];
            }
            if (label == 191)
            {
                return bonus[38, 1];
            }
            if (label == 192)
            {
                return bonus[39, 1];
            }
            if (label == 193)
            {
                return bonus[40, 1];
            }
            if (label == 194)
            {
                return bonus[41, 1];
            }
            if (label == 195)
            {
                return bonus[42, 1];
            }
            if (label == 196)
            {
                return bonus[43, 1];
            }
            if (label == 197)
            {
                return bonus[44, 1];
            }
            if (label == 198)
            {
                return bonus[45, 1];
            }
            if (label == 199)
            {
                return bonus[46, 1];
            }
            if (label == 200)
            {
                return bonus[47, 1];
            }
            if (label == 201)
            {
                return bonus[48, 1];
            }
            if (label == 202)
            {
                return bonus[49, 1];
            }
            if (label == 203)
            {
                return bonus[50, 1];
            }
            if (label == 204)
            {
                return bonus[51, 1];
            }
            if (label == 205)
            {
                return bonus[52, 1];
            }
            if (label == 206)
            {
                return bonus[53, 1];
            }
            if (label == 207)
            {
                return bonus[54, 1];
            }
            if (label == 208)
            {
                return bonus[55, 1];
            }
            if (label == 209)
            {
                return bonus[56, 1];
            }
            if (label == 210)
            {
                return bonus[57, 1];
            }
            if (label == 211)
            {
                return bonus[58, 1];
            }
            if (label == 212)
            {
                return bonus[59, 1];
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
        public bool enough(string pointsBuy, int label)
        {

            int point = skillRank(label);
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
        public void SkillLabelMod(string labelPointsLeft, int labelNumber, Label label)
        {
            if ( enough(labelPointsLeft, labelNumber) == true)
            {
                labelPointsLeft = pointBuy(labelPointsLeft, labelNumber);
                label.Text = skillAdd(label.Text, labelNumber);
            }
        }
        public string pointBuy(string points,int label)
        {
            string tulos = Convert.ToString(Convert.ToInt32(points) - skillRank(label)-1);
            
            return tulos;
        }
        public string pointRefund(string points, int label)
        {
            string tulos = Convert.ToString(Convert.ToInt32(points) + skillRank(label));
            
            return tulos;
        }
    }
}
