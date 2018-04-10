using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //check that the row is not a header/footer row
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            
            
            string s= (string)DataBinder.Eval(e.Row.DataItem, "GroupName");
            if (s =="Manufacturing")
            {
                e.Row.BackColor = System.Drawing.Color.Maroon;
                e.Row.ForeColor = System.Drawing.Color.White;
                e.Row.Font.Bold = true;
            }
        }
    }
}