<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Select Department ID"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Rows="1"></asp:ListBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
