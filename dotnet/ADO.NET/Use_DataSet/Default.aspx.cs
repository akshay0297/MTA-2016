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
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        string selectSQL;
        selectSQL = "Select DepartmentID,Name,GroupName from HumanResources.Department";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        ds = new DataSet();
        con.Open();
        adapter.Fill(ds, "HumanResources.Department");
       
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string str;
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            str = row[0] + " " + row[1] + " " + row[2] +  "<br>";
            Label1.Text += str;
        }

    }
    
}