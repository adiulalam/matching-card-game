using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class GameWindow : Form
    {
        int remain = 10; //sets the remaining cards to 10
        Random location = new Random();//random location of cards
        List<Point> points = new List<Point>();

        PictureBox PendingImage1; //Storing first card
        PictureBox PendingImage2; //Second card

        Timer t1 = new Timer(); //new timer for animation

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "5"; //game starts from 5
            ScoreCount.Text = "0"; //score count is set to 0


            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = false; //card are disabled until timer is 0
                points.Add(picture.Location);

            }

            foreach (PictureBox picture in CardHolder.Controls)//randomizes the location of the cards
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer1.Start();//timer starts
            timer2.Start();

            card1.Image = Properties.Resources.card1; //image box is set to an image
            name1.Image = Properties.Resources.name1; //name box is set to an image
            name1.Visible = true; //image is visible at the start
            card1.Visible = true; //image is visible at the start

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //5 seconds are up
            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = true; //images are enabled to click
                picture.Cursor = Cursors.Hand; //shows hand cursor
                picture.Image = Properties.Resources.cover; //set to the cover of the card
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text); //the countdown label is converted to int
            timer = timer - 1;//the countdown starts from 5
            label1.Text = Convert.ToString(timer);//the label is converted to string again
            if (timer == 0)//timer reaches 0
            {
                timer2.Stop();//timer stops 
            }

        }

        #region mathching cards process
        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.card1;//image on the card
            if (PendingImage1 == null)//first card is NOT selected
            {
                PendingImage1 = card1;//pending image is stored as card image
            }

            else if (PendingImage1 != null && PendingImage2 == null)//first is selected BUT second card is NOT selected
            {
                PendingImage2 = card1;//pending image is stored as card image
            }

            if (PendingImage1 != null && PendingImage2 != null)//when both images are selected
            {

                if (PendingImage1.Tag == PendingImage2.Tag)//and their tags match one another
                {
                    timer4.Start(); //timer 4 starts
                }
                else
                {
                    timer3.Start();//timer 3 starts
                }

            }
        }

        private void name1_Click(object sender, EventArgs e)
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

        private void card2_Click(object sender, EventArgs e)
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

        private void name2_Click(object sender, EventArgs e)
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

        private void card3_Click(object sender, EventArgs e)
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

        private void name3_Click(object sender, EventArgs e)
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

        private void card4_Click(object sender, EventArgs e)
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

        private void name4_Click(object sender, EventArgs e)
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

        private void card5_Click(object sender, EventArgs e)
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

        private void name5_Click(object sender, EventArgs e)
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

        private void card6_Click(object sender, EventArgs e)
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

        private void name6_Click(object sender, EventArgs e)
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

        private void card7_Click(object sender, EventArgs e)
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

        private void name7_Click(object sender, EventArgs e)
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

        private void card8_Click(object sender, EventArgs e)
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

        private void name8_Click(object sender, EventArgs e)
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

        private void card9_Click(object sender, EventArgs e)
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

        private void name9_Click(object sender, EventArgs e)
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

        private void card10_Click(object sender, EventArgs e)
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

        private void name10_Click(object sender, EventArgs e)
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

        void fadeIn(object sender, EventArgs e)//fade in animation
        {
            if (Opacity >= 1)//opacity is normal
                t1.Stop();//stops the timer if the screen is completely displayed
            else
                Opacity += 0.05;//opacity increases by 0.05
        }

        private void timer3_Tick(object sender, EventArgs e)//when user fails to match the card
        {

            timer3.Stop();
            PendingImage1.Image = Properties.Resources.cover;//card goes back it's cover
            PendingImage2.Image = Properties.Resources.cover;
            ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) - 1);//score is neglected by -1
            PendingImage1 = null;//pending image goes back to unselected
            PendingImage2 = null;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            timer4.Stop();

            ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);//score increases by 10
            PendingImage1.Visible = false;//removes the card
            PendingImage2.Visible = false;
            PendingImage1 = null;//pending image goes back to unselected
            PendingImage2 = null;

            Opacity = 0;//first the opacity is 0
            t1.Interval = 20;//increase the opacity every 20ms
            t1.Tick += new EventHandler(fadeIn);//calls the function that changes opacity 
            t1.Start();//timer starts again

            remain = remain - 1;//number of cards neglected by -1
            if (remain == 0)//when the reamaining card is 0
            {
                MessageBox.Show("Congratulations. You have fnished the game.", "End of the game");//end of game message will apear
            }
        }



        private void button1_Click(object sender, EventArgs e)//restart button
        {
            GameWindow_Load(sender, e); //goes back to game window     
        }

        private void button2_Click(object sender, EventArgs e)//when clicked on start button on start menu
        {
            button2.Visible = false;//the button dissapears
            panel1.Visible = false;//the background dissapears
        }

        void fadeOut(object sender, EventArgs e)//fade out animation
        {
            if (Opacity <= 0)//check if opacity is 0
            {
                t1.Stop();//stops the timer
                Close();//closes the form
            }
            else
                Opacity -= 0.05;//if not then decreases the opacity by 0.05

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Interval = 200;//increase the opacity every 200ms
            t1.Tick += new EventHandler(fadeOut);//calls the fade out function
            t1.Start();//timer starts again
        }
    }
}
