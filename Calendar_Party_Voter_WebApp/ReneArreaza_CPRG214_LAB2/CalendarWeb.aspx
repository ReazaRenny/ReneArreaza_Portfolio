<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalendarWeb.aspx.cs" Inherits="ReneArreaza_CPRG214_LAB2.CalendarWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 640px;
            height: 355px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Good Time Celebration Party<br />
        <img alt="Birthday" class="auto-style1" src="Images/gift-jeans-fashion-pack-157879.jpeg" /></div>
        <br />
        Pick preferred date from the calendar and submit your vote.<br />
        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
