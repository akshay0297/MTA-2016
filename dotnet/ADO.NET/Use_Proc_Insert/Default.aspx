<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    EmployeeID: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
    Employee Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
    Department:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
    Designation:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert Record" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
