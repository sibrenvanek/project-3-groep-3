using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.ForeColor = label1.BackColor;
            radioButton2.ForeColor = label2.BackColor;
            radioButton3.ForeColor = label3.BackColor;
            radioButton4.ForeColor = label4.BackColor;
            radioButton5.ForeColor = label5.BackColor;
            button1.BackColor = radioButton1.ForeColor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = radioButton1.ForeColor;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = radioButton2.ForeColor;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = radioButton3.ForeColor;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = radioButton4.ForeColor;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = radioButton5.ForeColor;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            if (radioButton1.Checked)
            {
                label6.Text = radioButton1.Text;
                label6.BackColor = radioButton1.ForeColor;
            }
            else if (radioButton2.Checked)
            {
                label6.Text = radioButton2.Text;
                label6.BackColor = radioButton2.ForeColor;
            }
            else if (radioButton3.Checked)
            {
                label6.Text = radioButton3.Text;
                label6.BackColor = radioButton3.ForeColor;
            }
            else if (radioButton4.Checked)
            {
                label6.Text = radioButton4.Text;
                label6.BackColor = radioButton4.ForeColor;
            }
            else if (radioButton5.Checked)
            {
                label6.Text = radioButton5.Text;
                label6.BackColor = radioButton5.ForeColor;
            }
            label6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            label6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
