namespace DBapplication
{
    partial class PendingChefsList
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
            this.PendingChefsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelChefs = new System.Windows.Forms.FlowLayoutPanel();
            this.NoChefsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelChefs.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingChefsLabel
            // 
            this.PendingChefsLabel.AutoSize = true;
            this.PendingChefsLabel.Font = new System.Drawing.Font("Anaktoria", 25F, System.Drawing.FontStyle.Bold);
            this.PendingChefsLabel.Location = new System.Drawing.Point(367, 24);
            this.PendingChefsLabel.Name = "PendingChefsLabel";
            this.PendingChefsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PendingChefsLabel.Size = new System.Drawing.Size(390, 53);
            this.PendingChefsLabel.TabIndex = 2;
            this.PendingChefsLabel.Text = "Pending Chefs: 10020";
            // 
            // flowLayoutPanelChefs
            // 
            this.flowLayoutPanelChefs.Controls.Add(this.NoChefsLabel);
            this.flowLayoutPanelChefs.Location = new System.Drawing.Point(3, 95);
            this.flowLayoutPanelChefs.Name = "flowLayoutPanelChefs";
            this.flowLayoutPanelChefs.Size = new System.Drawing.Size(795, 352);
            this.flowLayoutPanelChefs.TabIndex = 4;
            // 
            // NoChefsLabel
            // 
            this.NoChefsLabel.AutoSize = true;
            this.NoChefsLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoChefsLabel.Location = new System.Drawing.Point(3, 0);
            this.NoChefsLabel.Name = "NoChefsLabel";
            this.NoChefsLabel.Size = new System.Drawing.Size(221, 26);
            this.NoChefsLabel.TabIndex = 0;
            this.NoChefsLabel.Text = "There are no chefs pending.";
            this.NoChefsLabel.Visible = false;
            // 
            // PendingChefsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelChefs);
            this.Controls.Add(this.PendingChefsLabel);
            this.Name = "PendingChefsList";
            this.Text = "PendingChefsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PendingChefsList_FormClosed);
            this.Load += new System.EventHandler(this.PendingChefsList_Load);
            this.flowLayoutPanelChefs.ResumeLayout(false);
            this.flowLayoutPanelChefs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PendingChefsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChefs;
        private System.Windows.Forms.Label NoChefsLabel;
    }
}