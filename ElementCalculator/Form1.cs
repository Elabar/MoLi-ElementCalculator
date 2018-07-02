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

            Button[] singleArray = new Button[9];

            for (int i = 0; i < 9; i++)
            {
                singleArray[i] = new Button();
                singleArray[i].Size = new Size(60, 23);
                singleArray[i].Location = new Point(horizotal, vertical);
                singleArray[i].Text = "Level " + (i + 1);
                horizotal += 70;
                this.Controls.Add(singleArray[i]);
            }

            vertical += 30;
            horizotal = 13;

            Button[] threeTargetArray = new Button[9];

            for (int i = 0; i < 9; i++)
            {
                threeTargetArray[i] = new Button();
                threeTargetArray[i].Size = new Size(60, 23);
                threeTargetArray[i].Location = new Point(horizotal, vertical);
                threeTargetArray[i].Text = "Level " + (i + 1);
                horizotal += 70;
                this.Controls.Add(threeTargetArray[i]);
            }

            vertical += 30;
            horizotal = 13;

            Button[] AllTargetArray = new Button[9];

            for (int i = 0; i < 9; i++)
            {
                AllTargetArray[i] = new Button();
                AllTargetArray[i].Size = new Size(60, 23);
                AllTargetArray[i].Location = new Point(horizotal, vertical);
                AllTargetArray[i].Text = "Level " + (i + 1);
                horizotal += 70;
                this.Controls.Add(AllTargetArray[i]);
            }
        }
    }
}
