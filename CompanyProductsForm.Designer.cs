namespace DBapplication
{
    partial class CompanyProductsForm
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
            this.ProductListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ProductListView
            // 
            this.ProductListView.HideSelection = false;
            this.ProductListView.Location = new System.Drawing.Point(9, 69);
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(781, 376);
            this.ProductListView.TabIndex = 0;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            // 
            // CompanyProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductListView);
            this.Name = "CompanyProductsForm";
            this.Text = "CompanyProductsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyProductsForm_FormClosed);
            this.Load += new System.EventHandler(this.CompanyProductsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductListView;
    }
}