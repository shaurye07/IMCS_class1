using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Boolean isValidPassword(String Pass)
        {
            return false;
        }

        private bool isValidEmail(String email)
        {
            return true;
        }

        private bool isValidPhone(String phone)
        {
            return true;
        }
        protected void Submit_Click(object sender, EventArgs e)

        {
            Boolean result;
            String Password = text_Passwd.Text;
            String ConfirmPassword = text_ConfirmPasswd.Text;
            String Email = text_email.Text;
            String Phone = text_Cell.Text;

            if (isValidEmail(Email))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Please Enter a valid Email");
                result = false;
            }

            if (isValidPassword(Password))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Please follow password Guidelines");
                result = false;
            }

            if (isValidPassword(ConfirmPassword))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Please follow password Guidelines");
                result = false;
            }

            if (isValidPhone(Phone))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Please enter valid phone number");
                result = false;
            }


            if (result)
            {
                MessageBox.Show("Success !!");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        protected void text_email_TextChanged(object sender, EventArgs e)
        {
            if (isValidEmail(text_email.Text))
            {
                MessageBox.Show("Enter Valid Password");
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}