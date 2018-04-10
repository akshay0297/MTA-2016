<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datasrcdemo.aspx.cs" Inherits="page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString =" <%$ ConnectionStrings:conStr1 %>"
           SelectCommand =" Select * from HumanResources.Department"
              >

        </asp:SqlDataSource>
       
         <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="DepartmentID">
        </asp:DropDownList>
        <!-- datatextfield is the atb to be dis in the drop down list -->
    
    
    
    </div>
        </form>
</body>
</html>
