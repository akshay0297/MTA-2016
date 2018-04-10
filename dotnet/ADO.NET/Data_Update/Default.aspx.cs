using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class _Default : System.Web.UI.Page
{
    string connectionString = WebConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string insert_Query;
        insert_Query = "INSERT INTO Employee (";
        insert_Query += "EmpID,EName,Dept,Designation)";
        insert_Query += "values(";
        insert_Query += "@eid,@enm,@dpt,@desig)";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insert_Query, con);


        cmd.Parameters.AddWithValue("@eid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@enm", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dpt", TextBox3.Text);
        cmd.Parameters.AddWithValue("@desig", TextBox4.Text);


        int count = 0;
        try
        {
            con.Open();
            count = cmd.ExecuteNonQuery();
            Label1.Text = count.ToString() + " Records Inserted";
        }
        catch (Exception err)
        {
            Label1.Text = "Error inserting records";
            Label1.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
}