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
    public partial class UpdateRecipeForm : Form
    {
        int ID;
        Form prevForm;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        Image defaultImage = Image.FromFile("../../Resources/Images/default_not_found_image.jpg");
        Controller controlObj = new Controller();
        byte[] imagebytes;
        public UpdateRecipeForm(Form prevForm, int ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.ID = ID;
            this.BackColor = backgroundColor;
            RecipePhotoPictureBox.Image = defaultImage;
            RecipePhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string description = DescriptionTB.Text;
            string steps = StepsTB.Text;
            string nutritionalInfo = NutritionalInfoTB.Text;
            int difficulty = Convert.ToInt32(DifficultyCB.SelectedItem);
            int cooking_time = Convert.ToInt32(CookingTimeTB.Text);
            int ret = controlObj.UpdateRecipe(name, description, steps, difficulty, nutritionalInfo, imagebytes, cooking_time, ID);
            if (ret != 0)
            {
                MessageBox.Show("Recipe Updated Successfuly!");
                this.Close();
                prevForm.Show();
                prevForm.Refresh();
            }
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
    }
}
