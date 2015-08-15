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
    public partial class Form8 : Form
    {
        private DataTable dt;

        public Form8()
        {
            InitializeComponent();
            dt = new DataTable();
            DataColumn dc = new DataColumn("column1");
            dt.Columns.Add(dc);
        }
        
        private void btnChat_Click(object sender, EventArgs e)
        {
            
            var k = new Form9();
            Action<string> a = s =>
            {
                DataRow dr = dt.NewRow();
                dr["column1"] = s;
                dt.Rows.Add(dr);        
            };
            k.F = a;
            k.Show();                   
        }

        private void Form8_Load(object sender, EventArgs e)
        {                   
            dgvMessages.DataSource = dt;         
        }
    }
}
