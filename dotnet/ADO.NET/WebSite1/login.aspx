<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>dfyhvu</title>
    <style type="text/css">
        #form1 {
            height: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Login ID="Login1" runat="server">
        </asp:Login>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password "></asp:RequiredFieldValidator>
        <asp:HiddenField runat="server" OnValueChanged="HiddenField1_ValueChanged" ID="hidden"/>
        <asp:LinkButton ID="LinkButton1" runat="server" >Not an existing user? Register Now</asp:LinkButton>
        <br />
    </form>
</body>
</html>
