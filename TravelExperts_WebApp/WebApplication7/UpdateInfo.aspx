<%--Author: Rene
Created: January 2017
Assignment: Workshop 2

    
 
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInfo.aspx.cs" Inherits="WebApplication7.UpdateInfo" %>

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
                <li class="active"><a href="UpdateInfo.aspx">Update Info</a></li>          
                <li><a href="LogoutRedirect.aspx">Logout</a></li>                
            </ul>
        </div>
    </nav>

    
    
     <form id="form1" runat="server">          <div>
 
 <div class="container-fluid">
    <section class="container">
		<div class="container-page">				
			<div class="col-md-6">
				<h3 class="dark-grey">Update Information</h3>
                	
                <div class="form-group col-lg-6">
					<label>Your UserID is</label>
                    <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
					

				</div>
                <br />
                <br />
				<div class="form-group col-lg-6">
					<label>First Name</label>
					<asp:TextBox ID="txtF" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVFirstName" runat="server" ControlToValidate="txtF" ErrorMessage="First Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>

				</div>
				
				<div class="form-group col-lg-6">
					<label>Last Name</label>
					<asp:TextBox ID="txtL" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVLastName" runat="server" ControlToValidate="txtL" ErrorMessage="Last Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>

				</div>
								
				<div class="form-group col-lg-6">
					<label>Email Address</label>
					<asp:TextBox ID="txtE" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVEmailAddress" runat="server" ControlToValidate="txtE" Display="Dynamic" ErrorMessage="Email Address is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REVEmailAddress" runat="server" ControlToValidate="txtE" Display="Dynamic" ErrorMessage="Invalid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

				</div>
                
				<div class="form-group col-lg-6">
					<label>Address</label>
					<asp:TextBox ID="txtA" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ControlToValidate="txtA" ErrorMessage="Address is Required" ForeColor="Red"></asp:RequiredFieldValidator>

				</div>
				
				<div class="form-group col-lg-6">
					<label>Postal Code</label>
					<asp:TextBox ID="txtPo" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVPostalCode" runat="server" ControlToValidate="txtPo" Display="Dynamic" ErrorMessage="Postal Code is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPo" Display="Dynamic" ErrorMessage="Postal Code is Invalid (No &quot;-&quot;)" ForeColor="Red" ValidationExpression="[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]"></asp:RegularExpressionValidator>

				</div>
								
				<div class="form-group col-lg-6">
					<label>City</label>
					<asp:TextBox ID="txtCi" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVCity" runat="server" ControlToValidate="txtCi" ErrorMessage="City is Required" ForeColor="Red"></asp:RequiredFieldValidator>

				</div>

				
				<div class="form-group col-lg-6">
					<label>Province</label>
					<asp:DropDownList ID="ddlProvinces" class="form-control" runat="server">
                        <asp:ListItem>AB</asp:ListItem>
                        <asp:ListItem>BC</asp:ListItem>
                        <asp:ListItem>MB</asp:ListItem>
                        <asp:ListItem>NB</asp:ListItem>
                        <asp:ListItem>NL</asp:ListItem>
                        <asp:ListItem>NS</asp:ListItem>
                        <asp:ListItem>NT</asp:ListItem>
                        <asp:ListItem>NU</asp:ListItem>
                        <asp:ListItem>ON</asp:ListItem>
                        <asp:ListItem>PE</asp:ListItem>
                        <asp:ListItem>QC</asp:ListItem>
                        <asp:ListItem>SK</asp:ListItem>
                        <asp:ListItem>YT</asp:ListItem>
                    </asp:DropDownList>&nbsp;

				</div>

                <div class="form-group col-lg-6">
					<label>Country</label>
					<asp:TextBox ID="txtCo" class="form-control" runat="server"></asp:TextBox>&nbsp;

				    <asp:RequiredFieldValidator ID="RFVCountry" runat="server" ControlToValidate="txtCo" ErrorMessage="Country is Required" ForeColor="Red"></asp:RequiredFieldValidator>

				</div>
								
				<div class="form-group col-lg-6">
					<label>Home Phone</label>
					<asp:TextBox ID="txtH" class="form-control" runat="server"></asp:TextBox>&nbsp;
				    <asp:RequiredFieldValidator ID="RFVHomePhone" runat="server" ControlToValidate="txtH" ErrorMessage="Home Phone is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
				    <asp:RegularExpressionValidator ID="REVHomePhone" runat="server" ControlToValidate="txtH" Display="Dynamic" ErrorMessage="Invalid phone number format" ForeColor="Red" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"></asp:RegularExpressionValidator>
				</div>

				
				<div class="form-group col-lg-6">
					<label>Business Phone</label>
					<asp:TextBox ID="txtB" class="form-control" runat="server"></asp:TextBox>&nbsp;
				    <asp:RegularExpressionValidator ID="REVBusinessPhone" runat="server" ControlToValidate="txtB" Display="Dynamic" ErrorMessage="Invalid phone number format" ForeColor="Red" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"></asp:RegularExpressionValidator>
				    </div>


					
			

				<div class="col-sm-6">
				</div>				
			    <asp:Button ID="btnUpdate" runat="server" type="submit" class="btn btn-primary" Text="Update" OnClick="btnUpdate_Click"/>
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

</body>
</html>


</body>
</html>
