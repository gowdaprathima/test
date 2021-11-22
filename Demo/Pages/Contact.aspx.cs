using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDOB.Text = "";
            lblResult.Text = "";
            DateTime Dob;
            if (Calendar1.SelectedDate >= DateTime.Now.Date)
                lblResult.Text = "Your DOB Can not be today or in future";
            else
                txtDOB.Text =  Calendar1.SelectedDate.ToString("dd/MM/yyyy");            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("/Pages/Welcome.aspx?FirstName={0}&LastName={1}&DOB={2}", txtFirstName .Text,txtFirstName .Text,txtDOB.Text));
            //Response.Redirect("/Pages/Welcome.aspx");
        }
    }
}