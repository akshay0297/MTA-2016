using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string conStr = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = (string)Session["title"];

        txtName.Focus();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    { 
                Page.Title = (string)Session["title"];


        DataTable data = new DataTable();
        data.Columns.Add("Name",typeof(string));
        data.Columns.Add("Phone No.", typeof(string));
        data.Columns.Add("Email id", typeof(string));
        data.Columns.Add("Movie", typeof(string));
        data.Columns.Add("Date", typeof(string));
        data.Columns.Add("Time", typeof(string));
        data.Columns.Add("Screen No.", typeof(int));
        data.Columns.Add("Seat No.", typeof(int));

        SqlConnection con = new SqlConnection(conStr);
        string qry="select * from Bookings where Name like '%"+txtName.Text+"%' and Mob_no like '%"+txtPh.Text+"%'";
        SqlCommand cmd = new SqlCommand(qry,con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int count, id, da, ti, seatNo,screenNo=0;
                string seat="",sName, sPh, sEmail, sSeat ,movieName ,stime="" ,sdate="";
                sName = reader["Name"].ToString();
                sPh = reader["Mob_no"].ToString();
                sEmail = reader["Email"].ToString();
                sSeat = reader["Seat_no"].ToString();
                id = Int32.Parse("" + sSeat[1]);
                da = Int32.Parse("" + sSeat[3]);
                ti = Int32.Parse("" + sSeat[5]);
                count = sSeat.Length;
                for(int i=6;i<count;i++)
                {
                    seat = seat + sSeat[i];
                }
                seatNo = Int32.Parse(seat);
                if (id == 1 || id == 4)
                {
                    screenNo = 1;
                }
                else if (id == 2 || id == 5)
                {
                    screenNo = 2;
                }
                else if (id == 3 || id == 6)
                {
                    screenNo = 3;
                }
                if (ti == 1)
                {
                    stime = "09:00:00";
                }
                else if (ti == 2)
                {
                    stime = "12:00:00";
                }
                else if (ti == 3)
                {
                    stime = "15:00:00";
                }
                else if (ti == 4)
                {
                    stime = "18:00:00";
                }
                else if (ti == 5)
                {
                    stime = "21:00:00";
                }
                if (da == 1)
                {
                    DateTime dt = DateTime.Today;
                    sdate = dt.ToString("dd/MM/yyyy");
                }
                else if (da == 2)
                {
                    DateTime dt = DateTime.Today.AddDays(1);
                    sdate = dt.ToString("dd/MM/yyyy");
                }
                else if (da == 3)
                {
                    DateTime dt = DateTime.Today.AddDays(2);
                    sdate = dt.ToString("dd/MM/yyyy");
                }
                else if (da == 4)
                {
                    DateTime dt = DateTime.Today.AddDays(3);
                    sdate = dt.ToString("dd/MM/yyyy");
                }
                SqlConnection con2 = new SqlConnection(conStr);
                string qry2 = "select Name from movies where MovieID = 'MI"+id+"'";
                SqlCommand cmd2 = new SqlCommand(qry2,con2);
                SqlDataReader reader2;
                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    movieName = reader2["Name"].ToString();
                    data.Rows.Add(sName, sPh, sEmail, movieName, sdate, stime, screenNo, seatNo);
                    reader2.Close();
                }
                catch(Exception err)
                {
                    lblMessage2.Text = err.Message;
                }
                finally
                {
                    con2.Close();
                }
            }
            reader.Close();
        }
        catch(Exception err)
        {
            lblMessage.Text = err.Message;
        }
        finally
        {
            con.Close();
        }
        GridView1.DataSource = data;
        GridView1.DataBind();
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
    Page.Title = (string)Session["title"];

    Response.Redirect("Home.aspx");
    }
  }