namespace Find_Auto
{
    partial class ShowSearches
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridSearches = new System.Windows.Forms.DataGridView();
            this.searchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearches)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSearches
            // 
            this.dataGridSearches.AllowUserToAddRows = false;
            this.dataGridSearches.AllowUserToDeleteRows = false;
            this.dataGridSearches.AllowUserToResizeColumns = false;
            this.dataGridSearches.AllowUserToResizeRows = false;
            this.dataGridSearches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridSearches.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSearches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSearches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSearches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSearches.ColumnHeadersHeight = 30;
            this.dataGridSearches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSearches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchId,
            this.date,
            this.site,
            this.brand,
            this.model,
            this.year,
            this.price});
            this.dataGridSearches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearches.GridColor = System.Drawing.Color.White;
            this.dataGridSearches.Location = new System.Drawing.Point(0, 84);
            this.dataGridSearches.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridSearches.MultiSelect = false;
            this.dataGridSearches.Name = "dataGridSearches";
            this.dataGridSearches.ReadOnly = true;
            this.dataGridSearches.RowHeadersVisible = false;
            this.dataGridSearches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSearches.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridSearches.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridSearches.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.dataGridSearches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSearches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSearches.Size = new System.Drawing.Size(884, 377);
            this.dataGridSearches.TabIndex = 0;
            // 
            // searchId
            // 
            this.searchId.HeaderText = "SearchId";
            this.searchId.Name = "searchId";
            this.searchId.ReadOnly = true;
            this.searchId.Visible = false;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 150;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // site
            // 
            this.site.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.site.HeaderText = "Site";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            this.site.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.year.Width = 48;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.price.Width = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 84);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(671, 22);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(201, 42);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "DELETE SELECTED";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.buttonLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(12, 22);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(173, 42);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "LOAD SELECTED";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // ShowSearches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridSearches);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1696, 748);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ShowSearches";
            this.ShowIcon = false;
            this.Text = "Search manage";
            this.Activated += new System.EventHandler(this.ShowSearches_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearches)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLoad;
    }
}