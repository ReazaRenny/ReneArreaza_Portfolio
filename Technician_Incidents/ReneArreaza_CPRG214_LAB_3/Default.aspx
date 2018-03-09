<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReneArreaza_CPRG214_LAB_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 640px;
            height: 423px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial; font-size: xx-large; color: #808080">
    
        SportsPro - Open Incidents :<br />
    
        <asp:DropDownList ID="ddTechs" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="TechID" AutoPostBack="True">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllTechnicians" TypeName="ReneArreaza_CPRG214_LAB_3.App_Code.TechnicianDB"></asp:ObjectDataSource>
    
    </div>
        <p>
            <img alt="software" class="auto-style1" src="Images/pexels-photo-574070.jpeg" /></p>
        <asp:GridView ID="gvIncidents" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="IncidentID" HeaderText="IncidentID" SortExpression="IncidentID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="TechID" HeaderText="TechID" SortExpression="TechID" />
                <asp:BoundField DataField="DateOpened" HeaderText="DateOpened" SortExpression="DateOpened" />
                <asp:BoundField DataField="DateClosed" HeaderText="DateClosed" SortExpression="DateClosed" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOpenTechIncidents" TypeName="ReneArreaza_CPRG214_LAB_3.App_Code.IncidentDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddTechs" Name="techID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
