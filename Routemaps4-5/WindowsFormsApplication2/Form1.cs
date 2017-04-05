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
        string url_standard = "https://www.bing.com/maps?rtp=";
        
        

        string []url_list = new string[100];
        
        
        public Form1()

        {
            
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            url_list[0] = "~adr.Amsterdam";
            url_list[1] = "~adr.Rotterdam,Zuid-Holland";
            url_standard += url_list[0];
            url_standard += url_list[1];
            //url_list[].add("aaaa");
            Console.WriteLine(url_list[2]);
            

            webBrowser1.Url = new System.Uri(url_standard);

            /// add another button for this function
            
        }
    }
}
