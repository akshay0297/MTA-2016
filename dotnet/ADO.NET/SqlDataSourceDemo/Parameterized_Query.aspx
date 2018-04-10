<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Parameterized_Query.aspx.cs" Inherits="Parameterized_Query" %>

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
        SelectCommand="Select * from HumanResources.Department">
        </asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
        ConnectionString="<%$ ConnectionStrings:conStr1 %>" 
        SelectCommand="Select * from HumanResources.Department where DepartmentID=@DepartmentID">

    <SelectParameters>
<asp:ControlParameter ControlID="DropDownList1" Name="DepartmentID"
PropertyName="SelectedValue" />
</SelectParameters>
             </asp:SqlDataSource>

        <br />

        <br />
        <br />

        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource2"></asp:DetailsView>


    </div>
    </form>
</body>
</html>
