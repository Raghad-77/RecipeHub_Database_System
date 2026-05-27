namespace DBapplication
{
    partial class UserSignUpForm
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
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LNameTB
            // 
            this.LNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTB.Location = new System.Drawing.Point(429, 392);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(154, 30);
            this.LNameTB.TabIndex = 48;
            this.LNameTB.Text = "Last Name";
            // 
            // MatchPassLabel
            // 
            this.MatchPassLabel.AutoSize = true;
            this.MatchPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchPassLabel.ForeColor = System.Drawing.Color.Red;
            this.MatchPassLabel.Location = new System.Drawing.Point(578, 346);
            this.MatchPassLabel.Name = "MatchPassLabel";
            this.MatchPassLabel.Size = new System.Drawing.Size(147, 16);
            this.MatchPassLabel.TabIndex = 47;
            this.MatchPassLabel.Text = "Passwords must match!";
            this.MatchPassLabel.Visible = false;
            // 
            // PassCharWarningLabel
            // 
            this.PassCharWarningLabel.AutoSize = true;
            this.PassCharWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCharWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PassCharWarningLabel.Location = new System.Drawing.Point(578, 290);
            this.PassCharWarningLabel.Name = "PassCharWarningLabel";
            this.PassCharWarningLabel.Size = new System.Drawing.Size(231, 16);
            this.PassCharWarningLabel.TabIndex = 46;
            this.PassCharWarningLabel.Text = "Password must be atleast 8 chracters!";
            this.PassCharWarningLabel.Visible = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(317, 464);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(150, 54);
            this.SignUpButton.TabIndex = 45;
            this.SignUpButton.Text = "Sign Up ---->";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // FNameTB
            // 
            this.FNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTB.Location = new System.Drawing.Point(248, 392);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(154, 30);
            this.FNameTB.TabIndex = 44;
            this.FNameTB.Text = "First Name";
            // 
            // ConfirmPassTB
            // 
            this.ConfirmPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTB.Location = new System.Drawing.Point(248, 337);
            this.ConfirmPassTB.Name = "ConfirmPassTB";
            this.ConfirmPassTB.Size = new System.Drawing.Size(325, 30);
            this.ConfirmPassTB.TabIndex = 43;
            this.ConfirmPassTB.Text = "Confirm Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(248, 281);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(325, 30);
            this.PasswordTB.TabIndex = 42;
            this.PasswordTB.Text = "Password";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(248, 226);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(325, 30);
            this.EmailTB.TabIndex = 41;
            this.EmailTB.Text = "Email";
            // 
            // ToSeeYouLabel
            // 
            this.ToSeeYouLabel.AutoSize = true;
            this.ToSeeYouLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToSeeYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ToSeeYouLabel.Location = new System.Drawing.Point(479, 185);
            this.ToSeeYouLabel.Name = "ToSeeYouLabel";
            this.ToSeeYouLabel.Size = new System.Drawing.Size(160, 36);
            this.ToSeeYouLabel.TabIndex = 40;
            this.ToSeeYouLabel.Text = "to see you!";
            // 
            // ExcitedLabel
            // 
            this.ExcitedLabel.AutoSize = true;
            this.ExcitedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExcitedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ExcitedLabel.Location = new System.Drawing.Point(384, 133);
            this.ExcitedLabel.Name = "ExcitedLabel";
            this.ExcitedLabel.Size = new System.Drawing.Size(217, 58);
            this.ExcitedLabel.TabIndex = 39;
            this.ExcitedLabel.Text = "Excited!!";
            // 
            // WeAreLabel
            // 
            this.WeAreLabel.AutoSize = true;
            this.WeAreLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeAreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.WeAreLabel.Location = new System.Drawing.Point(259, 151);
            this.WeAreLabel.Name = "WeAreLabel";
            this.WeAreLabel.Size = new System.Drawing.Size(110, 36);
            this.WeAreLabel.TabIndex = 38;
            this.WeAreLabel.Text = "We are";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.WelcomeLabel.Location = new System.Drawing.Point(237, 58);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(308, 67);
            this.WelcomeLabel.TabIndex = 37;
            this.WelcomeLabel.Text = "Welcome!!";
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(703, 434);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(215, 194);
            this.BottomRightPic.TabIndex = 36;
            this.BottomRightPic.TabStop = false;
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(738, -43);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(215, 194);
            this.TopRightPic.TabIndex = 35;
            this.TopRightPic.TabStop = false;
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-1, 423);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(215, 194);
            this.BottomLeftPic.TabIndex = 50;
            this.BottomLeftPic.TabStop = false;
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-14, -34);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(215, 194);
            this.TopLeftPic.TabIndex = 49;
            this.TopLeftPic.TabStop = false;
            // 
            // UserSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 600);
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
            this.Name = "UserSignUpForm";
            this.Text = "UserSignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
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
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.PictureBox TopLeftPic;
    }
}