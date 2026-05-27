namespace DBapplication
{
    partial class CompanySignUpForm
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
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            this.TopRightPic = new System.Windows.Forms.PictureBox();
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.BottomRightPic = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WeAreLabel = new System.Windows.Forms.Label();
            this.ExcitedLabel = new System.Windows.Forms.Label();
            this.ToSeeYouLabel = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ConfirmPassTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.BioTB = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PassCharWarningLabel = new System.Windows.Forms.Label();
            this.MatchPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-59, -47);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(246, 194);
            this.TopLeftPic.TabIndex = 4;
            this.TopLeftPic.TabStop = false;
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(766, -47);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(246, 194);
            this.TopRightPic.TabIndex = 5;
            this.TopRightPic.TabStop = false;
            this.TopRightPic.Click += new System.EventHandler(this.TopRightPic_Click);
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-59, 475);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(246, 194);
            this.BottomLeftPic.TabIndex = 6;
            this.BottomLeftPic.TabStop = false;
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(766, 475);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(246, 194);
            this.BottomRightPic.TabIndex = 7;
            this.BottomRightPic.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Anaktoria", 35F);
            this.WelcomeLabel.Location = new System.Drawing.Point(193, 16);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(256, 75);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "Welcome!!";
            // 
            // WeAreLabel
            // 
            this.WeAreLabel.AutoSize = true;
            this.WeAreLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeAreLabel.Font = new System.Drawing.Font("Anaktoria", 18F);
            this.WeAreLabel.Location = new System.Drawing.Point(218, 109);
            this.WeAreLabel.Name = "WeAreLabel";
            this.WeAreLabel.Size = new System.Drawing.Size(101, 38);
            this.WeAreLabel.TabIndex = 9;
            this.WeAreLabel.Text = "We are";
            // 
            // ExcitedLabel
            // 
            this.ExcitedLabel.AutoSize = true;
            this.ExcitedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExcitedLabel.Font = new System.Drawing.Font("Anaktoria", 30F);
            this.ExcitedLabel.Location = new System.Drawing.Point(311, 91);
            this.ExcitedLabel.Name = "ExcitedLabel";
            this.ExcitedLabel.Size = new System.Drawing.Size(198, 64);
            this.ExcitedLabel.TabIndex = 10;
            this.ExcitedLabel.Text = "Excited!!";
            // 
            // ToSeeYouLabel
            // 
            this.ToSeeYouLabel.AutoSize = true;
            this.ToSeeYouLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToSeeYouLabel.Font = new System.Drawing.Font("Anaktoria", 18F);
            this.ToSeeYouLabel.Location = new System.Drawing.Point(470, 143);
            this.ToSeeYouLabel.Name = "ToSeeYouLabel";
            this.ToSeeYouLabel.Size = new System.Drawing.Size(130, 38);
            this.ToSeeYouLabel.TabIndex = 11;
            this.ToSeeYouLabel.Text = "to see you!";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(206, 184);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(371, 33);
            this.EmailTB.TabIndex = 12;
            this.EmailTB.Text = "Email";
            this.EmailTB.Enter += new System.EventHandler(this.EmailTB_Enter);
            this.EmailTB.Leave += new System.EventHandler(this.EmailTB_Leave);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(206, 239);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(371, 33);
            this.PasswordTB.TabIndex = 13;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_Enter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // ConfirmPassTB
            // 
            this.ConfirmPassTB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassTB.Location = new System.Drawing.Point(206, 295);
            this.ConfirmPassTB.Name = "ConfirmPassTB";
            this.ConfirmPassTB.Size = new System.Drawing.Size(371, 33);
            this.ConfirmPassTB.TabIndex = 14;
            this.ConfirmPassTB.Text = "Confirm Password";
            this.ConfirmPassTB.TextChanged += new System.EventHandler(this.ConfirmPassTB_TextChanged);
            this.ConfirmPassTB.Enter += new System.EventHandler(this.ConfirmPassTB_Enter);
            this.ConfirmPassTB.Leave += new System.EventHandler(this.ConfirmPassTB_Leave);
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(206, 350);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(176, 33);
            this.NameTB.TabIndex = 15;
            this.NameTB.Text = "Name";
            this.NameTB.Enter += new System.EventHandler(this.NameTB_Enter);
            this.NameTB.Leave += new System.EventHandler(this.NameTB_Leave);
            // 
            // BioTB
            // 
            this.BioTB.AcceptsReturn = true;
            this.BioTB.AcceptsTab = true;
            this.BioTB.AllowDrop = true;
            this.BioTB.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BioTB.Location = new System.Drawing.Point(206, 389);
            this.BioTB.Multiline = true;
            this.BioTB.Name = "BioTB";
            this.BioTB.Size = new System.Drawing.Size(371, 157);
            this.BioTB.TabIndex = 16;
            this.BioTB.Text = "Bio (Optional)";
            this.BioTB.Enter += new System.EventHandler(this.BioTB_Enter);
            this.BioTB.Leave += new System.EventHandler(this.BioTB_Leave);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Anaktoria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(727, 415);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(172, 54);
            this.SignUpButton.TabIndex = 17;
            this.SignUpButton.Text = "Sign Up ---->";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PassCharWarningLabel
            // 
            this.PassCharWarningLabel.AutoSize = true;
            this.PassCharWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassCharWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.PassCharWarningLabel.Location = new System.Drawing.Point(583, 248);
            this.PassCharWarningLabel.Name = "PassCharWarningLabel";
            this.PassCharWarningLabel.Size = new System.Drawing.Size(231, 16);
            this.PassCharWarningLabel.TabIndex = 18;
            this.PassCharWarningLabel.Text = "Password must be atleast 8 chracters!";
            this.PassCharWarningLabel.Visible = false;
            this.PassCharWarningLabel.Click += new System.EventHandler(this.PassCharWarningLabel_Click);
            // 
            // MatchPassLabel
            // 
            this.MatchPassLabel.AutoSize = true;
            this.MatchPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchPassLabel.ForeColor = System.Drawing.Color.Red;
            this.MatchPassLabel.Location = new System.Drawing.Point(583, 304);
            this.MatchPassLabel.Name = "MatchPassLabel";
            this.MatchPassLabel.Size = new System.Drawing.Size(147, 16);
            this.MatchPassLabel.TabIndex = 19;
            this.MatchPassLabel.Text = "Passwords must match!";
            this.MatchPassLabel.Visible = false;
            this.MatchPassLabel.Click += new System.EventHandler(this.MatchPassLabel_Click);
            // 
            // CompanySignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 615);
            this.Controls.Add(this.MatchPassLabel);
            this.Controls.Add(this.PassCharWarningLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.BioTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.ConfirmPassTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ToSeeYouLabel);
            this.Controls.Add(this.ExcitedLabel);
            this.Controls.Add(this.WeAreLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.BottomRightPic);
            this.Controls.Add(this.BottomLeftPic);
            this.Controls.Add(this.TopRightPic);
            this.Controls.Add(this.TopLeftPic);
            this.Name = "CompanySignUpForm";
            this.Text = "CompanySignUpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanySignUpForm_FormClosed);
            this.Load += new System.EventHandler(this.CompanySignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopLeftPic;
        private System.Windows.Forms.PictureBox TopRightPic;
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.PictureBox BottomRightPic;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label WeAreLabel;
        private System.Windows.Forms.Label ExcitedLabel;
        private System.Windows.Forms.Label ToSeeYouLabel;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox ConfirmPassTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox BioTB;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label PassCharWarningLabel;
        private System.Windows.Forms.Label MatchPassLabel;
    }
}