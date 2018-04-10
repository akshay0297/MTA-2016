<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet4.css" rel="stylesheet" />
    
    <style type="text/css">
        #form1 {
            text-align: left;
        }
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
        <div>
    <h3><b style="background-color: #993300">&nbsp;&nbsp;<asp:Label ID="Label302" runat="server" Text="looknbook.com" Font-Bold="True" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></h3>
     </div>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Search By Name : " Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#003366"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" Width="164px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Medium" ForeColor="#003366"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Search By Phone No." Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#003366"></asp:Label>
        &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPh" runat="server" Width="180px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Medium" ForeColor="#003366" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" CssClass="button1" runat="server" Text="Search" OnClick="btnSearch_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnHome" cssclass="button2" runat="server" Text="Go Home" OnClick="btnHome_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Medium" ForeColor="#00FFCC"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage2" runat="server" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Medium" ForeColor="#00FFCC"></asp:Label>
        <br />
        <br />
        <strong><span class="auto-style1">
        <br />
&nbsp;</span><asp:Label ID="Label3" runat="server" Text="Your Bookings : " Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#003366"></asp:Label>
        <br class="auto-style1" />
        </strong>
        <br />
        <asp:GridView ID="GridView1" runat="server" BorderColor="#003399" BorderStyle="Outset" BorderWidth="1px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Large" ForeColor="Black">
        </asp:GridView>
    </form>
</body>
</html>
