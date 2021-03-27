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

            <form action="Reg.aspx" method="post">
                <h1>Create Account</h1>

             
                <br/>
                <input type="text" name="name" placeholder="Name"/>
                <input type="email" name="email" placeholder="Email"/>
                <input type="password" name="password" placeholder="Password"/>
                <input type="text" name="phoneno" placeholder="phoneno"/>
            	<input type="text" name="address" placeholder="Address"/>
                <br/>
                <button>SignUp</button>
            </form>
        </div>
        <div class="form-container sign-in-container">
            <form method="post" runat="server">
                <h1>Login</h1>

                <br/>
                <br/>
                <input type="email" name="email" placeholder="Email"/>
                <input type="password" name="password1" placeholder="Password" size="20"/>

                <asp:Button CssClass="button" runat="server" ID="signin" Text="Sign In" OnClick="signin_Click"/>
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
