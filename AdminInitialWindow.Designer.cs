namespace DBapplication
{
    partial class AdminInitialWindow
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
            this.WelcomeLabel2 = new System.Windows.Forms.Label();
            this.ViewChefsListPB = new System.Windows.Forms.PictureBox();
            this.ViewNutritionistsListPB = new System.Windows.Forms.PictureBox();
            this.ViewCompanyListPB = new System.Windows.Forms.PictureBox();
            this.ChefsListLabel = new System.Windows.Forms.Label();
            this.NutritionistsListLabel = new System.Windows.Forms.Label();
            this.CompanyListLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewChefsListPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNutritionistsListPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCompanyListPB)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(42, 38);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(625, 67);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Hello, Raghad Waleed";
            // 
            // WelcomeLabel2
            // 
            this.WelcomeLabel2.AutoSize = true;
            this.WelcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel2.Location = new System.Drawing.Point(326, 100);
            this.WelcomeLabel2.Name = "WelcomeLabel2";
            this.WelcomeLabel2.Size = new System.Drawing.Size(331, 36);
            this.WelcomeLabel2.TabIndex = 3;
            this.WelcomeLabel2.Text = "Nice to see you again!";
            // 
            // ViewChefsListPB
            // 
            this.ViewChefsListPB.Location = new System.Drawing.Point(10, 177);
            this.ViewChefsListPB.Name = "ViewChefsListPB";
            this.ViewChefsListPB.Size = new System.Drawing.Size(254, 243);
            this.ViewChefsListPB.TabIndex = 4;
            this.ViewChefsListPB.TabStop = false;
            this.ViewChefsListPB.Click += new System.EventHandler(this.ViewChefsListPB_Click);
            // 
            // ViewNutritionistsListPB
            // 
            this.ViewNutritionistsListPB.Location = new System.Drawing.Point(310, 177);
            this.ViewNutritionistsListPB.Name = "ViewNutritionistsListPB";
            this.ViewNutritionistsListPB.Size = new System.Drawing.Size(252, 243);
            this.ViewNutritionistsListPB.TabIndex = 5;
            this.ViewNutritionistsListPB.TabStop = false;
            this.ViewNutritionistsListPB.Click += new System.EventHandler(this.ViewNutritionistsListPB_Click);
            // 
            // ViewCompanyListPB
            // 
            this.ViewCompanyListPB.Location = new System.Drawing.Point(598, 177);
            this.ViewCompanyListPB.Name = "ViewCompanyListPB";
            this.ViewCompanyListPB.Size = new System.Drawing.Size(248, 243);
            this.ViewCompanyListPB.TabIndex = 6;
            this.ViewCompanyListPB.TabStop = false;
            this.ViewCompanyListPB.Click += new System.EventHandler(this.ViewCompanyListPB_Click);
            // 
            // ChefsListLabel
            // 
            this.ChefsListLabel.AutoSize = true;
            this.ChefsListLabel.BackColor = System.Drawing.Color.White;
            this.ChefsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ChefsListLabel.Location = new System.Drawing.Point(49, 290);
            this.ChefsListLabel.Name = "ChefsListLabel";
            this.ChefsListLabel.Size = new System.Drawing.Size(215, 26);
            this.ChefsListLabel.TabIndex = 7;
            this.ChefsListLabel.Text = "View Pending Chefs ";
            this.ChefsListLabel.Click += new System.EventHandler(this.ViewChefsListPB_Click);
            // 
            // NutritionistsListLabel
            // 
            this.NutritionistsListLabel.AutoSize = true;
            this.NutritionistsListLabel.BackColor = System.Drawing.Color.White;
            this.NutritionistsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NutritionistsListLabel.Location = new System.Drawing.Point(327, 290);
            this.NutritionistsListLabel.Name = "NutritionistsListLabel";
            this.NutritionistsListLabel.Size = new System.Drawing.Size(266, 26);
            this.NutritionistsListLabel.TabIndex = 8;
            this.NutritionistsListLabel.Text = "View Pending Nutritionists";
            this.NutritionistsListLabel.Click += new System.EventHandler(this.ViewNutritionistsListPB_Click);
            // 
            // CompanyListLabel
            // 
            this.CompanyListLabel.AutoSize = true;
            this.CompanyListLabel.BackColor = System.Drawing.Color.White;
            this.CompanyListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CompanyListLabel.Location = new System.Drawing.Point(624, 290);
            this.CompanyListLabel.Name = "CompanyListLabel";
            this.CompanyListLabel.Size = new System.Drawing.Size(263, 26);
            this.CompanyListLabel.TabIndex = 9;
            this.CompanyListLabel.Text = "View Pending Companies";
            this.CompanyListLabel.Click += new System.EventHandler(this.ViewCompanyListPB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "view reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminInitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CompanyListLabel);
            this.Controls.Add(this.NutritionistsListLabel);
            this.Controls.Add(this.ChefsListLabel);
            this.Controls.Add(this.ViewCompanyListPB);
            this.Controls.Add(this.ViewNutritionistsListPB);
            this.Controls.Add(this.ViewChefsListPB);
            this.Controls.Add(this.WelcomeLabel2);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "AdminInitialWindow";
            this.Text = "AdminInitialWindow";
            this.Load += new System.EventHandler(this.AdminInitialWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewChefsListPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNutritionistsListPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCompanyListPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label WelcomeLabel2;
        private System.Windows.Forms.PictureBox ViewChefsListPB;
        private System.Windows.Forms.PictureBox ViewNutritionistsListPB;
        private System.Windows.Forms.PictureBox ViewCompanyListPB;
        private System.Windows.Forms.Label ChefsListLabel;
        private System.Windows.Forms.Label NutritionistsListLabel;
        private System.Windows.Forms.Label CompanyListLabel;
        private System.Windows.Forms.Button button1;
    }
}