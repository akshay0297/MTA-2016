using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        count = 10;
        this.DataBind();
        /*
         * If you decide not to use single-value data binding, you can accomplish the same thing by using code
         
         * TransactionCount = 10;
           lblDynamic.Text = "There were " + TransactionCount.ToString();
            lblDynamic.Text += " transactions today. ";
        */

    }
}