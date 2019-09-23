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
        {
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

            Pen drawPen1 = new Pen(Color.DarkOliveGreen, 25);
            g.DrawRectangle(drawPen1, 135, 46, 495, 255);

            Pen drawPen2 = new Pen(Color.LightGoldenrodYellow, 25);
            g.DrawRectangle(drawPen2, 96, 26, 540, 300);

            Pen drawPen3 = new Pen(Color.MidnightBlue, 25);
            g.DrawRectangle(drawPen3, 160, 73, 445, 203);


            Pen drawPen4 = new Pen(Color.IndianRed, 25);
            g.DrawRectangle(drawPen4, 185, 97, 397, 155);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen tilepen = new Pen(Color.Black);
            Font titlefont = new Font("Courier New", 18);
            Font smallfont = new Font("Courier New", 8);

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
            g.Clear(Color.Black);


            g.DrawRectangle(drawPen, 10, 20, 15, 10);


















        }



    }
}
