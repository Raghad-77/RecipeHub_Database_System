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
    public partial class Choice_of_UserTypeWindow : Form
    {
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        Color Tiger = ColorTranslator.FromHtml("#fc6a03");
        Welcome welcomeForm;
        public Choice_of_UserTypeWindow(Welcome welcomeForm)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;

            // Background Color
            this.BackColor = backgroundColor;

            // Next Button Color
            NextButton.BackColor = Tiger;
            

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
        }

        private void Choice_of_UserTypeWindow_Load(object sender, EventArgs e)
        {

        }

        private void Choice_of_UserTypeWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string usertype = Convert.ToString(UsertypeCB.SelectedItem);
            switch (usertype) {
                case "User":
                    Form Newform = new UserSignUpForm(this);
                    Newform.Show();
                    this.Hide(); break;
                case "Chef":
                    // Go to Chef signup form
                    Form Newf = new chefSignuoForm(this);
                    Newf.Show();
                    this.Hide(); 
                    break;
                case "Nutritionist":
                    // Go to Nutritionist signup form
                    Form f1 = new NutSignUp();
                    f1.Show();
                    this.Hide();
                    break;
         
                case "Company":
                    // Go to Company signup form
                    CompanySignUpForm companySignUpForm = new CompanySignUpForm(this);
                    companySignUpForm.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }

        }
    }
}
