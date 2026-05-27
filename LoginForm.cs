using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class LoginForm : Form
    {
        Welcome welcomeForm;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        Controller controlObj = new Controller();

        public LoginForm(Welcome welcomeForm)
        {
            InitializeComponent();
            // Save previous Form
            this.welcomeForm = welcomeForm;
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

            // GroupBox BG
            groupBoxRadioButtons.BackColor = backgroundColor;


            // Text BG
            AreYouLabel.BackColor = backgroundColor;

            // Login button BG color
            LoginButton.BackColor = ColorTranslator.FromHtml("#29AB87");
        }
        private string GetCheckedRadioButtonText(Control container) { 
            foreach (Control control in container.Controls) { 
                if (control is RadioButton rb && rb.Checked) {
                    return rb.Text; 
                } 
            } 
            return null; 
        }
        private bool Check_Email_Pass_andEnter(string usertype)
        {
            switch (usertype) {
                case "Users":
                    // check if user is available
                    if (!controlObj.checkEmail(EmailTB.Text, "Users"))
                    {
                        MessageBox.Show("Email is not registered in The Recipe Hub, please sign up.");
                        return false;
                    } else
                    {
                        if (!controlObj.checkPassword(EmailTB.Text, PasswordTB.Text, "Users"))
                        {
                            MessageBox.Show("Wrong Password!\nTry again!");
                            return false;
                        }
                        if (controlObj.isAdmin(EmailTB.Text))
                        {
                            // Get Admin ID
                            int ID = controlObj.GetID(EmailTB.Text, "Users");
                            // Go to Admin Form
                            AdminInitialWindow AdminWindow = new AdminInitialWindow(ID);
                            AdminWindow.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Get user ID
                            int ID = controlObj.GetID(EmailTB.Text, "Users");
                            Form Newform = new Users1(ID);
                            Newform.Show();
                            this.Hide();
                        }
                        return true;
                    }
                case "Chef":
                    // check if user is available
                    if (!controlObj.checkEmail(EmailTB.Text, usertype))
                    {
                        MessageBox.Show("Email is not registered in The Recipe Hub, please sign up.");
                        return false;
                    }
                    else
                    {
                        if (!controlObj.checkPassword(EmailTB.Text, PasswordTB.Text, usertype))
                        {
                            MessageBox.Show("Wrong Password!\nTry again!");
                            return false;
                        }
                        int ID = controlObj.GetID(EmailTB.Text, usertype);
                        MessageBox.Show($"{ID}");
                        Form Newform = new HelloChefForm(ID,this);
                        Newform.Show();
                        this.Hide();
                        return true;
                    }
                case "Nutritionist":
                    // check if user is available
                    if (!controlObj.checkEmail(EmailTB.Text, "Nutritionist"))
                    {
                        MessageBox.Show("Email is not registered in The Recipe Hub, please sign up.");
                        return false;
                    }
                    else
                    {
                        if (!controlObj.checkPassword(EmailTB.Text, PasswordTB.Text, "Nutritionist"))
                        {
                            MessageBox.Show("Wrong Password!\nTry again!");
                            return false;
                        }
                        int ID = controlObj.GetID(EmailTB.Text, "Nutritionist");
                        Form newform = new NutHome(ID);
                        newform.Show();
                        this.Hide();
                        return true;
                    }
                case "Company":
                    // check if user is available
                    if (!controlObj.checkEmail(EmailTB.Text, usertype))
                    {
                        MessageBox.Show("Email is not registered in The Recipe Hub, please sign up.");
                        return false;
                    }
                    else
                    {
                        if (!controlObj.checkPassword(EmailTB.Text, PasswordTB.Text, usertype))
                        {
                            MessageBox.Show("Wrong Password!\nTry again!");
                            return false;
                        }
                        // Get company ID
                        int ID = controlObj.GetID(EmailTB.Text, usertype);
                        // Go to initial Company Window
                        CompanyInitialWindow CompanyWindow = new CompanyInitialWindow(ID);
                        CompanyWindow.Show();
                        this.Hide();
                        return true;
                    }
                default:
                    return false;
            }

        }
        private bool ShowPassword(bool check)
        {
            return PasswordTB.UseSystemPasswordChar = check;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            ShowPassword(ShowPasswordCB.Checked);
        }

        private void PasswordTB_Enter(object sender, EventArgs e)
        {

            if (PasswordTB.Text == "Enter your Password") PasswordTB.Text = "";
            
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (PasswordTB.Text == "")
                PasswordTB.Text = "Enter your Password";
            if (PasswordTB.Text == "Enter your Password") PasswordTB.UseSystemPasswordChar = false;
        }

        private void ShowPasswordCB_CheckedChanged(object sender, EventArgs e)
        {   if (PasswordTB.Text != "Enter your Password")
            ShowPassword(ShowPasswordCB.Checked);
        }

        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (EmailTB.Text == "Enter your email") 
                EmailTB.Text = "";
        }

        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "")
                EmailTB.Text = "Enter your email";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check if any radio button is selected
            bool isAnyRadioButtonChecked = groupBoxRadioButtons.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
            if (!controlObj.IsValidEmail(EmailTB.Text))
            {
                MessageBox.Show("Please enter a valid email!", "Invalid email!");
            }else if (!isAnyRadioButtonChecked)
            {
                MessageBox.Show("Please pick a choice!");
            }
            else {
                string userType = GetCheckedRadioButtonText(groupBoxRadioButtons);
                Check_Email_Pass_andEnter(userType);
            }
        }

        private void ChefRB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
