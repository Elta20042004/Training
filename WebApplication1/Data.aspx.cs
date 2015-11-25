using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    internal class Books : DbContext
    {
        public DbSet<Authors> Authors { get; set; }
    }
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            string age = Request.QueryString["age"];

            Database.SetInitializer<Books>(new CreateDatabaseIfNotExists<Books>());
            var dbContext = new Books();
            var peopleList = dbContext.Authors.Select(t => t);

            foreach (var u in peopleList)
            {
                if (u.Name == name && u.Age == int.Parse(age))
                {
                    Label1.Text = u.Name + ' ' + u.Age + ' '  + u.ID;
                }

            }
        }
    }
}