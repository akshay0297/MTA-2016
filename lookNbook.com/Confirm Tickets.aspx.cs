using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;

public partial class Default3 : System.Web.UI.Page
{
    string conStr = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        string sParam,seat="";
        sParam = Request.QueryString["param1"];
        int count,j=0;
        int[] seatNo = new int[10];
        count = Int32.Parse(sParam[183].ToString() + sParam[184].ToString());
        for (int i = 185; i < (185 + (count * 3)); i = i + 3)
        {
            seatNo[j] = Int32.Parse(sParam[i].ToString() + sParam[i + 1].ToString() + sParam[i + 2].ToString());
            seat = seat + seatNo[j]+" , ";
            j++;
        }
        lblCount.Text = count+"";
        lblSeats.Text = seat;
        lblAmount.Text = "Rs "+(count * 150);
        TextBox1.Focus();
    }

    protected void Reset1_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox1.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        string sParam;
        int count, id, ti, da, flag = 0,j=0;
        int[] seatNo = new int[10];
        sParam = Request.QueryString["param1"];
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 180; i++)
        {
            sb.Append("" + sParam[i]);
        }
        id = Int32.Parse(sParam[180].ToString());
        ti = Int32.Parse(sParam[182].ToString());
        da = Int32.Parse(sParam[181].ToString());

        string stime="";

        if (ti == 1)
        {
            stime = "09:00:00";
        }
        if (ti == 2)
        {
            stime = "12:00:00";
        }
        if (ti == 3)
        {
            stime = "15:00:00";
        }
        if (ti == 4)
        {
            stime = "18:00:00";
        }
        if (ti == 5)
        {
            stime = "21:00:00";
        }

        count = Int32.Parse(sParam[183].ToString() + sParam[184].ToString());
        for (int i = 185; i < (185 + (count * 3)); i = i + 3)
        {
            seatNo[j] = Int32.Parse(sParam[i].ToString() + sParam[i + 1].ToString() + sParam[i + 2].ToString());
            j++;
        }
        for (int i = 0; i < count; i++)
        {
            SqlConnection con = new SqlConnection(conStr);
            string qry;
            qry = "insert into Bookings values(@name , @phNo , @email ,@seatNo)";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@phNo", TextBox2.Text);
            cmd.Parameters.AddWithValue("@seatNo", "M" + id + "D" + da + "T" + ti + seatNo[i]);
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Label4.Text = err.Message;
                flag = 1;
            }
            finally
            {
                con.Close();
            }
        }
        if (flag != 1)
        {
            btnHome.Visible = true;
            btnTickets.Visible = true;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Reset1.Enabled = false;
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            Label4.Text = "Booking Succesful !";

            if (id == 1 || id == 4)
            {
                if (da == 1)
                {
                    //update into S1D1
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S1D1 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 2)
                {
                    //update into S1D2
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S1D2 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 3)
                {
                    //update into S1D3
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S1D3 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 4)
                {
                    //update into S1D4
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S1D4 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            if (id == 2 || id == 5)
            {
                if (da == 1)
                {
                    //update into S2D1
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S2D1 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 2)
                {
                    //update into S2D2
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S2D2 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 3)
                {
                    //update into S2D3
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S2D3 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 4)
                {
                    //update into S2D4
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S2D4 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            if (id == 3 || id == 6)
            {
                if (da == 1)
                {
                    //update into S3D1
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S3D1 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 2)
                {
                    //update into S3D2
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S3D2 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 3)
                {
                    //update into S3D3
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S3D3 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (da == 4)
                {
                    //update into S3D4
                    SqlConnection con = new SqlConnection(conStr);
                    string qry2;
                    qry2 = "update S3D4 set Seating =@seat where StartTime='" + stime + "'";
                    SqlCommand cmd = new SqlCommand(qry2, con);
                    cmd.Parameters.AddWithValue("@seat", sb.ToString());
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Label4.Text = err.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        Response.Redirect("Home.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        Response.Redirect("Home.aspx");
    }

    protected void btnTickets_Click(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        Response.Redirect("Review.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
