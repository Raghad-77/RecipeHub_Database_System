using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AddRecipeForm : Form
    {
        int ID;
        string userType;
        Form prevForm;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        Image defaultImage = Image.FromFile("../../Resources/Images/default_not_found_image.jpg");
        Controller controlObj = new Controller();
        byte[] imagebytes;
        public AddRecipeForm(Form prevForm, int ID, string userType)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.ID = ID;
            this.userType = userType;
            this.BackColor = backgroundColor;
            RecipePhotoPictureBox.Image = defaultImage;
            RecipePhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CompanyNameTB.Visible = false;
            ReferralCodeTB.Visible = false;
        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {

        }
        private void RecipePhotoPictureBox_Click(object sender, EventArgs e)
        {
            byte[] RecipePhoto = controlObj.UploadImage();
            if (RecipePhoto != null)
            {
                using (MemoryStream ms = new MemoryStream(RecipePhoto))
                {
                    RecipePhotoPictureBox.Image = Image.FromStream(ms);
                    RecipePhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                imagebytes = RecipePhoto;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string description = DescriptionTB.Text;
            string steps = StepsTB.Text;
            string nutritionalInfo = NutritionalInfoTB.Text;
            int difficulty = Convert.ToInt32(DifficultyCB.SelectedItem);
            int cooking_time = Convert.ToInt32(CookingTimeTB.Text);
            if (CollabCB.Checked)
            {
                int ret = controlObj.AddRecipeWithCollab(name, description, steps, difficulty, nutritionalInfo, imagebytes, cooking_time, "Company", ID, CompanyNameTB.Text, "Chef");
                if (ret != 0)
                {

                MessageBox.Show("Recipe Inserted Successfuly!");
                this.Close();
                prevForm.Show();
                prevForm.Refresh();
                }
            } else
            { int ret = controlObj.AddRecipe(name, description, steps, difficulty, nutritionalInfo, imagebytes, cooking_time, userType, ID);
                if (ret != 0)
                {
                    MessageBox.Show("Recipe Inserted Successfuly!");
                    this.Close();
                    prevForm.Show();
                    prevForm.Refresh();
                }
            }
            
        }

        private void CollabCB_CheckedChanged(object sender, EventArgs e)
        {
            CompanyNameTB.Visible = CollabCB.Checked;
            ReferralCodeTB.Visible = CollabCB.Checked;
        }
    }
}
