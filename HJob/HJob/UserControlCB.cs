using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HJob
{
    public partial class UserControlCB : UserControl
    {
        public UserControlCB()
        {
            InitializeComponent();
        }

        private string[] ingridienty = new[]
        {
            "ogurcy", "pomedory", "luk", "hasa", "bazilic", "yajco", "kavachok"
        };

        private void AddToCB(string k)
        {
            checkedListBox1.Items.Add(k);
        }

        private void UserControlCB_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ingridienty.Length; i++)
            {
                string k = ingridienty[i];
                AddToCB(k);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string otvet = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    otvet = otvet +" "+ ingridienty[i];
                }
            }
            label1.Text = otvet;

        }



    }
}
