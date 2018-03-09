<%--Author: Rene
Created: January 2017
Assignment: Workshop 2

    
 
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatedComfirmation.aspx.cs" Inherits="WebApplication7.UpdatedComfirmation" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
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
                <li><a href="PackageHistory.aspx">Package History</a></li>   
                <li><a href="UpdateInfo.aspx">Update Info</a></li>            
                <li><a href="LogoutRedirect.aspx">Logout</a></li>                
            </ul>
        </div>
    </nav>

    
     <form id="form1" runat="server">          <div>
 
 <div class="container-fluid">
    <section class="container">
		<div class="container-page">				
			<div class="col-md-6">
				<h3 class="dark-grey">Successfully Updated Information</h3>
                <br />
                <p>The following is your new account information:</p>
                <br />
                		
                <div class="form-group col-lg-6">
					<label>UserID (Used to login)</label><br />
                    <asp:Label ID="lblCustId" runat="server" Text=""></asp:Label>
				</div>
                	
				<div class="form-group col-lg-6">
					<label>First Name</label><br />
                    <asp:Label ID="lblfirst" runat="server" Text=""></asp:Label>

				</div>
				
				<div class="form-group col-lg-6">
					<label>Last Name</label><br />
                    <asp:Label ID="lbllast" runat="server" Text=""></asp:Label>
				    </div>
								
				<div class="form-group col-lg-6">
					<label>Email Address</label><br />
                    <asp:Label ID="lblemail" runat="server" Text=""></asp:Label>
				    </div>
                
				<div class="form-group col-lg-6">
					<label>Address</label><br />
                    <asp:Label ID="lbladdress" runat="server" Text=""></asp:Label>
				    </div>
				
				<div class="form-group col-lg-6">
					<label>Postal Code</label><br />
                    <asp:Label ID="lblpostal" runat="server" Text=""></asp:Label>
				    </div>
								
				<div class="form-group col-lg-6">
					<label>City</label><br />
                    <asp:Label ID="lblcity" runat="server" Text=""></asp:Label>
				    </div>

				
				<div class="form-group col-lg-6">
					<label>Province</label><br />
                    <asp:Label ID="lblprovince" runat="server" Text=""></asp:Label>
				</div>

                <div class="form-group col-lg-6">
					<label>Country</label><br />
                    <asp:Label ID="lblcountry" runat="server" Text=""></asp:Label>
				    </div>
								
				<div class="form-group col-lg-6">
					<label>Home Phone</label><br />
                    <asp:Label ID="lblhomephone" runat="server" Text=""></asp:Label>
				</div>

				
				<div class="form-group col-lg-6">
					<label>Business Phone</label><br />
                    <asp:Label ID="lblbizphone" runat="server" Text=""></asp:Label>
				</div>

				<div class="col-sm-6">
				</div>				
			
			</div>
		</div>
	</section>
</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>

    </form>
    <footer class="footer navbar-fixed-bottom container-fluid bg-4 modal-footer" style="background-color:white">
        <div class="container">
            <p>&copy; 2018 Travel Experts <a href="MainPage.aspx">Make a bookign now!</a></p> 
        </div>
    </footer>
</body>
</html>
