using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*int clickcount = 1;*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*if (ViewState["clicks"]!=null)
            {
                clickcount = (int)ViewState["clicks"] + 1;
            }
            TextBox1.Text=clickcount.ToString();
            ViewState["clicks"]=clickcount;*/
            int clickcount = Convert.ToInt32(TextBox1.Text)+1;
            TextBox1.Text=clickcount.ToString();
            if (clickcount > 10)
            {
                Label1.Text = "Limit reached";
                clickcount = 0;
                Button1.Visible= false;
            }
        }
    }
}