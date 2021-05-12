using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]

        public static List<string> searchuser(string prefixText)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            OleDbDataAdapter da;
            DataTable dt;
            DataTable Result = new DataTable();
            string str = "select uname from users where uname like '"+prefixText+"%'";

            da = new OleDbDataAdapter(str, con);
            dt = new DataTable();
            da.Fill(dt);
 
            List<string> output = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
                output.Add(dt.Rows[i][0].ToString());

            con.Close();
            return output;
        }


        public string showdata()
        {
            string html = "";
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();

            string query = "select * from posts where userID in (select following from follows where follower = "+userid+") order by postID desc";

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
                string dp = "";
                if (!reader.IsDBNull(1))
                {
                    pic = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    status = reader.GetString(2);
                }
                int user = reader.GetInt32(3);
                string query2 = "select uname from users where userID = "+user+"";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                string name = (string)cmd2.ExecuteScalar();

                string query3 = "select profilepic from profiledetails where userID = " + user + "";
                OleDbCommand cmd3 = new OleDbCommand(query3, con);
                try
                {
                    dp = (string)cmd3.ExecuteScalar();
                }
                catch(Exception e)
                {
                    dp = "blank";
                }

                html += "<a style='text-decoration:none;color:black' href='postdetails.aspx?p="+p+"&user="+user+"'><div style='margin-left: 20%; margin-right: 20%; border: double; padding: 2% 2% 2% 2% '><br>" +
                    "<img style='width:50px' class='profilepic' src='/dp/" + dp + "' alt='image' onerror= this.src='dp.jpg'>" +
                    "&nbsp;&nbsp;&nbsp;<b>"+name+"</b><br /><br />" +
                    "<p>"+status+"</p>" +
                    "<img style='width:800px' src='/posts/"+pic+"'><br>" +
                "<p>"+cmtcount+" Comments</p></div></a><br>";
            }
            con.Close();

            return html;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            HttpPostedFile postedFile = Request.Files["FileUpload1"];
            string status = Request["status"];
            if (postedFile != null && status != "" && postedFile.ContentLength>0)
            {
                string filename = Path.GetFileName(postedFile.FileName);
                string filepath = Server.MapPath("~/posts/") + filename;
                postedFile.SaveAs(filepath);
                con.Open();
                string query = "insert into posts(picture,status,userID) values ('"+ filename +"','"+status+"',"+ userid +")";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //Response.Write("<script>alert('inserted')</script>");
                    Response.Redirect("Home.aspx");
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
               
            }
            else if(postedFile != null && postedFile.ContentLength > 0)
            {
                string filename = Path.GetFileName(postedFile.FileName);
                string filepath = Server.MapPath("~/posts/") + filename;
                postedFile.SaveAs(filepath);
                con.Open();
                string query = "insert into posts(picture,userID) values ('" + filename + "'," + userid + ")";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //Response.Write("<script>alert('inserted')</script>");
                    Response.Redirect("Home.aspx");
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
                
            }
            else if(status != "")
            {
                con.Open();
                string query = "insert into posts(status,userID) values ('" + status + "'," + userid + ")";
                OleDbCommand cmd = new OleDbCommand(query, con);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //Response.Write("<script>alert('inserted')</script>");
                    Response.Redirect("Home.aspx");
                }
                else
                    Response.Write("<script>alert('Not inserted')</script>");
            }
            else
            {
                Response.Write("<script>alert('Empty Field')</script>");
            }

        }

        protected void search(object sender, EventArgs e)
        {
            string name = searchbar.Text;
            Response.Redirect("profile.aspx?name="+name+"");
        }
    }
}