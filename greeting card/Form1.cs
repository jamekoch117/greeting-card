using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)

            //James Koch September 24 2019, Program is about a greeting card but also a "Virus

        {//the commands 
            Graphics g = this.CreateGraphics();
            Pen tilepen = new Pen(Color.Black);
            Font titlefont = new Font("Courier New", 18);
            SolidBrush titlebrush = new SolidBrush(Color.AntiqueWhite);
            Pen drawPen = new Pen(Color.AntiqueWhite, 25);
            g.Clear(Color.Black);
            g.DrawString("click on this ", titlefont, titlebrush, 235, 135);
            Font titlefont1 = new Font("Commic sans", 18);
            g.DrawString("for free v bucks ", titlefont1, titlebrush, 300, 165);
            Font titlefont2 = new Font("Times New Roman", 18);
            g.DrawString("Not a scam", titlefont2, titlebrush, 395, 195);

            g.DrawRectangle(drawPen, 210, 100, 350, 150);
            //the rectangles
            Pen drawPen1 = new Pen(Color.DarkOliveGreen, 25);
            g.DrawRectangle(drawPen1, 135, 46, 495, 255);
            Pen drawPen2 = new Pen(Color.LightGoldenrodYellow, 25);
            g.DrawRectangle(drawPen2, 110, 26, 540, 300);
            Pen drawPen3 = new Pen(Color.MidnightBlue, 25);
            g.DrawRectangle(drawPen3, 160, 73, 445, 203);
            Pen drawPen4 = new Pen(Color.IndianRed, 25);
            g.DrawRectangle(drawPen4, 185, 97, 397, 155);

        }
        private void Form1_Click(object sender, EventArgs e)
        {//the commands 
            Graphics g = this.CreateGraphics();
            Pen tilepen = new Pen(Color.Black);
            Font titlefont = new Font("Courier New", 18);
            Font smallfont = new Font("Courier New", 8);
            //you have been scammed writing
            SoundPlayer mac = new SoundPlayer(Properties.Resources.mac);
            mac.Play();
            SolidBrush titlebrush = new SolidBrush(Color.AntiqueWhite);
            Pen drawPen = new Pen(Color.AntiqueWhite, 25);
            g.Clear(Color.Black);
            SolidBrush titlebrush1 = new SolidBrush(Color.AntiqueWhite);
            g.DrawString("You", titlefont, titlebrush1, 235, 135);
            Thread.Sleep(500);
            SolidBrush titlebrush2 = new SolidBrush(Color.Aquamarine);
            g.DrawString("have", titlefont, titlebrush2, 250, 150);
            Thread.Sleep(500);
            g.DrawString("been", titlefont, titlebrush, 265, 165);
            SolidBrush titlebrush3 = new SolidBrush(Color.IndianRed);
            Thread.Sleep(500);
            g.DrawString("fooled", titlefont, titlebrush3, 280, 180);
            Thread.Sleep(500);
           //clearing screen and putting flashing colours 
            g.Clear(Color.White);
            Thread.Sleep(100);
            g.Clear(Color.Magenta);
            Thread.Sleep(100);
            g.Clear(Color.Yellow);
            Thread.Sleep(100);
            g.Clear(Color.AliceBlue);
            Thread.Sleep(100);
            g.Clear(Color.White);
            Thread.Sleep(100);
            g.Clear(Color.Magenta);
            Thread.Sleep(100);
            g.Clear(Color.Yellow);
            Thread.Sleep(100);
            g.Clear(Color.AliceBlue);
            Thread.Sleep(100);
            g.Clear(Color.White);
            Thread.Sleep(100);
            g.Clear(Color.Black);
            //the road
            g.DrawRectangle(drawPen, 0, 180, 900, 200);
            g.FillRectangle(titlebrush, 0, 180, 900, 200);
            //linedivider 
            Pen drawPen2 = new Pen(Color.Black, 15);
            g.DrawLine(drawPen2, 10, 270, 120, 270);
            g.DrawLine(drawPen2, 230, 270, 340, 270);
            g.DrawLine(drawPen2, 450, 270, 560, 270);
            g.DrawLine(drawPen2, 670, 270, 780, 270);
            //sun
            Pen drawPen3 = new Pen(Color.Yellow, 15);
            SolidBrush titleBrush1 = new SolidBrush(Color.LightYellow);
            g.FillEllipse(titleBrush1, 10, 10, 80, 90);
            //lines falling
            SolidBrush titlebrush4 = new SolidBrush(Color.Black);
            g.DrawString("Get hacked", titlefont, titlebrush4, 150, 0);
            Thread.Sleep(100);
            SolidBrush titlebrush5 = new SolidBrush(Color.White);
            SoundPlayer fall = new SoundPlayer(Properties.Resources.fall);
            fall.Play();
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 0);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 15);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 30);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 45);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 60);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 75);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 90);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 105);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 120);
            Thread.Sleep(10);
            g.DrawString("Get hacked", titlefont, titlebrush5, 150, 120);
            SolidBrush titlebrush6 = new SolidBrush(Color.White);
            Font titlefont1 = new Font("Courier New", 30);
            g.DrawString("By James Koch", titlefont1, titlebrush6, 330,130);
        }



    }
}
