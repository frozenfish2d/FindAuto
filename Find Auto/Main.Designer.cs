namespace Find_Auto
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonParse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuRows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchDataSet = new Find_Auto.searchDataSet();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.contextMenuRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.buttonParse);
            this.panelTop.Location = new System.Drawing.Point(-8, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 108);
            this.panelTop.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(752, 32);
            this.textBox1.TabIndex = 4;
            // 
            // buttonParse
            // 
            this.buttonParse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.buttonParse.FlatAppearance.BorderSize = 0;
            this.buttonParse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(35)))), ((int)(((byte)(200)))));
            this.buttonParse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParse.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonParse.ForeColor = System.Drawing.Color.White;
            this.buttonParse.Location = new System.Drawing.Point(821, 31);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(151, 42);
            this.buttonParse.TabIndex = 3;
            this.buttonParse.Text = "REFRESH LIST";
            this.buttonParse.UseVisualStyleBackColor = false;
            this.buttonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.labelModel);
            this.panel1.Controls.Add(this.labelBrand);
            this.panel1.Controls.Add(this.labelSite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 86);
            this.panel1.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(817, 43);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(151, 24);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "5 000 - 15 000 $";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(628, 43);
            this.labelYear.Margin = new System.Windows.Forms.Padding(0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(114, 24);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "2011 - 2020";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.ForeColor = System.Drawing.Color.White;
            this.labelModel.Location = new System.Drawing.Point(420, 43);
            this.labelModel.Margin = new System.Windows.Forms.Padding(0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(54, 24);
            this.labelModel.TabIndex = 7;
            this.labelModel.Text = "E350";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(215, 43);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(148, 24);
            this.labelBrand.TabIndex = 6;
            this.labelBrand.Text = "Mercedes-Benz";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSite.ForeColor = System.Drawing.Color.White;
            this.labelSite.Location = new System.Drawing.Point(65, 43);
            this.labelSite.Margin = new System.Windows.Forms.Padding(0);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(96, 24);
            this.labelSite.TabIndex = 5;
            this.labelSite.Text = "Sitename";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(817, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(628, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(420, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 61;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.State,
            this.modelCol,
            this.descripionCol,
            this.yearCol,
            this.milageCol,
            this.locationCol,
            this.priceCol});
            this.dataGrid.ContextMenuStrip = this.contextMenuRows;
            this.dataGrid.GridColor = System.Drawing.SystemColors.Window;
            this.dataGrid.Location = new System.Drawing.Point(9, 194);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.ContextMenuStrip = this.contextMenuRows;
            this.dataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowTemplate.Height = 98;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(966, 458);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellMouseEnter);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // State
            // 
            this.State.HeaderText = "";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.State.Width = 10;
            // 
            // modelCol
            // 
            this.modelCol.HeaderText = "Model";
            this.modelCol.Name = "modelCol";
            this.modelCol.ReadOnly = true;
            this.modelCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modelCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modelCol.Width = 150;
            // 
            // descripionCol
            // 
            this.descripionCol.HeaderText = "Descripion";
            this.descripionCol.Name = "descripionCol";
            this.descripionCol.ReadOnly = true;
            this.descripionCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripionCol.Width = 305;
            // 
            // yearCol
            // 
            this.yearCol.HeaderText = "Year";
            this.yearCol.Name = "yearCol";
            this.yearCol.ReadOnly = true;
            this.yearCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yearCol.Width = 102;
            // 
            // milageCol
            // 
            this.milageCol.HeaderText = "Milage";
            this.milageCol.Name = "milageCol";
            this.milageCol.ReadOnly = true;
            this.milageCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.milageCol.Width = 128;
            // 
            // locationCol
            // 
            this.locationCol.HeaderText = "Location";
            this.locationCol.Name = "locationCol";
            this.locationCol.ReadOnly = true;
            this.locationCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.locationCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.locationCol.Width = 140;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceCol.Width = 115;
            // 
            // contextMenuRows
            // 
            this.contextMenuRows.BackColor = System.Drawing.Color.White;
            this.contextMenuRows.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInBrowser,
            this.addToFavorites});
            this.contextMenuRows.Name = "contextMenuRows";
            this.contextMenuRows.ShowImageMargin = false;
            this.contextMenuRows.Size = new System.Drawing.Size(171, 74);
            // 
            // showInBrowser
            // 
            this.showInBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showInBrowser.Name = "showInBrowser";
            this.showInBrowser.Size = new System.Drawing.Size(170, 24);
            this.showInBrowser.Text = "Show in browser";
            this.showInBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showInBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.showInBrowser.Click += new System.EventHandler(this.showInBrowser_Click);
            // 
            // addToFavorites
            // 
            this.addToFavorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToFavorites.Name = "addToFavorites";
            this.addToFavorites.Size = new System.Drawing.Size(170, 24);
            this.addToFavorites.Text = "Add to favorites";
            this.addToFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // searchDataSetBindingSource
            // 
            this.searchDataSetBindingSource.DataSource = this.searchDataSet;
            this.searchDataSetBindingSource.Position = 0;
            // 
            // searchDataSet
            // 
            this.searchDataSet.DataSetName = "searchDataSet";
            this.searchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Find Auto";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.contextMenuRows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.ContextMenuStrip contextMenuRows;
        private System.Windows.Forms.ToolStripMenuItem showInBrowser;
        private System.Windows.Forms.ToolStripMenuItem addToFavorites;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn milageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.BindingSource searchDataSetBindingSource;
        private searchDataSet searchDataSet;
        private System.Windows.Forms.TextBox textBox1;
    }
}

