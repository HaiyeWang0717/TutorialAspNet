using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApplication
{
    public partial class NewsLetterSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ltMessage.Text = "Welcome to the NewsLetter Page.";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            //TODO: Validate and save email to data storage

            ltMessage.Text = "Your email has been subscribed to our newsletter.";
        }
    }
}