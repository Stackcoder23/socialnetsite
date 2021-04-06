<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="sampleproject.Home" %>

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
        <li><a href="#0">About</a></li>
        <li><a href="#0">Friends</a></li>
        <li><a href="myprofile.aspx">Profile</a></li>
        <li><a href="#0">Contact</a></li>
      </ul>
    </nav>
    <br />
    <br />
    <div style="margin-left: 40%"><asp:Image ID="Image2" runat="server" ImageUrl="https://picsum.photos/200/200" /></div>

    <br />

    <h2 style="margin-left: 40%">Angel Priya</h2><br />
    <p style="margin-left: 40%"> - Not yet working i am still studying</p>
    <p style="margin-left: 40%"> - Papa Ki pari</p>
    <p style="margin-left: 40%"> - Lives on Mars</p>
    
    <br /><br />        
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image5" runat="server" ImageUrl="https://picsum.photos/40/40" />
        <b>&nbsp;&nbsp;&nbsp; Angel Priya</b><br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image6" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Angel Priya</b><br />
        <br />
        <p>Good Morning</p>
        <asp:Image ID="Image4" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div><br />
    
            
    
    </body>
</html>
