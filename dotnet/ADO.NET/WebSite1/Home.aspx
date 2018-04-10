<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
      <!--electtonics-->  <asp:DropDownList ID="DropDownList1"  runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Mobiles</asp:ListItem>
            <asp:ListItem>Tablets</asp:ListItem>
            <asp:ListItem>Laptop</asp:ListItem>
            <asp:ListItem>Accesories</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <!--men--> <asp:DropDownList ID="DropDownList2"  runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
             <asp:ListItem>Clothing</asp:ListItem>
            <asp:ListItem>Footwear</asp:ListItem>
            <asp:ListItem>Watches</asp:ListItem>
            <asp:ListItem>Perfumes</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <!--female--> <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
            <asp:ListItem>Clothing</asp:ListItem>
            <asp:ListItem>Footwear</asp:ListItem>
            <asp:ListItem>Watches</asp:ListItem>
            <asp:ListItem>Perfumes</asp:ListItem>
        </asp:DropDownList>
    &nbsp;
       <!--home&furnishing--> <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>Furniture</asp:ListItem>
            <asp:ListItem>Kitchen and Dining</asp:ListItem>
            <asp:ListItem>Pet Supplies</asp:ListItem>
            <asp:ListItem>Home Decor</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="iPhone" Height="320px"  Width="334px" ImageUrl="i6.jpg" />
        </p>
    </form>
</body>
</html>
