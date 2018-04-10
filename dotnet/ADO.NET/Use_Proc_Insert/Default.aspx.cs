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
    string connectionString = WebConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("proc_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", TextBox1.Text);
                cmd.Parameters.AddWithValue("@enm", TextBox2.Text);
                cmd.Parameters.AddWithValue("@dpt", TextBox3.Text);
                cmd.Parameters.AddWithValue("@desig", TextBox4.Text);
                con.Open();
                count = cmd.ExecuteNonQuery();
                Label1.Text = count.ToString() + " Records Inserted";
            }
        }
    }
}