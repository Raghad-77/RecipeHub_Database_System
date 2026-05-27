namespace DBapplication
{
    partial class CompanyPendingList
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
            this.PendingCompaniesLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelCompanies = new System.Windows.Forms.FlowLayoutPanel();
            this.NoCompaniesLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelCompanies.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingCompaniesLabel
            // 
            this.PendingCompaniesLabel.AutoSize = true;
            this.PendingCompaniesLabel.Font = new System.Drawing.Font("Anaktoria", 25F, System.Drawing.FontStyle.Bold);
            this.PendingCompaniesLabel.Location = new System.Drawing.Point(304, 9);
            this.PendingCompaniesLabel.Name = "PendingCompaniesLabel";
            this.PendingCompaniesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PendingCompaniesLabel.Size = new System.Drawing.Size(471, 53);
            this.PendingCompaniesLabel.TabIndex = 5;
            this.PendingCompaniesLabel.Text = "Pending Companies: 10020";
            // 
            // flowLayoutPanelCompanies
            // 
            this.flowLayoutPanelCompanies.Controls.Add(this.NoCompaniesLabel);
            this.flowLayoutPanelCompanies.Location = new System.Drawing.Point(2, 86);
            this.flowLayoutPanelCompanies.Name = "flowLayoutPanelCompanies";
            this.flowLayoutPanelCompanies.Size = new System.Drawing.Size(795, 352);
            this.flowLayoutPanelCompanies.TabIndex = 6;
            // 
            // NoCompaniesLabel
            // 
            this.NoCompaniesLabel.AutoSize = true;
            this.NoCompaniesLabel.Font = new System.Drawing.Font("Anaktoria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoCompaniesLabel.Location = new System.Drawing.Point(3, 0);
            this.NoCompaniesLabel.Name = "NoCompaniesLabel";
            this.NoCompaniesLabel.Size = new System.Drawing.Size(258, 26);
            this.NoCompaniesLabel.TabIndex = 0;
            this.NoCompaniesLabel.Text = "There are no companies pending.";
            this.NoCompaniesLabel.Visible = false;
            // 
            // CompanyPendingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelCompanies);
            this.Controls.Add(this.PendingCompaniesLabel);
            this.Name = "CompanyPendingList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyPendingList_FormClosed);
            this.Load += new System.EventHandler(this.PendingCompaniesList_Load);
            this.flowLayoutPanelCompanies.ResumeLayout(false);
            this.flowLayoutPanelCompanies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PendingCompaniesLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCompanies;
        private System.Windows.Forms.Label NoCompaniesLabel;
    }
}