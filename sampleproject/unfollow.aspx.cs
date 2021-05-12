using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class unfollow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            int userid = (int)Session["id"];

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();

            string query2 = "delete from follows where follower =" + userid + " and following =" + id + "";

            OleDbCommand cmd2 = new OleDbCommand(query2, con);
            int x = cmd2.ExecuteNonQuery();
            if (x > 0)
            {
                Response.Redirect("following.aspx");
            }
            else
                Response.Write("Not deleted");
        }
    }
}