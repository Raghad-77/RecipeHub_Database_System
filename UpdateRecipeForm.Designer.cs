namespace DBapplication
{
    partial class UpdateRecipeForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CookingTimeTB = new System.Windows.Forms.TextBox();
            this.DifficultyCB = new System.Windows.Forms.ComboBox();
            this.NutritionalInfoTB = new System.Windows.Forms.TextBox();
            this.StepsTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AddPhotoLabel = new System.Windows.Forms.Label();
            this.RecipePhotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Anaktoria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(808, 437);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(153, 49);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CookingTimeTB
            // 
            this.CookingTimeTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookingTimeTB.Location = new System.Drawing.Point(402, 144);
            this.CookingTimeTB.Name = "CookingTimeTB";
            this.CookingTimeTB.Size = new System.Drawing.Size(139, 29);
            this.CookingTimeTB.TabIndex = 21;
            this.CookingTimeTB.Text = "Cooking Time";
            // 
            // DifficultyCB
            // 
            this.DifficultyCB.Font = new System.Drawing.Font("Anaktoria", 8F);
            this.DifficultyCB.FormattingEnabled = true;
            this.DifficultyCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.DifficultyCB.Location = new System.Drawing.Point(400, 98);
            this.DifficultyCB.Name = "DifficultyCB";
            this.DifficultyCB.Size = new System.Drawing.Size(142, 24);
            this.DifficultyCB.TabIndex = 20;
            this.DifficultyCB.Text = "Difficulty (1-5)";
            // 
            // NutritionalInfoTB
            // 
            this.NutritionalInfoTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionalInfoTB.Location = new System.Drawing.Point(386, 227);
            this.NutritionalInfoTB.Multiline = true;
            this.NutritionalInfoTB.Name = "NutritionalInfoTB";
            this.NutritionalInfoTB.Size = new System.Drawing.Size(288, 142);
            this.NutritionalInfoTB.TabIndex = 19;
            this.NutritionalInfoTB.Text = "Nutritional Information";
            // 
            // StepsTB
            // 
            this.StepsTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsTB.Location = new System.Drawing.Point(703, 224);
            this.StepsTB.Multiline = true;
            this.StepsTB.Name = "StepsTB";
            this.StepsTB.Size = new System.Drawing.Size(288, 145);
            this.StepsTB.TabIndex = 18;
            this.StepsTB.Text = "Steps";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTB.Location = new System.Drawing.Point(703, 48);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(288, 142);
            this.DescriptionTB.TabIndex = 17;
            this.DescriptionTB.Text = "Description";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(400, 48);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(288, 29);
            this.NameTB.TabIndex = 16;
            this.NameTB.Text = "Name";
            // 
            // AddPhotoLabel
            // 
            this.AddPhotoLabel.AutoSize = true;
            this.AddPhotoLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhotoLabel.Location = new System.Drawing.Point(38, 329);
            this.AddPhotoLabel.Name = "AddPhotoLabel";
            this.AddPhotoLabel.Size = new System.Drawing.Size(272, 26);
            this.AddPhotoLabel.TabIndex = 15;
            this.AddPhotoLabel.Text = "Click on picture to add or update.";
            // 
            // RecipePhotoPictureBox
            // 
            this.RecipePhotoPictureBox.Location = new System.Drawing.Point(43, 25);
            this.RecipePhotoPictureBox.Name = "RecipePhotoPictureBox";
            this.RecipePhotoPictureBox.Size = new System.Drawing.Size(309, 289);
            this.RecipePhotoPictureBox.TabIndex = 14;
            this.RecipePhotoPictureBox.TabStop = false;
            this.RecipePhotoPictureBox.Click += new System.EventHandler(this.RecipePhotoPictureBox_Click);
            // 
            // UpdateRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 511);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CookingTimeTB);
            this.Controls.Add(this.DifficultyCB);
            this.Controls.Add(this.NutritionalInfoTB);
            this.Controls.Add(this.StepsTB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.AddPhotoLabel);
            this.Controls.Add(this.RecipePhotoPictureBox);
            this.Name = "UpdateRecipeForm";
            this.Text = "UpdateRecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.RecipePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox CookingTimeTB;
        private System.Windows.Forms.ComboBox DifficultyCB;
        private System.Windows.Forms.TextBox NutritionalInfoTB;
        private System.Windows.Forms.TextBox StepsTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label AddPhotoLabel;
        private System.Windows.Forms.PictureBox RecipePhotoPictureBox;
    }
}