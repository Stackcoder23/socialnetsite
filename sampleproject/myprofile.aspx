<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myprofile.aspx.cs" Inherits="sampleproject.myprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="home.css" />
    <script src="https://kit.fontawesome.com/a076d05399.js" crossorigin="anonymous"></script>
</head>
<body>
    <br />
    <br />
    <br />
     <nav>
      <ul>
        <li><a href="Home.aspx">Home</a></li>
        <li><a href="about.aspx">About</a></li>
        <li><a href="following.aspx">Following</a></li>
        <li><a href="followers.aspx">Followers</a></li>
        <li><a href="myprofile.aspx">Profile</a></li>
        <li><a href="logout.aspx">Logout</a></li>
      </ul>
    </nav>
    <br />
    <br />
    <div style="margin-left: 40%"><img style='width:200px' src="/dp/<%=profilepic()%>" onerror= "this.src='dp.jpg'" />&nbsp;&nbsp;&nbsp;
        
        <br />
        <form id="form1" runat="server" enctype="multipart/form-data">
        Update Profile pic : <input name="FileUpload1" id="FileUpload1" type="file" accept="image/*"/><br />
            <asp:Button Text="Update" runat="server" ID="updatedp" OnClick="updatedp_Click" />
        </form>
    </div>
    <br />

    <h2 style="margin-left: 40%"><% Response.Write(Session["User"]); %></h2><br />
    <p style="margin-left: 40%">  <%=showmybio()%></p>
    <!--<p style="margin-left: 40%"> - Papa Ki pari</p>
    <p style="margin-left: 40%"> - Lives on Mars</p>-->
    <button onclick="location.href = 'updatebio.aspx'" style="margin-left: 40%">Update Bio</button>
    
    <br />
    <br />
    
    <br /><br />        
    
    <%=showmydata()%>
    
            
    
    </body>
</html>
