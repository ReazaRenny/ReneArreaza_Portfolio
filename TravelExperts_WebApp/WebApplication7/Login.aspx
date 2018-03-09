<%--Author:Rene
Created: January 2017
Assignment: Workshop 2

    
 
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication7.Login" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <link href="~/Content/LoginStyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/LoginJS.js"></script>
</head>
<body>
    <%--<form id="form1" runat="server">
    </form>--%>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand">Travel Experts</a>              
            </div>
            <ul class="nav navbar-nav">
                <li><a href="MainPage.aspx">Home</a></li>
                <li><a href="Register.aspx">Register</a></li>    
                <li class="active"><a href="Login.aspx">Login</a></li>              
            </ul>
        </div>
    </nav>
 <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="wrap">
                <p class="form-title">
                    Sign In</p>
                <form class="login" runat="server">
                <asp:TextBox ID="txtCustID" runat="server" placeholder="Username"></asp:TextBox> 
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
        <asp:Label ID="lblAlert" runat="server" ForeColor="Red"></asp:Label>

                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login"  />
                
                </form>
            </div>
        </div>
    </div>
        </div>
        <footer class="footer navbar-fixed-bottom container-fluid bg-4 modal-footer" style="background-color:white">
        <div class="container">
            <p>&copy; 2018 Travel Experts <a href="MainPage.aspx">Make a bookign now!</a></p> 
        </div>
    </footer>
</body>
</html>
