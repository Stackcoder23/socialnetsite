using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class postdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int post = int.Parse(Request.QueryString["p"]);
            int user = int.Parse(Request.QueryString["user"]);
        }
        public string dp()
        {
            string dp = "";
            int user = int.Parse(Request.QueryString["user"]);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string query3 = "select profilepic from profiledetails where userID = " + user + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            try
            {
                dp = (string)cmd3.ExecuteScalar();
            }
            catch (Exception e)
            {
                dp = "blank";
            }
            return dp;
        }
        public string name()
        {
            string html = "";
            int user = int.Parse(Request.QueryString["user"]);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string query3 = "select uname from users where userID = " + user + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            html = (string)cmd3.ExecuteScalar();
            return html;
        }
        public string status()
        {
            string html = "";
            int post = int.Parse(Request.QueryString["p"]);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string query3 = "select status from posts where postID = " + post + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            try
            {
                html = (string)cmd3.ExecuteScalar();
            }
            catch (Exception e)
            {
                html = "";
            }
            return html;
        }
        public string pic()
        {
            string html = "";
            int post = int.Parse(Request.QueryString["p"]);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string query3 = "select picture from posts where postID = " + post + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            try
            {
                html = (string)cmd3.ExecuteScalar();
            }
            catch (Exception e)
            {
                html = "";
            }
            return html;
        }

        public string showcmt()
        {
            string html = "";
            int post = int.Parse(Request.QueryString["p"]);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();

            string query = "select * from comments where postID = "+post+"";

            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string cmt = reader.GetString(2);
                int cmtuser = reader.GetInt32(3);
                string dp = "";
                string query3 = "select profilepic from profiledetails where userID = " + cmtuser + "";
                OleDbCommand cmd3 = new OleDbCommand(query3, con);
                try
                {
                    dp = (string)cmd3.ExecuteScalar();
                }
                catch (Exception e)
                {
                    dp = "blank";
                }

                string query2 = "select uname from users where userID = " + cmtuser + "";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                string name = (string)cmd2.ExecuteScalar();

                html += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img style='width:50px' class='profilepic' src='/dp/" + dp+"' alt='image' onerror= this.src='dp.jpg'>" +
                    "&nbsp;&nbsp;&nbsp;<b>"+name+"</b>" +
                    "<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + cmt + "</p></br>";
            }
            return html;
        }

        protected void cmt_button_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["id"];
            int post = int.Parse(Request.QueryString["p"]);
            string cmt = comment.Text;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            if (cmt != null)
            {
                string query = "insert into comments(postID,comment,userID) values ("+post+",'"+cmt+"',"+userid+")";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect(Request.RawUrl.ToString());
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
            }
            else
            {
                Response.Redirect(Request.RawUrl.ToString());
            }
        }
    }
}