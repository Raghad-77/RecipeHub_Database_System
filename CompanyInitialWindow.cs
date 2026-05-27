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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class CompanyInitialWindow : Form
    {
        int CompanyID;
        CompanyController companycontrolObj = new CompanyController();
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        private ImageList imageList = new ImageList();
        // Load default image for recipes that do not have an image
        Image defaultImage = Image.FromFile("../../Resources/Images/default_not_found_image.jpg");
        Image defaultImageResized;
        int SelectedRecipeID;
        public CompanyInitialWindow(int ID)
        {
            InitializeComponent();
            CompanyID = ID;
            // Retrieving Company Name
            string companyName = companycontrolObj.getName(CompanyID);
            // Greeting Company
            WelcomeLabel.Text = $"Hello, {companyName}!";
            WelcomeLabel.BackColor = Color.Transparent;
            // BG color
            this.BackColor = backgroundColor;
            // List BG color
            RecipesList.BackColor = backgroundColor;
            NoRecipesLabel.Visible = false;
            // Set Recipes List to view Image and label
            RecipesList.View = View.LargeIcon;
            // Initialize Image list
            imageList.ImageSize = new Size(64, 64); // Set the size of images
            imageList.ColorDepth = ColorDepth.Depth32Bit; // Set color depth
            RecipesList.LargeImageList = imageList;
            // resize default image
            defaultImageResized = ResizeImage(defaultImage, 64, 64);
            

        }
        private void LoadRecipes()
        {
            DataTable recipesList = companycontrolObj.GetRecipes(CompanyID);
            int imageIndex = 0;
            if (recipesList != null && recipesList.Rows.Count > 0)
            {
                NoRecipesLabel.Visible = false;
                foreach (DataRow row in recipesList.Rows)
                {
                    string recipeName = row["Name"].ToString();
                    byte[] imageData = row["Image"] as byte[];

                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image originalImage = Image.FromStream(ms);
                            Image resizedImage = ResizeImage(originalImage, 64, 64);
                            imageList.Images.Add(resizedImage);
                            RecipesList.Items.Add(new ListViewItem(recipeName, imageIndex));
                            imageIndex++;
                        }
                    }
                    else // if No image
                    {
                        imageList.Images.Add(defaultImageResized);
                        RecipesList.Items.Add(new ListViewItem(recipeName, imageIndex));
                        imageIndex++;
                    }
                }
            }
            else NoRecipesLabel.Visible = true;
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void CompanyInitialWindow_Load(object sender, EventArgs e)
        {
            LoadRecipes();
        }
        private int DurationScale(int CookingTime)
        {
            if (CookingTime < 10) return 1;
            if (CookingTime < 20) return 2;
            if (CookingTime < 30) return 3;
            if (CookingTime < 60) return 4;
            return 5;
        }

        private void RecipesList_Click(object sender, EventArgs e)
        {
            if (RecipesList.SelectedItems.Count > 0)
            {
                // Reset Labels so they dont overlap over each other
                NameLabel.Text = "Name";
                CookingTimeLabel.Text = "Cooking Time";
                DescriptionLabel.Text = "Description";
                NutritionalInfoLabel.Text = "NutritionalInfo";
                StepsLabel.Text = "Steps";

                // Get selected Recipe
                ListViewItem selectedItem = RecipesList.SelectedItems[0];
                string selectedRecipeName = selectedItem.Text;
                DataTable recipeTable = companycontrolObj.GetRecipes(CompanyID);
                if (recipeTable != null && recipeTable.Rows.Count > 0)
                {
                    NoRecipesLabel.Visible = false;
                    foreach (DataRow row in recipeTable.Rows)
                    {
                        if (row["Name"].ToString() == selectedRecipeName)
                        {
                            NameLabel.Text += "\n" + row["Name"].ToString();
                            int difficulty = Convert.ToInt32(row["Difficulty_Level"]);
                            DifficultyProgressBar.Value = difficulty;
                            int CookingTime = Convert.ToInt32(row["Cooking_Time"]);
                            CookingTimeLabel.Text += $" {CookingTime} Mins";
                            int CookingTimeScaled = DurationScale(CookingTime);
                            CookingTimeProgressBar.Value = CookingTimeScaled;
                            DescriptionLabel.Text += "\n" + row["Description"].ToString();
                            NutritionalInfoLabel.Text += "\n" + row["NutritionalInfo"].ToString();
                            StepsLabel.Text += "\n" + row["Steps"].ToString();
                            SelectedRecipeID =Convert.ToInt32(row["RecipeID"]);

                            byte[] imageBytes = row["Image"] as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);
                                    RecipePictureBox.Image = image;
                                    RecipePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            else
                            {
                                RecipePictureBox.Image = defaultImage;
                                RecipePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                    }
                }
                else NoRecipesLabel.Visible = true;
            }
        }

        private void RecipePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(this, CompanyID, "Company");
            addRecipeForm.Show();
            this.Hide();
        }
        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            UpdateRecipeForm updateRecipeForm = new UpdateRecipeForm(this,SelectedRecipeID);
            updateRecipeForm.Show();
            this.Hide();
        }

        private void ShowProductsButton_Click(object sender, EventArgs e)
        {
            CompanyProductsForm form = new CompanyProductsForm(CompanyID,this);
            form.Show();
            this.Hide();
        }
    }
}
