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
    private string connectionString =WebConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            // Define the ADO.NET objects .
            string selectSQL = "SELECT DepartmentID,Name FROM HumanResources.Department";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            // Open the connection.
            con.Open();
            // Define the binding.
            ListBox1.DataSource = cmd.ExecuteReader();
            ListBox1.DataTextField = "Name";
            ListBox1.DataValueField = "DepartmentID";
            // Activate the binding.
            this.DataBind();
            con.Close();
            // Make sure nothing is currently selected in the list box.
            ListBox1.SelectedIndex = -1;
        }
    }
}