<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="sampleproject.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="home.css" />
    <script src="https://kit.fontawesome.com/a076d05399.js" crossorigin="anonymous"></script>
    <style>
        .follow {
          background-color: blue;
          border: none;
          color: white;
          padding: 15px 32px;
          text-align: center;
          text-decoration: none;
          display: inline-block;
          font-size: 16px;
          margin: 4px 2px;
          cursor: pointer;
          width: 50%;
        }
    </style>
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
    <div style="margin-left: 40%"><img style='width:200px' src="/dp/<%=profilepic()%>" onerror= "this.src='dp.jpg'" /></div>

    

    <h2 style="margin-left: 40%"><% Response.Write(Request.QueryString["name"]); %></h2><br />
    
    <p style="margin-left: 40%">  <%=showbio()%></p><br /><br />
    <p style="margin-left: 40%">-  <%=followers()%> Followers</p>
    <p style="margin-left: 40%">-  <%=following()%> Following</p>
    <form runat="server" >
        <div style="margin-left: 30%">
            <asp:Button CssClass="follow" Text='+Follow' runat="server" ID="follow" OnClick="follow_Click" />
        </div>
    </form>

    
    <br /><br />        
    <%=showdata()%>
    
            
    
    </body>
</html>
