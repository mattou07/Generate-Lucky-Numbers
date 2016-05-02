using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GenericsExample
{
    public partial class _Default : System.Web.UI.Page
    {
        People p = new People(); //calls the people class and returns a value 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Label1.Text = p.DisplayPeople();
        }
    }
}
