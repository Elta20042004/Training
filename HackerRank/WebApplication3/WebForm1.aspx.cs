using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private List<int> oneNumbers;

        public List<int> OneNumber
        {
            get
            {
                return List<int> oneNumber;
            }
            set
            {
                ViewState["test"] = value;
            }
        }
        
        public List<int> TwoNumbers;
        public List<int> ResList;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void one_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '1';
        }

        protected void two_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '2';
        }

        protected void three_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '3';
        }

        protected void four_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '4';
        }

        protected void five_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '5';
        }

        protected void six_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '6';
        }

        protected void seven_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '7';
        }

        protected void eight_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '8';
        }

        protected void nine_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '9';
        }

        protected void zero_click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + '0';
        }

        public void GetOneNumbersArray(string text)
        {
            string k = TextBox1.Text;
            OneNumbers = new List<int>();
            for (int i = 0; i < k.Length; i++)
            {
                OneNumbers.Add(k[i] - '0');
            }
            TextBox1.Text = "";
        }

        //                   ++++++++
        protected void summary_click(object sender, EventArgs e)
        {
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  --------
        protected void subtraction_click(object sender, EventArgs e)
        {
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  ********
        protected void multiplication_click(object sender, EventArgs e)
        {
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  ////////
        protected void division_click(object sender, EventArgs e)
        {
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  CCCCCCCC
        protected void C_click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            OneNumbers.Clear();
            TwoNumbers.Clear();
        }

        //                  =======
        protected void result_click(object sender, EventArgs e)
        {
            string k = TextBox1.Text;
            TwoNumbers = new List<int>();
            for (int i = 0; i < k.Length; i++)
            {
                TwoNumbers.Add(k[i] - '0');
            }
            TextBox1.Text = "";



        }
    }
}