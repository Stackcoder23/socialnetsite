using System;
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
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");
            con.Open();
            int userid = (int)Session["id"];
            string query = "select * from posts where userID="+userid+" order by postID desc";

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
                    "&nbsp;&nbsp;&nbsp;<b>" + Session["user"] + "</b><br /><br />" +
                    "<p>" + status + "</p>" +
                    "<img style='width:800px' src='/posts/" + pic + "'>" +
                "</div><br>";
            }


            return html;
        }
    }
}