using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Three_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dbContext = new Books();
            var bookTitles = dbContext.Boooks.Select(t => t.Title.Trim());
            var bookPrice = dbContext.Boooks.Select(t => t.Price.ToString());

            var authorNames = dbContext.Authors.Select(t => t.Name.Trim());
            var authotAges = dbContext.Authors.Select(t => t.Age.ToString());

            string execBooks = DrawChart(bookTitles, bookPrice, "canvas");
            string execAuthors = DrawChart(authorNames, authotAges, "canvas1");
            ExecJs("drawChart", string.Join(";", new[] { execBooks, execAuthors }));
        }

        private string DrawChart(IEnumerable<string> categories, IEnumerable<string> data, string canvasId)
        {
            categories = categories.Select(t => "'" + t + "'");
            var catetgoryParam = string.Join(",", categories);
            var dataParam = string.Join(",", data);

            var config ="{ labels: ["+ 
                catetgoryParam+ 
                "], datasets: [ { label: '#1', fillColor: 'rgba(151,187,205,0.2)', strokeColor: 'rgba(151,187,205,1)', pointColor: 'rgba(151,187,205,1)', pointStrokeColor: '#fff', pointHighlightFill: '#fff', pointHighlightStroke: 'rgba(151,187,205,1)', data: ["+
                dataParam +"] }] }";
            var execQuery = string.Format("drawChart({0},'{1}')", config, canvasId);
            return execQuery;
        }


        private void ExecJs(string name, string call)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), name, call, true);
        }
    }
}