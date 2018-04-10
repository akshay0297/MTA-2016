<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">
               <Columns>
                <asp:BoundField DataField="DepartmentID" HeaderText="Department Number" />
                <asp:BoundField DataField="Name" HeaderText="Department Name" />
                <asp:BoundField DataField="GroupName" HeaderText="Division" />        
                <asp:BoundField DataField = "ModifiedDate" HeaderText = "Date of Update"
                DataFormatString = "{0:MM/dd/yy}">
                    </asp:BoundField>
                

            </Columns>

        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString = "<%$ ConnectionStrings:conStr1 %>" 
         SelectCommand = "SELECT * FROM HumanResources.Department"></asp:SqlDataSource>
        
    
    </div>
    </form>
</body>
</html>
