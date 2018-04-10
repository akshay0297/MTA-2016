<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3><b style="background-color: #993300">&nbsp;&nbsp;<asp:Label ID="Label302" runat="server" Text="looknbook.com" Font-Bold="True" Font-Names="Bell MT" Font-Size="XX-Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></h3>
     </div>
    <div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ProviderName="System.Data.SqlClient" 
        SelectCommand="Select * from dbo.Movies" 
        connectionString="<%$ ConnectionStrings:conStr %>"> 
        </asp:SqlDataSource>
       <div>
         
           <img class="image-round" src="angry-birds.jpg" alt="Angry Birds" width="200" height="200" />
           <img class="image-round" src="sarbjit.jpg" alt="Sarbjit" width="200" height="200" />
           <img class="image-round" src="x-men-apoc.jpg" alt="X-Men Apoclypse" width="200" height="200" />
           <img class="image-round" src="saadey-cm-saab.jpg" alt="Saade CM Saab" width="200" height="200" />
           <img class="image-round" src="phobia.jpg" alt="Phobia" width="200" height="200" />
           <img class="image-round" src="veerappan.jpg  " alt="Veerappan" width="200" height="200" />
        
           </div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Select Movie: " Font-Bold="True" Font-Italic="False" Font-Names="Bernard MT Condensed" Font-Size="X-Large" ForeColor="#000066" Width="150px"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
             DataTextField="Name"
             DataSourceID="SqlDataSource1"
             DataValueField="MovieID" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AppendDataBoundItems="true" BackColor="#999966" Font-Italic="False" CssClass="drop" Font-Names="Felix Titling" Font-Size="Medium" ForeColor="Black" Height="26px" Width="226px" Font-Bold="True">
            <Items>
                <asp:ListItem Text="Choose Here..." Value="" />
            </Items>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Algerian" Font-Underline="True" ForeColor="#000066"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
        ConnectionString="<%$ ConnectionStrings:conStr %>" 
        SelectCommand="Select Name,Description,Duration,Genre,Rating,Language,Censor from dbo.Movies where MovieID=@MovieID">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="MovieID"
            PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" BorderColor="Black" BorderWidth="1px" Font-Italic="False" Font-Names="Algerian" ForeColor="Black" BorderStyle="Solid">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" class="button1" Text="Submit" OnClick="Button1_Click" Visible="false" Font-Italic="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="Black" Height="27px" Width="104px" Font-Bold="True" />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Names="Copperplate Gothic Bold" ForeColor="Black" Font-Bold="True"></asp:Label>
    </div>
        <div>
        <asp:Label ID="Label100" runat="server" Text=" SELECT DATE :" Visible="False" Font-Bold="True" Font-Names="Castellar" Font-Size="Large" ForeColor="#003366"></asp:Label>
        <asp:Label ID="Label200" runat="server" Visible="False" Font-Bold="True" Font-Names="Copperplate Gothic Bold"></asp:Label>
        <asp:Button ID="Button100" runat="server" OnClick="Button100_Click" 
            class="button2" Text="Calendar" Height="24px" Width="134px" Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Medium" ForeColor="#000066" />
    </div>
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" 
            Visible="False"  CssClass="calendar"  
            BackColor="White" BorderColor="Blue"  CellPadding="1" DayNameFormat="Shortest"
    Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="255px" 
    Width="608px" ondayrender="Calendar1_DayRender">
    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        </asp:Calendar>
        <br />
        
        <br />
        
        <asp:Label ID="Label300" runat="server" ForeColor="#003366" Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large"></asp:Label>
        <asp:Button ID="Button200" runat="server" class="button3" OnClick="Button200_Click" Text="Show Timings" Visible="False" Font-Bold="True" Font-Italic="True" Font-Names="Engravers MT"  Font-Size="Medium" Height="30px" style="margin-top: 0px" Width="206px" />
        <asp:DropDownList ID="DropDownList10" runat="server" Visible="False" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Medium" Height="33px" Width="123px" BackColor="#999966">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button300" runat="server" OnClick="Button300_Click" class="button4" Text="Proceed" Visible="False" Font-Bold="True" Font-Names="Engravers MT" Font-Size="Medium" Font-Underline="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <span class="auto-style1"><strong>
        <br />
        <br />
        <br />
        <asp:Label ID="Label301" runat="server" Text="Review Booked Tickets :" Font-Bold="True" Font-Names="Copperplate Gothic Bold" Font-Size="Large" ForeColor="#003366"></asp:Label>
        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReview" runat="server" style="text-align: right" class="button5" Text="Review Tickets !" OnClick="btnReview_Click" Font-Bold="True" Font-Size="Large" ForeColor="Black" Font-Names="Felix Titling" />
    <br />
        </div>

        <p>
            <b style="background-color: #993300">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </b>
        </p>

   </form>
</body>
</html>
