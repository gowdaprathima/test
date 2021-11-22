using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Demo.Classes;

namespace Demo.Pages
{    
    public partial class Welcome : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            Person person =new Person ();
            DOB dob=new DOB();
            CalculateAge calage = new CalculateAge();
            CountVowels NoOfVowels = new CountVowels();
            if(!Page.IsPostBack)
            {
                person.FirstName = Request.QueryString["FirstName"];
                person.LastName = Request.QueryString["LastName"];
                person.DOB = Convert.ToDateTime (Request.QueryString["DOB"]);
                lblWelcomeMessage.Text = "Welcome " + person.FirstName.ToString();
                lblCountOfVowels.Text = "Your name contain total of " + NoOfVowels.CalCulateVowels(person.FirstName.Trim()+ person.LastName.Trim()).ToString()+ " Vowels";
                lblAge.Text = "you are " + calage.Calcualteage(person.DOB).age.ToString() + " years Old and "+ calage.Calcualteage(person.DOB).days.ToString() + " days left for your next birthday";

            }
        }
    }
}