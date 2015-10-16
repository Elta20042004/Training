using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LongCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly ILongArithm _longArithm;
        public WebForm1()
        {
            _longArithm = new LongArithm(); 
            //_longArithm = new LongArithmMock();
        }
        public List<int> OneNumber
        {
            get
            {
                return (List<int>)ViewState["OneNumber"];
            }
            set
            {
                ViewState["OneNumber"] = value;
            }
        }

        public string Sign
        {
            get
            {
                return (string)ViewState["Sign"];
            }
            set
            {
                ViewState["Sign"] = value;
            }
        }

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

        //                   ++++++++
        protected void summary_click(object sender, EventArgs e)
        {
            Calculator(Sign);
            Sign = "+";
            Label1.Text = Label1.Text + '+';
        }

        //                  --------
        protected void subtraction_click(object sender, EventArgs e)
        {
            Calculator(Sign);
            Sign = "-";
            Label1.Text = Label1.Text + '-';
        }

        //                  ********
        protected void multiplication_click(object sender, EventArgs e)
        {
            Calculator(Sign);
            Sign = "*";
            Label1.Text = Label1.Text + '*';
        }

        //                  CCCCCCCC
        protected void C_click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            OneNumber.Clear();
            Label1.Text = "";
            Sign = null;
        }

        //                  =======
        protected void result_click(object sender, EventArgs e)
        {          
            Calculator(Sign);
            Sign = "=";
            Label1.Text = Label1.Text + "=";
            OneNumber.Reverse();
            for (int i = 0; i < OneNumber.Count; i++)
            {
                Label1.Text = Label1.Text + OneNumber[i];
            }
 
        }

        protected void Calculator(string sign)
        {
            if (sign == null)
            {
                OneNumber = _longArithm.ConvertStringToLongNumber(TextBox1.Text);
                for (int i = 0; i < OneNumber.Count; i++)
                {
                    Label1.Text = Label1.Text + OneNumber[i];
                }
                TextBox1.Text = "";
                OneNumber.Reverse();
            }
            else
            {
                var twoNumbers = _longArithm.ConvertStringToLongNumber(TextBox1.Text);

                for (int i = 0; i < twoNumbers.Count; i++)
                {
                    Label1.Text = Label1.Text + twoNumbers[i];
                }

                TextBox1.Text = "";
                twoNumbers.Reverse();

                switch (Sign)
                {
                    case "+":
                        OneNumber = _longArithm.Summ(OneNumber, twoNumbers);
                        break;
                    case "-":
                        OneNumber = _longArithm.Subtraction(OneNumber, twoNumbers);
                        break;
                    case "*":
                        OneNumber = _longArithm.Multiplication(OneNumber, twoNumbers);
                        break;

                }
            }
        }
    }
}