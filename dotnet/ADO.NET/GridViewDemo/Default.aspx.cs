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
    protected void Page_Load(object sender, EventArgs e)
    {
        //displaying data inside the grid

        string connectionString = WebConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;
        string selectSQL = "SELECT * FROM HumanResources.Department";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        // Fill the DataSet.
       
        DataSet ds = new DataSet();
        adapter.Fill(ds, "HumanResources.Department");
        // Perform the binding.
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}