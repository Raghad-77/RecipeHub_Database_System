using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBapplication

{
    public partial class NutHome : Form

    {
        NutritionistController obj = new NutritionistController();
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        private ImageList imageList = new ImageList();
        // Load default image for recipes that do not have an image
        Image defaultImage =Properties.Resources.Ramen2; 
        Image defaultImageResized;
        int ID;

        //string User_Name = "Protype_User";
        public NutHome(int ID)
        {
            InitializeComponent();


            this.ID = ID;

            //Asume that with each login there will a function that returns all nessceary info


            string Nut = obj.GetNutName(ID);
            //string companyName = companycontrolObj.getName(CompanyID);

            WelcomeLabel.Text = $"Hello, {Nut}!";
            WelcomeLabel.BackColor = Color.Transparent;
            int idused = obj.Get_FollowerCount(ID);
            this.BackColor = backgroundColor;
            // List BG color
            RecipesList.BackColor = backgroundColor;

            // Set Recipes List to view Image and label
            RecipesList.View = View.LargeIcon;
            // Initialize Image list
            imageList.ImageSize = new Size(64, 64); // Set the size of images
            imageList.ColorDepth = ColorDepth.Depth32Bit; // Set color depth
            RecipesList.LargeImageList = imageList;
            // resize default image
            defaultImageResized = ResizeImage(defaultImage, 64, 64);
            LoadRecipes();
            //initializing follower counts
            int RecipesTotal = obj.getRecipesTotal(ID);
            if (RecipesTotal != -1)
            {
                label2.Text = Convert.ToString(RecipesTotal);

            }
            else
            {
                label2.Text = Convert.ToString(0);
            }
            if (idused != -1)
            {
                Followers_count.Text = Convert.ToString(obj.Get_FollowerCount(ID));

            }
            else
            {
                Followers_count.Text = Convert.ToString("0");
            }


        }

        private void LoadRecipes()
        {
            DataTable recipesList = obj.Getrec(ID);
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
        private int DurationScale(int CookingTime)
        {
            if (CookingTime < 10) return 1;
            if (CookingTime < 20) return 2;
            if (CookingTime < 30) return 3;
            if (CookingTime < 60) return 4;
            return 5;
        }



        private void NutHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DietPlan f1 = new DietPlan(this,ID);
            f1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NutInfoAdded next = new NutInfoAdded(this, ID);
            next.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddComment f1 = new AddComment(this, ID);
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calories f2 = new Calories(this, ID);
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Blog f1 = new Blog(this, ID);
            f1.Show();
            this.Hide();
        }

        private void RecipesList_SelectedIndexChanged(object sender, EventArgs e)
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
                DataTable recipeTable = obj.Getrec(ID);
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
        }

        private void NoRecipesLabel_Click(object sender, EventArgs e)
        {

        }

        private void CookingTimeProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
