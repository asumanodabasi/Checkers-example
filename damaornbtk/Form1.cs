using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damaornbtk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top=0, left=0;

            Button[,] bottons = new Button[8, 8];
            for (int i = 0; i < bottons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < bottons.GetUpperBound(1); j++)
                {
                    bottons[i, j] = new Button();
                    bottons[i, j].Top = top;
                    bottons[i, j].Left = left;
                    bottons[i, j].Height = 50;
                    bottons[i, j].Width = 50;
                    left += 50;
                    if((i+j)%2==0)
                    {
                        bottons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        bottons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(bottons[i, j]);
                }
                top += 50;
                left = 0;

            }
        }
    }
}
