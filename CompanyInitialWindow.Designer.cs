namespace DBapplication
{
    partial class CompanyInitialWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.RecipesList = new System.Windows.Forms.ListView();
            this.RecipeDetailsPanel = new System.Windows.Forms.Panel();
            this.LikesCountLabel = new System.Windows.Forms.Label();
            this.CookingTimeProgressBar = new CustomProgressBar();
            this.DifficultyProgressBar = new CustomProgressBar();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.NutritionalInfoLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CookingTimeLabel = new System.Windows.Forms.Label();
            this.DifficultyLevelLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RecipePictureBox = new System.Windows.Forms.PictureBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.EditRecipeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FollowersCountLabel = new System.Windows.Forms.Label();
            this.ShowProductsButton = new System.Windows.Forms.Button();
            this.NoRecipesLabel = new System.Windows.Forms.Label();
            this.RecipeDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Anaktoria", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(43, 30);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(517, 74);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, Oniro Cookies!";
            // 
            // RecipesList
            // 
            this.RecipesList.HideSelection = false;
            this.RecipesList.Location = new System.Drawing.Point(3, 133);
            this.RecipesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipesList.Name = "RecipesList";
            this.RecipesList.Size = new System.Drawing.Size(567, 424);
            this.RecipesList.TabIndex = 1;
            this.RecipesList.UseCompatibleStateImageBehavior = false;
            this.RecipesList.Click += new System.EventHandler(this.RecipesList_Click);
            // 
            // RecipeDetailsPanel
            // 
            this.RecipeDetailsPanel.Controls.Add(this.LikesCountLabel);
            this.RecipeDetailsPanel.Controls.Add(this.CookingTimeProgressBar);
            this.RecipeDetailsPanel.Controls.Add(this.DifficultyProgressBar);
            this.RecipeDetailsPanel.Controls.Add(this.StepsLabel);
            this.RecipeDetailsPanel.Controls.Add(this.NutritionalInfoLabel);
            this.RecipeDetailsPanel.Controls.Add(this.DescriptionLabel);
            this.RecipeDetailsPanel.Controls.Add(this.CookingTimeLabel);
            this.RecipeDetailsPanel.Controls.Add(this.DifficultyLevelLabel);
            this.RecipeDetailsPanel.Controls.Add(this.NameLabel);
            this.RecipeDetailsPanel.Controls.Add(this.RecipePictureBox);
            this.RecipeDetailsPanel.Location = new System.Drawing.Point(575, 133);
            this.RecipeDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeDetailsPanel.Name = "RecipeDetailsPanel";
            this.RecipeDetailsPanel.Size = new System.Drawing.Size(494, 452);
            this.RecipeDetailsPanel.TabIndex = 2;
            // 
            // LikesCountLabel
            // 
            this.LikesCountLabel.AutoSize = true;
            this.LikesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikesCountLabel.Location = new System.Drawing.Point(387, 211);
            this.LikesCountLabel.Name = "LikesCountLabel";
            this.LikesCountLabel.Size = new System.Drawing.Size(81, 20);
            this.LikesCountLabel.TabIndex = 7;
            this.LikesCountLabel.Text = "200 Likes";
            // 
            // CookingTimeProgressBar
            // 
            this.CookingTimeProgressBar.Location = new System.Drawing.Point(269, 185);
            this.CookingTimeProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.CookingTimeProgressBar.Maximum = 5;
            this.CookingTimeProgressBar.Name = "CookingTimeProgressBar";
            this.CookingTimeProgressBar.Size = new System.Drawing.Size(205, 22);
            this.CookingTimeProgressBar.TabIndex = 9;
            // 
            // DifficultyProgressBar
            // 
            this.DifficultyProgressBar.Location = new System.Drawing.Point(268, 121);
            this.DifficultyProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.DifficultyProgressBar.Maximum = 5;
            this.DifficultyProgressBar.Name = "DifficultyProgressBar";
            this.DifficultyProgressBar.Size = new System.Drawing.Size(205, 22);
            this.DifficultyProgressBar.TabIndex = 8;
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsLabel.Location = new System.Drawing.Point(263, 326);
            this.StepsLabel.MaximumSize = new System.Drawing.Size(251, 100);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(50, 26);
            this.StepsLabel.TabIndex = 7;
            this.StepsLabel.Text = "Steps";
            // 
            // NutritionalInfoLabel
            // 
            this.NutritionalInfoLabel.AutoSize = true;
            this.NutritionalInfoLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionalInfoLabel.Location = new System.Drawing.Point(3, 326);
            this.NutritionalInfoLabel.MaximumSize = new System.Drawing.Size(251, 100);
            this.NutritionalInfoLabel.Name = "NutritionalInfoLabel";
            this.NutritionalInfoLabel.Size = new System.Drawing.Size(133, 26);
            this.NutritionalInfoLabel.TabIndex = 6;
            this.NutritionalInfoLabel.Text = "Nutritional Info";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 228);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 26);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // CookingTimeLabel
            // 
            this.CookingTimeLabel.AutoSize = true;
            this.CookingTimeLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookingTimeLabel.Location = new System.Drawing.Point(269, 156);
            this.CookingTimeLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.CookingTimeLabel.Name = "CookingTimeLabel";
            this.CookingTimeLabel.Size = new System.Drawing.Size(118, 26);
            this.CookingTimeLabel.TabIndex = 4;
            this.CookingTimeLabel.Text = "Cooking Time";
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.AutoSize = true;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(269, 94);
            this.DifficultyLevelLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.DifficultyLevelLabel.Name = "DifficultyLevelLabel";
            this.DifficultyLevelLabel.Size = new System.Drawing.Size(88, 26);
            this.DifficultyLevelLabel.TabIndex = 2;
            this.DifficultyLevelLabel.Text = "Difficulty";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(269, 14);
            this.NameLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 26);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // RecipePictureBox
            // 
            this.RecipePictureBox.Location = new System.Drawing.Point(0, 0);
            this.RecipePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipePictureBox.Name = "RecipePictureBox";
            this.RecipePictureBox.Size = new System.Drawing.Size(261, 225);
            this.RecipePictureBox.TabIndex = 0;
            this.RecipePictureBox.TabStop = false;
            this.RecipePictureBox.Click += new System.EventHandler(this.RecipePictureBox_Click);
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipeButton.Location = new System.Drawing.Point(943, 82);
            this.AddRecipeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(107, 50);
            this.AddRecipeButton.TabIndex = 3;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // EditRecipeButton
            // 
            this.EditRecipeButton.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRecipeButton.Location = new System.Drawing.Point(815, 82);
            this.EditRecipeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditRecipeButton.Name = "EditRecipeButton";
            this.EditRecipeButton.Size = new System.Drawing.Size(107, 50);
            this.EditRecipeButton.TabIndex = 4;
            this.EditRecipeButton.Text = "Edit Recipe";
            this.EditRecipeButton.UseVisualStyleBackColor = true;
            this.EditRecipeButton.Click += new System.EventHandler(this.EditRecipeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on a recipe to view its details.";
            // 
            // FollowersCountLabel
            // 
            this.FollowersCountLabel.AutoSize = true;
            this.FollowersCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowersCountLabel.Location = new System.Drawing.Point(447, 112);
            this.FollowersCountLabel.Name = "FollowersCountLabel";
            this.FollowersCountLabel.Size = new System.Drawing.Size(113, 20);
            this.FollowersCountLabel.TabIndex = 6;
            this.FollowersCountLabel.Text = "200 Followers";
            // 
            // ShowProductsButton
            // 
            this.ShowProductsButton.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProductsButton.Location = new System.Drawing.Point(645, 82);
            this.ShowProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowProductsButton.Name = "ShowProductsButton";
            this.ShowProductsButton.Size = new System.Drawing.Size(129, 50);
            this.ShowProductsButton.TabIndex = 7;
            this.ShowProductsButton.Text = "Show Products";
            this.ShowProductsButton.UseVisualStyleBackColor = true;
            this.ShowProductsButton.Click += new System.EventHandler(this.ShowProductsButton_Click);
            // 
            // NoRecipesLabel
            // 
            this.NoRecipesLabel.AutoSize = true;
            this.NoRecipesLabel.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRecipesLabel.Location = new System.Drawing.Point(155, 336);
            this.NoRecipesLabel.Name = "NoRecipesLabel";
            this.NoRecipesLabel.Size = new System.Drawing.Size(168, 22);
            this.NoRecipesLabel.TabIndex = 8;
            this.NoRecipesLabel.Text = "You have no recipes yet!";
            this.NoRecipesLabel.Visible = false;
            // 
            // CompanyInitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 587);
            this.Controls.Add(this.NoRecipesLabel);
            this.Controls.Add(this.ShowProductsButton);
            this.Controls.Add(this.FollowersCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditRecipeButton);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.RecipeDetailsPanel);
            this.Controls.Add(this.RecipesList);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyInitialWindow";
            this.Text = "CompanyInitialWindow";
            this.Load += new System.EventHandler(this.CompanyInitialWindow_Load);
            this.RecipeDetailsPanel.ResumeLayout(false);
            this.RecipeDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ListView RecipesList;
        private System.Windows.Forms.Panel RecipeDetailsPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox RecipePictureBox;
        private System.Windows.Forms.Label DifficultyLevelLabel;
        private System.Windows.Forms.Label NutritionalInfoLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CookingTimeLabel;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Button AddRecipeButton;
        private CustomProgressBar DifficultyProgressBar;
        private CustomProgressBar CookingTimeProgressBar;
        private System.Windows.Forms.Button EditRecipeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FollowersCountLabel;
        private System.Windows.Forms.Label LikesCountLabel;
        private System.Windows.Forms.Button ShowProductsButton;
        private System.Windows.Forms.Label NoRecipesLabel;
    }
}