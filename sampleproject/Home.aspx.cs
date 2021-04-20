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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public string showdata()
        {
            string html = "";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();

            string query = "select * from posts order by postID desc";

            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
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
                html += "<div style='margin-left: 20%; margin-right: 20%; border: double; padding: 2% 2% 2% 2% '><br>" +
                    "<img class='profilepic' src='https://picsum.photos/40/40' alt='image'>" +
                    "&nbsp;&nbsp;&nbsp;<b>Tony Stark</b><br /><br />" +
                    "<p>"+status+"</p>" +
                    "<img style='width:800px' src='/posts/"+pic+"'>" +
                "</div><br>";
            }
            

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
                    Response.Write("<script>alert('inserted')</script>");
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
                    Response.Write("<script>alert('inserted')</script>");
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
                    Response.Write("<script>alert('inserted')</script>");
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
    }
}