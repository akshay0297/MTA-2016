<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <!--This tag demonstrates how you can change the header text at the top of a column from-->
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false">

           <%-- applying styles--%>
           <RowStyle BackColor ="SkyBlue" ForeColor = "#4A3C8C" HorizontalAlign="Center" />
            <HeaderStyle BackColor = "#4A3C8C" Font-Bold = "True" ForeColor = "#F7F7F7" HorizontalAlign="Center" />
            
            <Columns>

                <asp:BoundField DataField="DepartmentID" HeaderText="Department Number" />
                <asp:BoundField DataField="Name" HeaderText="Department Name" />
                <asp:BoundField DataField="GroupName" HeaderText="Division" />
                <%--applying column specific styles--%>
                <asp:BoundField DataField = "ModifiedDate" HeaderText = "Date of Update" DataFormatString = "{0:MM/dd/yy}">
                    <ItemStyle BackColor = "#E7E7FF" ForeColor = "#4A3C8C" />
                    <HeaderStyle BackColor = "YellowGreen" Font-Bold = "True" ForeColor = "#F7F7F7" />
                    </asp:BoundField>
                

            </Columns>

        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString = "<%$ ConnectionStrings:conStr1 %>" 
         SelectCommand = "SELECT * FROM HumanResources.Department"></asp:SqlDataSource>
        
    
    </div>
    </form>
</body>
</html>
