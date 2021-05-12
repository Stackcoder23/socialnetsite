<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="followers.aspx.cs" Inherits="sampleproject.followers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="home.css" />
</head>
<body>
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
        <div style="margin-left: 440px">
            <br />
            <br />
            <br />
            <br />
            <h1>Followers (<%=count() %>)</h1>
            <table>
            <%=showdata()%>
            </table>
        </div>  
</body>
</html>
