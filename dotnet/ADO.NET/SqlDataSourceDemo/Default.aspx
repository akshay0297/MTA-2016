<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
        DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="DepartmentID"  
        ></asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
        ConnectionString="<%$ ConnectionStrings:conStr1 %>" 
        SelectCommand="Select DepartmentID,Name from HumanResources.Department"
        >
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
