using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> fruit = new List<string>();
        fruit.Add("Kiwi");
        fruit.Add("Pear");
        fruit.Add("Mango");
        fruit.Add("Blueberry");
        fruit.Add("Apricot");
        fruit.Add("Banana");
        fruit.Add("Peach");
        fruit.Add("Plum");
        ListBox1.DataSource = fruit;
        this.DataBind();
    }
}