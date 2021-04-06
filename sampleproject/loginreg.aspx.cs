using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace sampleproject
{
    public partial class loginreg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signin_Click(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mjosh\\Documents\\kwitbook.accdb");

            //con.Open();

            string name = Request["uname"];
            string uemail = email.Text;
            string pass = Request["password"];
            string phone = phoneno.Text;

            //Response.Redirect("Home.aspx");
        }
    }
}