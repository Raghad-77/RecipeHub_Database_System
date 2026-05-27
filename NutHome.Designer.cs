namespace DBapplication
{
    partial class NutHome
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
            this.Followers = new System.Windows.Forms.Label();
            this.Followers_count = new System.Windows.Forms.Label();
            this.DietPlan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.RecipesList = new System.Windows.Forms.ListView();
            this.RecipeDetailsPanel = new System.Windows.Forms.Panel();
            this.NoRecipesLabel = new System.Windows.Forms.Label();
            this.DifficultyProgressBar = new System.Windows.Forms.ProgressBar();
            this.CookingTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.LikesCountLabel = new System.Windows.Forms.Label();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.NutritionalInfoLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CookingTimeLabel = new System.Windows.Forms.Label();
            this.DifficultyLevelLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RecipePictureBox = new System.Windows.Forms.PictureBox();
            this.RecipeDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Followers
            // 
            this.Followers.AutoSize = true;
            this.Followers.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Followers.Location = new System.Drawing.Point(149, 54);
            this.Followers.Name = "Followers";
            this.Followers.Size = new System.Drawing.Size(86, 25);
            this.Followers.TabIndex = 1;
            this.Followers.Text = "Followers";
            // 
            // Followers_count
            // 
            this.Followers_count.AutoSize = true;
            this.Followers_count.Location = new System.Drawing.Point(153, 5);
            this.Followers_count.Name = "Followers_count";
            this.Followers_count.Size = new System.Drawing.Size(0, 16);
            this.Followers_count.TabIndex = 2;
            // 
            // DietPlan
            // 
            this.DietPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DietPlan.Location = new System.Drawing.Point(1117, 263);
            this.DietPlan.Name = "DietPlan";
            this.DietPlan.Size = new System.Drawing.Size(337, 41);
            this.DietPlan.TabIndex = 3;
            this.DietPlan.Text = "Create Diet plans and Add Recipes";
            this.DietPlan.UseVisualStyleBackColor = true;
            this.DietPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1161, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Nutritional Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1199, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "New Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1199, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Calorie Count";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recipes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1199, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add Blog";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(9, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(44, 16);
            this.WelcomeLabel.TabIndex = 11;
            this.WelcomeLabel.Text = "label4";
            // 
            // RecipesList
            // 
            this.RecipesList.HideSelection = false;
            this.RecipesList.Location = new System.Drawing.Point(11, 86);
            this.RecipesList.Name = "RecipesList";
            this.RecipesList.Size = new System.Drawing.Size(538, 311);
            this.RecipesList.TabIndex = 12;
            this.RecipesList.UseCompatibleStateImageBehavior = false;
            this.RecipesList.SelectedIndexChanged += new System.EventHandler(this.RecipesList_SelectedIndexChanged);
            // 
            // RecipeDetailsPanel
            // 
            this.RecipeDetailsPanel.Controls.Add(this.NoRecipesLabel);
            this.RecipeDetailsPanel.Controls.Add(this.DifficultyProgressBar);
            this.RecipeDetailsPanel.Controls.Add(this.CookingTimeProgressBar);
            this.RecipeDetailsPanel.Controls.Add(this.LikesCountLabel);
            this.RecipeDetailsPanel.Controls.Add(this.StepsLabel);
            this.RecipeDetailsPanel.Controls.Add(this.NutritionalInfoLabel);
            this.RecipeDetailsPanel.Controls.Add(this.DescriptionLabel);
            this.RecipeDetailsPanel.Controls.Add(this.CookingTimeLabel);
            this.RecipeDetailsPanel.Controls.Add(this.DifficultyLevelLabel);
            this.RecipeDetailsPanel.Controls.Add(this.NameLabel);
            this.RecipeDetailsPanel.Controls.Add(this.RecipePictureBox);
            this.RecipeDetailsPanel.Location = new System.Drawing.Point(611, 25);
            this.RecipeDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeDetailsPanel.Name = "RecipeDetailsPanel";
            this.RecipeDetailsPanel.Size = new System.Drawing.Size(477, 423);
            this.RecipeDetailsPanel.TabIndex = 13;
            // 
            // NoRecipesLabel
            // 
            this.NoRecipesLabel.AutoSize = true;
            this.NoRecipesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRecipesLabel.Location = new System.Drawing.Point(269, 254);
            this.NoRecipesLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.NoRecipesLabel.Name = "NoRecipesLabel";
            this.NoRecipesLabel.Size = new System.Drawing.Size(95, 25);
            this.NoRecipesLabel.TabIndex = 10;
            this.NoRecipesLabel.Text = "No recipe";
            this.NoRecipesLabel.Click += new System.EventHandler(this.NoRecipesLabel_Click);
            // 
            // DifficultyProgressBar
            // 
            this.DifficultyProgressBar.Location = new System.Drawing.Point(270, 130);
            this.DifficultyProgressBar.Maximum = 5;
            this.DifficultyProgressBar.Name = "DifficultyProgressBar";
            this.DifficultyProgressBar.Size = new System.Drawing.Size(198, 23);
            this.DifficultyProgressBar.TabIndex = 9;
            // 
            // CookingTimeProgressBar
            // 
            this.CookingTimeProgressBar.Location = new System.Drawing.Point(270, 184);
            this.CookingTimeProgressBar.Maximum = 5;
            this.CookingTimeProgressBar.Name = "CookingTimeProgressBar";
            this.CookingTimeProgressBar.Size = new System.Drawing.Size(198, 23);
            this.CookingTimeProgressBar.TabIndex = 8;
            this.CookingTimeProgressBar.Click += new System.EventHandler(this.CookingTimeProgressBar_Click);
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
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsLabel.Location = new System.Drawing.Point(269, 326);
            this.StepsLabel.MaximumSize = new System.Drawing.Size(251, 100);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(63, 25);
            this.StepsLabel.TabIndex = 7;
            this.StepsLabel.Text = "Steps";
            // 
            // NutritionalInfoLabel
            // 
            this.NutritionalInfoLabel.AutoSize = true;
            this.NutritionalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionalInfoLabel.Location = new System.Drawing.Point(3, 326);
            this.NutritionalInfoLabel.MaximumSize = new System.Drawing.Size(251, 100);
            this.NutritionalInfoLabel.Name = "NutritionalInfoLabel";
            this.NutritionalInfoLabel.Size = new System.Drawing.Size(135, 25);
            this.NutritionalInfoLabel.TabIndex = 6;
            this.NutritionalInfoLabel.Text = "Nutritional Info";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 228);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(501, 100);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // CookingTimeLabel
            // 
            this.CookingTimeLabel.AutoSize = true;
            this.CookingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookingTimeLabel.Location = new System.Drawing.Point(269, 156);
            this.CookingTimeLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.CookingTimeLabel.Name = "CookingTimeLabel";
            this.CookingTimeLabel.Size = new System.Drawing.Size(134, 25);
            this.CookingTimeLabel.TabIndex = 4;
            this.CookingTimeLabel.Text = "Cooking Time";
            // 
            // DifficultyLevelLabel
            // 
            this.DifficultyLevelLabel.AutoSize = true;
            this.DifficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelLabel.Location = new System.Drawing.Point(269, 94);
            this.DifficultyLevelLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.DifficultyLevelLabel.Name = "DifficultyLevelLabel";
            this.DifficultyLevelLabel.Size = new System.Drawing.Size(84, 25);
            this.DifficultyLevelLabel.TabIndex = 2;
            this.DifficultyLevelLabel.Text = "Difficulty";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(269, 14);
            this.NameLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // RecipePictureBox
            // 
            this.RecipePictureBox.Location = new System.Drawing.Point(3, 0);
            this.RecipePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipePictureBox.Name = "RecipePictureBox";
            this.RecipePictureBox.Size = new System.Drawing.Size(261, 225);
            this.RecipePictureBox.TabIndex = 0;
            this.RecipePictureBox.TabStop = false;
            // 
            // NutHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1451, 450);
            this.Controls.Add(this.RecipeDetailsPanel);
            this.Controls.Add(this.RecipesList);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DietPlan);
            this.Controls.Add(this.Followers_count);
            this.Controls.Add(this.Followers);
            this.Name = "NutHome";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.NutHome_Load);
            this.RecipeDetailsPanel.ResumeLayout(false);
            this.RecipeDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Followers;
        private System.Windows.Forms.Label Followers_count;
        private System.Windows.Forms.Button DietPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ListView RecipesList;
        private System.Windows.Forms.Panel RecipeDetailsPanel;
        private System.Windows.Forms.Label LikesCountLabel;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Label NutritionalInfoLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CookingTimeLabel;
        private System.Windows.Forms.Label DifficultyLevelLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox RecipePictureBox;
        private System.Windows.Forms.ProgressBar DifficultyProgressBar;
        private System.Windows.Forms.ProgressBar CookingTimeProgressBar;
        private System.Windows.Forms.Label NoRecipesLabel;
    }
}