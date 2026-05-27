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
    public partial class CompanySignUpForm : Form
    {
        Choice_of_UserTypeWindow ChoiceWindow;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        CompanyController companyControlObj = new CompanyController();
        Controller controlObj = new Controller();
        public CompanySignUpForm(Choice_of_UserTypeWindow ChoiceWindow)
        {
            InitializeComponent();
            this.ChoiceWindow = ChoiceWindow;
            // Top Right Picture
            Image TopRight = Properties.Resources.Ramen;
            TopRightPic.Image = TopRight;
            TopRightPic.SizeMode = PictureBoxSizeMode.Zoom;
            // Top Left picture
            Image TopLeft = Properties.Resources.Ramen2;
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

            // Labels BG Color

        }
        /*
         CompanyID INT IDENTITY(1,1) PRIMARY KEY,
 Name VARCHAR(150) NOT NULL,
 Email VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(250) NOT NULL,
 Bio VARCHAR(150),
 ISApproved BIT NOT NULL DEFAULT 0,
 AdminID INT,
 FOREIGN KEY (AdminID) REFERENCES Users(UserID)
         */

        private void CompanySignUpForm_Load(object sender, EventArgs e)
        {

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

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "") PasswordTB.Text = "Password";
        }

        private void ConfirmPassTB_Enter(object sender, EventArgs e)
        {
            if (ConfirmPassTB.Text == "Confirm Password") ConfirmPassTB.Text = "";
        }

        private void ConfirmPassTB_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassTB.Text == "") ConfirmPassTB.Text = "Confirm Password";
        }

        private void NameTB_Enter(object sender, EventArgs e)
        {
            if (NameTB.Text == "Name") NameTB.Text = "";
        }

        private void NameTB_Leave(object sender, EventArgs e)
        {
            if (NameTB.Text == "") NameTB.Text = "Name";
        }

        private void BioTB_Enter(object sender, EventArgs e)
        {
            if (BioTB.Text == "Bio (Optional)") BioTB.Text = "";
        }

        private void BioTB_Leave(object sender, EventArgs e)
        {
            if (BioTB.Text == "") BioTB.Text = "Bio (Optional)";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTB.Text;
            string confirmPassword = ConfirmPassTB.Text;
            bool EmailAvailable = companyControlObj.checkEmail(EmailTB.Text);
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
                bool Added = companyControlObj.AddCompany(NameTB.Text, EmailTB.Text, PasswordTB.Text, BioTB.Text);
                if (Added)
                {
                    MessageBox.Show("Successfuly Signed Up!");
                    int ID = controlObj.GetID(EmailTB.Text, "Company");
                    NameTB.Text = "";
                    EmailTB.Text = "";
                    PasswordTB.Text = "";
                    ConfirmPassTB.Text = "";
                    BioTB.Text = "";
                    CompanyInitialWindow companyInitialWindow = new CompanyInitialWindow(ID);
                    companyInitialWindow.Show();
                    this.Hide();
                }
                else MessageBox.Show("Failed to sign up. Please try again.");
            }
        }
        public bool IsPasswordsMatch(string pass1, string pass2)
        {
            return pass1 == pass2;
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTB.Text.Length < 8) PassCharWarningLabel.Visible = true;
            else PassCharWarningLabel.Visible = false;
        }
        private void ConfirmPassTB_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPassTB.Text != PasswordTB.Text) MatchPassLabel.Visible = true;
            else MatchPassLabel.Visible = false;
        }

        private void TopRightPic_Click(object sender, EventArgs e)
        {

        }

        private void PassCharWarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void MatchPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanySignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChoiceWindow.Show();
        }
    }
}
