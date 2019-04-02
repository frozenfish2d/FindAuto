using System.Windows.Forms;

namespace Find_Auto
{
    partial class SelectProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProject));
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMinPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMinYear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchDataSet = new Find_Auto.searchDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(53, 215);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(351, 32);
            this.comboBoxBrand.TabIndex = 1;
            this.comboBoxBrand.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(49, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select brand *";
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Projects(*.fapr)|*fapr\"";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.buttonSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.buttonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.ForeColor = System.Drawing.Color.White;
            this.buttonSelect.Location = new System.Drawing.Point(-3, 0);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(456, 65);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "SEARCH HISTORY";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select site *";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.IntegralHeight = false;
            this.comboBoxSite.ItemHeight = 24;
            this.comboBoxSite.Location = new System.Drawing.Point(53, 139);
            this.comboBoxSite.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(351, 32);
            this.comboBoxSite.TabIndex = 0;
            this.comboBoxSite.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSite_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(49, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select model";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(53, 281);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(351, 32);
            this.comboBoxModel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(49, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Min price";
            // 
            // comboBoxMinPrice
            // 
            this.comboBoxMinPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxMinPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMinPrice.FormattingEnabled = true;
            this.comboBoxMinPrice.Location = new System.Drawing.Point(53, 419);
            this.comboBoxMinPrice.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMinPrice.Name = "comboBoxMinPrice";
            this.comboBoxMinPrice.Size = new System.Drawing.Size(162, 32);
            this.comboBoxMinPrice.TabIndex = 5;
            // 
            // comboBoxMaxPrice
            // 
            this.comboBoxMaxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxMaxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaxPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaxPrice.FormattingEnabled = true;
            this.comboBoxMaxPrice.Location = new System.Drawing.Point(242, 419);
            this.comboBoxMaxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaxPrice.Name = "comboBoxMaxPrice";
            this.comboBoxMaxPrice.Size = new System.Drawing.Size(162, 32);
            this.comboBoxMaxPrice.TabIndex = 6;
            // 
            // comboBoxMaxYear
            // 
            this.comboBoxMaxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxMaxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaxYear.FormattingEnabled = true;
            this.comboBoxMaxYear.Location = new System.Drawing.Point(242, 345);
            this.comboBoxMaxYear.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxMaxYear.Name = "comboBoxMaxYear";
            this.comboBoxMaxYear.Size = new System.Drawing.Size(162, 32);
            this.comboBoxMaxYear.TabIndex = 4;
            // 
            // comboBoxMinYear
            // 
            this.comboBoxMinYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxMinYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMinYear.FormattingEnabled = true;
            this.comboBoxMinYear.Location = new System.Drawing.Point(53, 345);
            this.comboBoxMinYear.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMinYear.Name = "comboBoxMinYear";
            this.comboBoxMinYear.Size = new System.Drawing.Size(162, 32);
            this.comboBoxMinYear.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.Location = new System.Drawing.Point(49, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Min year";
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.buttonCreateNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCreateNew.FlatAppearance.BorderSize = 0;
            this.buttonCreateNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.buttonCreateNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNew.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNew.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNew.Location = new System.Drawing.Point(-3, 505);
            this.buttonCreateNew.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCreateNew.Size = new System.Drawing.Size(456, 65);
            this.buttonCreateNew.TabIndex = 7;
            this.buttonCreateNew.Text = "SEARCH";
            this.buttonCreateNew.UseVisualStyleBackColor = false;
            this.buttonCreateNew.Click += new System.EventHandler(this.buttonCreateNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.Location = new System.Drawing.Point(238, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label7.Location = new System.Drawing.Point(237, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label9.Location = new System.Drawing.Point(130, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "or create new search";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchDataSet
            // 
            this.searchDataSet.DataSetName = "searchDataSet";
            this.searchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.buttonCreateNew);
            this.Controls.Add(this.comboBoxMaxYear);
            this.Controls.Add(this.comboBoxMinYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMaxPrice);
            this.Controls.Add(this.comboBoxMinPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProject";
            this.ShowInTaskbar = false;
            this.Text = "Select or Create New Project";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMinPrice;
        private System.Windows.Forms.ComboBox comboBoxMaxPrice;
        private System.Windows.Forms.ComboBox comboBoxMaxYear;
        private System.Windows.Forms.ComboBox comboBoxMinYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCreateNew;
        private Label label6;
        private Label label7;
        private Label label9;
        private searchDataSet searchDataSet;
    }
}