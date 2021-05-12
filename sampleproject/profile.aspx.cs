using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();

            string query = "select * from users where uname='" + name + "' ";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                Response.Redirect("usernotfound.aspx");
            }

            string query1 = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd1 = new OleDbCommand(query1, con);
            int following = (int)cmd1.ExecuteScalar();
            int follower = (int)Session["id"];

            string query2 = "select * from follows where follower = " + follower + " and following = " + following + "";
            OleDbCommand cmd2 = new OleDbCommand(query2, con);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                follow.Text = "✔Following";
            }
            else
                follow.Text = "+Follow";
        }

        public string showbio()
        {
            string html = "";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string name = Request.QueryString["name"];
            string query = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            int userid = (int)cmd.ExecuteScalar();

            string query3 = "select bio from profiledetails where userID = " + userid + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            OleDbDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    html = reader.GetString(0);
                }
                catch(Exception e)
                {
                    html = "-Empty Bio";
                }
            }
            else
            {
                html = "-Empty Bio";
            }

            return html;
        }

        public string profilepic()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string name = Request.QueryString["name"];
            string dp = "";
            string query = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            int userid = (int)cmd.ExecuteScalar();

            string query3 = "select profilepic from profiledetails where userID = " + userid + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            try
            {
                dp = (string)cmd3.ExecuteScalar();
            }
            catch(Exception e)
            {
                dp = "blank";
            }

            return dp;
        }

        public string showdata()
        {
            string html="";
            string dp = "";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            string name = Request.QueryString["name"];
            string query2 = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd2 = new OleDbCommand(query2, con);
            int userid = (int)cmd2.ExecuteScalar();
            string query1 = "select profilepic from profiledetails where userID = " + userid + "";

            OleDbCommand cmd1 = new OleDbCommand(query1, con);

            OleDbDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                try
                {
                    dp = reader1.GetString(0);
                }
                catch(Exception e)
                {
                    dp = "blank";
                }
            }

            string query = "select * from posts where userID=" + userid + " order by postID desc";

            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int p = reader.GetInt32(0);

                int cmtcount = 0;
                string cmtquery = "select * from comments where postID = " + p + "";

                OleDbCommand cmtcmd = new OleDbCommand(cmtquery, con);

                OleDbDataReader cmtreader = cmtcmd.ExecuteReader();

                while (cmtreader.Read())
                {
                    cmtcount += 1;
                }

                string pic = "";
                string status = "";
                if (!reader.IsDBNull(1))
                {
                    pic = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    status = reader.GetString(2);
                }
                html += "<a style='text-decoration:none;color:black' href='postdetails.aspx?p=" + p + "&user=" + userid + "'><div style='margin-left: 20%; margin-right: 20%; border: double; padding: 2% 2% 2% 2% '><br>" +
                    "<img style='width:50px' class='profilepic' src='/dp/" + dp + "' alt='image' onerror= this.src='dp.jpg'>" +
                    "&nbsp;&nbsp;&nbsp;<b>" + name + "</b><br /><br />" +
                    "<p>" + status + "</p>" +
                    "<img style='width:800px' src='/posts/" + pic + "'><br>" +
                "<p>" + cmtcount + " Comments</p></div></a><br>";
            }


            return html;
        }

        public int followers()
        {
            int n = 0;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string name = Request.QueryString["name"];
            string dp = "";
            string query = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            int userid = (int)cmd.ExecuteScalar();

            string query3 = "select follower from follows where following = " + userid + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            OleDbDataReader reader = cmd3.ExecuteReader();
            while (reader.Read()) {
                n++;
            }

            return n;
        }

        public int following()
        {
            int n = 0;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();
            string name = Request.QueryString["name"];
            string dp = "";
            string query = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            int userid = (int)cmd.ExecuteScalar();

            string query3 = "select following from follows where follower = " + userid + "";
            OleDbCommand cmd3 = new OleDbCommand(query3, con);
            OleDbDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                n++;
            }

            return n;
        }

        protected void follow_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            string name = Request.QueryString["name"];
            string query = "select userID from users where uname = '" + name + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            int following = (int)cmd.ExecuteScalar();
            int follower = (int)Session["id"];

            if (follow.Text == "+Follow")
            {
                string query2 = "insert into follows values (" + follower + "," + following + ")";

                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                int x = cmd2.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect(Request.RawUrl.ToString());
                }
                else
                    Response.Write("Not Inserted");
            }
            else
            {
                string query2 = "delete from follows where follower =" + follower + " and following =" + following + "";

                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                int x = cmd2.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Redirect(Request.RawUrl.ToString());
                }
                else
                    Response.Write("Not deleted");
            }
        }
        
    }
}