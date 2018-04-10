<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ProviderName="System.Data.SqlClient" 
        SelectCommand="Select * from HumanResources.Department" 
        connectionString="<%$ ConnectionStrings:conStr1 %>"></asp:SqlDataSource>
    
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="GroupName"
         
            DataSourceID="SqlDataSource1"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
