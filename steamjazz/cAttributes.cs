using System;
using System.Windows.Forms;

namespace Steamjazz
{
    internal class cAttributes
    {
        public cAttributes()
        {
        }

        public void AttributeChange(int change, int points, Label attributeValue, Label attributePointBuy)
        {
            attributePointBuy.Text = Convert.ToString(pointCalc(Convert.ToInt32(attributeValue.Text), points, change));
            attributeValue.Text = Convert.ToString(Convert.ToInt32(attributeValue.Text) + change);
        }

        /// <summary>
        /// Vastaa attribuutin lisäämisen tai vähentämisen vaikutuksesta attribuuttipisteiden määrään.
        /// </summary>
        /// <param name="x"></param>
        /// attribuutin nykyinen arvo
        /// <param name="points"></param>
        /// vapaiden attribuuttipisteiden määrä
        /// <param name="change"></param>
        /// muutoksen määrä
        /// <returns></returns>
        private static int pointCalc(int x, int points, int change)
        {
            int[] hinta = new int[] { 0, 1, 4, 9, 16, 25, 36, 49, 64 };

            if (x < 10)
            {
                points = points - change * 5;
            }
            if (x == 10 && change < 0)
            {
                points = points - change * 5;
            }
            if (x == 10 && change > 0)
            {
                while (change > 0)
                {
                    points = points - hinta[change];
                    change--;
                }
            }
            if (x > 10)
            {
                if (change > 0)
                {
                    int diff = 0;
                    diff = x - 10;

                    points = points - hinta[diff + change];
                }
                if (change < 0)
                {
                    int diff = 0;
                    diff = x - 10;
                    points = points + hinta[diff];
                }
            }
            return points;
        }
    }
}