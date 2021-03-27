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
        <li><a href="#0">Home</a></li>
        <li><a href="#0">About</a></li>
        <li><a href="#0">Friends</a></li>
        <li><a href="#">Profile</a></li>
        <li><a href="#0">Contact</a></li>
      </ul>
    </nav>
    <br /><br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <input id="searchbar" placeholder="Search.." />
&nbsp;<button id="searchbtn"><i class="fas fa-search"></i></button>
    <form id="form1" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            

            <input class="status" type="text" placeholder="What's in your mind" /><br />
       </form>
            
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image5" runat="server" ImageUrl="https://picsum.photos/40/40" />
        <b>&nbsp;&nbsp;&nbsp; Tony Stark</b><br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image6" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Tony Stark</b><br />
        <br />
        <p>Good Morning</p>
        <asp:Image ID="Image4" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image7" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Chai vali aunty</b><br />
        <br />
        <p>Hello Friends... Chai peelo</p>
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image8" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Bruce Wayne</b><br />
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image9" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Bruce Wayne</b><br />
        <br />
        <p>Hey There.....</p>
        <br />
    </div><br />
    <div style="margin-left: 20%; margin-right: 20%; border:double; padding: 2% 2% 2% 2%">
        <br />
        <asp:Image CssClass="profilepic" ID="Image10" runat="server" ImageUrl="https://picsum.photos/40/40" />
        &nbsp;&nbsp;&nbsp;
        <b>Sherlock holmes</b><br />
        <br />
        <asp:Image ID="Image3" runat="server" ImageUrl="https://picsum.photos/800/400" />
        <br />
    </div>
            
    
    </body>
</html>
