<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
          
             <SelectedRowStyle BackColor="Thistle" Font-Italic="true" />
             
               <Columns>
               <asp:ButtonField CommandName="Select" ButtonType="Button" DataTextField="DepartmentID" />
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
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
