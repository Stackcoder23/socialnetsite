using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class myprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string showmydata()
        {
            string html = "";
            string dp = "";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            int userid = (int)Session["id"];
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

            string query = "select * from posts where userID="+userid+" order by postID desc";

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
                    "<img style='width:50px' class='profilepic' src='/dp/"+dp+"' alt='image' onerror= this.src='dp.jpg'>" +
                    "&nbsp;&nbsp;&nbsp;<b>" + Session["user"] + "</b><br /><br />" +
                    "<p>" + status + "</p>" +
                    "<img style='width:800px' src='/posts/" + pic + "'><br>" +
                "<p>" + cmtcount + " Comments</p></div></a><br>";
            }


            return html;
        }

        public string showmybio()
        {
            string html = "";
            int userid = (int)Session["id"];
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            string query = "select bio from profiledetails where userID = " + userid + "";

            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    html = reader.GetString(0);
                }
                catch(Exception e)
                {
                    html = "-Update Your Bio";
                }
            }
            else
            {
                html = "-Update Your Bio";
            }
            return html;
        }

        public string profilepic()
        {
            int userid = (int)Session["id"];
            string html = "";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            string query = "select profilepic from profiledetails where userID = "+userid+"";

            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    html = reader.GetString(0);
                }
                catch(Exception e)
                {
                    html = "blank";
                }
            }
            else
            {
                html = "blank";
            }
            return html;
        }

        protected void updatedp_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            HttpPostedFile postedFile = Request.Files["FileUpload1"];
            if (postedFile != null && postedFile.ContentLength > 0)
            {
                string filename = Path.GetFileName(postedFile.FileName);
                string filepath = Server.MapPath("~/dp/") + filename;
                postedFile.SaveAs(filepath);
                con.Open();
                string check = "select * from profiledetails where userID = "+userid+"";
                OleDbCommand checkcmd = new OleDbCommand(check, con);
                OleDbDataReader dr = checkcmd.ExecuteReader();
                if (dr.Read())
                {
                    string query = "update profiledetails set profilepic = '"+filename+"' where userID = "+userid+"";
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
                    string query = "insert into profiledetails(userID, profilepic) values ("+userid+",'"+filename+"')";
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
}