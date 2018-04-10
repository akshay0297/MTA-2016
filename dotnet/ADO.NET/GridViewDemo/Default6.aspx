<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:GridView ID="GridView1" runat="server" 
             DataSourceID="SqlDataSource1" AutoGenerateColumns="false" DataKeyNames="EmpID">
               <Columns>
                <asp:BoundField DataField="EmpID" HeaderText="Employee ID" />
                <asp:BoundField DataField="EName" HeaderText="Employee Name" />
                <asp:BoundField DataField="Dept" HeaderText="Department" />        
                <asp:BoundField DataField = "Designation" HeaderText = "Designation"/>
                <asp:CommandField ShowEditButton="true" />
                   <asp:CommandField ShowDeleteButton="true" />
                    

            </Columns>

        </asp:GridView>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString = "<%$ ConnectionStrings:conStr2 %>" 
         SelectCommand = "SELECT * FROM Employee" 
         UpdateCommand="update Employee set Ename=@ename,Dept=@dept,designation=@designation where EmpID=@EmpID" 
         DeleteCommand="delete from employee where EmpID=@EmpID"> </asp:SqlDataSource>
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
