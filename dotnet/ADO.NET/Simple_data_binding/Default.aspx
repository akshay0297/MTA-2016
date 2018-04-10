<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <!--can be used within the opening and closing tags-->
        <asp:Label ID="Label1" runat="server" Text="NOTE:">
            There were <%#count %> transactions today.
        </asp:Label>

        <br />
        <!--can also be used as property of a tag-->
        <asp:Label ID="Label2" runat="server" Text="NOTE:">
            I have also noticed <%#count %> transactions today.
        </asp:Label>
    
    </div>
    </form>
</body>
</html>
