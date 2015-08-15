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
    public partial class Form11 : Form
    {
        private DataTable dt;
        public Action<string, string> Send { get; set; }

        public Form11()
        {
            InitializeComponent();
            dt = new DataTable();
            DataColumn dc1 = new DataColumn("sender");
            DataColumn dc2 = new DataColumn("message");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
        }

        public void Reseve(string sender, string message)
        {
            var row = dt.NewRow();
            row["sender"] = sender;
            row["message"] = message;
            dt.Rows.Add(row);
        }

        private void btnSend_1_Click(object sender, EventArgs e)
        {
            Reseve(Text, tbText_1.Text);
            if (Send != null)
            {
                 Send(Text, tbText_1.Text);
            }       
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dgv_1.DataSource = dt;
        }

    }
}
