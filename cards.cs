using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    public class cards:cardwindow
    {
        #region Cards///////
        public void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = card1;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card1;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {

                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name1_Click(object sender, EventArgs e)
        {
            name1.Image = Properties.Resources.name1;
            if (PendingImage1 == null)
            {
                PendingImage1 = name1;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name1;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }

        }

        public void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = card2;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card2;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void name2_Click(object sender, EventArgs e)
        {
            name2.Image = Properties.Resources.name2;
            if (PendingImage1 == null)
            {
                PendingImage1 = name2;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name2;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = card3;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card3;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name3_Click(object sender, EventArgs e)
        {
            name3.Image = Properties.Resources.name3;
            if (PendingImage1 == null)
            {
                PendingImage1 = name3;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name3;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = card4;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card4;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name4_Click(object sender, EventArgs e)
        {
            name4.Image = Properties.Resources.name4;
            if (PendingImage1 == null)
            {
                PendingImage1 = name4;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name4;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = card5;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card5;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name5_Click(object sender, EventArgs e)
        {
            name5.Image = Properties.Resources.name5;
            if (PendingImage1 == null)
            {
                PendingImage1 = name5;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name5;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = card6;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card6;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name6_Click(object sender, EventArgs e)
        {
            name6.Image = Properties.Resources.name6;
            if (PendingImage1 == null)
            {
                PendingImage1 = name6;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name6;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = card7;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card7;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name7_Click(object sender, EventArgs e)
        {
            name7.Image = Properties.Resources.name7;
            if (PendingImage1 == null)
            {
                PendingImage1 = name7;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name7;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = card8;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card8;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name8_Click(object sender, EventArgs e)
        {
            name8.Image = Properties.Resources.name8;
            if (PendingImage1 == null)
            {
                PendingImage1 = name8;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name8;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card9_Click(object sender, EventArgs e)
        {
            card9.Image = Properties.Resources.card9;
            if (PendingImage1 == null)
            {
                PendingImage1 = card9;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card9;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name9_Click(object sender, EventArgs e)
        {
            name9.Image = Properties.Resources.name9;
            if (PendingImage1 == null)
            {
                PendingImage1 = name9;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name9;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        public void card10_Click(object sender, EventArgs e)
        {
            card10.Image = Properties.Resources.card10;
            if (PendingImage1 == null)
            {
                PendingImage1 = card10;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card10;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        public void name10_Click(object sender, EventArgs e)
        {
            name10.Image = Properties.Resources.name10;
            if (PendingImage1 == null)
            {
                PendingImage1 = name10;
            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = name10;
            }

            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    timer4.Start();
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        #endregion///////

    }
}
