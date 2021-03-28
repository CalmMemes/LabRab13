using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxC.SelectedIndex = 0;
            comboBoxH.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Z = 0;
            double X = Convert.ToDouble(textBoxX.Text);
            double Y = Convert.ToDouble(textBoxY.Text);
            int N = Convert.ToInt32(textBoxN.Text);
            int R = Convert.ToInt32(textBoxR.Text);
            double h = Convert.ToDouble(comboBoxH.SelectedItem.ToString());
            double c = Convert.ToDouble(comboBoxC.SelectedItem.ToString());

            if (radioButton1.Checked)
            {
                Z = -1; double item = 0;
                int K = 2;
                for (int i = 1; i < N; i++)
                {
                    item = (i % 2 == 0) ? X : Y;
                    Z += (Math.Pow(-1, i % 2) * Math.Pow(item, i)) / K;
                    K++;
                }
            }
            else
            {
                Z = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < R; j++)
                    {
                        Z += (Math.Pow(j, 2) + h * i) / (Math.Pow(i,j) + c * j);
                    }
                }
            }
            textBoxZ.Text = Z.ToString();
        }
    }
}
