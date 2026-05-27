using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class UserSignUpForm : Form
    {
        Choice_of_UserTypeWindow ChoiceWindow; //toremovecommentafterintegration
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        userController usercontrollerObj;
        Controller controlObj = new Controller();
        public UserSignUpForm(Choice_of_UserTypeWindow ChoiceWindow)
        {
            InitializeComponent();
            usercontrollerObj = new userController();

            this.ChoiceWindow = ChoiceWindow;
            // Top Right Picture
            Image TopRight = Image.FromFile(@"..\..\Resources\Images\Ramen2.png");
            TopRightPic.Image = TopRight;
            TopRightPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Top Left picture
            Image TopLeft = Image.FromFile(@"..\..\Resources\Images\Chicken_Curry.png");
            TopLeftPic.Image = TopLeft;
            TopLeftPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Bottom Left picture
            Image BottomLeft = Image.FromFile(@"..\..\Resources\Images\Breakfast.png");
            BottomLeftPic.Image = BottomLeft;
            BottomLeftPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Bottom Right Picture
            Image BottomRight = Image.FromFile(@"..\..\Resources\Images\Ramen.png");
            BottomRightPic.Image = BottomRight;
            BottomRightPic.SizeMode = PictureBoxSizeMode.Zoom;

            // Form BG color
            this.BackColor = backgroundColor;

            // Labels BG Color();
        }
        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (EmailTB.Text == "Email") EmailTB.Text = "";
        }
        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "") EmailTB.Text = "Email";
        }
        private void PasswordTB_Enter(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "Password") PasswordTB.Text = "";
        }
        private void ConfirmPassTB_Enter(object sender, EventArgs e)
        {
            if (ConfirmPassTB.Text == "Confirm Password") ConfirmPassTB.Text = "";
        }
        private void ConfirmPassTB_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassTB.Text == "") ConfirmPassTB.Text = "Confirm Password";
        }
        private void FNameTB_Enter(object sender, EventArgs e)
        {
            if (FNameTB.Text == "Name") FNameTB.Text = "";
        }

        private void LNameTB_Enter(object sender, EventArgs e)
        {
            if (LNameTB.Text == "Name")
            { LNameTB.Text = ""; }
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsPasswordsMatch(string pass1, string pass2)
        {
            return pass1 == pass2;
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTB.Text;
            string confirmPassword = ConfirmPassTB.Text;
            bool EmailAvailable = usercontrollerObj.checkEmail(EmailTB.Text);
            if (!IsPasswordsMatch(password, confirmPassword))
            {
                MessageBox.Show("Passwords Do not Match!");
            }
            else if (EmailAvailable)
            {
                MessageBox.Show("You already have an Email! Please login.");
            }
            else
            {
                bool Added = usercontrollerObj.AddUser(FNameTB.Text, LNameTB.Text, EmailTB.Text, PasswordTB.Text);
                if (Added)
                {
                    MessageBox.Show("Successfuly Signed Up!");
                    int ID = controlObj.GetID(EmailTB.Text, "Users");
                    Form Newform = new Users1(ID);
                    Newform.Show();
                    this.Hide();

                }
                else MessageBox.Show("Failed to sign up. Please try again.");
            }
        }

        private void MatchPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void PassCharWarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void LNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToSeeYouLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExcitedLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeAreLabel_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void BottomRightPic_Click(object sender, EventArgs e)
        {

        }

        private void TopRightPic_Click(object sender, EventArgs e)
        {

        }
    }
}
