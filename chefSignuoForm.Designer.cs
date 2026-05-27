namespace DBapplication
{
    partial class chefSignuoForm
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
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.MatchPassLabel = new System.Windows.Forms.Label();
            this.PassCharWarningLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.ConfirmPassTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ToSeeYouLabel = new System.Windows.Forms.Label();
            this.ExcitedLabel = new System.Windows.Forms.Label();
            this.WeAreLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BottomRightPic = new System.Windows.Forms.PictureBox();
            this.TopRightPic = new System.Windows.Forms.PictureBox();
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.BioTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LNameTB
            // 
            this.LNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTB.Location = new System.Drawing.Point(472, 391);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(154, 30);
            this.LNameTB.TabIndex = 62;
            this.LNameTB.Text = "Last Name";
            // 
            // MatchPassLabel
            // 
            this.MatchPassLabel.AutoSize = true;
            this.MatchPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchPassLabel.ForeColor = System.Drawing.Color.Red;
            this.MatchPassLabel.Location = new System.Drawing.Point(621, 345);
            this.MatchPassLabel.Name = "MatchPassLabel";
            this.MatchPassLabel.Size = new System.Drawing.Size(147, 16);
            this.MatchPassLabel.TabIndex = 61;
            this.MatchPassLabel.Text = "Passwords must match!";
            this.MatchPassLabel.Visible = false;
            // 
            // PassCharWarningLabel
            // 
            this.PassCharWarningLabel.AutoSize = true;
            this.PassCharWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCharWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PassCharWarningLabel.Location = new System.Drawing.Point(621, 289);
            this.PassCharWarningLabel.Name = "PassCharWarningLabel";
            this.PassCharWarningLabel.Size = new System.Drawing.Size(231, 16);
            this.PassCharWarningLabel.TabIndex = 60;
            this.PassCharWarningLabel.Text = "Password must be atleast 8 chracters!";
            this.PassCharWarningLabel.Visible = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(382, 612);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(150, 54);
            this.SignUpButton.TabIndex = 59;
            this.SignUpButton.Text = "Sign Up ---->";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // FNameTB
            // 
            this.FNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTB.Location = new System.Drawing.Point(291, 391);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(154, 30);
            this.FNameTB.TabIndex = 58;
            this.FNameTB.Text = "First Name";
            // 
            // ConfirmPassTB
            // 
            this.ConfirmPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTB.Location = new System.Drawing.Point(291, 336);
            this.ConfirmPassTB.Name = "ConfirmPassTB";
            this.ConfirmPassTB.Size = new System.Drawing.Size(325, 30);
            this.ConfirmPassTB.TabIndex = 57;
            this.ConfirmPassTB.Text = "Confirm Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(291, 280);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(325, 30);
            this.PasswordTB.TabIndex = 56;
            this.PasswordTB.Text = "Password";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(291, 225);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(325, 30);
            this.EmailTB.TabIndex = 55;
            this.EmailTB.Text = "Email";
            // 
            // ToSeeYouLabel
            // 
            this.ToSeeYouLabel.AutoSize = true;
            this.ToSeeYouLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToSeeYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ToSeeYouLabel.Location = new System.Drawing.Point(522, 184);
            this.ToSeeYouLabel.Name = "ToSeeYouLabel";
            this.ToSeeYouLabel.Size = new System.Drawing.Size(160, 36);
            this.ToSeeYouLabel.TabIndex = 54;
            this.ToSeeYouLabel.Text = "to see you!";
            // 
            // ExcitedLabel
            // 
            this.ExcitedLabel.AutoSize = true;
            this.ExcitedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExcitedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ExcitedLabel.Location = new System.Drawing.Point(427, 132);
            this.ExcitedLabel.Name = "ExcitedLabel";
            this.ExcitedLabel.Size = new System.Drawing.Size(217, 58);
            this.ExcitedLabel.TabIndex = 53;
            this.ExcitedLabel.Text = "Excited!!";
            // 
            // WeAreLabel
            // 
            this.WeAreLabel.AutoSize = true;
            this.WeAreLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeAreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.WeAreLabel.Location = new System.Drawing.Point(302, 150);
            this.WeAreLabel.Name = "WeAreLabel";
            this.WeAreLabel.Size = new System.Drawing.Size(110, 36);
            this.WeAreLabel.TabIndex = 52;
            this.WeAreLabel.Text = "We are";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.WelcomeLabel.Location = new System.Drawing.Point(280, 57);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(308, 67);
            this.WelcomeLabel.TabIndex = 51;
            this.WelcomeLabel.Text = "Welcome!!";
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(750, 523);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(215, 194);
            this.BottomRightPic.TabIndex = 50;
            this.BottomRightPic.TabStop = false;
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(781, -44);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(215, 194);
            this.TopRightPic.TabIndex = 49;
            this.TopRightPic.TabStop = false;
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-36, -35);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(215, 194);
            this.TopLeftPic.TabIndex = 63;
            this.TopLeftPic.TabStop = false;
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-53, 523);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(215, 194);
            this.BottomLeftPic.TabIndex = 64;
            this.BottomLeftPic.TabStop = false;
            // 
            // BioTB
            // 
            this.BioTB.AcceptsReturn = true;
            this.BioTB.AcceptsTab = true;
            this.BioTB.AllowDrop = true;
            this.BioTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BioTB.Location = new System.Drawing.Point(291, 432);
            this.BioTB.Multiline = true;
            this.BioTB.Name = "BioTB";
            this.BioTB.Size = new System.Drawing.Size(325, 157);
            this.BioTB.TabIndex = 65;
            this.BioTB.Text = "Bio (Optional)";
            // 
            // chefSignuoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 678);
            this.Controls.Add(this.BioTB);
            this.Controls.Add(this.BottomLeftPic);
            this.Controls.Add(this.TopLeftPic);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.MatchPassLabel);
            this.Controls.Add(this.PassCharWarningLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.ConfirmPassTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ToSeeYouLabel);
            this.Controls.Add(this.ExcitedLabel);
            this.Controls.Add(this.WeAreLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.BottomRightPic);
            this.Controls.Add(this.TopRightPic);
            this.Name = "chefSignuoForm";
            this.Text = "chefSignuoForm";
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.Label MatchPassLabel;
        private System.Windows.Forms.Label PassCharWarningLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox ConfirmPassTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label ToSeeYouLabel;
        private System.Windows.Forms.Label ExcitedLabel;
        private System.Windows.Forms.Label WeAreLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox BottomRightPic;
        private System.Windows.Forms.PictureBox TopRightPic;
        private System.Windows.Forms.PictureBox TopLeftPic;
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.TextBox BioTB;
    }
}