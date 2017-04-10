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
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Cyan;
            radioButton3.ForeColor = Color.Orange;
            radioButton4.ForeColor = Color.Yellow;
            radioButton5.ForeColor = Color.Lime;
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
    }
}
