using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HJob
{
    public partial class Form10 : Form
    {
       
        private Dictionary<string, Form11> dic;
        public Form10()
        {
            InitializeComponent();
            dic = new Dictionary<string, Form11>();
        }

        private void btnOpenNewChat_Click(object sender, EventArgs e)
        {
          
                string a = tbOpenNewChat.Text;
               
                if (!dic.ContainsKey(a))
                {
                    dic.Add(tbOpenNewChat.Text, new Form11());
                    dic[tbOpenNewChat.Text].Text = tbOpenNewChat.Text;
                    dic[tbOpenNewChat.Text].Show();
                }

        }

        private void btnConnect2Chats_Click(object sender, EventArgs e)
        {
            string k = tbConnect2Chats.Text;
            string[] key = k.Split(' ');
            string first = key[0];
            string second = key[1];

            if ((dic.ContainsKey(first)) && (dic.ContainsKey(second)))
            {
                var F1 = dic[first];
                var F2 = dic[second];

                F1.Send = F2.Reseve;
                F2.Send = F1.Reseve;
            }

        }
    }
}
