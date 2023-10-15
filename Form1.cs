using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Reflex_Agent
{
    public partial class Form1 : Form
    {
        private Random randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            textLabels();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int quadrant = new Random().Next(4);
        private int prevQuadrant = 0;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White);

            int picBoxWidth = pictureBox1.Width;
            int picBoxHeight = pictureBox1.Height;
            int x = (picBoxWidth / 4) / 4;
            int y = (picBoxHeight / 4) / 4;

            int xSize = picBoxWidth - (picBoxWidth / 4);
            int ySize = picBoxHeight - (picBoxHeight / 4);

            int xCenter = x + xSize / 2;
            int yCenter = y + ySize / 2;

            g.DrawRectangle(pen, x, y, xSize, ySize);

            g.DrawLine(pen, xCenter, y, xCenter, y + ySize);

            g.DrawLine(pen, x, yCenter, x + xSize, yCenter);

            Rectangle border = new Rectangle(x, y, xSize/2, ySize/2);
            int newQuadrant = randomizer.Next(2);
            switch (quadrant)
            {
                case 0:
                    border.X = xCenter;
                    prevQuadrant = quadrant;
                    quadrant = (newQuadrant == 0) ? 1 : 3;  // randomizer transfer of the vacuum robot (UP, DOWN, LEFT, RIGHT)
                    break;

                case 1:
                    prevQuadrant = quadrant;
                    quadrant = (newQuadrant == 0) ? 0 : 2; // randomizer transfer of the vacuum robot (UP, DOWN, LEFT, RIGHT)
                    break;

                case 2:
                    prevQuadrant = quadrant;
                    border.Y = yCenter;
                    quadrant = (newQuadrant == 0) ? 1 : 3; // randomizer transfer of the vacuum robot (UP, DOWN, LEFT, RIGHT)
                    break;

                case 3:
                    prevQuadrant = quadrant;
                    border.X = xCenter;
                    border.Y = yCenter;
                    quadrant = (newQuadrant == 0) ? 0 : 2; // randomizer transfer of the vacuum robot (UP, DOWN, LEFT, RIGHT)
                    break;
            }
            g.DrawEllipse(pen, border);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            check(prevQuadrant);
        }

        private void textLabels()
        {
            quadrant1.Text = (randomizer.Next(2) == 1) ? "CLEAN" : "DIRTY";
            quadrant2.Text = (randomizer.Next(2) == 1) ? "CLEAN" : "DIRTY";
            quadrant3.Text = (randomizer.Next(2) == 1) ? "CLEAN" : "DIRTY";
            quadrant4.Text = (randomizer.Next(2) == 1) ? "CLEAN" : "DIRTY";
        }

        private void check(int quadrant)
        {
            switch (quadrant)
            {
                case 0:
                    quadrant1.Text = "CHECKING";
                    break;
                case 1:
                    quadrant2.Text = "CHECKING";
                    break;
                case 2:
                    quadrant3.Text = "CHECKING";
                    break;
                case 3:
                    quadrant4.Text = "CHECKING";
                    break;
            }
        }
    }
}
