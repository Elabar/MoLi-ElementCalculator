using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPTextBox.Enabled = false;

            int horizotal = 13;
            int vertical = 40;

            Button[] singleArray = new Button[10];
            
            int[] singleMP = { 60,92,110,140,170,200,230,260,290,320};
            for (int i = 0; i < 10; i++)
            {
                singleArray[i] = new Button();
                singleArray[i].Size = new Size(60, 23);
                singleArray[i].Location = new Point(horizotal, vertical);
                singleArray[i].Text = "Level " + (i + 1);
                if ((Convert.ToInt32(MPTextBox.Text) - singleMP[i]) % 3 == 2)
                    singleArray[i].BackColor = Color.Green;
                else
                    singleArray[i].BackColor = Color.Red;
                horizotal += 70;
                this.Controls.Add(singleArray[i]);
            }

            vertical += 30;
            horizotal = 13;

            Button[] threeTargetArray = new Button[10];

            int[] ThreeMP = { 60, 92, 110, 140, 170, 200, 230, 260, 290, 320 };
            for (int i = 0; i < 10; i++)
            {
                threeTargetArray[i] = new Button();
                threeTargetArray[i].Size = new Size(60, 23);
                threeTargetArray[i].Location = new Point(horizotal, vertical);
                threeTargetArray[i].Text = "Level " + (i + 1);
                if ((Convert.ToInt32(MPTextBox.Text) - ThreeMP[i]) % 3 == 1)
                    threeTargetArray[i].BackColor = Color.Green;
                else
                    threeTargetArray[i].BackColor = Color.Red;
                horizotal += 70;
                this.Controls.Add(threeTargetArray[i]);
            }

            vertical += 30;
            horizotal = 13;

            Button[] AllTargetArray = new Button[10];

            int[] AllMP = { 60, 92, 160, 140, 170, 200, 230, 260, 290, 320 };
            for (int i = 0; i < 10; i++)
            {
                AllTargetArray[i] = new Button();
                AllTargetArray[i].Size = new Size(60, 23);
                AllTargetArray[i].Location = new Point(horizotal, vertical);
                AllTargetArray[i].Text = "Level " + (i + 1);
                if ((Convert.ToInt32(MPTextBox.Text) - AllMP[i]) % 3 == 1)
                    AllTargetArray[i].BackColor = Color.Green;
                else
                    AllTargetArray[i].BackColor = Color.Red;
                horizotal += 70;
                this.Controls.Add(AllTargetArray[i]);
            }
        }
    }
}
