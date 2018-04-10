using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Text;

public partial class Seat_Booking : System.Web.UI.Page
{
    static int count=0;
    static int[] seatNo = new int[12];
    static string seat;
    protected void Page_Load(object sender, EventArgs e)
    {
        seat = Request.QueryString["param"];
        seat.ToCharArray();

        if (seat[0] == 'u')
        {
            Button1.BackColor = Color.Red;
        }
        if (seat[1] == 'u')
        {
            Button2.BackColor = Color.Red;
        }
        if (seat[2] == 'u')
        {
            Button3.BackColor = Color.Red;
        }
        if (seat[3] == 'u')
        {
            Button4.BackColor = Color.Red;
        }
        if (seat[4] == 'u')
        {
            Button5.BackColor = Color.Red;
        }
        if (seat[5] == 'u')
        {
            Button6.BackColor = Color.Red;
        }
        if (seat[6] == 'u')
        {
            Button7.BackColor = Color.Red;
        }
        if (seat[7] == 'u')
        {
            Button8.BackColor = Color.Red;
        }
        if (seat[8] == 'u')
        {
            Button9.BackColor = Color.Red;
        }
        if (seat[9] == 'u')
        {
            Button10.BackColor = Color.Red;
        }
        if (seat[10] == 'u')
        {
            Button11.BackColor = Color.Red;
        }
        if (seat[11] == 'u')
        {
            Button12.BackColor = Color.Red;
        }
        if (seat[12] == 'u')
        {
            Button13.BackColor = Color.Red;
        }
        if (seat[13] == 'u')
        {
            Button14.BackColor = Color.Red;
        }
        if (seat[14] == 'u')
        {
            Button15.BackColor = Color.Red;
        }
        if (seat[15] == 'u')
        {
            Button16.BackColor = Color.Red;
        }
        if (seat[16] == 'u')
        {
            Button17.BackColor = Color.Red;
        }
        if (seat[17] == 'u')
        {
            Button18.BackColor = Color.Red;
        }
        if (seat[18] == 'u')
        {
            Button19.BackColor = Color.Red;
        }
        if (seat[19] == 'u')
        {
            Button20.BackColor = Color.Red;
        }
        if (seat[20] == 'u')
        {
            Button21.BackColor = Color.Red;
        }
        if (seat[21] == 'u')
        {
            Button22.BackColor = Color.Red;
        }
        if (seat[22] == 'u')
        {
            Button23.BackColor = Color.Red;
        }
        if (seat[23] == 'u')
        {
            Button24.BackColor = Color.Red;
        }
        if (seat[24] == 'u')
        {
            Button25.BackColor = Color.Red;
        }
        if (seat[25] == 'u')
        {
            Button26.BackColor = Color.Red;
        }
        if (seat[26] == 'u')
        {
            Button27.BackColor = Color.Red;
        }
        if (seat[27] == 'u')
        {
            Button28.BackColor = Color.Red;
        }
        if (seat[28] == 'u')
        {
            Button29.BackColor = Color.Red;
        }
        if (seat[29] == 'u')
        {
            Button30.BackColor = Color.Red;
        }
        if (seat[30] == 'u')
        {
            Button31.BackColor = Color.Red;
        }
        if (seat[31] == 'u')
        {
            Button32.BackColor = Color.Red;
        }
        if (seat[32] == 'u')
        {
            Button33.BackColor = Color.Red;
        }
        if (seat[33] == 'u')
        {
            Button34.BackColor = Color.Red;
        }
        if (seat[34] == 'u')
        {
            Button35.BackColor = Color.Red;
        }
        if (seat[35] == 'u')
        {
            Button36.BackColor = Color.Red;
        }
        if (seat[36] == 'u')
        {
            Button37.BackColor = Color.Red;
        }
        if (seat[37] == 'u')
        {
            Button38.BackColor = Color.Red;
        }
        if (seat[38] == 'u')
        {
            Button39.BackColor = Color.Red;
        }
        if (seat[39] == 'u')
        {
            Button40.BackColor = Color.Red;
        }
        if (seat[40] == 'u')
        {
            Button41.BackColor = Color.Red;
        }
        if (seat[41] == 'u')
        {
            Button42.BackColor = Color.Red;
        }
        if (seat[42] == 'u')
        {
            Button43.BackColor = Color.Red;
        }
        if (seat[43] == 'u')
        {
            Button44.BackColor = Color.Red;
        }
        if (seat[44] == 'u')
        {
            Button45.BackColor = Color.Red;
        }
        if (seat[45] == 'u')
        {
            Button46.BackColor = Color.Red;
        }
        if (seat[46] == 'u')
        {
            Button47.BackColor = Color.Red;
        }
        if (seat[47] == 'u')
        {
            Button48.BackColor = Color.Red;
        }
        if (seat[48] == 'u')
        {
            Button49.BackColor = Color.Red;
        }
        if (seat[49] == 'u')
        {
            Button50.BackColor = Color.Red;
        }
        if (seat[50] == 'u')
        {
            Button51.BackColor = Color.Red;
        }
        if (seat[51] == 'u')
        {
            Button52.BackColor = Color.Red;
        }
        if (seat[52] == 'u')
        {
            Button53.BackColor = Color.Red;
        }
        if (seat[53] == 'u')
        {
            Button54.BackColor = Color.Red;
        }
        if (seat[54] == 'u')
        {
            Button55.BackColor = Color.Red;
        }
        if (seat[55] == 'u')
        {
            Button56.BackColor = Color.Red;
        }
        if (seat[56] == 'u')
        {
            Button57.BackColor = Color.Red;
        }
        if (seat[57] == 'u')
        {
            Button58.BackColor = Color.Red;
        }
        if (seat[58] == 'u')
        {
            Button59.BackColor = Color.Red;
        }
        if (seat[59] == 'u')
        {
            Button60.BackColor = Color.Red;
        }
        if (seat[60] == 'u')
        {
            Button61.BackColor = Color.Red;
        }
        if (seat[61] == 'u')
        {
            Button62.BackColor = Color.Red;
        }
        if (seat[62] == 'u')
        {
            Button63.BackColor = Color.Red;
        }
        if (seat[63] == 'u')
        {
            Button64.BackColor = Color.Red;
        }
        if (seat[64] == 'u')
        {
            Button65.BackColor = Color.Red;
        }
        if (seat[65] == 'u')
        {
            Button66.BackColor = Color.Red;
        }
        if (seat[66] == 'u')
        {
            Button67.BackColor = Color.Red;
        }
        if (seat[67] == 'u')
        {
            Button68.BackColor = Color.Red;
        }
        if (seat[68] == 'u')
        {
            Button69.BackColor = Color.Red;
        }
        if (seat[69] == 'u')
        {
            Button70.BackColor = Color.Red;
        }
        if (seat[70] == 'u')
        {
            Button71.BackColor = Color.Red;
        }
        if (seat[71] == 'u')
        {
            Button72.BackColor = Color.Red;
        }
        if (seat[72] == 'u')
        {
            Button73.BackColor = Color.Red;
        }
        if (seat[73] == 'u')
        {
            Button74.BackColor = Color.Red;
        }
        if (seat[74] == 'u')
        {
            Button75.BackColor = Color.Red;
        }
        if (seat[75] == 'u')
        {
            Button76.BackColor = Color.Red;
        }
        if (seat[76] == 'u')
        {
            Button77.BackColor = Color.Red;
        }
        if (seat[77] == 'u')
        {
            Button78.BackColor = Color.Red;
        }
        if (seat[78] == 'u')
        {
            Button79.BackColor = Color.Red;
        }
        if (seat[79] == 'u')
        {
            Button80.BackColor = Color.Red;
        }
        if (seat[80] == 'u')
        {
            Button81.BackColor = Color.Red;
        }
        if (seat[81] == 'u')
        {
            Button82.BackColor = Color.Red;
        }
        if (seat[82] == 'u')
        {
            Button83.BackColor = Color.Red;
        }
        if (seat[83] == 'u')
        {
            Button84.BackColor = Color.Red;
        }
        if (seat[84] == 'u')
        {
            Button85.BackColor = Color.Red;
        }
        if (seat[85] == 'u')
        {
            Button86.BackColor = Color.Red;
        }
        if (seat[86] == 'u')
        {
            Button87.BackColor = Color.Red;
        }
        if (seat[87] == 'u')
        {
            Button88.BackColor = Color.Red;
        }
        if (seat[88] == 'u')
        {
            Button89.BackColor = Color.Red;
        }
        if (seat[89] == 'u')
        {
            Button90.BackColor = Color.Red;
        }
        if (seat[90] == 'u')
        {
            Button91.BackColor = Color.Red;
        }
        if (seat[91] == 'u')
        {
            Button92.BackColor = Color.Red;
        }
        if (seat[92] == 'u')
        {
            Button93.BackColor = Color.Red;
        }
        if (seat[93] == 'u')
        {
            Button94.BackColor = Color.Red;
        }
        if (seat[94] == 'u')
        {
            Button95.BackColor = Color.Red;
        }
        if (seat[95] == 'u')
        {
            Button96.BackColor = Color.Red;
        }
        if (seat[96] == 'u')
        {
            Button97.BackColor = Color.Red;
        }
        if (seat[97] == 'u')
        {
            Button98.BackColor = Color.Red;
        }
        if (seat[98] == 'u')
        {
            Button99.BackColor = Color.Red;
        }
        if (seat[99] == 'u')
        {
            Button100.BackColor = Color.Red;
        }
        if (seat[100] == 'u')
        {
            Button101.BackColor = Color.Red;
        }
        if (seat[117] == 'u')
        {
            Button118.BackColor = Color.Red;
        }
        if (seat[101] == 'u')
        {
            Button102.BackColor = Color.Red;
        }
        if (seat[178] == 'u')
        {
            Button179.BackColor = Color.Red;
        }
        if (seat[102] == 'u')
        {
            Button103.BackColor = Color.Red;
        }
        if (seat[103] == 'u')
        {
            Button104.BackColor = Color.Red;
        }
        if (seat[104] == 'u')
        {
            Button105.BackColor = Color.Red;
        }
        if (seat[105] == 'u')
        {
            Button106.BackColor = Color.Red;
        }
        if (seat[106] == 'u')
        {
            Button107.BackColor = Color.Red;
        }
        if (seat[107] == 'u')
        {
            Button108.BackColor = Color.Red;
        }
        if (seat[108] == 'u')
        {
            Button109.BackColor = Color.Red;
        }
        if (seat[109] == 'u')
        {
            Button110.BackColor = Color.Red;
        }
        if (seat[110] == 'u')
        {
            Button111.BackColor = Color.Red;
        }
        if (seat[111] == 'u')
        {
            Button112.BackColor = Color.Red;
        }
        if (seat[112] == 'u')
        {
            Button113.BackColor = Color.Red;
        }
        if (seat[179] == 'u')
        {
            Button180.BackColor = Color.Red;
        }
        if (seat[113] == 'u')
        {
            Button114.BackColor = Color.Red;
        }
        if (seat[114] == 'u')
        {
            Button115.BackColor = Color.Red;
        }
        if (seat[115] == 'u')
        {
            Button116.BackColor = Color.Red;
        }
        if (seat[116] == 'u')
        {
            Button117.BackColor = Color.Red;
        }
        if (seat[118] == 'u')
        {
            Button119.BackColor = Color.Red;
        }
        if (seat[119] == 'u')
        {
            Button120.BackColor = Color.Red;
        }
        if (seat[120] == 'u')
        {
            Button121.BackColor = Color.Red;
        }
        if (seat[121] == 'u')
        {
            Button122.BackColor = Color.Red;
        }
        if (seat[122] == 'u')
        {
            Button123.BackColor = Color.Red;
        }
        if (seat[123] == 'u')
        {
            Button124.BackColor = Color.Red;
        }
        if (seat[124] == 'u')
        {
            Button125.BackColor = Color.Red;
        }
        if (seat[125] == 'u')
        {
            Button126.BackColor = Color.Red;
        }
        if (seat[126] == 'u')
        {
            Button127.BackColor = Color.Red;
        }
        if (seat[127] == 'u')
        {
            Button128.BackColor = Color.Red;
        }
        if (seat[128] == 'u')
        {
            Button129.BackColor = Color.Red;
        }
        if (seat[129] == 'u')
        {
            Button130.BackColor = Color.Red;
        }
        if (seat[130] == 'u')
        {
            Button131.BackColor = Color.Red;
        }
        if (seat[131] == 'u')
        {
            Button132.BackColor = Color.Red;
        }
        if (seat[132] == 'u')
        {
            Button133.BackColor = Color.Red;
        }
        if (seat[133] == 'u')
        {
            Button134.BackColor = Color.Red;
        }
        if (seat[134] == 'u')
        {
            Button135.BackColor = Color.Red;
        }
        if (seat[135] == 'u')
        {
            Button136.BackColor = Color.Red;
        }
        if (seat[136] == 'u')
        {
            Button137.BackColor = Color.Red;
        }
        if (seat[137] == 'u')
        {
            Button138.BackColor = Color.Red;
        }
        if (seat[138] == 'u')
        {
            Button139.BackColor = Color.Red;
        }
        if (seat[139] == 'u')
        {
            Button140.BackColor = Color.Red;
        }
        if (seat[140] == 'u')
        {
            Button141.BackColor = Color.Red;
        }
        if (seat[141] == 'u')
        {
            Button142.BackColor = Color.Red;
        }
        if (seat[142] == 'u')
        {
            Button143.BackColor = Color.Red;
        }
        if (seat[143] == 'u')
        {
            Button144.BackColor = Color.Red;
        }
        if (seat[144] == 'u')
        {
            Button145.BackColor = Color.Red;
        }
        if (seat[145] == 'u')
        {
            Button146.BackColor = Color.Red;
        }
        if (seat[146] == 'u')
        {
            Button147.BackColor = Color.Red;
        }
        if (seat[147] == 'u')
        {
            Button148.BackColor = Color.Red;
        }
        if (seat[148] == 'u')
        {
            Button149.BackColor = Color.Red;
        }
        if (seat[149] == 'u')
        {
            Button150.BackColor = Color.Red;
        }
        if (seat[150] == 'u')
        {
            Button151.BackColor = Color.Red;
        }
        if (seat[151] == 'u')
        {
            Button152.BackColor = Color.Red;
        }
        if (seat[152] == 'u')
        {
            Button153.BackColor = Color.Red;
        }
        if (seat[153] == 'u')
        {
            Button154.BackColor = Color.Red;
        }
        if (seat[154] == 'u')
        {
            Button155.BackColor = Color.Red;
        }
        if (seat[155] == 'u')
        {
            Button156.BackColor = Color.Red;
        }
        if (seat[156] == 'u')
        {
            Button157.BackColor = Color.Red;
        }
        if (seat[157] == 'u')
        {
            Button158.BackColor = Color.Red;
        }
        if (seat[158] == 'u')
        {
            Button159.BackColor = Color.Red;
        }
        if (seat[159] == 'u')
        {
            Button160.BackColor = Color.Red;
        }
        if (seat[160] == 'u')
        {
            Button161.BackColor = Color.Red;
        }
        if (seat[161] == 'u')
        {
            Button162.BackColor = Color.Red;
        }
        if (seat[162] == 'u')
        {
            Button163.BackColor = Color.Red;
        }
        if (seat[163] == 'u')
        {
            Button164.BackColor = Color.Red;
        }
        if (seat[164] == 'u')
        {
            Button165.BackColor = Color.Red;
        }
        if (seat[165] == 'u')
        {
            Button166.BackColor = Color.Red;
        }
        if (seat[166] == 'u')
        {
            Button167.BackColor = Color.Red;
        }
        if (seat[167] == 'u')
        {
            Button168.BackColor = Color.Red;
        }
        if (seat[168] == 'u')
        {
            Button169.BackColor = Color.Red;
        }
        if (seat[169] == 'u')
        {
            Button170.BackColor = Color.Red;
        }
        if (seat[170] == 'u')
        {
            Button171.BackColor = Color.Red;
        }
        if (seat[171] == 'u')
        {
            Button172.BackColor = Color.Red;
        }
        if (seat[172] == 'u')
        {
            Button173.BackColor = Color.Red;
        }
        if (seat[173] == 'u')
        {
            Button174.BackColor = Color.Red;
        }
        if (seat[174] == 'u')
        {
            Button175.BackColor = Color.Red;
        }
        if (seat[175] == 'u')
        {
            Button176.BackColor = Color.Red;
        }
        if (seat[176] == 'u')
        {
            Button177.BackColor = Color.Red;
        }
        if (seat[177] == 'u')
        {
            Button178.BackColor = Color.Red;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(count!=0)
        {
            StringBuilder sbParam = new StringBuilder();
            char seatCh;
            for (int i = 0; i < 183; i++)
            {
                if (i < 180)
                {
                    seatCh = seat[i];
                    for (int j = 0; j < count; j++)
                    {
                        if (i + 1 == seatNo[j])
                        {
                            seatCh = 'u';
                        }
                    }
                    sbParam.Append(seatCh);
                }
                else
                {
                    sbParam.Append(seat[i]);
                }
            }
            if(count==10)
            {
                sbParam.Append("" + count);
            }
            else
            {
                sbParam.Append("0" + count);
            }
            for(int i=0;i<count;i++)
            {
                if(seatNo[i]<=9)
                {
                    sbParam.Append("00"+seatNo[i]);
                }
                else if((seatNo[i]<=99)&&(seatNo[i]>=10))
                {
                    sbParam.Append("0"+seatNo[i]);
                }
                else
                {
                    sbParam.Append("" + seatNo[i]);
                }
            }
            Response.Redirect("Confirm Tickets.aspx?param1=" + sbParam);
        }
    }

    protected void btnSelect_Click(object sender, EventArgs e)
    {
        count = 0;
        for (int i = 0;i<10;i++)
        {
            seatNo[i] = 0;
        }
        btnSelect.Visible = false;
        btnSubmit.Enabled = true;
        Button1.Enabled = true;
        Button2.Enabled = true;
        Button3.Enabled = true;
        Button4.Enabled = true;
        Button5.Enabled = true;
        Button6.Enabled = true;
        Button7.Enabled = true;
        Button8.Enabled = true;
        Button9.Enabled = true;
        Button10.Enabled = true;
        Button11.Enabled = true;
        Button12.Enabled = true;
        Button13.Enabled = true;
        Button14.Enabled = true;
        Button15.Enabled = true;
        Button16.Enabled = true;
        Button17.Enabled = true;
        Button18.Enabled = true;
        Button19.Enabled = true;
        Button20.Enabled = true;
        Button21.Enabled = true;
        Button22.Enabled = true;
        Button23.Enabled = true;
        Button24.Enabled = true;
        Button25.Enabled = true;
        Button26.Enabled = true;
        Button27.Enabled = true;
        Button28.Enabled = true;
        Button29.Enabled = true;
        Button30.Enabled = true;
        Button31.Enabled = true;
        Button32.Enabled = true;
        Button33.Enabled = true;
        Button34.Enabled = true;
        Button35.Enabled = true;
        Button36.Enabled = true;
        Button37.Enabled = true;
        Button38.Enabled = true;
        Button39.Enabled = true;
        Button40.Enabled = true;
        Button41.Enabled = true;
        Button42.Enabled = true;
        Button43.Enabled = true;
        Button44.Enabled = true;
        Button45.Enabled = true;
        Button46.Enabled = true;
        Button47.Enabled = true;
        Button48.Enabled = true;
        Button49.Enabled = true;
        Button50.Enabled = true;
        Button51.Enabled = true;
        Button52.Enabled = true;
        Button53.Enabled = true;
        Button54.Enabled = true;
        Button55.Enabled = true;
        Button56.Enabled = true;
        Button57.Enabled = true;
        Button58.Enabled = true;
        Button59.Enabled = true;
        Button60.Enabled = true;
        Button61.Enabled = true;
        Button63.Enabled = true;
        Button62.Enabled = true;
        Button64.Enabled = true;
        Button65.Enabled = true;
        Button66.Enabled = true;
        Button67.Enabled = true;
        Button68.Enabled = true;
        Button69.Enabled = true;
        Button70.Enabled = true;
        Button71.Enabled = true;
        Button72.Enabled = true;
        Button73.Enabled = true;
        Button74.Enabled = true;
        Button75.Enabled = true;
        Button76.Enabled = true;
        Button78.Enabled = true;
        Button77.Enabled = true;
        Button79.Enabled = true;
        Button80.Enabled = true;
        Button81.Enabled = true;
        Button82.Enabled = true;
        Button83.Enabled = true;
        Button84.Enabled = true;
        Button85.Enabled = true;
        Button86.Enabled = true;
        Button87.Enabled = true;
        Button88.Enabled = true;
        Button89.Enabled = true;
        Button90.Enabled = true;
        Button91.Enabled = true;
        Button92.Enabled = true;
        Button93.Enabled = true;
        Button94.Enabled = true;
        Button95.Enabled = true;
        Button96.Enabled = true;
        Button99.Enabled = true;
        Button98.Enabled = true;
        Button97.Enabled = true;
        Button100.Enabled = true;
        Button101.Enabled = true;
        Button102.Enabled = true;
        Button103.Enabled = true;
        Button104.Enabled = true;
        Button105.Enabled = true;
        Button106.Enabled = true;
        Button107.Enabled = true;
        Button108.Enabled = true;
        Button109.Enabled = true;
        Button110.Enabled = true;
        Button111.Enabled = true;
        Button112.Enabled = true;
        Button113.Enabled = true;
        Button114.Enabled = true;
        Button115.Enabled = true;
        Button116.Enabled = true;
        Button117.Enabled = true;
        Button118.Enabled = true;
        Button119.Enabled = true;
        Button120.Enabled = true;
        Button121.Enabled = true;
        Button122.Enabled = true;
        Button123.Enabled = true;
        Button124.Enabled = true;
        Button125.Enabled = true;
        Button126.Enabled = true;
        Button127.Enabled = true;
        Button128.Enabled = true;
        Button129.Enabled = true;
        Button130.Enabled = true;
        Button131.Enabled = true;
        Button132.Enabled = true;
        Button133.Enabled = true;
        Button134.Enabled = true;
        Button135.Enabled = true;
        Button136.Enabled = true;
        Button137.Enabled = true;
        Button138.Enabled = true;
        Button139.Enabled = true;
        Button140.Enabled = true;
        Button141.Enabled = true;
        Button142.Enabled = true;
        Button143.Enabled = true;
        Button144.Enabled = true;
        Button145.Enabled = true;
        Button146.Enabled = true;
        Button147.Enabled = true;
        Button148.Enabled = true;
        Button149.Enabled = true;
        Button150.Enabled = true;
        Button151.Enabled = true;
        Button152.Enabled = true;
        Button153.Enabled = true;
        Button154.Enabled = true;
        Button155.Enabled = true;
        Button156.Enabled = true;
        Button157.Enabled = true;
        Button158.Enabled = true;
        Button159.Enabled = true;
        Button160.Enabled = true;
        Button161.Enabled = true;
        Button163.Enabled = true;
        Button162.Enabled = true;
        Button164.Enabled = true;
        Button165.Enabled = true;
        Button166.Enabled = true;
        Button167.Enabled = true;
        Button168.Enabled = true;
        Button169.Enabled = true;
        Button170.Enabled = true;
        Button171.Enabled = true;
        Button172.Enabled = true;
        Button173.Enabled = true;
        Button174.Enabled = true;
        Button175.Enabled = true;
        Button176.Enabled = true;
        Button178.Enabled = true;
        Button177.Enabled = true;
        Button179.Enabled = true;
        Button180.Enabled = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button1.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 1;
            }
        }
        else if (Button1.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button1.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 1)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Button2.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button2.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 2;
            }
        }
        else if (Button2.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button2.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 2)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Button3.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button3.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 3;
            }
        }
        else if (Button3.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button3.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 3)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Button4.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button4.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 4;
            }
        }
        else if (Button4.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button4.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 4)
                    
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Button5.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button5.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 5;
            }
        }
        else if (Button5.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button5.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 5)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (Button6.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button6.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 6;
            }
        }
        else if (Button6.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button6.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 6)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        if (Button7.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button7.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 7;
            }
        }
        else if (Button7.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button7.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 7)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (Button8.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button8.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 8;
            }
        }
        else if (Button8.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button8.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 8)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        if (Button9.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button9.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 9;
            }
        }
        else if (Button9.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button9.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 9)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        if (Button10.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button10.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 10;
            }
        }
        else if (Button10.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button10.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 10)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        if (Button11.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button11.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 11;
            }
        }
        else if (Button11.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button11.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 11)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        if (Button12.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button12.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 12;
            }
        }
        else if (Button12.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button12.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 12)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        if (Button13.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button13.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 13;
            }
        }
        else if (Button13.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button13.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 13)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        if (Button14.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button14.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 14;
            }
        }
        else if (Button14.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button14.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 14)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        if (Button15.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button15.BackColor = Color.Green;
                count++;
                seatNo[count - 1] =15;
            }
        }
        else if (Button15.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button15.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 15)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        if (Button16.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button16.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 16;
            }
        }
        else if (Button16.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button16.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 16)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        if (Button17.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button17.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 17;
            }
        }
        else if (Button17.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button17.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 17)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        if (Button18.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button18.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 18;
            }
        }
        else if (Button18.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button18.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 18)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        if (Button19.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button19.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 19;
            }
        }
        else if (Button19.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button19.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 19)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        if (Button20.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button20.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 20;
            }
        }
        else if (Button20.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button20.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 20)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        if (Button21.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button21.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 21;
            }
        }
        else if (Button21.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button21.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 21)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        if (Button22.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button22.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 22;
            }
        }
        else if (Button22.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button22.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 22)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button23_Click(object sender, EventArgs e)
    {
        if (Button23.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button23.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 23;
            }
        }
        else if (Button23.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button23.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 23)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button24_Click(object sender, EventArgs e)
    {
        if (Button24.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button24.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 24;
            }
        }
        else if (Button24.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button24.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 24)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button25_Click(object sender, EventArgs e)
    {
        if (Button25.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button25.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 25;
            }
        }
        else if (Button25.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button25.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 25)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button26_Click(object sender, EventArgs e)
    {
        if (Button26.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button26.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 26;
            }
        }
        else if (Button26.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button26.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 26)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button27_Click(object sender, EventArgs e)
    {
        if (Button27.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button27.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 27;
            }
        }
        else if (Button27.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button27.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 27)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button28_Click(object sender, EventArgs e)
    {
        if (Button28.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button28.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 28;
            }
        }
        else if (Button28.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button28.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 28)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button29_Click(object sender, EventArgs e)
    {
        if (Button29.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button29.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 29;
            }
        }
        else if (Button29.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button29.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 29)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button30_Click(object sender, EventArgs e)
    {
        if (Button30.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button30.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 30;
            }
        }
        else if (Button30.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button30.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 30)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button31_Click(object sender, EventArgs e)
    {
        if (Button31.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button31.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 31;
            }
        }
        else if (Button31.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button31.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 31)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button32_Click(object sender, EventArgs e)
    {
        if (Button32.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button32.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 32;
            }
        }
        else if (Button32.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button32.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 32)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button33_Click(object sender, EventArgs e)
    {
        if (Button33.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button33.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 33;
            }
        }
        else if (Button33.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button33.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 33)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button34_Click(object sender, EventArgs e)
    {
        if (Button34.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button34.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 34;
            }
        }
        else if (Button34.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button34.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 34)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button35_Click(object sender, EventArgs e)
    {
        if (Button35.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button35.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 35;
            }
        }
        else if (Button35.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button35.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 35)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button36_Click(object sender, EventArgs e)
    {
        if (Button36.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button36.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 36;
            }
        }
        else if (Button36.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button36.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 36)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button37_Click(object sender, EventArgs e)
    {
        if (Button37.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button37.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 37;
            }
        }
        else if (Button37.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button37.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 37)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button38_Click(object sender, EventArgs e)
    {
        if (Button38.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button38.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 38;
            }
        }
        else if (Button38.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button38.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 38)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button39_Click(object sender, EventArgs e)
    {
        if (Button39.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button39.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 39;
            }
        }
        else if (Button39.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button39.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 39)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button40_Click(object sender, EventArgs e)
    {
        if (Button40.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button40.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 40;
            }
        }
        else if (Button40.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button40.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 40)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button41_Click(object sender, EventArgs e)
    {
        if (Button41.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button41.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 41;
            }
        }
        else if (Button41.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button41.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 41)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button42_Click(object sender, EventArgs e)
    {
        if (Button42.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button42.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 42;
            }
        }
        else if (Button42.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button42.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 42)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button43_Click(object sender, EventArgs e)
    {
        if (Button43.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button43.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 43;
            }
        }
        else if (Button43.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button43.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 43)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button44_Click(object sender, EventArgs e)
    {
        if (Button44.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button44.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 44;
            }
        }
        else if (Button44.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button44.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 44)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button45_Click(object sender, EventArgs e)
    {
        if (Button45.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button45.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 45;
            }
        }
        else if (Button45.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button45.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 45)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button46_Click(object sender, EventArgs e)
    {
        if (Button46.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button46.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 46;
            }
        }
        else if (Button46.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button46.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 46)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button47_Click(object sender, EventArgs e)
    {
        if (Button47.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button47.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 47;
            }
        }
        else if (Button47.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button47.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 47)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button48_Click(object sender, EventArgs e)
    {
        if (Button48.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button48.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 48;
            }
        }
        else if (Button48.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button48.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 48)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button49_Click(object sender, EventArgs e)
    {
        if (Button49.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button49.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 49;
            }
        }
        else if (Button49.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button49.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 49)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button50_Click(object sender, EventArgs e)
    {
        if (Button50.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button50.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 50;
            }
        }
        else if (Button50.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button50.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 50)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button51_Click(object sender, EventArgs e)
    {
        if (Button51.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button51.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 51;
            }
        }
        else if (Button51.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button51.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 51)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button52_Click(object sender, EventArgs e)
    {
        if (Button52.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button52.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 52;
            }
        }
        else if (Button52.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button52.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 52)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button53_Click(object sender, EventArgs e)
    {
        if (Button53.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button53.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 53;
            }
        }
        else if (Button53.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button53.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 53)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button54_Click(object sender, EventArgs e)
    {
        if (Button54.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button54.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 54;
            }
        }
        else if (Button54.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button54.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 54)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button55_Click(object sender, EventArgs e)
    {
        if (Button55.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button55.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 55;
            }
        }
        else if (Button55.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button55.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 55)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button56_Click(object sender, EventArgs e)
    {
        if (Button56.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button56.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 56;
            }
        }
        else if (Button56.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button56.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 56)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button57_Click(object sender, EventArgs e)
    {
        if (Button57.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button57.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 57;
            }
        }
        else if (Button57.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button57.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 57)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button58_Click(object sender, EventArgs e)
    {
        if (Button58.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button58.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 58;
            }
        }
        else if (Button58.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button58.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 58)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button59_Click(object sender, EventArgs e)
    {
        if (Button59.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button59.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 59;
            }
        }
        else if (Button59.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button59.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 59)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button60_Click(object sender, EventArgs e)
    {
        if (Button60.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button60.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 60;
            }
        }
        else if (Button60.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button60.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 60)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button61_Click(object sender, EventArgs e)
    {
        if (Button61.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button61.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 61;
            }
        }
        else if (Button61.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button61.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 61)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button62_Click(object sender, EventArgs e)
    {
        if (Button62.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button62.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 62;
            }
        }
        else if (Button62.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button62.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 62)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button63_Click(object sender, EventArgs e)
    {
        if (Button63.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button63.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 63;
            }
        }
        else if (Button63.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button63.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 63)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button64_Click(object sender, EventArgs e)
    {
        if (Button64.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button64.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 64;
            }
        }
        else if (Button64.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button64.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 64)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button65_Click(object sender, EventArgs e)
    {
        if (Button65.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button65.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 65;
            }
        }
        else if (Button65.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button65.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 65)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button66_Click(object sender, EventArgs e)
    {
        if (Button66.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button66.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 66;
            }
        }
        else if (Button66.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button66.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 66)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button67_Click(object sender, EventArgs e)
    {
        if (Button67.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button67.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 67;
            }
        }
        else if (Button67.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button67.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 67)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button68_Click(object sender, EventArgs e)
    {
        if (Button68.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button68.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 68;
            }
        }
        else if (Button68.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button68.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 68)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button69_Click(object sender, EventArgs e)
    {
        if (Button69.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button69.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 69;
            }
        }
        else if (Button69.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button69.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 69)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button70_Click(object sender, EventArgs e)
    {
        if (Button70.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button70.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 70;
            }
        }
        else if (Button70.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button70.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 70)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button71_Click(object sender, EventArgs e)
    {
        if (Button71.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button71.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 71;
            }
        }
        else if (Button71.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button71.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 71)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button72_Click(object sender, EventArgs e)
    {
        if (Button72.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button72.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 72;
            }
        }
        else if (Button72.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button72.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 72)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button73_Click(object sender, EventArgs e)
    {
        if (Button73.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button73.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 73;
            }
        }
        else if (Button73.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button73.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 73)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button74_Click(object sender, EventArgs e)
    {
        if (Button74.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button74.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 74;
            }
        }
        else if (Button74.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button74.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 74)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button75_Click(object sender, EventArgs e)
    {
        if (Button75.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button75.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 75;
            }
        }
        else if (Button75.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button75.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 75)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button76_Click(object sender, EventArgs e)
    {
        if (Button76.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button76.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 76;
            }
        }
        else if (Button76.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button76.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 76)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button77_Click(object sender, EventArgs e)
    {
        if (Button77.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button77.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 77;
            }
        }
        else if (Button77.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button77.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 77)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button78_Click(object sender, EventArgs e)
    {
        if (Button78.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button78.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 78;
            }
        }
        else if (Button78.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button78.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 78)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button79_Click(object sender, EventArgs e)
    {
        if (Button79.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button79.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 79;
            }
        }
        else if (Button79.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button79.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 79)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button80_Click(object sender, EventArgs e)
    {
        if (Button80.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button80.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 80;
            }
        }
        else if (Button80.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button80.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 80)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button81_Click(object sender, EventArgs e)
    {
        if (Button81.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button81.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 81;
            }
        }
        else if (Button81.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button81.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 81)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button82_Click(object sender, EventArgs e)
    {
        if (Button82.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button82.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 82;
            }
        }
        else if (Button82.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button82.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 82)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button83_Click(object sender, EventArgs e)
    {
        if (Button83.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button83.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 83;
            }
        }
        else if (Button83.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button83.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 83)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button84_Click(object sender, EventArgs e)
    {
        if (Button84.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button84.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 84;
            }
        }
        else if (Button84.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button84.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 84)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button85_Click(object sender, EventArgs e)
    {
        if (Button85.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button85.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 85;
            }
        }
        else if (Button85.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button85.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 85)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button86_Click(object sender, EventArgs e)
    {
        if (Button86.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button86.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 86;
            }
        }
        else if (Button86.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button86.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 86)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button87_Click(object sender, EventArgs e)
    {
        if (Button87.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button87.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 87;
            }
        }
        else if (Button87.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button87.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 87)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button88_Click(object sender, EventArgs e)
    {
        if (Button88.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button88.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 88;
            }
        }
        else if (Button88.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button88.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 88)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button89_Click(object sender, EventArgs e)
    {
        if (Button89.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button89.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 89;
            }
        }
        else if (Button89.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button89.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 89)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button90_Click(object sender, EventArgs e)
    {
        if (Button90.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button90.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 90;
            }
        }
        else if (Button90.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button90.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 90)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button91_Click(object sender, EventArgs e)
    {
        if (Button91.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button91.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 91;
            }
        }
        else if (Button91.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button91.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 91)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button92_Click(object sender, EventArgs e)
    {
        if (Button92.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button92.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 92;
            }
        }
        else if (Button92.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button92.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 92)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button93_Click(object sender, EventArgs e)
    {
        if (Button93.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button93.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 93;
            }
        }
        else if (Button93.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button93.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 93)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button94_Click(object sender, EventArgs e)
    {
        if (Button94.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button94.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 94;
            }
        }
        else if (Button94.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button94.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 94)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button95_Click(object sender, EventArgs e)
    {
        if (Button95.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button95.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 95;
            }
        }
        else if (Button95.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button95.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 95)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button96_Click(object sender, EventArgs e)
    {
        if (Button96.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button96.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 96;
            }
        }
        else if (Button96.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button96.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 96)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button97_Click(object sender, EventArgs e)
    {
        if (Button97.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button97.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 97;
            }
        }
        else if (Button97.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button97.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 97)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button98_Click(object sender, EventArgs e)
    {
        if (Button98.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button98.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 98;
            }
        }
        else if (Button98.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button98.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 98)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button99_Click(object sender, EventArgs e)
    {
        if (Button99.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button99.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 99;
            }
        }
        else if (Button99.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button99.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 99)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button100_Click(object sender, EventArgs e)
    {
        if (Button100.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button100.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 100;
            }
        }
        else if (Button100.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button100.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 100)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }
    protected void Button101_Click(object sender, EventArgs e)
    {
        if (Button101.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button101.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 101;
            }
        }
        else if (Button101.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button101.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 101)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }
    protected void Button102_Click(object sender, EventArgs e)
    {
        if (Button102.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button102.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 102;
            }
        }
        else if (Button102.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button102.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 102)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button103_Click(object sender, EventArgs e)
    {
        if (Button103.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button103.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 103;
            }
        }
        else if (Button103.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button103.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 103)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button104_Click(object sender, EventArgs e)
    {
        if (Button104.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button104.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 104;
            }
        }
        else if (Button104.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button104.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 104)

                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button105_Click(object sender, EventArgs e)
    {
        if (Button105.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button105.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 105;
            }
        }
        else if (Button105.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button105.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 105)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button106_Click(object sender, EventArgs e)
    {
        if (Button106.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button106.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 106;
            }
        }
        else if (Button106.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button106.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 106)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button107_Click(object sender, EventArgs e)
    {
        if (Button107.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button107.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 107;
            }
        }
        else if (Button107.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button107.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 107)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button108_Click(object sender, EventArgs e)
    {
        if (Button108.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button108.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 108;
            }
        }
        else if (Button108.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button108.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 108)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button109_Click(object sender, EventArgs e)
    {
        if (Button109.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button109.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 109;
            }
        }
        else if (Button109.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button109.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 109)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button110_Click(object sender, EventArgs e)
    {
        if (Button110.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button110.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 110;
            }
        }
        else if (Button110.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button110.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] ==110)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button111_Click(object sender, EventArgs e)
    {
        if (Button111.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button111.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 111;
            }
        }
        else if (Button111.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button111.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 111)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button112_Click(object sender, EventArgs e)
    {
        if (Button112.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button112.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 112;
            }
        }
        else if (Button112.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button112.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 112)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button113_Click(object sender, EventArgs e)
    {
        if (Button113.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button113.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 113;
            }
        }
        else if (Button113.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button113.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 113)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button114_Click(object sender, EventArgs e)
    {
        if (Button114.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button114.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 114;
            }
        }
        else if (Button114.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button114.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] ==114)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button115_Click(object sender, EventArgs e)
    {
        if (Button115.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button115.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 115;
            }
        }
        else if (Button115.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button115.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 115)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button116_Click(object sender, EventArgs e)
    {
        if (Button116.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button116.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 116;
            }
        }
        else if (Button116.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button116.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 116)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button117_Click(object sender, EventArgs e)
    {
        if (Button117.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button117.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 117;
            }
        }
        else if (Button117.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button117.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 117)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button118_Click(object sender, EventArgs e)
    {
        if (Button118.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button118.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 118;
            }
        }
        else if (Button118.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button118.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 118)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button119_Click(object sender, EventArgs e)
    {
        if (Button119.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button119.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 119;
            }
        }
        else if (Button119.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button119.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 119)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button120_Click(object sender, EventArgs e)
    {
        if (Button120.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button20.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 20;
            }
        }
        else if (Button120.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button120.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 120)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button121_Click(object sender, EventArgs e)
    {
        if (Button121.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button121.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 121;
            }
        }
        else if (Button121.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button121.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 121)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button122_Click(object sender, EventArgs e)
    {
        if (Button122.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button122.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 122;
            }
        }
        else if (Button122.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button122.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 122)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button123_Click(object sender, EventArgs e)
    {
        if (Button123.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button123.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 123;
            }
        }
        else if (Button123.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button123.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 123)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button124_Click(object sender, EventArgs e)
    {
        if (Button124.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button124.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 124;
            }
        }
        else if (Button124.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button124.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 124)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button125_Click(object sender, EventArgs e)
    {
        if (Button125.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button125.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 125;
            }
        }
        else if (Button125.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button125.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 125)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button126_Click(object sender, EventArgs e)
    {
        if (Button126.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button126.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 26;
            }
        }
        else if (Button126.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button126.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 126)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button127_Click(object sender, EventArgs e)
    {
        if (Button127.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button127.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 127;
            }
        }
        else if (Button127.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button127.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 127)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button128_Click(object sender, EventArgs e)
    {
        if (Button128.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button128.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 128;
            }
        }
        else if (Button128.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button128.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 128)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button129_Click(object sender, EventArgs e)
    {
        if (Button129.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button129.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 129;
            }
        }
        else if (Button129.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button129.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 129)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button130_Click(object sender, EventArgs e)
    {
        if (Button130.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button130.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 130;
            }
        }
        else if (Button130.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button130.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 130)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button131_Click(object sender, EventArgs e)
    {
        if (Button131.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button131.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 131;
            }
        }
        else if (Button131.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button131.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 131)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button132_Click(object sender, EventArgs e)
    {
        if (Button132.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button132.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 132;
            }
        }
        else if (Button132.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button132.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 132)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button133_Click(object sender, EventArgs e)
    {
        if (Button133.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button133.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 133;
            }
        }
        else if (Button133.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button133.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 133)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button134_Click(object sender, EventArgs e)
    {
        if (Button134.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button134.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 134;
            }
        }
        else if (Button134.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button134.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 134)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button135_Click(object sender, EventArgs e)
    {
        if (Button135.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button135.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 135;
            }
        }
        else if (Button135.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button135.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 135)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button136_Click(object sender, EventArgs e)
    {
        if (Button136.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button136.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 136;
            }
        }
        else if (Button136.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button136.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 136)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button137_Click(object sender, EventArgs e)
    {
        if (Button137.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button137.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 137;
            }
        }
        else if (Button137.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button137.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 137)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button138_Click(object sender, EventArgs e)
    {
        if (Button138.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button138.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 138;
            }
        }
        else if (Button138.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button138.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 138)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button139_Click(object sender, EventArgs e)
    {
        if (Button139.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button139.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 139;
            }
        }
        else if (Button139.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button139.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 139)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button140_Click(object sender, EventArgs e)
    {
        if (Button140.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button140.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 140;
            }
        }
        else if (Button140.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button140.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 140)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button141_Click(object sender, EventArgs e)
    {
        if (Button141.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button141.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 141;
            }
        }
        else if (Button141.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button141.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 141)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button142_Click(object sender, EventArgs e)
    {
        if (Button142.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button142.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 142;
            }
        }
        else if (Button142.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button142.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 142)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button143_Click(object sender, EventArgs e)
    {
        if (Button143.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button143.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 143;
            }
        }
        else if (Button143.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button143.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 143)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button144_Click(object sender, EventArgs e)
    {
        if (Button144.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button144.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 144;
            }
        }
        else if (Button144.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button144.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 144)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button145_Click(object sender, EventArgs e)
    {
        if (Button145.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button145.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 145;
            }
        }
        else if (Button145.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button145.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 145)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button146_Click(object sender, EventArgs e)
    {
        if (Button146.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button146.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 146;
            }
        }
        else if (Button146.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button146.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 146)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button147_Click(object sender, EventArgs e)
    {
        if (Button147.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button147.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 147;
            }
        }
        else if (Button147.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button147.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 147)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button148_Click(object sender, EventArgs e)
    {
        if (Button148.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button148.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 148;
            }
        }
        else if (Button148.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button148.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 148)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button149_Click(object sender, EventArgs e)
    {
        if (Button149.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button149.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 149;
            }
        }
        else if (Button149.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button149.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 149)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button150_Click(object sender, EventArgs e)
    {
        if (Button150.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button150.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 150;
            }
        }
        else if (Button150.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button150.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 150)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button151_Click(object sender, EventArgs e)
    {
        if (Button151.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button151.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 151;
            }
        }
        else if (Button151.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button151.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 151)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button152_Click(object sender, EventArgs e)
    {
        if (Button152.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button152.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 152;
            }
        }
        else if (Button152.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button152.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 152)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button153_Click(object sender, EventArgs e)
    {
        if (Button153.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button153.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 153;
            }
        }
        else if (Button153.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button153.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 153)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button154_Click(object sender, EventArgs e)
    {
        if (Button154.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button154.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 154;
            }
        }
        else if (Button154.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button154.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 154)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button155_Click(object sender, EventArgs e)
    {
        if (Button155.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button155.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 155;
            }
        }
        else if (Button155.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button155.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 155)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button156_Click(object sender, EventArgs e)
    {
        if (Button156.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button156.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 156;
            }
        }
        else if (Button156.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button156.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 156)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button157_Click(object sender, EventArgs e)
    {
        if (Button157.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button157.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 157;
            }
        }
        else if (Button157.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button157.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 157)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button158_Click(object sender, EventArgs e)
    {
        if (Button158.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button158.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 158;
            }
        }
        else if (Button158.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button158.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 158)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button159_Click(object sender, EventArgs e)
    {
        if (Button159.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button159.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 159;
            }
        }
        else if (Button159.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button159.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 159)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button160_Click(object sender, EventArgs e)
    {
        if (Button160.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button160.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 160;
            }
        }
        else if (Button160.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button160.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 160)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button161_Click(object sender, EventArgs e)
    {
        if (Button161.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button161.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 161;
            }
        }
        else if (Button161.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button161.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 161)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button162_Click(object sender, EventArgs e)
    {
        if (Button162.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button162.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 162;
            }
        }
        else if (Button162.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button162.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 162)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button163_Click(object sender, EventArgs e)
    {
        if (Button163.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button163.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 163;
            }
        }
        else if (Button163.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button163.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 163)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button164_Click(object sender, EventArgs e)
    {
        if (Button164.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button164.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 164;
            }
        }
        else if (Button164.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button164.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 164)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button165_Click(object sender, EventArgs e)
    {
        if (Button165.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button165.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 165;
            }
        }
        else if (Button165.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button165.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 165)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button166_Click(object sender, EventArgs e)
    {
        if (Button166.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button166.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 166;
            }
        }
        else if (Button166.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button166.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 166)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button167_Click(object sender, EventArgs e)
    {
        if (Button167.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button167.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 167;
            }
        }
        else if (Button167.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button167.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 167)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button168_Click(object sender, EventArgs e)
    {
        if (Button168.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button168.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 168;
            }
        }
        else if (Button168.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button168.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 168)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button169_Click(object sender, EventArgs e)
    {
        if (Button169.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button169.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 169;
            }
        }
        else if (Button169.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button169.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 169)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button170_Click(object sender, EventArgs e)
    {
        if (Button170.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button170.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 170;
            }
        }
        else if (Button170.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button170.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 170)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button171_Click(object sender, EventArgs e)
    {
        if (Button171.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button171.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 171;
            }
        }
        else if (Button171.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button171.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 171)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button172_Click(object sender, EventArgs e)
    {
        if (Button172.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button172.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 172;
            }
        }
        else if (Button172.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button172.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 172)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button173_Click(object sender, EventArgs e)
    {
        if (Button173.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button173.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 173;
            }
        }
        else if (Button173.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button173.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 173)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button174_Click(object sender, EventArgs e)
    {
        if (Button174.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button174.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 174;
            }
        }
        else if (Button174.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button174.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 174)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button175_Click(object sender, EventArgs e)
    {
        if (Button175.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button175.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 175;
            }
        }
        else if (Button175.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button175.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 175)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button176_Click(object sender, EventArgs e)
    {
        if (Button176.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button176.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 176;
            }
        }
        else if (Button176.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button176.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 176)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button177_Click(object sender, EventArgs e)
    {
        if (Button177.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button177.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 177;
            }
        }
        else if (Button177.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button177.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 177)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button178_Click(object sender, EventArgs e)
    {
        if (Button178.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button178.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 178;
            }
        }
        else if (Button178.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button178.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 178)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button179_Click(object sender, EventArgs e)
    {
        if (Button179.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button179.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 179;
            }
        }
        else if (Button179.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button179.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 179)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void Button180_Click(object sender, EventArgs e)
    {
        if (Button180.BackColor == default(Color))
        {
            if (count >= 10)
            {
                lblMessage.Text = "Max Selection : 10";
            }
            else
            {
                Button180.BackColor = Color.Green;
                count++;
                seatNo[count - 1] = 180;
            }
        }
        else if (Button180.BackColor == Color.Green)
        {
            count--;
            lblMessage.Text = "";
            Button180.BackColor = default(Color);
            for (int i = 0; i <= count; i++)
            {
                if (seatNo[i] == 180)
                {
                    seatNo[i] = seatNo[i + 1];
                }
            }
        }
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}
