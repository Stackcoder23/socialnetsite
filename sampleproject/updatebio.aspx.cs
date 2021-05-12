using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class updatebio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            string bio = Request["status"];
            con.Open();
            string check = "select * from profiledetails where userID = " + userid + "";
            OleDbCommand checkcmd = new OleDbCommand(check, con);
            OleDbDataReader dr = checkcmd.ExecuteReader();
            if (dr.Read())
            {
                string query = "update profiledetails set bio = '" + bio + "' where userID = " + userid + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //Response.Write("<script>alert('inserted')</script>");
                    Response.Redirect("myprofile.aspx");
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
            }
            else
            {
                string query = "insert into profiledetails(userID, bio) values (" + userid + ",'" + bio + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //Response.Write("<script>alert('inserted')</script>");
                    Response.Redirect("myprofile.aspx");
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
            }
        }
    }
}