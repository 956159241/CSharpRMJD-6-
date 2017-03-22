using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventRegistration
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void labelResult_Load(object sender, EventArgs e)
        {
            try
            {
                DropDownList dropDownListEvents = (DropDownList)PreviousPage.FindControl("dropDownListEvents");
                string selectEvent = dropDownListEvents.SelectedValue;
                string firstName = ((TextBox)PreviousPage.FindControl("textFirstName")).Text;
                string lastName = ((TextBox)PreviousPage.FindControl("lastFirstName")).Text;
                string email = ((TextBox)PreviousPage.FindControl("text.Email")).Text;
                labelResult.Text = String.Format("{0}{1} selected the event {2}",firstName,lastName,selectEvent);
            }
            catch
            {
                labelResult.Text = "The originating page must contain textFirstName,textLastName,textEmail controls";
            }
        }
    }
}