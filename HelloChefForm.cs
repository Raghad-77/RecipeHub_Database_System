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
using System.Xml;

namespace DBapplication
{
    public partial class HelloChefForm : Form
    {
        Form form;
        int ChefID;
        ChefController controller;
        Color backgroundColor = ColorTranslator.FromHtml("#f0e8db");
        private ImageList imageList = new ImageList();
        // Load default image for recipes that do not have an image
        Image defaultImage = Image.FromFile("../../Resources/Images/default_not_found_image.jpg");
        Image defaultImageResized;
        public HelloChefForm(int ChefID, Form form)
        {

            InitializeComponent();
            this.form = form;
            controller = new ChefController();
            this.ChefID = ChefID;
            // Retrieving Chef Name
            string chefName = controller.getName(ChefID);
            // getting count of followers
            int followercount = controller.Get_FollowerCount(ChefID);
            cheffollowers.Text = $"Number Of Followers: {followercount}!";
            
            // Greeting Chef
            hellohello.Text = $"Hello Chef {chefName}!";
            hellohello.BackColor = Color.Transparent;
            // BG color
            this.BackColor = backgroundColor;
            // List BG color
            chefList.BackColor = backgroundColor;
            // initialize likes
            likes.Text = "0 Likes";
            // Set Recipes List to view Image and label
            chefList.View = View.LargeIcon;
            // Initialize Image list
            imageList.ImageSize = new Size(64, 64); // Set the size of images
            imageList.ColorDepth = ColorDepth.Depth32Bit; // Set color depth
            chefList.LargeImageList = imageList;
            // resize default image
            defaultImageResized = ResizeImage(defaultImage, 64, 64);
            LoadRecipes();
            // loading collection names into combobox
            DataTable dt = controller.showcollection(ChefID);
            comboBox1.DataSource = dt;

        }

        private void chefList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chefList.SelectedItems.Count > 0)
            {
                // Reset Labels so they dont overlap over each other
                RName.Text = "Name";
                Rtime.Text = "Cooking Time";
                RDescription.Text = "Description";
                Rnut.Text = "NutritionalInfo";
                Rsteps.Text = "Steps";

                // Get selected Recipe
                ListViewItem selectedItem = chefList.SelectedItems[0];
                string selectedRecipeName = selectedItem.Text;
                DataTable recipeTable = controller.GetRecipes(ChefID);
                foreach (DataRow row in recipeTable.Rows)
                {
                    if (row["Name"].ToString() == selectedRecipeName)
                    {
                        RName.Text += "\n" + row["Name"].ToString();
                        int difficulty = Convert.ToInt32(row["Difficulty_Level"]);
                        customProgressBar1.Value = difficulty;
                        int CookingTime = Convert.ToInt32(row["Cooking_Time"]);
                        Rtime.Text += $" {CookingTime} Mins";
                        int CookingTimeScaled = DurationScale(CookingTime);
                        customProgressBar2.Value = CookingTimeScaled;
                        RDescription.Text += "\n" + row["Description"].ToString();
                        Rnut.Text += "\n" + row["NutritionalInfo"].ToString();
                        Rsteps.Text += "\n" + row["Steps"].ToString();
                        int likecount = controller.Get_likeCount(controller.get_RecipeID(row["Name"].ToString()));
                        likes.Text = $"{likecount} Likes";
                        byte[] imageBytes = row["Image"] as byte[];
                        if (imageBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(ms);
                                recipephoto.Image = image;
                                recipephoto.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            recipephoto.Image = defaultImage;
                            recipephoto.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
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

        private void LoadRecipes()
        {


            DataTable recipesList = controller.GetRecipes(ChefID);
            int imageIndex = 0;
            if (recipesList != null && recipesList.Rows.Count > 0)
            {
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
                            chefList.Items.Add(new ListViewItem(recipeName, imageIndex));
                            imageIndex++;
                        }
                    }
                    else // if No image
                    {
                        imageList.Images.Add(defaultImageResized);
                        chefList.Items.Add(new ListViewItem(recipeName, imageIndex));
                        imageIndex++;
                    }
                }
            }
            else
            {
                NoRecipes.Visible = true;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable recipesList = controller.GetCollectionRecipes(ChefID, comboBox1.SelectedItem.ToString());
            int imageIndex = 0;
            if (recipesList != null && recipesList.Rows.Count > 0)
            {
                NoRecipes.Visible = false;
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
                            chefList.Items.Add(new ListViewItem(recipeName, imageIndex));
                            imageIndex++;
                        }
                    }
                    else // if No image
                    {
                        imageList.Images.Add(defaultImageResized);
                        chefList.Items.Add(new ListViewItem(recipeName, imageIndex));
                        imageIndex++;
                    }
                }
            }
            else NoRecipes.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            chating form = new chating(this, ChefID);
            form.Show();
            this.Hide();
        }

        private void ShareR_Click(object sender, EventArgs e)
        {
            Form nf = new AddRecipeForm(this, ChefID,"Chef");
            nf.Show();
            this.Hide();
        }

        private void editR_Click(object sender, EventArgs e)
        {
            
            Form nf = new UpdateRecipeForm(this, ChefID);
            nf.Show();
            this.Hide();
        }

        private void likes_Click(object sender, EventArgs e)
        {

        }
    }
}
