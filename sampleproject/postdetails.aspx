<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postdetails.aspx.cs" Inherits="sampleproject.postdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .profilepic {
            border-radius: 50% 50% 50% 50%;
            margin-top: 0%;
        }
        body{
            background: lightblue;
        }
    </style>
</head>
<body>
    <div style='margin-left: 20%; margin-right: 20%; border: double; padding: 2% 2% 2% 2% '><br />
        <img style='width:50px' class='profilepic' src='/dp/<%=dp() %>' alt='image' onerror= "this.src='dp.jpg'" />
        &nbsp;&nbsp;&nbsp;<b><%=name() %></b><br /><br />
        <p><%=status() %></p>
        <img style='width:800px' src='/posts/<%=pic() %>' /><br /><br /><br />

    <p>Comment Something</p>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" ID="comment" placeholder="Write Comment here" Width="75%" />
        <asp:Button Text="Post" ID="cmt_button" runat="server" OnClick="cmt_button_Click" />
    </form><br /><br />
        <%=showcmt() %>
    </div>
</body>
</html>
