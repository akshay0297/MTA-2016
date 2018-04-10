using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    static DateTime date = DateTime.Today;
    static int flag = 0;
    static int dt = 0;
    static string screen, seat;
    static string mid;
    static string tim = "00:00:00";
    static string select_Query;
    string connectionString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
    string conStr = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

        int countDate = 0;
        DateTime dateCheck = DateTime.Today;

        for (countDate = 0; ; countDate++)
        {
            if (dateCheck == date.AddDays(countDate))
            {
                break;
            }
        }
        date = date.AddDays(countDate);
        flag = flag + countDate;
        if (countDate == 1)
        {
            string qryDel10 = "";
            string qryIns10 = "";
            string qryDel11 = "";
            string qryIns11 = "";
            string qryDel12 = "";
            string qryIns12 = "";
            SqlConnection con = new SqlConnection(conStr);
            string qryDel1 = "delete from S1D1";
            string qryIns1 = "insert into S1D1 select * from S1D2";
            string qryDel2 = "delete from S2D1";
            string qryIns2 = "insert into S2D1 select * from S2D2";
            string qryDel3 = "delete from S3D1";
            string qryIns3 = "insert into S3D1 select * from S3D2";
            string qryDel4 = "delete from S1D2";
            string qryIns4 = "insert into S1D2 select * from S1D3";
            string qryDel5 = "delete from S2D2";
            string qryIns5 = "insert into S2D2 select * from S2D3";
            string qryDel6 = "delete from S3D2";
            string qryIns6 = "insert into S3D2 select * from S3D3";
            string qryDel7 = "delete from S1D3";
            string qryIns7 = "insert into S1D3 select * from S1D4";
            string qryDel8 = "delete from S2D3";
            string qryIns8 = "insert into S2D3 select * from S2D4";
            string qryDel9 = "delete from S3D3";
            string qryIns9 = "insert into S3D3 select * from S3D4";
            if (flag % 2 != 0)
            {
                qryDel10 = "delete from S1D4";
                qryIns10 = "insert into S1D4 select * from S1Df";
                qryDel11 = "delete from S2D4";
                qryIns11 = "insert into S2D4 select * from S2Df";
                qryDel12 = "delete from S3D4";
                qryIns12 = "insert into S3D4 select * from S3Df";
            }
            else
            {
                qryDel10 = "delete from S1D4";
                qryIns10 = "insert into S1D4 select * from S1Ds";
                qryDel11 = "delete from S2D4";
                qryIns11 = "insert into S2D4 select * from S2Ds";
                qryDel12 = "delete from S3D4";
                qryIns12 = "insert into S3D4 select * from S3Ds";
            }
            string qryBookings1 = "select Seat_no from Bookings where Seat_no like 'M_D2T_%'";
            string qryBookings2 = "select Seat_no from Bookings where Seat_no like 'M_D3T_%'";
            string qryBookings3 = "select Seat_no from Bookings where Seat_no like 'M_D4T_%'";
            string qryBookingsDel = "delete from Bookings where Seat_no like 'M_D1T_%'";
            SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
            SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
            SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
            SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
            SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
            SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
            SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
            SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
            SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
            SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
            SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
            SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
            SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
            SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
            SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
            SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
            SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
            SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
            SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
            SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
            SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
            SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
            SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
            SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
            SqlCommand cmdBookings1 = new SqlCommand(qryBookings1, con);
            SqlCommand cmdBookings2 = new SqlCommand(qryBookings2, con);
            SqlCommand cmdBookings3 = new SqlCommand(qryBookings3, con);
            SqlCommand cmdBookingsDel = new SqlCommand(qryBookingsDel, con);
            SqlDataReader reader1;
            SqlDataReader reader2;
            SqlDataReader reader3;
            try
            {
                con.Open();
                cmdDel1.ExecuteNonQuery();
                cmdIns1.ExecuteNonQuery();
                cmdDel2.ExecuteNonQuery();
                cmdIns2.ExecuteNonQuery();
                cmdDel3.ExecuteNonQuery();
                cmdIns3.ExecuteNonQuery();
                cmdDel4.ExecuteNonQuery();
                cmdIns4.ExecuteNonQuery();
                cmdDel5.ExecuteNonQuery();
                cmdIns5.ExecuteNonQuery();
                cmdDel6.ExecuteNonQuery();
                cmdIns6.ExecuteNonQuery();
                cmdDel7.ExecuteNonQuery();
                cmdIns7.ExecuteNonQuery();
                cmdDel8.ExecuteNonQuery();
                cmdIns8.ExecuteNonQuery();
                cmdDel9.ExecuteNonQuery();
                cmdIns9.ExecuteNonQuery();
                cmdDel10.ExecuteNonQuery();
                cmdIns10.ExecuteNonQuery();
                cmdDel11.ExecuteNonQuery();
                cmdIns11.ExecuteNonQuery();
                cmdDel12.ExecuteNonQuery();
                cmdIns12.ExecuteNonQuery();
                cmdBookingsDel.ExecuteNonQuery();
                reader1 = cmdBookings1.ExecuteReader();

                while (reader1.Read())
                {
                    string Seat;
                    StringBuilder sbSeat = new StringBuilder();
                    int len;
                    Seat = reader1["Seat_no"].ToString();
                    len = Seat.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (i == 3)
                        {
                            sbSeat.Append("1");
                        }
                        else
                        {
                            sbSeat.Append(Seat[i]);
                        }
                    }
                    SqlConnection con2 = new SqlConnection(conStr);
                    string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                    SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                    try
                    {
                        con2.Open();
                        cmdBookingsUpd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        lblMessage.Text = err.Message;
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
                reader1.Close();
                reader2 = cmdBookings2.ExecuteReader();
                while (reader2.Read())
                {
                    string Seat;
                    StringBuilder sbSeat = new StringBuilder();
                    int len;
                    Seat = reader2["Seat_no"].ToString();
                    len = Seat.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (i == 3)
                        {
                            sbSeat.Append("2");
                        }
                        else
                        {
                            sbSeat.Append(Seat[i]);
                        }
                    }
                    SqlConnection con2 = new SqlConnection(conStr);
                    string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                    SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                    try
                    {
                        con2.Open();
                        cmdBookingsUpd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        lblMessage.Text = err.Message;
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
                reader2.Close();

                reader3 = cmdBookings3.ExecuteReader();
                while (reader3.Read())
                {
                    string Seat;
                    StringBuilder sbSeat = new StringBuilder();
                    int len;
                    Seat = reader3["Seat_no"].ToString();
                    len = Seat.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (i == 3)
                        {
                            sbSeat.Append("3");
                        }
                        else
                        {
                            sbSeat.Append(Seat[i]);
                        }
                    }
                    SqlConnection con2 = new SqlConnection(conStr);
                    string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                    SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                    try
                    {
                        con2.Open();
                        cmdBookingsUpd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        lblMessage.Text = err.Message;
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
                reader3.Close();
            }
            catch (Exception err)
            {
                lblMessage.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
        }
        else if (countDate == 2)
        {
            string qryDel7 = "";
            string qryIns7 = "";
            string qryDel8 = "";
            string qryIns8 = "";
            string qryDel9 = "";
            string qryIns9 = "";
            string qryDel10 = "";
            string qryIns10 = "";
            string qryDel11 = "";
            string qryIns11 = "";
            string qryDel12 = "";
            string qryIns12 = "";
            SqlConnection con = new SqlConnection(conStr);
            string qryDel1 = "delete from S1D1";
            string qryIns1 = "insert into S1D1 select * from S1D3";
            string qryDel2 = "delete from S2D1";
            string qryIns2 = "insert into S2D1 select * from S2D3";
            string qryDel3 = "delete from S3D1";
            string qryIns3 = "insert into S3D1 select * from S3D3";
            string qryDel4 = "delete from S1D2";
            string qryIns4 = "insert into S1D2 select * from S1D4";
            string qryDel5 = "delete from S2D2";
            string qryIns5 = "insert into S2D2 select * from S2D4";
            string qryDel6 = "delete from S3D2";
            string qryIns6 = "insert into S3D2 select * from S3D4";
            if (flag % 2 == 0)
            {
                qryDel7 = "delete from S1D3";
                qryIns7 = "insert into S1D3 select * from S1Df";
                qryDel8 = "delete from S2D3";
                qryIns8 = "insert into S2D3 select * from S2Df";
                qryDel9 = "delete from S3D3";
                qryIns9 = "insert into S3D3 select * from S3Df";
                qryDel10 = "delete from S1D4";
                qryIns10 = "insert into S1D4 select * from S1Ds";
                qryDel11 = "delete from S2D4";
                qryIns11 = "insert into S2D4 select * from S2Ds";
                qryDel12 = "delete from S3D4";
                qryIns12 = "insert into S3D4 select * from S3Ds";
            }
            else
            {
                qryDel7 = "delete from S1D3";
                qryIns7 = "insert into S1D3 select * from S1Ds";
                qryDel8 = "delete from S2D3";
                qryIns8 = "insert into S2D3 select * from S2Ds";
                qryDel9 = "delete from S3D3";
                qryIns9 = "insert into S3D3 select * from S3Ds";
                qryDel10 = "delete from S1D4";
                qryIns10 = "insert into S1D4 select * from S1Df";
                qryDel11 = "delete from S2D4";
                qryIns11 = "insert into S2D4 select * from S2Df";
                qryDel12 = "delete from S3D4";
                qryIns12 = "insert into S3D4 select * from S3Df";
            }
            string qryBookingsDel1 = "delete from Bookings where Seat_no like 'M_D1T_%'";
            string qryBookingsDel2 = "delete from Bookings where Seat_no like 'M_D2T_%'";
            string qryBookings1 = "select Seat_no from Bookings where Seat_no like 'M_D3T_%'";
            string qryBookings2 = "select Seat_no from Bookings where Seat_no like 'M_D4T_%'";
            SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
            SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
            SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
            SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
            SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
            SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
            SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
            SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
            SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
            SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
            SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
            SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
            SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
            SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
            SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
            SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
            SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
            SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
            SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
            SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
            SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
            SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
            SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
            SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
            SqlCommand cmdBookingsDel1 = new SqlCommand(qryBookingsDel1, con);
            SqlCommand cmdBookingsDel2 = new SqlCommand(qryBookingsDel2, con);
            SqlCommand cmdBookings1 = new SqlCommand(qryBookings1, con);
            SqlCommand cmdBookings2 = new SqlCommand(qryBookings2, con);
            SqlDataReader reader1;
            SqlDataReader reader2;
            try
            {
                con.Open();
                cmdDel1.ExecuteNonQuery();
                cmdIns1.ExecuteNonQuery();
                cmdDel2.ExecuteNonQuery();
                cmdIns2.ExecuteNonQuery();
                cmdDel3.ExecuteNonQuery();
                cmdIns3.ExecuteNonQuery();
                cmdDel4.ExecuteNonQuery();
                cmdIns4.ExecuteNonQuery();
                cmdDel5.ExecuteNonQuery();
                cmdIns5.ExecuteNonQuery();
                cmdDel6.ExecuteNonQuery();
                cmdIns6.ExecuteNonQuery();
                cmdDel7.ExecuteNonQuery();
                cmdIns7.ExecuteNonQuery();
                cmdDel8.ExecuteNonQuery();
                cmdIns8.ExecuteNonQuery();
                cmdDel9.ExecuteNonQuery();
                cmdIns9.ExecuteNonQuery();
                cmdDel10.ExecuteNonQuery();
                cmdIns10.ExecuteNonQuery();
                cmdDel11.ExecuteNonQuery();
                cmdIns11.ExecuteNonQuery();
                cmdDel12.ExecuteNonQuery();
                cmdIns12.ExecuteNonQuery();
                cmdBookingsDel1.ExecuteNonQuery();
                cmdBookingsDel2.ExecuteNonQuery();
                reader1 = cmdBookings1.ExecuteReader();

                while (reader1.Read())
                {
                    string Seat;
                    StringBuilder sbSeat = new StringBuilder();
                    int len;
                    Seat = reader1["Seat_no"].ToString();
                    len = Seat.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (i == 3)
                        {
                            sbSeat.Append("1");
                        }
                        else
                        {
                            sbSeat.Append(Seat[i]);
                        }
                    }
                    SqlConnection con2 = new SqlConnection(conStr);
                    string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                    SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                    try
                    {
                        con2.Open();
                        cmdBookingsUpd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        lblMessage.Text = err.Message;
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
                reader1.Close();
                reader2 = cmdBookings2.ExecuteReader();
                while (reader2.Read())
                {
                    string Seat;
                    StringBuilder sbSeat = new StringBuilder();
                    int len;
                    Seat = reader2["Seat_no"].ToString();
                    len = Seat.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (i == 3)
                        {
                            sbSeat.Append("2");
                        }
                        else
                        {
                            sbSeat.Append(Seat[i]);
                        }
                    }
                    SqlConnection con2 = new SqlConnection(conStr);
                    string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                    SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                    try
                    {
                        con2.Open();
                        cmdBookingsUpd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        lblMessage.Text = err.Message;
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
                reader2.Close();
            }
            catch (Exception err)
            {
                lblMessage.Text = err.Message;
            }
            finally
            {
                con.Close();
            }
        }
        else if (countDate == 3)
        {
            if (flag % 2 != 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1D4";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2D4";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3D4";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Df";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Df";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Df";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Ds";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Ds";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Ds";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Df";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Df";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Df";
                string qryBookingsDel1 = "delete from Bookings where Seat_no like 'M_D1T_%'";
                string qryBookingsDel2 = "delete from Bookings where Seat_no like 'M_D2T_%'";
                string qryBookingsDel3 = "delete from Bookings where Seat_no like 'M_D3T_%'";
                string qryBookings = "select Seat_no from Bookings where Seat_no like 'M_D4T_%'";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                SqlCommand cmdBookingsDel1 = new SqlCommand(qryBookingsDel1, con);
                SqlCommand cmdBookingsDel2 = new SqlCommand(qryBookingsDel2, con);
                SqlCommand cmdBookingsDel3 = new SqlCommand(qryBookingsDel3, con);
                SqlCommand cmdBookings = new SqlCommand(qryBookings, con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                    cmdBookingsDel1.ExecuteNonQuery();
                    cmdBookingsDel2.ExecuteNonQuery();
                    cmdBookingsDel3.ExecuteNonQuery();
                    reader = cmdBookings.ExecuteReader();
                    while (reader.Read())
                    {
                        string Seat;
                        StringBuilder sbSeat = new StringBuilder();
                        int len;
                        Seat = reader["Seat_no"].ToString();
                        len = Seat.Length;
                        for (int i = 0; i < len; i++)
                        {
                            if (i == 3)
                            {
                                sbSeat.Append("1");
                            }
                            else
                            {
                                sbSeat.Append(Seat[i]);
                            }
                        }
                        SqlConnection con2 = new SqlConnection(conStr);
                        string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                        SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                        try
                        {
                            con2.Open();
                            cmdBookingsUpd.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con2.Close();
                        }
                    }
                    reader.Close();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1D4";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2D4";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3D4";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Ds";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Ds";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Ds";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Df";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Df";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Df";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Ds";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Ds";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Ds";
                string qryBookingsDel1 = "delete from Bookings where Seat_no like 'M_D1T_%'";
                string qryBookingsDel2 = "delete from Bookings where Seat_no like 'M_D2T_%'";
                string qryBookingsDel3 = "delete from Bookings where Seat_no like 'M_D3T_%'";
                string qryBookings = "select Seat_no from Bookings where Seat_no like 'M_D4T_%'";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                SqlCommand cmdBookingsDel1 = new SqlCommand(qryBookingsDel1, con);
                SqlCommand cmdBookingsDel2 = new SqlCommand(qryBookingsDel2, con);
                SqlCommand cmdBookingsDel3 = new SqlCommand(qryBookingsDel3, con);
                SqlCommand cmdBookings = new SqlCommand(qryBookings, con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                    cmdBookingsDel1.ExecuteNonQuery();
                    cmdBookingsDel2.ExecuteNonQuery();
                    cmdBookingsDel3.ExecuteNonQuery();
                    reader = cmdBookings.ExecuteReader();
                    while (reader.Read())
                    {
                        string Seat;
                        StringBuilder sbSeat = new StringBuilder();
                        int len;
                        Seat = reader["Seat_no"].ToString();
                        len = Seat.Length;
                        for (int i = 0; i < len; i++)
                        {
                            if (i == 3)
                            {
                                sbSeat.Append("1");
                            }
                            else
                            {
                                sbSeat.Append(Seat[i]);
                            }
                        }
                        SqlConnection con2 = new SqlConnection(conStr);
                        string qryBookingsUpd = "update Bookings set Seat_no = '" + sbSeat + "' where Seat_no = '" + Seat + "'";
                        SqlCommand cmdBookingsUpd = new SqlCommand(qryBookingsUpd, con2);
                        try
                        {
                            con2.Open();
                            cmdBookingsUpd.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con2.Close();
                        }
                    }
                    reader.Close();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        else if ((countDate == 4) || ((countDate > 4) && ((countDate % 4 == 0) || (countDate % 4 == 2))))
        {
            if (flag % 2 == 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1Df";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2Df";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3Df";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Ds";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Ds";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Ds";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Df";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Df";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Df";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Ds";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Ds";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Ds";
                string qryBookingsDel = "delete from Bookings";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                SqlCommand cmdBookingsDel = new SqlCommand(qryBookingsDel, con);
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                    cmdBookingsDel.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1Ds";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2Ds";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3Ds";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Df";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Df";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Df";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Ds";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Ds";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Ds";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Df";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Df";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Df";
                string qryBookingsDel = "delete from Bookings";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                SqlCommand cmdBookingsDel = new SqlCommand(qryBookingsDel, con);
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                    cmdBookingsDel.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        else if ((countDate > 4) && ((countDate % 4 == 1) || (countDate % 4 == 3)))
        {
            if (flag % 2 != 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1Ds";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2Ds";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3Ds";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Df";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Df";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Df";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Ds";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Ds";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Ds";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Df";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Df";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Df";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                string qryDel1 = "delete from S1D1";
                string qryIns1 = "insert into S1D1 select * from S1Df";
                string qryDel2 = "delete from S2D1";
                string qryIns2 = "insert into S2D1 select * from S2Df";
                string qryDel3 = "delete from S3D1";
                string qryIns3 = "insert into S3D1 select * from S3Df";
                string qryDel4 = "delete from S1D2";
                string qryIns4 = "insert into S1D2 select * from S1Ds";
                string qryDel5 = "delete from S2D2";
                string qryIns5 = "insert into S2D2 select * from S2Ds";
                string qryDel6 = "delete from S3D2";
                string qryIns6 = "insert into S3D2 select * from S3Ds";
                string qryDel7 = "delete from S1D3";
                string qryIns7 = "insert into S1D3 select * from S1Df";
                string qryDel8 = "delete from S2D3";
                string qryIns8 = "insert into S2D3 select * from S2Df";
                string qryDel9 = "delete from S3D3";
                string qryIns9 = "insert into S3D3 select * from S3Df";
                string qryDel10 = "delete from S1D4";
                string qryIns10 = "insert into S1D4 select * from S1Ds";
                string qryDel11 = "delete from S2D4";
                string qryIns11 = "insert into S2D4 select * from S2Ds";
                string qryDel12 = "delete from S3D4";
                string qryIns12 = "insert into S3D4 select * from S3Ds";
                SqlCommand cmdIns1 = new SqlCommand(qryIns1, con);
                SqlCommand cmdIns2 = new SqlCommand(qryIns2, con);
                SqlCommand cmdIns3 = new SqlCommand(qryIns3, con);
                SqlCommand cmdIns4 = new SqlCommand(qryIns4, con);
                SqlCommand cmdIns5 = new SqlCommand(qryIns5, con);
                SqlCommand cmdIns6 = new SqlCommand(qryIns6, con);
                SqlCommand cmdIns7 = new SqlCommand(qryIns7, con);
                SqlCommand cmdIns8 = new SqlCommand(qryIns8, con);
                SqlCommand cmdIns9 = new SqlCommand(qryIns9, con);
                SqlCommand cmdIns10 = new SqlCommand(qryIns10, con);
                SqlCommand cmdIns11 = new SqlCommand(qryIns11, con);
                SqlCommand cmdIns12 = new SqlCommand(qryIns12, con);
                SqlCommand cmdDel1 = new SqlCommand(qryDel1, con);
                SqlCommand cmdDel2 = new SqlCommand(qryDel2, con);
                SqlCommand cmdDel3 = new SqlCommand(qryDel3, con);
                SqlCommand cmdDel4 = new SqlCommand(qryDel4, con);
                SqlCommand cmdDel5 = new SqlCommand(qryDel5, con);
                SqlCommand cmdDel6 = new SqlCommand(qryDel6, con);
                SqlCommand cmdDel7 = new SqlCommand(qryDel7, con);
                SqlCommand cmdDel8 = new SqlCommand(qryDel8, con);
                SqlCommand cmdDel9 = new SqlCommand(qryDel9, con);
                SqlCommand cmdDel10 = new SqlCommand(qryDel10, con);
                SqlCommand cmdDel11 = new SqlCommand(qryDel11, con);
                SqlCommand cmdDel12 = new SqlCommand(qryDel12, con);
                try
                {
                    con.Open();
                    cmdDel1.ExecuteNonQuery();
                    cmdIns1.ExecuteNonQuery();
                    cmdDel2.ExecuteNonQuery();
                    cmdIns2.ExecuteNonQuery();
                    cmdDel3.ExecuteNonQuery();
                    cmdIns3.ExecuteNonQuery();
                    cmdDel4.ExecuteNonQuery();
                    cmdIns4.ExecuteNonQuery();
                    cmdDel5.ExecuteNonQuery();
                    cmdIns5.ExecuteNonQuery();
                    cmdDel6.ExecuteNonQuery();
                    cmdIns6.ExecuteNonQuery();
                    cmdDel7.ExecuteNonQuery();
                    cmdIns7.ExecuteNonQuery();
                    cmdDel8.ExecuteNonQuery();
                    cmdIns8.ExecuteNonQuery();
                    cmdDel9.ExecuteNonQuery();
                    cmdIns9.ExecuteNonQuery();
                    cmdDel10.ExecuteNonQuery();
                    cmdIns10.ExecuteNonQuery();
                    cmdDel11.ExecuteNonQuery();
                    cmdIns11.ExecuteNonQuery();
                    cmdDel12.ExecuteNonQuery();
                    cmdIns12.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    lblMessage.Text = err.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        SqlConnection con3 = new SqlConnection(conStr);
        string qry = "select Seat_no from Bookings where Seat_no like 'M_D1T_%'";
        SqlCommand cmd = new SqlCommand(qry, con3);
        SqlDataReader readerBookings;
        try
        {
            con3.Open();
            readerBookings = cmd.ExecuteReader();
            while (readerBookings.Read())
            {
                string seat;
                seat = readerBookings["Seat_no"].ToString();
                int ti = Int32.Parse("" + seat[5]);
                if (ti == 1)
                {
                    DateTime dt = Convert.ToDateTime("09:00:00");
                    if (DateTime.Now > dt)
                    {
                        SqlConnection con4 = new SqlConnection(conStr);
                        string qry2 = "delete from Bookings where Seat_no = '" + seat + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con4);
                        try
                        {
                            con4.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
                else if (ti == 2)
                {
                    DateTime dt = Convert.ToDateTime("12:00:00");
                    if (DateTime.Now > dt)
                    {
                        SqlConnection con4 = new SqlConnection(conStr);
                        string qry2 = "delete from Bookings where Seat_no = '" + seat + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con4);
                        try
                        {
                            con4.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
                else if (ti == 3)
                {
                    DateTime dt = Convert.ToDateTime("15:00:00");
                    if (DateTime.Now > dt)
                    {
                        SqlConnection con4 = new SqlConnection(conStr);
                        string qry2 = "delete from Bookings where Seat_no = '" + seat + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con4);
                        try
                        {
                            con4.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
                else if (ti == 4)
                {
                    DateTime dt = Convert.ToDateTime("18:00:00");
                    if (DateTime.Now > dt)
                    {
                        SqlConnection con4 = new SqlConnection(conStr);
                        string qry2 = "delete from Bookings where Seat_no = '" + seat + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con4);
                        try
                        {
                            con4.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
                else if (ti == 5)
                {
                    DateTime dt = Convert.ToDateTime("21:00:00");
                    if (DateTime.Now > dt)
                    {
                        SqlConnection con4 = new SqlConnection(conStr);
                        string qry2 = "delete from Bookings where Seat_no = '" + seat + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con4);
                        try
                        {
                            con4.Open();
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            lblMessage.Text = err.Message;
                        }
                        finally
                        {
                            con4.Close();
                        }
                    }
                }
            }
            readerBookings.Close();
        }
        catch (Exception err)
        {
            lblMessage.Text = err.Message;
        }
        finally
        {
            con3.Close();
        }


        Page.Title = "Welcome to Movie Bookings!";
        string str, s;
        //str = Request.QueryString["param"];
        str = mid;
        if (str == "MI1" || str == "MI4")
        {
            s = "1";
        }
        else if (str == "MI2" || str == "MI5")
            s = "2";
        else
            s = "3";
        screen = s;
        /*if(DropDownList1.AutoPostBack)
        {
            Button3.Visible = true;
            DropDownList1.SelectedIndex = -1;
        }*/
        //Label100.Visible = false;
        //Label200.Visible = false;
        Button100.Visible = false;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Page.Title = "Welcome to Movie Bookings!";

        Button1.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["title"] = DropDownList1.SelectedItem.Text;
        Page.Title = (string)Session["title"];
        string str = "";
        str = DropDownList1.SelectedValue;
        mid = str;
        Label100.Visible = true;
        Label200.Visible = true;
        Button100.Visible = true;
        Button1.Visible = false;
        Label1.Visible = false;
        DropDownList1.Visible = false;
        string m = DropDownList1.SelectedItem.Text;
        Label3.Text = "Movie Selected : "+m;
        //Response.Redirect("default2.aspx?param="+str);

    }
    protected void Button100_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        Calendar1.Visible = true;

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        Page.Title = (string)Session["title"];

        // Select all dates in the past
        if (e.Day.Date < DateTime.Today || e.Day.Date > DateTime.Today.AddDays(3))
        {
            // Disable date
            e.Day.IsSelectable = false;
            // Change color of disabled date
            e.Cell.ForeColor = System.Drawing.Color.Gray;
            e.Cell.Font.Strikeout = true;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        DateTime d;
        d = Calendar1.SelectedDate;
        Label100.Text = "SELECTED Date:";
        Label200.Text = d.ToString("dd/MM/yyyy");
        Calendar1.Visible = false;
        Button200.Visible = true;
        if (d == DateTime.Today)
            dt = 1;
        else if (d == DateTime.Today.AddDays(1))
            dt = 2;
        else if (d == DateTime.Today.AddDays(2))
            dt = 3;
        else
            dt = 4;

    }

    protected void Button200_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        select_Query = " Select *";

        Label300.Text = "AVAILABLE TIMINGS:";
        //Label200.Visible = false;
        Button100.Visible = false;
        DropDownList10.Visible = true;
        DropDownList10.ClearSelection();
        Button200.Visible = false;
        if (screen == "1")
        {
            if (dt == 1)
            {
                select_Query = "Select * from S1D1 where MovieID = @movieid and StartTime > @starttime";
            }
            else if (dt == 2)
                select_Query = "Select * from S1D2 where MovieID = @movieid";
            else if (dt == 3)
                select_Query = "Select * from S1D3 where MovieID = @movieid";
            else if (dt == 4)
                select_Query = "Select * from S1D4 where MovieID = @movieid";
            else
            { }
        }
        else if (screen == "2")
        {
            if (dt == 1)
            {
                select_Query = "Select * from S2D1 where MovieID = @movieid and StartTime > @starttime";
            }
            else if (dt == 2)
                select_Query = "Select * from S2D2 where MovieID = @movieid";
            else if (dt == 3)
                select_Query = "Select * from S2D3 where MovieID = @movieid";
            else if (dt == 4)
                select_Query = "Select * from S2D4 where MovieID = @movieid";
            else
            { }
        }
        else if (screen == "3")
        {
            if (dt == 1)
            {
                select_Query = "Select * from S3D1 where MovieID = @movieid and StartTime > @starttime;";
            }
            else if (dt == 2)
                select_Query = "Select * from S3D2 where MovieID = @movieid";
            else if (dt == 3)
                select_Query = "Select * from S3D3 where MovieID = @movieid";
            else if (dt == 4)
                select_Query = "Select * from S3D4 where MovieID = @movieid";
            else
            { }
        }
        else
        { }
        FillList();
        Button300.Visible = true;
    }
    protected void FillList()
    {
        Page.Title = (string)Session["title"];

        string t = System.DateTime.Now.ToString("HH:mm:ss");
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand(select_Query, con);
        cmd.Parameters.AddWithValue("@movieid", mid);
        cmd.Parameters.AddWithValue("@starttime", t);
        SqlDataReader reader;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListItem newItem = new ListItem();
                newItem.Text = reader["StartTime"].ToString();
                newItem.Value = reader["StartTime"].ToString();
                DropDownList10.Items.Add(newItem);
            }
            reader.Close();
        }
        catch (Exception err)
        {
            Label200.Text = "Error reading the IDs";
            Label200.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void Button300_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        char m = mid[2];
        tim = DropDownList10.SelectedItem.Text.ToString();
        
            if (screen == "1")
            {
                    if (dt == 1)
                    {
                             select_Query = "Select * from S1D1 where MovieID = @movieid and StartTime = @starttime;";
                    }
                    else if (dt == 2)
                            select_Query = "Select * from S1D2 where MovieID = @movieid and StartTime = @starttime;";
                    else if (dt == 3)
                            select_Query = "Select * from S1D3 where MovieID = @movieid and StartTime = @starttime;";
                    else if (dt == 4)
                             select_Query = "Select * from S1D4 where MovieID = @movieid and StartTime = @starttime;";
                    else
                        { }         
            }
            else if (screen == "2")
            {
                    if (dt == 1)
                    {
                            select_Query = "Select * from S2D1 where MovieID = @movieid and StartTime = @starttime;";
                    }
                    else if (dt == 2)
                            select_Query = "Select * from S2D2 where MovieID = @movieid and StartTime = @starttime;";
                    else if (dt == 3)
                            select_Query = "Select * from S2D3 where MovieID = @movieid and StartTime = @starttime;";
                    else if (dt == 4)
                            select_Query = "Select * from S2D4 where MovieID = @movieid and StartTime = @starttime;";
                    else
                    { }
            }   
            else if (screen == "3")
            {
                if (dt == 1)
                {
                    select_Query = "Select * from S3D1 where MovieID = @movieid and StartTime = @starttime;";
                }
                else if (dt == 2)
                    select_Query = "Select * from S3D2 where MovieID = @movieid and StartTime = @starttime;";
                else if (dt == 3)
                    select_Query = "Select * from S3D3 where MovieID = @movieid and StartTime = @starttime;";
                else if (dt == 4)
                    select_Query = "Select * from S3D4 where MovieID = @movieid and StartTime = @starttime;";
                else
                    { }
            }
            else
                { }
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(select_Query, con);
        cmd.Parameters.AddWithValue("@movieid", mid);
        cmd.Parameters.AddWithValue("@starttime", tim);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            seat = reader["seating"].ToString();

            reader.Close();
        }
        catch (Exception err)
        {
            Label200.Text = "Error reading the IDs";
            Label200.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        if (tim == "09:00:00")
        {
            tim = "1";
        }
        else if (tim == "12:00:00")
            tim = "2";
        else if (tim == "15:00:00")
            tim = "3";
        else if (tim == "18:00:00")
            tim = "4";
        else if (tim == "21:00:00")
            tim = "5";
        else { tim = "-999"; }
        //Label300.Text = seat + m + dt + tim;
        Response.Redirect("Seat Booking.aspx?param=" +seat+m+dt+tim);
        //Response.Redirect("Seat Booking.aspx");
    }

    protected void btnReview_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        Response.Redirect("Review.aspx");
    }
}