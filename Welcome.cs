using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Welcome : Form
    {
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        Color Carrot = ColorTranslator.FromHtml("#ed7117");
        Color Tiger = ColorTranslator.FromHtml("#fc6a03");
        Controller controlObj = new Controller();
        public Welcome()
        {
            InitializeComponent();
            // Load file
            // Initialize BG
            InitializeBackground(this);
            

            // Text Backgrounds
            TheLabel.BackColor = Color.Transparent;
            RecipeLabel.BackColor = Color.Transparent;
            HubLabel.BackColor = Color.Transparent;

            // Button Backgrounds
            LoginButton.BackColor = Tiger;
            SignUpButton.BackColor = Tiger;
            
           
        }
        public void InitializeBackground(Form form)
        {
            Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
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

            // Background Color
            form.BackColor = backgroundColor;
        }
        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void MyLabel_Click(object sender, EventArgs e)
        {

        }

        private void HubLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Choice_of_UserTypeWindow ChooseWindow = new Choice_of_UserTypeWindow(this);
            ChooseWindow.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm(this);
            LoginForm.Show();
            this.Hide();
        }
    }
}
