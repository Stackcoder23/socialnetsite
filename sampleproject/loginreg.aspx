<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginreg.aspx.cs" Inherits="sampleproject.loginreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
     <div class="bubbels">
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
        <div class="bubble"></div>
    </div>

    <div class="container" id="container">
        <div class="form-container sign-up-container">

            <form method="post" runat="server">
                <h1>Create Account</h1>

             
                <!--<br/>
                <input type="text" name="name" placeholder="Name" required="required" />
                <!-- <input type="email" name="email" placeholder="Email" id="email" required />
                <input type="password" name="password" placeholder="Password" required />
                <input type="text" name="phoneno" placeholder="phoneno" required />
            	<!-- <input type="text" name="address" placeholder="Address"/> -->
                <br/>
                <!-- <asp:TextBox runat="server" ID="name" placeholder="Name"/> -->
                <input type="text" name="uname" id="uname" placeholder="Name" required="required" />
                <asp:TextBox runat="server" ID="email" placeholder="Email"/><asp:RegularExpressionValidator ErrorMessage="Enter valid email" ControlToValidate="email" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" />
                <input type="password" name="password" id="password" placeholder="Password" required />
                <asp:DropDownList CssClass="input" ID="gender" runat="server" placeholder="Gender">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox runat="server" ID="phoneno" placeholder="Phone Number"/><asp:RegularExpressionValidator ErrorMessage="Enter valid phone number" ControlToValidate="phoneno" runat="server" ForeColor="Red" ValidationExpression="\d{10}" />
                <asp:Button CssClass="button" runat="server" ID="Button1" Text="Sign Up" OnClick="signin_Click"/>
            </form>
        </div>
        <div class="form-container sign-in-container">
            <form method="post" action="Reg.aspx">
                <h1>Login</h1>

                <br/>
                <br/>
                <input type="email" name="email" placeholder="Email"/>
                <input type="password" name="password1" placeholder="Password" size="20"/>

                <button>SignIn</button>
            </form>
        </div>
        <div class="overlay-container">
            <div class="overlay">
                <div class="overlay-panel overlay-left">
                    <h1>Login</h1>
                    <button class="ghost" id="signIn">Sign In</button>
                </div>
                <div class="overlay-panel overlay-right">
                    <h1>To Create New Account</h1>
                    <button class="ghost" id="signUp">Sign Up</button>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        const signUpButton = document.getElementById('signUp');
        const signInButton = document.getElementById('signIn');
        const container = document.getElementById('container');

        signUpButton.addEventListener('click', () => {
            container.classList.add("right-panel-active");
        });
        signInButton.addEventListener('click', () => {
            container.classList.remove("right-panel-active");
        });
    </script>

</body>
</html>
