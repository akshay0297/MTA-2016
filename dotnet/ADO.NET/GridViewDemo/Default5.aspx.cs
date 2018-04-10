using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s;
        s = "Department ID: ";

        s += GridView1.SelectedRow.Cells[1].Text;
        s += "<br> Department name: ";
        s += GridView1.SelectedRow.Cells[2].Text;
        s += "<br> Division:";
        s += GridView1.SelectedRow.Cells[3].Text;
        Label1.Text = s;
    }
}