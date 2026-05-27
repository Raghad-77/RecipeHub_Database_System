namespace DBapplication
{
    partial class HelloChefForm
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
            this.hellohello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cheffollowers = new System.Windows.Forms.Label();
            this.chefList = new System.Windows.Forms.ListView();
            this.ShareR = new System.Windows.Forms.Button();
            this.editR = new System.Windows.Forms.Button();
            this.recipephoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RName = new System.Windows.Forms.Label();
            this.Rdifficulty = new System.Windows.Forms.Label();
            this.Rtime = new System.Windows.Forms.Label();
            this.RDescription = new System.Windows.Forms.Label();
            this.Rnut = new System.Windows.Forms.Label();
            this.Rsteps = new System.Windows.Forms.Label();
            this.likes = new System.Windows.Forms.Label();
            this.customProgressBar1 = new CustomProgressBar();
            this.customProgressBar2 = new CustomProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.NoRecipes = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipephoto)).BeginInit();
            this.SuspendLayout();
            // 
            // hellohello
            // 
            this.hellohello.AutoSize = true;
            this.hellohello.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellohello.Location = new System.Drawing.Point(11, 9);
            this.hellohello.Name = "hellohello";
            this.hellohello.Size = new System.Drawing.Size(433, 71);
            this.hellohello.TabIndex = 0;
            this.hellohello.Text = "Hello Chef Mustafa!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a recipe and enjoy!!";
            // 
            // cheffollowers
            // 
            this.cheffollowers.AutoSize = true;
            this.cheffollowers.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheffollowers.Location = new System.Drawing.Point(278, 80);
            this.cheffollowers.Name = "cheffollowers";
            this.cheffollowers.Size = new System.Drawing.Size(224, 22);
            this.cheffollowers.TabIndex = 2;
            this.cheffollowers.Text = "Number Of Followers: 200";
            // 
            // chefList
            // 
            this.chefList.HideSelection = false;
            this.chefList.Location = new System.Drawing.Point(24, 120);
            this.chefList.Name = "chefList";
            this.chefList.Size = new System.Drawing.Size(486, 319);
            this.chefList.TabIndex = 3;
            this.chefList.UseCompatibleStateImageBehavior = false;
            this.chefList.SelectedIndexChanged += new System.EventHandler(this.chefList_SelectedIndexChanged);
            // 
            // ShareR
            // 
            this.ShareR.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareR.Location = new System.Drawing.Point(16, 444);
            this.ShareR.Name = "ShareR";
            this.ShareR.Size = new System.Drawing.Size(185, 38);
            this.ShareR.TabIndex = 4;
            this.ShareR.Text = "Share New Recipe";
            this.ShareR.UseVisualStyleBackColor = true;
            this.ShareR.Click += new System.EventHandler(this.ShareR_Click);
            // 
            // editR
            // 
            this.editR.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editR.Location = new System.Drawing.Point(207, 445);
            this.editR.Name = "editR";
            this.editR.Size = new System.Drawing.Size(184, 38);
            this.editR.TabIndex = 5;
            this.editR.Text = "Edit Existing Recipe";
            this.editR.UseVisualStyleBackColor = true;
            this.editR.Click += new System.EventHandler(this.editR_Click);
            // 
            // recipephoto
            // 
            this.recipephoto.Location = new System.Drawing.Point(523, 69);
            this.recipephoto.Name = "recipephoto";
            this.recipephoto.Size = new System.Drawing.Size(264, 139);
            this.recipephoto.TabIndex = 7;
            this.recipephoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Recipe";
            // 
            // RName
            // 
            this.RName.AutoSize = true;
            this.RName.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RName.Location = new System.Drawing.Point(803, 69);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(48, 20);
            this.RName.TabIndex = 9;
            this.RName.Text = "Name";
            // 
            // Rdifficulty
            // 
            this.Rdifficulty.AutoSize = true;
            this.Rdifficulty.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdifficulty.Location = new System.Drawing.Point(521, 272);
            this.Rdifficulty.Name = "Rdifficulty";
            this.Rdifficulty.Size = new System.Drawing.Size(63, 17);
            this.Rdifficulty.TabIndex = 10;
            this.Rdifficulty.Text = "Difficulty";
            // 
            // Rtime
            // 
            this.Rtime.AutoSize = true;
            this.Rtime.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtime.Location = new System.Drawing.Point(768, 272);
            this.Rtime.Name = "Rtime";
            this.Rtime.Size = new System.Drawing.Size(86, 17);
            this.Rtime.TabIndex = 11;
            this.Rtime.Text = "Cooking Time";
            // 
            // RDescription
            // 
            this.RDescription.AutoSize = true;
            this.RDescription.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDescription.Location = new System.Drawing.Point(803, 119);
            this.RDescription.Name = "RDescription";
            this.RDescription.Size = new System.Drawing.Size(84, 20);
            this.RDescription.TabIndex = 12;
            this.RDescription.Text = "Description";
            // 
            // Rnut
            // 
            this.Rnut.AutoSize = true;
            this.Rnut.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rnut.Location = new System.Drawing.Point(521, 338);
            this.Rnut.Name = "Rnut";
            this.Rnut.Size = new System.Drawing.Size(103, 17);
            this.Rnut.TabIndex = 13;
            this.Rnut.Text = "Nutritional Info";
            // 
            // Rsteps
            // 
            this.Rsteps.AutoSize = true;
            this.Rsteps.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rsteps.Location = new System.Drawing.Point(768, 338);
            this.Rsteps.Name = "Rsteps";
            this.Rsteps.Size = new System.Drawing.Size(41, 17);
            this.Rsteps.TabIndex = 14;
            this.Rsteps.Text = "Steps";
            // 
            // likes
            // 
            this.likes.AutoSize = true;
            this.likes.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likes.Location = new System.Drawing.Point(521, 211);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(65, 17);
            this.likes.TabIndex = 15;
            this.likes.Text = "100 Likes";
            this.likes.Click += new System.EventHandler(this.likes_Click);
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(523, 300);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.Size = new System.Drawing.Size(174, 23);
            this.customProgressBar1.TabIndex = 16;
            // 
            // customProgressBar2
            // 
            this.customProgressBar2.Location = new System.Drawing.Point(771, 300);
            this.customProgressBar2.Name = "customProgressBar2";
            this.customProgressBar2.Size = new System.Drawing.Size(174, 23);
            this.customProgressBar2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 464);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Choose Collection";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(885, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 40);
            this.logout.TabIndex = 20;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // NoRecipes
            // 
            this.NoRecipes.AutoSize = true;
            this.NoRecipes.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRecipes.Location = new System.Drawing.Point(187, 272);
            this.NoRecipes.Name = "NoRecipes";
            this.NoRecipes.Size = new System.Drawing.Size(160, 17);
            this.NoRecipes.TabIndex = 21;
            this.NoRecipes.Text = "You Have no Recipes Yet";
            this.NoRecipes.Visible = false;
            // 
            // Messages
            // 
            this.Messages.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages.Location = new System.Drawing.Point(877, 464);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(83, 26);
            this.Messages.TabIndex = 22;
            this.Messages.Text = "Chat";
            this.Messages.UseVisualStyleBackColor = true;
            this.Messages.Click += new System.EventHandler(this.Messages_Click);
            // 
            // HelloChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 502);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.NoRecipes);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.customProgressBar2);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.Rsteps);
            this.Controls.Add(this.Rnut);
            this.Controls.Add(this.RDescription);
            this.Controls.Add(this.Rtime);
            this.Controls.Add(this.Rdifficulty);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipephoto);
            this.Controls.Add(this.editR);
            this.Controls.Add(this.ShareR);
            this.Controls.Add(this.chefList);
            this.Controls.Add(this.cheffollowers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hellohello);
            this.Name = "HelloChefForm";
            this.Text = "HelloChefForm";
            ((System.ComponentModel.ISupportInitialize)(this.recipephoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hellohello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cheffollowers;
        private System.Windows.Forms.ListView chefList;
        private System.Windows.Forms.Button ShareR;
        private System.Windows.Forms.Button editR;
        private System.Windows.Forms.PictureBox recipephoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RName;
        private System.Windows.Forms.Label Rdifficulty;
        private System.Windows.Forms.Label Rtime;
        private System.Windows.Forms.Label RDescription;
        private System.Windows.Forms.Label Rnut;
        private System.Windows.Forms.Label Rsteps;
        private System.Windows.Forms.Label likes;
        private CustomProgressBar customProgressBar1;
        private CustomProgressBar customProgressBar2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label NoRecipes;
        private System.Windows.Forms.Button Messages;
    }
}