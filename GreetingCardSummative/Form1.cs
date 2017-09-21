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
        
        int flag = 0;

        public GreetingCardSummative()
        {
            InitializeComponent();
        }

        private void GreetingCardSummative_Click(object sender, EventArgs e)
        {
            //Establishes the ability to create graphics, the pen, the brush, 4 fonts, and 2 soundplayers
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Ubuntu", 16, FontStyle.Bold);
            Font bigFont = new Font("Copperplate Gothic Bold", 60, FontStyle.Bold);
            Font smallFont = new Font("Ubuntu", 8, FontStyle.Regular);
            Font medFont = new Font("Ubuntu", 24, FontStyle.Underline);
            SoundPlayer loadSound = new SoundPlayer(Properties.Resources.Startup_Noise);
            //add another sound effect
    
            if (flag == 1)
            {
                formGraphics.Clear(Color.Black);
                //draw ellipses and lines for virgo constalation and write text that scrolls in from the bottom
                
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
