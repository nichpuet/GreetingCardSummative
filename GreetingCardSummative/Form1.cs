using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GreetingCardSummative
{
    public partial class GreetingCardSummative : Form
    {
        //sets flag to tell if you should go to the title page or the info page
        int flag = 0;
  
        public GreetingCardSummative()
        {
            InitializeComponent();
        }

        private void GreetingCardSummative_Click(object sender, EventArgs e)
        {
            //Establishes the ability to create graphics, the pen, the brush, 4 fonts, and 2 soundplayers
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.Snow);
            Pen starPen = new Pen(Color.Snow,1);
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Ubuntu", 16, FontStyle.Bold);
            Font bigFont = new Font("Copperplate Gothic Bold", 60, FontStyle.Bold);
            Font smallFont = new Font("Ubuntu", 8, FontStyle.Regular);
            Font medFont = new Font("Ubuntu", 24, FontStyle.Underline);
            SoundPlayer loadSound = new SoundPlayer(Properties.Resources.Startup_Noise);
            SoundPlayer starSound = new SoundPlayer(Properties.Resources.up);
            //add another sound effect
    
            if (flag == 1)
            {
                int flagStar = 0;

                formGraphics.Clear(Color.Black);
                //draw ellipses and lines for virgo constalation and write text that scrolls in from the bottom
                for(int x = 1; x <= 5; x++)
                {
                   //draws the lines between the circles
                    formGraphics.DrawLine(starPen, 339, 54, 308, 99);
                    formGraphics.DrawLine(starPen, 278, 127, 308, 99);
                    formGraphics.DrawLine(starPen, 241, 115, 278, 127);
                    formGraphics.DrawLine(starPen, 203, 80, 241, 115);
                    formGraphics.DrawLine(starPen, 278, 127, 248, 181);
                    formGraphics.DrawLine(starPen, 241, 115, 195, 173);
                    formGraphics.DrawLine(starPen, 196, 173, 241, 225);
                    formGraphics.DrawLine(starPen, 241, 225, 248, 181);
                    formGraphics.DrawLine(starPen, 241, 225, 141, 238);
                    formGraphics.DrawLine(starPen, 141, 238, 92, 255);
                    formGraphics.DrawLine(starPen, 194, 172, 141, 182);
                    formGraphics.DrawLine(starPen, 65, 210, 141, 182);
                    //draws all the circles
                    formGraphics.FillEllipse(starBrush, 60, 205, 10, 10);
                    formGraphics.FillEllipse(starBrush, 334, 49, 10, 10);
                    formGraphics.FillEllipse(starBrush, 303, 94, 10, 10);
                    formGraphics.FillEllipse(starBrush, 273, 122, 10, 10);
                    formGraphics.FillEllipse(starBrush, 236, 110, 10, 10);
                    formGraphics.FillEllipse(starBrush, 198, 75, 10, 10);
                    formGraphics.FillEllipse(starBrush, 243, 176, 10, 10);
                    formGraphics.FillEllipse(starBrush, 190, 168, 10, 10);
                    formGraphics.FillEllipse(starBrush, 236, 220, 15, 15);
                    formGraphics.FillEllipse(starBrush, 136, 233, 10, 10);
                    formGraphics.FillEllipse(starBrush, 87, 250, 10, 10);
                    formGraphics.FillEllipse(starBrush, 136, 177, 10, 10);

                    //tells the program to wait 1 second then redraw the stars in either green,red, medium aquamarine, or snow depending on which loop its on.
                    //also plays a quick sound each time the colour changes.
                    Thread.Sleep(1000);
                    starSound.Play();
                    if (flagStar == 0)
                    {
                        starBrush.Color = Color.Green;
                        starPen.Color = Color.Yellow;
                    }
                    if (flagStar == 1)
                    {
                        starBrush.Color = Color.Red;
                        starPen.Color = Color.Snow;
                    }
                    if (flagStar == 2)
                    {
                        starBrush.Color = Color.MediumAquamarine;
                        starPen.Color = Color.Yellow;
                    }
                    if (flagStar == 3)
                    {
                        starBrush.Color = Color.Snow;
                        starPen.Color = Color.Snow;
                    }
                    flagStar += 1;
                }

                //draws the info paragraph and has a delay to writing the lines
                formGraphics.DrawString("Virgo Constellation", drawFont, starBrush, 15, 270);
                Thread.Sleep(500);
                formGraphics.DrawString("Virgo is one of the zodiac representing the virgin. In horoscopes it is used", smallFont, starBrush, 20, 300);
                Thread.Sleep(500);
                formGraphics.DrawString("to represent people born between August 22nd and September 22nd. It is  ", smallFont, starBrush, 15, 320);
                Thread.Sleep(500);
                formGraphics.DrawString("also the second largest constellation in the sky.", smallFont, starBrush, 15, 340);

                //tells the program to go back to the title page next time the window is clicked
                flag -= 1;
            }

            else
            {   //Plays the windows XP startup noise
                loadSound.Play();

                // Clears the "Canvas" and sets the background to Dark Green
                formGraphics.Clear(Color.DarkGreen);

                // Draws the red circle behind the text
                formGraphics.DrawEllipse(drawPen, 50, 90, 200, 100);
                formGraphics.FillEllipse(drawBrush, 50, 90, 200, 100);

                // Sets the brush color to Snow and draws the "c" and rams
                drawBrush.Color = Color.Snow;
                formGraphics.DrawString("Rams", drawFont, drawBrush, 125, 125);
                formGraphics.DrawString("C", bigFont, drawBrush, 90, 95);

                //Draws the rotated text to the right of the red ellipse
                formGraphics.TranslateTransform(270, 200);
                formGraphics.RotateTransform(270);
                formGraphics.DrawString("Central Rams Arcade", smallFont, drawBrush, new Rectangle());
                formGraphics.ResetTransform();

                // Writes name and text on the screen
                formGraphics.DrawString("Virgo Greeting Card", medFont, drawBrush, 15, 15);
                formGraphics.DrawString("By Nick Puetz | 20/09/17", smallFont, drawBrush, 15, 325);

                flag += 1;
            }
           
        }
    }
}
