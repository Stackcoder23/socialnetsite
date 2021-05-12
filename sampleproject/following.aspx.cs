using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class following : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int count()
        {
            int n = 0;
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();

            string query = "select userID, uname from users where userID in (select following from follows where follower = " + userid + ")";
            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                n = n + 1;
            }
                return n;
        }
        public string showdata()
        {
            string html = "";
            int userid = (int)Session["id"];
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();

            string query = "select userID, uname from users where userID in (select following from follows where follower = " + userid + ")";
            OleDbCommand cmd = new OleDbCommand(query, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string dp = "";
                string query3 = "select profilepic from profiledetails where userID = " + id + "";
                OleDbCommand cmd3 = new OleDbCommand(query3, con);
                try
                {
                    dp = (string)cmd3.ExecuteScalar();
                }
                catch (Exception e)
                {
                    dp = "blank";
                }
                html += "<tr><td><img style='width:50px; border-radius:50%' class='profilepic' src='/dp/" + dp + "' alt='image' onerror= this.src='dp.jpg'></td>" +
                    "<td></td><td>" + name + "&nbsp;&nbsp;&nbsp;</td><td><a href='unfollow.aspx?id="+id+"'>Unfollow</a></td></tr>";
            }

            return html;
        }
    }
}