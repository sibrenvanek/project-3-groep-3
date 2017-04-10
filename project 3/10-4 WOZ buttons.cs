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
        public float Budget_Amount; // is insert amount
        private float woz, woz2; // change with database 
        private int id;
        

        



        public Form1()
        {
            InitializeComponent();

            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Label_budget_amount.Text = textBox_budget_amount.Text;
            //woz = 100;  // input from database
            Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);

            change_color();
        }
        


        private void button3_Click(object sender, EventArgs e)
        {
            woz = 200; // input from database
            change_color();
        }
        public void change_color()
        {
            List<Button> List_buttons = new List<Button>();
            List_buttons.Add(button1);
            List_buttons.Add(button2);
            List_buttons.Add(button3);
            List_buttons.Add(button4);
            List_buttons.Add(button5);
            List_buttons.Add(button6);
            List_buttons.Add(button7);


            foreach (Button button in List_buttons)


            {
                // woz = button.woz

                float A = ((woz / Budget_Amount) * 100); // is relative value in % 

                if (A > 80 & A <= 120) { button.BackColor = Color.Green; }
                else if (A > 60 & A <= 80 || A > 120 & A <= 140) { button.BackColor = Color.YellowGreen; }
                else if (A > 40 & A <= 60 || A > 160 & A <= 180) { button.BackColor = Color.Yellow; }
                else if (A > 20 & A <= 40 || A > 180 & A <= 200) { button.BackColor = Color.Orange; }
                else if (A < 20 || A > 200) { button.BackColor = Color.Red; }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            woz2 = 300; // input from database *edit: remove this* 
            change_color();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            woz = 100;  // input from database
            change_color();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Budget_Amount = Convert.ToInt32(Label_budget_amount.Text);
        }
    }
    class space1
    {
        public space1()
        {
            float WOZ = 100;
        }
    }

}
