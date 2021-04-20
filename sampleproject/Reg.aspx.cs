using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection userdata;
            userdata = Request.Form;
            string email = userdata["email"];
            string pass = userdata["password1"];
            //Response.Write(userdata["email"] + "<br>");
            //Response.Write(userdata["password1"] + "<br>");
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            con.Open();

            string query = "select email, [password] from users where email='"+email+"' AND [password]='"+pass+"'";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                Response.Redirect("Home.aspx");
            else
                Response.Write("Incorrect email or password");
        }
    }
}