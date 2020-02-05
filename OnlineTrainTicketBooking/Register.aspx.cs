using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTrainTicketBooking
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string name =txtName.Text;
            string email =txtMailId.Text;
            string mailId = txtMailId.Text;
            DateTime dateOfBirth = DateTime.Parse(txtDob.Text);
            //string gender = txtgender;
            Int64 mobileNumber = Int64.Parse(txtMobilenumber.Text);
            //string nationality = nationality;
        }
    }
}