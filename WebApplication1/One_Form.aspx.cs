using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
    public partial class One_Form : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void UsersGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                switch (e.Row.RowType)
                {
                    case DataControlRowType.Header:
                        //...
                        break;

                    case DataControlRowType.DataRow:
                        var test = Page.ClientScript.GetPostBackEventReference
                            (UsersGridView, "Select$" + e.Row.RowIndex.ToString());
                        e.Row.Attributes.Add("onclick",test);
                           
                        break;
                }
            }
            catch
            {
                //...throw
            }
        }


        protected void UsersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var usersGridView = sender as GridView;
                if (usersGridView != null)
                {
                    var row = usersGridView.SelectedRow;
                    string name = row.Cells[0].Text;
                    string age = row.Cells[1].Text;
                    Response.Redirect(string.Format("~/Data.aspx?name={0}&age={1}",name,age));
                    //Server.Transfer("Data.aspx");

                }
                //Do wherever you want with grvSearch.SelectedIndex                
            }
            catch
            {
                //...throw
            }
        }
    }
}