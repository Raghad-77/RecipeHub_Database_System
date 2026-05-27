namespace DBapplication
{
    partial class AddRecipeForm
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
            this.AddPhotoLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.StepsTB = new System.Windows.Forms.TextBox();
            this.NutritionalInfoTB = new System.Windows.Forms.TextBox();
            this.DifficultyCB = new System.Windows.Forms.ComboBox();
            this.CookingTimeTB = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RecipePhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.CollabCB = new System.Windows.Forms.CheckBox();
            this.CompanyNameTB = new System.Windows.Forms.TextBox();
            this.ReferralCodeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecipePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPhotoLabel
            // 
            this.AddPhotoLabel.AutoSize = true;
            this.AddPhotoLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhotoLabel.Location = new System.Drawing.Point(25, 327);
            this.AddPhotoLabel.Name = "AddPhotoLabel";
            this.AddPhotoLabel.Size = new System.Drawing.Size(272, 26);
            this.AddPhotoLabel.TabIndex = 6;
            this.AddPhotoLabel.Text = "Click on picture to add or update.";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(387, 46);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(288, 29);
            this.NameTB.TabIndex = 7;
            this.NameTB.Text = "Name";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTB.Location = new System.Drawing.Point(690, 46);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(288, 142);
            this.DescriptionTB.TabIndex = 8;
            this.DescriptionTB.Text = "Description";
            // 
            // StepsTB
            // 
            this.StepsTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsTB.Location = new System.Drawing.Point(681, 211);
            this.StepsTB.Multiline = true;
            this.StepsTB.Name = "StepsTB";
            this.StepsTB.Size = new System.Drawing.Size(288, 145);
            this.StepsTB.TabIndex = 9;
            this.StepsTB.Text = "Steps";
            // 
            // NutritionalInfoTB
            // 
            this.NutritionalInfoTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionalInfoTB.Location = new System.Drawing.Point(357, 211);
            this.NutritionalInfoTB.Multiline = true;
            this.NutritionalInfoTB.Name = "NutritionalInfoTB";
            this.NutritionalInfoTB.Size = new System.Drawing.Size(288, 142);
            this.NutritionalInfoTB.TabIndex = 10;
            this.NutritionalInfoTB.Text = "Nutritional Information";
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
            this.DifficultyCB.Location = new System.Drawing.Point(387, 96);
            this.DifficultyCB.Name = "DifficultyCB";
            this.DifficultyCB.Size = new System.Drawing.Size(142, 24);
            this.DifficultyCB.TabIndex = 11;
            this.DifficultyCB.Text = "Difficulty (1-5)";
            // 
            // CookingTimeTB
            // 
            this.CookingTimeTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookingTimeTB.Location = new System.Drawing.Point(389, 142);
            this.CookingTimeTB.Name = "CookingTimeTB";
            this.CookingTimeTB.Size = new System.Drawing.Size(139, 29);
            this.CookingTimeTB.TabIndex = 12;
            this.CookingTimeTB.Text = "Cooking Time";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Anaktoria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(795, 435);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(153, 49);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RecipePhotoPictureBox
            // 
            this.RecipePhotoPictureBox.Location = new System.Drawing.Point(30, 23);
            this.RecipePhotoPictureBox.Name = "RecipePhotoPictureBox";
            this.RecipePhotoPictureBox.Size = new System.Drawing.Size(309, 289);
            this.RecipePhotoPictureBox.TabIndex = 0;
            this.RecipePhotoPictureBox.TabStop = false;
            this.RecipePhotoPictureBox.Click += new System.EventHandler(this.RecipePhotoPictureBox_Click);
            // 
            // CollabCB
            // 
            this.CollabCB.AutoSize = true;
            this.CollabCB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollabCB.Location = new System.Drawing.Point(34, 387);
            this.CollabCB.Name = "CollabCB";
            this.CollabCB.Size = new System.Drawing.Size(199, 30);
            this.CollabCB.TabIndex = 14;
            this.CollabCB.Text = "Is this recipe a collab?";
            this.CollabCB.UseVisualStyleBackColor = true;
            this.CollabCB.CheckedChanged += new System.EventHandler(this.CollabCB_CheckedChanged);
            // 
            // CompanyNameTB
            // 
            this.CompanyNameTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameTB.Location = new System.Drawing.Point(34, 423);
            this.CompanyNameTB.Name = "CompanyNameTB";
            this.CompanyNameTB.Size = new System.Drawing.Size(288, 29);
            this.CompanyNameTB.TabIndex = 15;
            this.CompanyNameTB.Text = "Chef Email";
            // 
            // ReferralCodeTB
            // 
            this.ReferralCodeTB.Font = new System.Drawing.Font("Anaktoria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferralCodeTB.Location = new System.Drawing.Point(34, 470);
            this.ReferralCodeTB.Name = "ReferralCodeTB";
            this.ReferralCodeTB.Size = new System.Drawing.Size(288, 29);
            this.ReferralCodeTB.TabIndex = 16;
            this.ReferralCodeTB.Text = "Referral Code";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 524);
            this.Controls.Add(this.ReferralCodeTB);
            this.Controls.Add(this.CompanyNameTB);
            this.Controls.Add(this.CollabCB);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CookingTimeTB);
            this.Controls.Add(this.DifficultyCB);
            this.Controls.Add(this.NutritionalInfoTB);
            this.Controls.Add(this.StepsTB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.AddPhotoLabel);
            this.Controls.Add(this.RecipePhotoPictureBox);
            this.Name = "AddRecipeForm";
            this.Text = "AddRecipeForm";
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RecipePhotoPictureBox;
        private System.Windows.Forms.Label AddPhotoLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox StepsTB;
        private System.Windows.Forms.TextBox NutritionalInfoTB;
        private System.Windows.Forms.ComboBox DifficultyCB;
        private System.Windows.Forms.TextBox CookingTimeTB;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckBox CollabCB;
        private System.Windows.Forms.TextBox CompanyNameTB;
        private System.Windows.Forms.TextBox ReferralCodeTB;
    }
}