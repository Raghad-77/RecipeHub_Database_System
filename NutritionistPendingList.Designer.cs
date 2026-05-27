namespace DBapplication
{
    partial class NutritionistPendingList
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
            this.PendingNutritionistsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelNutritionists = new System.Windows.Forms.FlowLayoutPanel();
            this.NoNutritionistsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelNutritionists.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingNutritionistsLabel
            // 
            this.PendingNutritionistsLabel.AutoSize = true;
            this.PendingNutritionistsLabel.Font = new System.Drawing.Font("Anaktoria", 25F, System.Drawing.FontStyle.Bold);
            this.PendingNutritionistsLabel.Location = new System.Drawing.Point(238, 9);
            this.PendingNutritionistsLabel.Name = "PendingNutritionistsLabel";
            this.PendingNutritionistsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PendingNutritionistsLabel.Size = new System.Drawing.Size(512, 53);
            this.PendingNutritionistsLabel.TabIndex = 5;
            this.PendingNutritionistsLabel.Text = "Pending Nutritionists: 10020";
            // 
            // flowLayoutPanelNutritionists
            // 
            this.flowLayoutPanelNutritionists.Controls.Add(this.NoNutritionistsLabel);
            this.flowLayoutPanelNutritionists.Location = new System.Drawing.Point(3, 86);
            this.flowLayoutPanelNutritionists.Name = "flowLayoutPanelNutritionists";
            this.flowLayoutPanelNutritionists.Size = new System.Drawing.Size(795, 352);
            this.flowLayoutPanelNutritionists.TabIndex = 6;
            // 
            // NoNutritionistsLabel
            // 
            this.NoNutritionistsLabel.AutoSize = true;
            this.NoNutritionistsLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoNutritionistsLabel.Location = new System.Drawing.Point(3, 0);
            this.NoNutritionistsLabel.Name = "NoNutritionistsLabel";
            this.NoNutritionistsLabel.Size = new System.Drawing.Size(277, 26);
            this.NoNutritionistsLabel.TabIndex = 0;
            this.NoNutritionistsLabel.Text = "There are no Nutritionists pending.";
            this.NoNutritionistsLabel.Visible = false;
            // 
            // NutritionistPendingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelNutritionists);
            this.Controls.Add(this.PendingNutritionistsLabel);
            this.Name = "NutritionistPendingList";
            this.Text = "NutritionistPendingList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NutritionistPendingList_FormClosed);
            this.Load += new System.EventHandler(this.PendingNutritionistsList_Load);
            this.flowLayoutPanelNutritionists.ResumeLayout(false);
            this.flowLayoutPanelNutritionists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PendingNutritionistsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNutritionists;
        private System.Windows.Forms.Label NoNutritionistsLabel;
    }
}