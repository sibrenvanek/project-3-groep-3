using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button1
{
    public partial class Form1 : Form
    {
        public float Budget_Amount ; // is insert amount
        float woz; // change with database 
        List<MethodAccessException> List_buttons = new List<MethodAccessException>();



        public Form1()
        {
            InitializeComponent();

            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Label_budget_amount.Text = textBox_budget_amount.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button3.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button3.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button3.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button3.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button3.BackColor = Color.Red; }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120){button2.BackColor = Color.Green;}
            else if (A > 60 & A <= 80 || A > 120 & A <= 140){button2.BackColor = Color.YellowGreen;}
            else if (A > 40 & A <= 60 || A > 160 & A <= 180){button2.BackColor = Color.Yellow;}
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) {button2.BackColor = Color.Orange;}
            else if (A < 20 || A > 200)  {button2.BackColor = Color.Red;}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button1.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button1.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button1.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button1.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button1.BackColor = Color.Red; }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button4.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button4.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button4.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button4.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button4.BackColor = Color.Red; }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button5.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button5.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button5.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button5.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button2.BackColor = Color.Red; }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button6.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button6.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button6.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button6.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button6.BackColor = Color.Red; }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            float A = ((woz / Budget_Amount) * 100); // is relative value in % 

            if (A > 80 & A <= 120) { button7.BackColor = Color.Green; }
            else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button7.BackColor = Color.YellowGreen; }
            else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button7.BackColor = Color.Yellow; }
            else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button7.BackColor = Color.Orange; }
            else if (A < 20 || A > 200) { button7.BackColor = Color.Red; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);
        }
    }
}
