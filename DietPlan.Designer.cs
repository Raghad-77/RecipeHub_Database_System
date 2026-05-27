namespace DBapplication
{
    partial class DietPlan
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
            this.label1 = new System.Windows.Forms.Label();
            this.RecipeName = new System.Windows.Forms.Label();
            this.NameRecipe = new System.Windows.Forms.TextBox();
            this.Decription = new System.Windows.Forms.Label();
            this.Des = new System.Windows.Forms.TextBox();
            this.Steps = new System.Windows.Forms.Label();
            this.Stepss = new System.Windows.Forms.TextBox();
            this.NutInfo = new System.Windows.Forms.Label();
            this.NutInfoBox = new System.Windows.Forms.TextBox();
            this.Diff = new System.Windows.Forms.Label();
            this.DiffBox = new System.Windows.Forms.TextBox();
            this.CookTime = new System.Windows.Forms.Label();
            this.CookingTimeBox = new System.Windows.Forms.TextBox();
            this.AddRecipeButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DPbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GoalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Recipe Or Diet Plant";
            this.label1.Click += new System.EventHandler(this.DietPlan_Load);
            // 
            // RecipeName
            // 
            this.RecipeName.AutoSize = true;
            this.RecipeName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeName.Location = new System.Drawing.Point(12, 82);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(153, 32);
            this.RecipeName.TabIndex = 1;
            this.RecipeName.Text = "Recipe Name";
            this.RecipeName.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameRecipe
            // 
            this.NameRecipe.Location = new System.Drawing.Point(12, 110);
            this.NameRecipe.Name = "NameRecipe";
            this.NameRecipe.Size = new System.Drawing.Size(135, 22);
            this.NameRecipe.TabIndex = 2;
            // 
            // Decription
            // 
            this.Decription.AutoSize = true;
            this.Decription.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decription.Location = new System.Drawing.Point(16, 158);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(131, 32);
            this.Decription.TabIndex = 3;
            this.Decription.Text = "Decription";
            // 
            // Des
            // 
            this.Des.Location = new System.Drawing.Point(12, 193);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(455, 22);
            this.Des.TabIndex = 4;
            // 
            // Steps
            // 
            this.Steps.AutoSize = true;
            this.Steps.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steps.Location = new System.Drawing.Point(12, 248);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(67, 32);
            this.Steps.TabIndex = 5;
            this.Steps.Text = "Steps";
            // 
            // Stepss
            // 
            this.Stepss.Location = new System.Drawing.Point(12, 283);
            this.Stepss.Name = "Stepss";
            this.Stepss.Size = new System.Drawing.Size(455, 22);
            this.Stepss.TabIndex = 6;
            // 
            // NutInfo
            // 
            this.NutInfo.AutoSize = true;
            this.NutInfo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutInfo.Location = new System.Drawing.Point(12, 333);
            this.NutInfo.Name = "NutInfo";
            this.NutInfo.Size = new System.Drawing.Size(277, 32);
            this.NutInfo.TabIndex = 7;
            this.NutInfo.Text = "Nutritional Information";
            // 
            // NutInfoBox
            // 
            this.NutInfoBox.Location = new System.Drawing.Point(12, 382);
            this.NutInfoBox.Name = "NutInfoBox";
            this.NutInfoBox.Size = new System.Drawing.Size(455, 22);
            this.NutInfoBox.TabIndex = 8;
            this.NutInfoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diff.Location = new System.Drawing.Point(176, 75);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(119, 32);
            this.Diff.TabIndex = 9;
            this.Diff.Text = "Difficulty";
            this.Diff.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // DiffBox
            // 
            this.DiffBox.Location = new System.Drawing.Point(182, 110);
            this.DiffBox.Name = "DiffBox";
            this.DiffBox.Size = new System.Drawing.Size(79, 22);
            this.DiffBox.TabIndex = 10;
            this.DiffBox.TextChanged += new System.EventHandler(this.DiffBox_TextChanged);
            // 
            // CookTime
            // 
            this.CookTime.AutoSize = true;
            this.CookTime.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookTime.Location = new System.Drawing.Point(341, 75);
            this.CookTime.Name = "CookTime";
            this.CookTime.Size = new System.Drawing.Size(126, 32);
            this.CookTime.TabIndex = 11;
            this.CookTime.Text = "Cook Time";
            // 
            // CookingTimeBox
            // 
            this.CookingTimeBox.Location = new System.Drawing.Point(347, 110);
            this.CookingTimeBox.Name = "CookingTimeBox";
            this.CookingTimeBox.Size = new System.Drawing.Size(79, 22);
            this.CookingTimeBox.TabIndex = 12;
            // 
            // AddRecipeButt
            // 
            this.AddRecipeButt.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipeButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRecipeButt.Location = new System.Drawing.Point(548, 373);
            this.AddRecipeButt.Name = "AddRecipeButt";
            this.AddRecipeButt.Size = new System.Drawing.Size(144, 43);
            this.AddRecipeButt.TabIndex = 15;
            this.AddRecipeButt.Text = "Add Recipe";
            this.AddRecipeButt.UseVisualStyleBackColor = true;
            this.AddRecipeButt.Click += new System.EventHandler(this.AddRecipeButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Diet Plan Name";
            // 
            // DPbox
            // 
            this.DPbox.Location = new System.Drawing.Point(569, 193);
            this.DPbox.Name = "DPbox";
            this.DPbox.Size = new System.Drawing.Size(79, 22);
            this.DPbox.TabIndex = 17;
            this.DPbox.TextChanged += new System.EventHandler(this.DPbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Diet Plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Goal";
            // 
            // GoalBox
            // 
            this.GoalBox.Location = new System.Drawing.Point(569, 283);
            this.GoalBox.Name = "GoalBox";
            this.GoalBox.Size = new System.Drawing.Size(79, 22);
            this.GoalBox.TabIndex = 20;
            // 
            // DietPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DPbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddRecipeButt);
            this.Controls.Add(this.CookingTimeBox);
            this.Controls.Add(this.CookTime);
            this.Controls.Add(this.DiffBox);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.NutInfoBox);
            this.Controls.Add(this.NutInfo);
            this.Controls.Add(this.Stepss);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.Des);
            this.Controls.Add(this.Decription);
            this.Controls.Add(this.NameRecipe);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.label1);
            this.Name = "DietPlan";
            this.Text = "DietPlan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DietPlan_FormClosed);
            this.Load += new System.EventHandler(this.DietPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecipeName;
        private System.Windows.Forms.TextBox NameRecipe;
        private System.Windows.Forms.Label Decription;
        private System.Windows.Forms.TextBox Des;
        private System.Windows.Forms.Label Steps;
        private System.Windows.Forms.TextBox Stepss;
        private System.Windows.Forms.Label NutInfo;
        private System.Windows.Forms.TextBox NutInfoBox;
        private System.Windows.Forms.Label Diff;
        private System.Windows.Forms.TextBox DiffBox;
        private System.Windows.Forms.Label CookTime;
        private System.Windows.Forms.TextBox CookingTimeBox;
        private System.Windows.Forms.Button AddRecipeButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DPbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GoalBox;
    }
}