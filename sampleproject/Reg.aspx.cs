using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sampleproject
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection userdata;
            userdata = Request.Form;
            Response.Write(userdata["name"]+"<br>");
            Response.Write(userdata["email"] + "<br>");
            Response.Write(userdata["password"] + "<br>");
            Response.Write(userdata["phoneno"] + "<br>");
            Response.Write(userdata["address"] + "<br>");
        }
    }
}