<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newuserform.aspx.cs" Inherits="newuserform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password2 {
            width: 182px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            CREATE ACCOUNT</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Your name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            Gender</p>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Female" />
&nbsp;
        </p>
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Other" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Age</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            Phone number</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            Address</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;Email</p>
        <p>
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p accesskey="5gggg">
            New Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <input id="Password1" maxlength="20" type="password" placeholder="at least 7 characters required" /></p>
        <p>
            Confirm Password</p>
        <p>
            <input id="Password2" type="password"/></p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Create your account" />
        </p>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server">Already have an account. </asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
