using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    //AutoPostBack property of the list box is set to true so that its change events are detected automatically.

    string conString = @"Data Source=MIT-DEPT-123\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=SSPI";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillList();
        }

    }
    private void FillList()
    {
        ListBox1.Items.Clear();
        
        SqlConnection con = new SqlConnection(conString);

        string sel_query = "select DepartmentID from HumanResources.Department order by DepartmentID";
        SqlCommand cmd = new SqlCommand(sel_query, con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListItem newItem = new ListItem();
                newItem.Text = reader["DepartmentID"].ToString();
                newItem.Value = reader["DepartmentID"].ToString();
                ListBox1.Items.Add(newItem);
            }
            reader.Close();
        }
        catch (Exception err)
        {
            Label2.Text = "Error reading the IDs";
            Label2.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        string selectSQL;
        
       
        //parameterized query
        selectSQL = "SELECT * FROM HumanResources.Department where DepartmentID=@id";


        SqlConnection con = new SqlConnection(conString);

        SqlDataReader reader;
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        cmd.Parameters.AddWithValue("@id",ListBox1.SelectedItem.Value);
        try
        {
        // Define the ADO.NET objects.
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
           
           // Build a string with the record information,
            // and display that in a label.
            StringBuilder sb = new StringBuilder();
            sb.Append("<b>");
            sb.Append(reader["Name"]);
            sb.Append(", ");
            sb.Append(reader["GroupName"]);
            sb.Append("</b><br />");
            Label2.Text = sb.ToString();
            reader.Close();
        }
        catch (Exception err)
        {
            Label2.Text = "Error getting the details. ";
            Label2.Text += err.Message;
            Label2.Text += err.StackTrace;
        }
        finally
        {
            con.Close();
        }
    }
    
}