<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultsPage.aspx.cs" Inherits="ReneArreaza_CPRG214_LAB2.ResultsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblDay1" runat="server" Text="Day One"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDayOne" runat="server" ReadOnly="True"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Day Two"></asp:Label>
&nbsp;<asp:TextBox ID="txtDayTwo" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Day Three"></asp:Label>
&nbsp;<asp:TextBox ID="txtDayThree" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
    </form>
</body>
</html>
