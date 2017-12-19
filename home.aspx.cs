using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("howto.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("aboutus.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String q="SELECT phone FROM PLAYER WHERE phone='"+TextBox1.Text+"'";
            DataSet ds=DbAccess.Fetch1(q);
        if(ds.Tables[0].Rows.Count==1)
        {
            Response.Redirect("game.aspx");
        }
     else
        {
            Response.Write("Not A Player Yet...");
        }

}
}