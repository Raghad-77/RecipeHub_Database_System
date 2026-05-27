namespace DBapplication
{
    partial class FilterForm
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
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilterOptions = new System.Windows.Forms.ComboBox();
            this.comboBoxDifficultyLevel = new System.Windows.Forms.ComboBox();
            this.difficultylbl = new System.Windows.Forms.Label();
            this.numericUpDownMinTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxTime = new System.Windows.Forms.NumericUpDown();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.namelbl = new System.Windows.Forms.Label();
            this.minlbl = new System.Windows.Forms.Label();
            this.maxlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxFilterType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Location = new System.Drawing.Point(128, 20);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFilterType.TabIndex = 0;
            this.comboBoxFilterType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "filter based on:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxFilterOptions
            // 
            this.comboBoxFilterOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxFilterOptions.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFilterOptions.FormattingEnabled = true;
            this.comboBoxFilterOptions.Location = new System.Drawing.Point(470, 20);
            this.comboBoxFilterOptions.Name = "comboBoxFilterOptions";
            this.comboBoxFilterOptions.Size = new System.Drawing.Size(193, 24);
            this.comboBoxFilterOptions.TabIndex = 3;
            this.comboBoxFilterOptions.Visible = false;
            this.comboBoxFilterOptions.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterOptions_SelectedIndexChanged);
            // 
            // comboBoxDifficultyLevel
            // 
            this.comboBoxDifficultyLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxDifficultyLevel.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDifficultyLevel.FormattingEnabled = true;
            this.comboBoxDifficultyLevel.Location = new System.Drawing.Point(469, 20);
            this.comboBoxDifficultyLevel.Name = "comboBoxDifficultyLevel";
            this.comboBoxDifficultyLevel.Size = new System.Drawing.Size(166, 24);
            this.comboBoxDifficultyLevel.TabIndex = 4;
            this.comboBoxDifficultyLevel.Visible = false;
            this.comboBoxDifficultyLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxDifficultyLevel_SelectedIndexChanged);
            // 
            // difficultylbl
            // 
            this.difficultylbl.AutoSize = true;
            this.difficultylbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.difficultylbl.ForeColor = System.Drawing.Color.Black;
            this.difficultylbl.Location = new System.Drawing.Point(311, 23);
            this.difficultylbl.Name = "difficultylbl";
            this.difficultylbl.Size = new System.Drawing.Size(138, 17);
            this.difficultylbl.TabIndex = 5;
            this.difficultylbl.Text = "Choose difficulty level";
            this.difficultylbl.Visible = false;
            this.difficultylbl.Click += new System.EventHandler(this.difficultylbl_Click);
            // 
            // numericUpDownMinTime
            // 
            this.numericUpDownMinTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numericUpDownMinTime.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownMinTime.Location = new System.Drawing.Point(12, 81);
            this.numericUpDownMinTime.Name = "numericUpDownMinTime";
            this.numericUpDownMinTime.Size = new System.Drawing.Size(64, 24);
            this.numericUpDownMinTime.TabIndex = 6;
            this.numericUpDownMinTime.Visible = false;
            this.numericUpDownMinTime.ValueChanged += new System.EventHandler(this.numericUpDownMinTime_ValueChanged);
            // 
            // numericUpDownMaxTime
            // 
            this.numericUpDownMaxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numericUpDownMaxTime.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownMaxTime.Location = new System.Drawing.Point(82, 81);
            this.numericUpDownMaxTime.Name = "numericUpDownMaxTime";
            this.numericUpDownMaxTime.Size = new System.Drawing.Size(64, 24);
            this.numericUpDownMaxTime.TabIndex = 7;
            this.numericUpDownMaxTime.Visible = false;
            this.numericUpDownMaxTime.ValueChanged += new System.EventHandler(this.numericUpDownMaxTime_ValueChanged);
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.buttonApplyFilters.Location = new System.Drawing.Point(196, 74);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(108, 35);
            this.buttonApplyFilters.TabIndex = 8;
            this.buttonApplyFilters.Text = "Lets Go!";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Visible = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipes.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridViewRecipes.Location = new System.Drawing.Point(31, 148);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.RowHeadersWidth = 51;
            this.dataGridViewRecipes.RowTemplate.Height = 26;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(1001, 495);
            this.dataGridViewRecipes.TabIndex = 9;
            this.dataGridViewRecipes.Visible = false;
            this.dataGridViewRecipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipes_CellContentClick);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.namelbl.ForeColor = System.Drawing.Color.Black;
            this.namelbl.Location = new System.Drawing.Point(320, 23);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(93, 17);
            this.namelbl.TabIndex = 10;
            this.namelbl.Text = "Choose Name";
            this.namelbl.Visible = false;
            this.namelbl.Click += new System.EventHandler(this.namelbl_Click);
            // 
            // minlbl
            // 
            this.minlbl.AutoSize = true;
            this.minlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.minlbl.ForeColor = System.Drawing.Color.Black;
            this.minlbl.Location = new System.Drawing.Point(12, 61);
            this.minlbl.Name = "minlbl";
            this.minlbl.Size = new System.Drawing.Size(42, 17);
            this.minlbl.TabIndex = 11;
            this.minlbl.Text = "Min =";
            this.minlbl.Visible = false;
            this.minlbl.Click += new System.EventHandler(this.minlbl_Click);
            // 
            // maxlbl
            // 
            this.maxlbl.AutoSize = true;
            this.maxlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.maxlbl.ForeColor = System.Drawing.Color.Black;
            this.maxlbl.Location = new System.Drawing.Point(88, 60);
            this.maxlbl.Name = "maxlbl";
            this.maxlbl.Size = new System.Drawing.Size(47, 17);
            this.maxlbl.TabIndex = 12;
            this.maxlbl.Text = "Max =";
            this.maxlbl.Visible = false;
            this.maxlbl.Click += new System.EventHandler(this.maxlbl_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBapplication.Properties.Resources.Nutritionist_scribbles;
            this.ClientSize = new System.Drawing.Size(1084, 665);
            this.Controls.Add(this.maxlbl);
            this.Controls.Add(this.minlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.buttonApplyFilters);
            this.Controls.Add(this.numericUpDownMaxTime);
            this.Controls.Add(this.numericUpDownMinTime);
            this.Controls.Add(this.difficultylbl);
            this.Controls.Add(this.comboBoxDifficultyLevel);
            this.Controls.Add(this.comboBoxFilterOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.dataGridViewRecipes);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilterForm_FormClosed);
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilterOptions;
        private System.Windows.Forms.ComboBox comboBoxDifficultyLevel;
        private System.Windows.Forms.Label difficultylbl;
        private System.Windows.Forms.NumericUpDown numericUpDownMinTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxTime;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.DataGridView dataGridViewRecipes;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label minlbl;
        private System.Windows.Forms.Label maxlbl;
    }
}