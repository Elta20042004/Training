using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

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

        public List<int> TwoNumbers
        {
            get
            {
                return (List<int>)ViewState["TwoNumbers"];
            }
            set
            {
                ViewState["TwoNumbers"] = value;
            }
        }

        public List<int> ResList
        {
            get
            {
                return (List<int>)ViewState["ResList"];
            }
            set
            {
                ViewState["ResList"] = value;
            }
        }

        public string test
        {
            get
            {
                return (string)ViewState["test"];
            }
            set
            {
                ViewState["test"] = value;
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

        public void GetOneNumbersArray(string text)
        {
            string k = TextBox1.Text;
            OneNumber = new List<int>();
            for (int i = 0; i < k.Length; i++)
            {
                OneNumber.Add(k[i] - '0');
            }
            TextBox1.Text = "";
        }

        //                   ++++++++
        protected void summary_click(object sender, EventArgs e)
        {
            test = "+";
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  --------
        protected void subtraction_click(object sender, EventArgs e)
        {
            test = "-";
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  ********
        protected void multiplication_click(object sender, EventArgs e)
        {
            test = "*";
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  ////////
        protected void division_click(object sender, EventArgs e)
        {
            test = "/";
            GetOneNumbersArray(TextBox1.Text);
        }

        //                  CCCCCCCC
        protected void C_click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            OneNumber.Clear();
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

            List<int> one = UpendArray(OneNumber);
            List<int> two = UpendArray(TwoNumbers);
            ResList = new List<int>();

            if (test == "+")
            {
                Summ(one, two);
            }
            else if (test == "-")
            {
                Subtraction(one, two);
            }
            else if (test == "*")
            {
                Multiplication(one, two);
            }
        }

        // *
        public void Multiplication(List<int> one, List<int> two)
        {
            if (one.Count != two.Count)
            {
                Balance(one, two);
            }

            int k = 0;
            int index = 0;
            List<int> intermediateResult = new List<int>();

            for (int i = 0; i < one.Count; i++)
            {
                for (int j = 0; j < two.Count; j++)
                {
                    int temp = (one[j] * two[i]) + index;

                    if (temp > 9 && j != one.Count - 1)
                    {
                        intermediateResult.Add(temp % 10);
                        index = temp / 10;
                    }
                    else if (temp <= 9)
                    {
                        intermediateResult.Add(temp);
                        index = 0;
                    }
                    else if (temp > 9 && i == one.Count - 1)
                    {
                        intermediateResult.Add(temp % 10);
                        intermediateResult.Add(temp / 10);
                    }
                }

                Balance(intermediateResult,ResList);
                int index1 = 0;

                for (int j = k; j < intermediateResult.Count; j++)
                {
                    int temp = intermediateResult[j] + ResList[j] + index1;
                    if (temp > 9 && j != intermediateResult.Count - 1)
                    {
                        ResList[j] = (temp % 10);
                        index1 = temp / 10;
                    }
                    else if (temp <= 9)
                    {
                        ResList[j] = temp;
                        index1 = 0;
                    }
                    else if (temp > 9 && j == intermediateResult.Count - 1)
                    {
                        ResList[j] = temp % 10;
                        ResList[j+1] = temp % 10; 
                    }
                }
                intermediateResult.Clear();
                k++;
            }
        }

        public void Balance(List<int> one, List<int> two)
        {
            if (one.Count > two.Count)
            {
                int difference = one.Count - two.Count;
                while (difference != 0)
                {
                    two.Add(0);
                    difference--;
                }
            }
            else if (one.Count < two.Count)
            {
                int difference = two.Count - one.Count;
                while (difference != 0)
                {
                    one.Add(0);
                    difference--;
                }
            }
        }

        // -
        public void Subtraction(List<int> one, List<int> two)
        {
            if (one.Count != two.Count)
            {
                Balance(one, two);
            }
            for (int i = 0; i < one.Count; i++)
            {
                ResList.Add(Math.Abs(one[i] - two[i]));
            }
        }

        // +
        public void Summ(List<int> one, List<int> two)
        {
            if (one.Count != two.Count)
            {
                Balance(one, two);
            }
            int index = 0;

            for (int i = 0; i < one.Count; i++)
            {
                int temp = one[i] + two[i] + index;
                if (temp > 9 && i != one.Count - 1)
                {
                    ResList.Add(temp % 10);
                    index = temp / 10;
                }
                else if (temp <= 9)
                {
                    ResList.Add(temp);
                    index = 0;
                }
                else if (temp > 9 && i == one.Count - 1)
                {
                    ResList.Add(temp % 10);
                    ResList.Add(temp / 10);
                }
            }

        }

        public void Console()
        {

        }

        public List<int> UpendArray(List<int> oneTwoResult)
        {

            List<int> uppendArray = new List<int>();
            for (int i = oneTwoResult.Count - 1; i >= 0; i--)
            {
                uppendArray.Add(oneTwoResult[i]);
            }
            return uppendArray;
        }

    }
}