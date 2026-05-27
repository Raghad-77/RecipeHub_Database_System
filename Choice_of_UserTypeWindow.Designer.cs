namespace DBapplication
{
    partial class Choice_of_UserTypeWindow
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
            this.AreYouLabel = new System.Windows.Forms.Label();
            this.UsertypeCB = new System.Windows.Forms.ComboBox();
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.BottomRightPic = new System.Windows.Forms.PictureBox();
            this.TopRightPic = new System.Windows.Forms.PictureBox();
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AreYouLabel
            // 
            this.AreYouLabel.AutoSize = true;
            this.AreYouLabel.Font = new System.Drawing.Font("Anaktoria", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreYouLabel.Location = new System.Drawing.Point(175, 88);
            this.AreYouLabel.Name = "AreYouLabel";
            this.AreYouLabel.Size = new System.Drawing.Size(410, 85);
            this.AreYouLabel.TabIndex = 7;
            this.AreYouLabel.Text = "What are you?";
            // 
            // UsertypeCB
            // 
            this.UsertypeCB.FormattingEnabled = true;
            this.UsertypeCB.Items.AddRange(new object[] {
            "User",
            "Chef",
            "Nutritionist",
            "Company"});
            this.UsertypeCB.Location = new System.Drawing.Point(282, 176);
            this.UsertypeCB.Name = "UsertypeCB";
            this.UsertypeCB.Size = new System.Drawing.Size(335, 24);
            this.UsertypeCB.TabIndex = 8;
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-30, 331);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(246, 194);
            this.BottomLeftPic.TabIndex = 12;
            this.BottomLeftPic.TabStop = false;
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(616, 331);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(246, 194);
            this.BottomRightPic.TabIndex = 11;
            this.BottomRightPic.TabStop = false;
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(616, -74);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(246, 194);
            this.TopRightPic.TabIndex = 10;
            this.TopRightPic.TabStop = false;
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-30, -74);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(246, 194);
            this.TopLeftPic.TabIndex = 9;
            this.TopLeftPic.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Font = new System.Drawing.Font("Anaktoria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.Black;
            this.NextButton.Location = new System.Drawing.Point(447, 275);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(138, 38);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Choice_of_UserTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AreYouLabel);
            this.Controls.Add(this.BottomLeftPic);
            this.Controls.Add(this.BottomRightPic);
            this.Controls.Add(this.TopRightPic);
            this.Controls.Add(this.TopLeftPic);
            this.Controls.Add(this.UsertypeCB);
            this.Name = "Choice_of_UserTypeWindow";
            this.Text = "Choice_of_UserTypeWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Choice_of_UserTypeWindow_FormClosed);
            this.Load += new System.EventHandler(this.Choice_of_UserTypeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AreYouLabel;
        private System.Windows.Forms.ComboBox UsertypeCB;
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.PictureBox BottomRightPic;
        private System.Windows.Forms.PictureBox TopRightPic;
        private System.Windows.Forms.PictureBox TopLeftPic;
        private System.Windows.Forms.Button NextButton;
    }
}