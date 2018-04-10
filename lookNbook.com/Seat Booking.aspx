<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Seat Booking.aspx.cs" Inherits="Seat_Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet2.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            background-color: #00FFFF;
        }
        #form1 {
            height: 482px;
        }
        .auto-style3 {
            font-size: x-large;
        }
    </style>
</head>
<body style="text-align: center; height: 518px;">
        <div>
    <h3><b style="background-color: #993300">&nbsp;&nbsp;<asp:Label ID="Label302" runat="server" Text="looknbook.com" Font-Bold="True" Font-Size="Large" ForeColor="#0099CC"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></h3>
     </div>
    <form id="form1" runat="server" visible="True">
        <p class="auto-style3" style="color: #FFFF00; height: 32px; background-color: #000000">
            <strong>SELECT YOUR SEATS !&nbsp;&nbsp;&nbsp; </strong>
            <asp:Button ID="btnSelect" runat="server" class="bitton3" Text="Start Selecting Seats !" OnClick="btnSelect_Click" />
        </p>
        <p style="margin-top: 41px" visible="False">
            <asp:Button ID="Button1" runat="server"  Height="39px" Text="" Width="39px" OnClick="Button1_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="39px" Text="" Width="39px" OnClick="Button2_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="39px" Text="" Width="39px" OnClick="Button3_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="39px" Text="" Width="39px" OnClick="Button4_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="39px" Text="" Width="39px" OnClick="Button5_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="39px" Text="" Width="39px" OnClick="Button6_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Height="39px" Text="" Width="39px" OnClick="Button7_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Height="39px" Text="" Width="39px" OnClick="Button8_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" Height="39px" Text="" Width="39px" OnClick="Button9_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" Height="39px" Text="" Width="39px" OnClick="Button10_Click" Enabled="False" />
        <br />
        <br />
        <asp:Button ID="Button11" runat="server" Height="25px" Text="" Width="27px" OnClick="Button11_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button12" runat="server" Height="25px" Text="" Width="27px" OnClick="Button12_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button13" runat="server" Height="25px" Text="" Width="27px" OnClick="Button13_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button14" runat="server" Height="25px" Text="" Width="27px" OnClick="Button14_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button15" runat="server" Height="25px" Text="" Width="27px" OnClick="Button15_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button16" runat="server" Height="25px" Text="" Width="27px" OnClick="Button16_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button17" runat="server" Height="25px" Text="" Width="27px" OnClick="Button17_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button18" runat="server" Height="25px" Text="" Width="27px" OnClick="Button18_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button19" runat="server" Height="25px" Text="" Width="27px" OnClick="Button19_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button20" runat="server" Height="25px" Text="" Width="27px" OnClick="Button20_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button21" runat="server" Height="25px" Text="" Width="27px" OnClick="Button21_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button22" runat="server" Height="25px" Text="" Width="27px" OnClick="Button22_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button23" runat="server" Height="25px" Text="" Width="27px" OnClick="Button23_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button24" runat="server" Height="25px" Text="" Width="27px" OnClick="Button24_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button25" runat="server" Height="25px" Text="" Width="27px" OnClick="Button25_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button26" runat="server" Height="25px" Text="" Width="27px" OnClick="Button26_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button27" runat="server" Height="25px" Text="" Width="27px" OnClick="Button27_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button28" runat="server" Height="25px" Text="" Width="27px" OnClick="Button28_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button29" runat="server" Height="25px" Text="" Width="27px" OnClick="Button29_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button30" runat="server" Height="25px" Text="" Width="27px" OnClick="Button30_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button31" runat="server" Height="25px" Text="" Width="27px" OnClick="Button31_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button32" runat="server" Height="25px" Text="" Width="27px" OnClick="Button32_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button33" runat="server" Height="25px" Text="" Width="27px" OnClick="Button33_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button34" runat="server" Height="25px" Text="" Width="27px" OnClick="Button34_Click" Enabled="False" />
        <br />
        <asp:Button ID="Button35" runat="server" Height="25px" Text="" Width="27px" OnClick="Button35_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button36" runat="server" Height="25px" Text="" Width="27px" OnClick="Button36_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button37" runat="server" Height="25px" Text="" Width="27px" OnClick="Button37_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button38" runat="server" Height="25px" Text="" Width="27px" OnClick="Button38_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button39" runat="server" Height="25px" Text="" Width="27px" OnClick="Button39_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button40" runat="server" Height="25px" Text="" Width="27px" OnClick="Button40_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button41" runat="server" Height="25px" Text="" Width="27px" OnClick="Button41_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button42" runat="server" Height="25px" Text="" Width="27px" OnClick="Button42_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button43" runat="server" Height="25px" Text="" Width="27px" OnClick="Button43_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button44" runat="server" Height="25px" Text="" Width="27px" OnClick="Button44_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button45" runat="server" Height="25px" Text="" Width="27px" OnClick="Button45_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button46" runat="server" Height="25px" Text="" Width="27px" OnClick="Button46_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button47" runat="server" Height="25px" Text="" Width="27px" OnClick="Button47_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button48" runat="server" Height="25px" Text="" Width="27px" OnClick="Button48_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button49" runat="server" Height="25px" Text="" Width="27px" OnClick="Button49_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button50" runat="server" Height="25px" Text="" Width="27px" OnClick="Button50_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button51" runat="server" Height="25px" Text="" Width="27px" OnClick="Button51_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button52" runat="server" Height="25px" Text="" Width="27px" OnClick="Button52_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button53" runat="server" Height="25px" Text="" Width="27px" OnClick="Button53_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button54" runat="server" Height="25px" Text="" Width="27px" OnClick="Button54_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button55" runat="server" Height="25px" Text="" Width="27px" OnClick="Button55_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button56" runat="server" Height="25px" Text="" Width="27px" OnClick="Button56_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button57" runat="server" Height="25px" Text="" Width="27px" OnClick="Button57_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button58" runat="server" Height="25px" Text="" Width="27px" OnClick="Button58_Click" Enabled="False" />
        <br />
        <asp:Button ID="Button59" runat="server" Height="25px" Text="" Width="27px" OnClick="Button59_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button60" runat="server" Height="25px" Text="" Width="27px" OnClick="Button60_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button61" runat="server" Height="25px" Text="" Width="27px" OnClick="Button61_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button62" runat="server" Height="25px" Text="" Width="27px" OnClick="Button62_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button63" runat="server" Height="25px" Text="" Width="27px" OnClick="Button63_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button64" runat="server" Height="25px" Text="" Width="27px" OnClick="Button64_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button65" runat="server" Height="25px" Text="" Width="27px" OnClick="Button65_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button66" runat="server" Height="25px" Text="" Width="27px" OnClick="Button66_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button67" runat="server" Height="25px" Text="" Width="27px" OnClick="Button67_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button68" runat="server" Height="25px" Text="" Width="27px" OnClick="Button68_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button69" runat="server" Height="25px" Text="" Width="27px" OnClick="Button69_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button70" runat="server" Height="25px" Text="" Width="27px" OnClick="Button70_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button71" runat="server" Height="25px" Text="" Width="27px" OnClick="Button71_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button72" runat="server" Height="25px" Text="" Width="27px" OnClick="Button72_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button73" runat="server" Height="25px" Text="" Width="27px" OnClick="Button73_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button74" runat="server" Height="25px" Text="" Width="27px" OnClick="Button74_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button75" runat="server" Height="25px" Text="" Width="27px" OnClick="Button75_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button76" runat="server" Height="25px" Text="" Width="27px" OnClick="Button76_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button77" runat="server" Height="25px" Text="" Width="27px" OnClick="Button77_Click" Enabled="False" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button78" runat="server" Height="25px" Text="" Width="27px" OnClick="Button78_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button79" runat="server" Height="25px" Text="" Width="27px" OnClick="Button79_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button80" runat="server" Height="25px" Text="" Width="27px" OnClick="Button80_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button81" runat="server" Height="25px" Text="" Width="27px" OnClick="Button81_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button82" runat="server" Height="25px" Text="" Width="27px" OnClick="Button82_Click" Enabled="False" />
        <br />
        <asp:Button ID="Button83" runat="server" Height="25px" Text="" Width="27px" OnClick="Button83_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button84" runat="server" Height="25px" Text="" Width="27px" OnClick="Button84_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button85" runat="server" Height="25px" Text="" Width="27px" OnClick="Button85_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button86" runat="server" Height="25px" Text="" Width="27px" OnClick="Button86_Click" Enabled="False" />
    &nbsp;<asp:Button ID="Button87" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button87_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button88" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button88_Click" />
    &nbsp;<asp:Button ID="Button89" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button89_Click" />
    &nbsp;<asp:Button ID="Button90" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button90_Click" />
    &nbsp;<asp:Button ID="Button91" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button91_Click" />
    &nbsp;<asp:Button ID="Button92" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button92_Click" />
    &nbsp;<asp:Button ID="Button93" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button93_Click" />
    &nbsp;<asp:Button ID="Button94" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button94_Click" />
    &nbsp;<asp:Button ID="Button95" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button95_Click" />
    &nbsp;<asp:Button ID="Button96" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button96_Click" />
    &nbsp;<asp:Button ID="Button97" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button97_Click" />
    &nbsp;<asp:Button ID="Button98" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button98_Click" />
    &nbsp;<asp:Button ID="Button99" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button99_Click" />
    &nbsp;<asp:Button ID="Button100" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button100_Click" />
    &nbsp;<asp:Button ID="Button101" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button101_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button102" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button102_Click" />
    &nbsp;<asp:Button ID="Button103" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button103_Click" />
    &nbsp;<asp:Button ID="Button104" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button104_Click" />
    &nbsp;<asp:Button ID="Button105" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button105_Click" />
    &nbsp;<asp:Button ID="Button106" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button106_Click" />
        <br />
        <asp:Button ID="Button107" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button107_Click" />
    &nbsp;<asp:Button ID="Button108" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button108_Click" />
    &nbsp;<asp:Button ID="Button109" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button109_Click" />
    &nbsp;<asp:Button ID="Button110" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button110_Click" />
    &nbsp;<asp:Button ID="Button111" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button111_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button112" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button112_Click" />
    &nbsp;<asp:Button ID="Button113" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button113_Click" />
    &nbsp;<asp:Button ID="Button114" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button114_Click" />
    &nbsp;<asp:Button ID="Button115" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button115_Click" />
    &nbsp;<asp:Button ID="Button116" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button116_Click" />
    &nbsp;<asp:Button ID="Button117" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button117_Click" />
    &nbsp;<asp:Button ID="Button118" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button118_Click" />
    &nbsp;<asp:Button ID="Button119" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button119_Click" />
    &nbsp;<asp:Button ID="Button120" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button120_Click" />
    &nbsp;<asp:Button ID="Button121" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button121_Click" />
    &nbsp;<asp:Button ID="Button122" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button122_Click" />
    &nbsp;<asp:Button ID="Button123" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button123_Click" />
    &nbsp;<asp:Button ID="Button124" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button124_Click" />
    &nbsp;<asp:Button ID="Button125" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button125_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button126" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button126_Click" />
    &nbsp;<asp:Button ID="Button127" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button127_Click" />
    &nbsp;<asp:Button ID="Button128" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button128_Click" />
    &nbsp;<asp:Button ID="Button129" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button129_Click" />
    &nbsp;<asp:Button ID="Button130" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button130_Click" />
        <br />
        <asp:Button ID="Button131" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button131_Click" />
    &nbsp;<asp:Button ID="Button132" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button132_Click" />
    &nbsp;<asp:Button ID="Button133" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button133_Click" />
    &nbsp;<asp:Button ID="Button134" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button134_Click" />
    &nbsp;<asp:Button ID="Button135" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button135_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button136" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button136_Click" />
    &nbsp;<asp:Button ID="Button137" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button137_Click" />
    &nbsp;<asp:Button ID="Button138" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button138_Click" />
    &nbsp;<asp:Button ID="Button139" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button139_Click" />
    &nbsp;<asp:Button ID="Button140" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button140_Click" />
    &nbsp;<asp:Button ID="Button141" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button141_Click" />
    &nbsp;<asp:Button ID="Button142" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button142_Click" />
    &nbsp;<asp:Button ID="Button143" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button143_Click" />
    &nbsp;<asp:Button ID="Button144" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button144_Click" />
    &nbsp;<asp:Button ID="Button145" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button145_Click" />
    &nbsp;<asp:Button ID="Button146" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button146_Click" />
    &nbsp;<asp:Button ID="Button147" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button147_Click" />
    &nbsp;<asp:Button ID="Button148" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button148_Click" />
    &nbsp;<asp:Button ID="Button149" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button149_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button150" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button150_Click" />
    &nbsp;<asp:Button ID="Button151" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button151_Click" />
    &nbsp;<asp:Button ID="Button152" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button152_Click" />
    &nbsp;<asp:Button ID="Button153" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button153_Click" />
    &nbsp;<asp:Button ID="Button154" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button154_Click" />
        <br />
        <br />
        <asp:Button ID="Button155" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button155_Click" />
    &nbsp;<asp:Button ID="Button156" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button156_Click" />
    &nbsp;<asp:Button ID="Button157" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button157_Click" />
    &nbsp;<asp:Button ID="Button158" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button158_Click" />
    &nbsp;<asp:Button ID="Button159" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button159_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button160" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button160_Click" />
    &nbsp;<asp:Button ID="Button161" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button161_Click" />
    &nbsp;<asp:Button ID="Button162" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button162_Click" />
    &nbsp;<asp:Button ID="Button163" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button163_Click" />
    &nbsp;<asp:Button ID="Button164" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button164_Click" />
        <br />
        <asp:Button ID="Button165" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button165_Click" />
    &nbsp;<asp:Button ID="Button166" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button166_Click" />
    &nbsp;<asp:Button ID="Button167" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button167_Click" />
    &nbsp;<asp:Button ID="Button168" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button168_Click" />
    &nbsp;<asp:Button ID="Button169" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button169_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button170" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button170_Click" />
    &nbsp;<asp:Button ID="Button171" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button171_Click" />
    &nbsp;<asp:Button ID="Button172" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button172_Click" />
    &nbsp;<asp:Button ID="Button173" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button173_Click" />
    &nbsp;<asp:Button ID="Button174" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button174_Click" />
        <br />
        <asp:Button ID="Button175" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button175_Click" />
    &nbsp;<asp:Button ID="Button176" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button176_Click" />
    &nbsp;<asp:Button ID="Button177" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button177_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button178" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button178_Click" />
    &nbsp;<asp:Button ID="Button179" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button179_Click" />
    &nbsp;<asp:Button ID="Button180" runat="server" Height="25px" Text="" Width="27px" Enabled="False" OnClick="Button180_Click" />
            <br />
            <br />
            <span class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="EXIT" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Large" ForeColor="Red"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label ID="Label1" runat="server" Text="Screen" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Large" ForeColor="#003366"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="EXIT" Font-Bold="True" Font-Names="Felix Titling" Font-Size="Large" ForeColor="Red"></asp:Label>
            </span>
        </p>
        <p style="margin-top: 32px">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </p>
        <p style="height: 25px; margin-top: 42px">
            <asp:Button ID="btnHome" runat="server" class="button1" Text="Go Home" OnClick="btnHome_Click" Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" class="button2" Text="SUBMIT SELECTION !" OnClick="btnSubmit_Click" Enabled="False" />
        </p>
    </form>
    </body>
</html>
