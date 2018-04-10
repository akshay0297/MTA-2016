<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirm Tickets.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet3.css" rel="stylesheet" />
    <style type="text/css">
        #Reset1 {
            width: 96px;
        }
        .auto-style1 {
            color: #FF0000;
            font-weight: 700;
        }
        .auto-style2 {
            color: #0099FF;
        }
    </style>
</head>
<body>
        <div>
    <h3><b style="background-color: #993300">&nbsp;&nbsp;<asp:Label ID="Label302" runat="server" Text="looknbook.com" Font-Bold="True" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></h3>
     </div>
    <form id="form1" runat="server">
    <div style="text-align: center; color: #000099; font-size: large; background-color: #FFFFFF; height: 597px; width: 1295px;">
        <span class="auto-style1">CONFIRM YOUR BOOKINGS<br />
        <br />
        </span><span class="auto-style2">
        <asp:Label ID="lblCount0" runat="server" Text="Total No. Of Tickets :" Font-Bold="True" Font-Names="Copperplate Gothic Bold"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCount" runat="server" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblSeats0" runat="server" Text="Selected Seat No.s : " Font-Bold="True" Font-Names="Copperplate Gothic Bold"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblSeats" runat="server" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblAmount0" runat="server" Text="Amount : " Font-Bold="True" Font-Names="Copperplate Gothic Bold"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAmount" runat="server" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <br />
        </span><span class="auto-style1">
        <br />
        <br />
        </span>
        <asp:Label ID="Label1" runat="server" Text="Enter Name: " Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#66FFCC" BorderColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Small" ForeColor="#666666" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Mobile No.: " Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#66FFCC" BorderColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Small" ForeColor="#666666"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter E-mail: " Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" BackColor="#66FFCC" BorderColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Small" ForeColor="#666666"></asp:TextBox>
        
        &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
&nbsp;<asp:Button ID="Reset1" runat="server" CssClass="button1" OnClick="Reset1_Click" Text="Reset" />
        
        <asp:Button ID="Button1" runat="server" cssclass="button1" Text="Confirm Tickets !" OnClick="Button1_Click" style="margin-left: 43px" Width="118px" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="button1" OnClick="Button2_Click" Text="Cancel Booking" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="X-Large" ForeColor="#00FFCC"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" Text="Go Home"  CssClass="button2" OnClick="btnHome_Click" Visible="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTickets" runat="server" Text="Review Your Tickets" CssClass="button2" EnableTheming="True" OnClick="btnTickets_Click" Visible="False" />
    </div>
    </form>
</body>
</html>
