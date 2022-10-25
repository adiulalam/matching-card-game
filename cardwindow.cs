using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    public class cardwindow
    {
        public void GameWindow_Load(object sender, EventArgs e)
        {


            label1.Text = "5";
            
            ScoreCount.Text = "0";

            

            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);

            }

            foreach (PictureBox picture in CardHolder.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer1.Start();
            timer2.Start();

            card1.Image = Properties.Resources.card1;
            name1.Image = Properties.Resources.name1;
            name1.Visible = true;
            card1.Visible = true;

            card2.Image = Properties.Resources.card2;
            name2.Image = Properties.Resources.name2;
            name2.Visible = true;
            card2.Visible = true;

            card3.Image = Properties.Resources.card3;
            name3.Image = Properties.Resources.name3;
            name3.Visible = true;
            card3.Visible = true;

            card4.Image = Properties.Resources.card4;
            name4.Image = Properties.Resources.name4;
            name4.Visible = true;
            card4.Visible = true;

            card5.Image = Properties.Resources.card5;
            name5.Image = Properties.Resources.name5;
            name5.Visible = true;
            card5.Visible = true;

            card6.Image = Properties.Resources.card6;
            name6.Image = Properties.Resources.name6;
            name6.Visible = true;
            card6.Visible = true;

            card7.Image = Properties.Resources.card7;
            name7.Image = Properties.Resources.name7;
            name7.Visible = true;
            card7.Visible = true;

            card8.Image = Properties.Resources.card8;
            name8.Image = Properties.Resources.name8;
            name8.Visible = true;
            card8.Visible = true;

            card9.Image = Properties.Resources.card9;
            name9.Image = Properties.Resources.name9;
            name9.Visible = true;
            card9.Visible = true;

            card10.Image = Properties.Resources.card10;
            name10.Image = Properties.Resources.name10;
            name10.Visible = true;
            card10.Visible = true;

        }

    }
}
