namespace Find_Auto
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.buttonPrevImg = new System.Windows.Forms.Button();
            this.buttonNextImg = new System.Windows.Forms.Button();
            this.labelCurrentImg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaxImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(36, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(544, 408);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(8, 472);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(119, 24);
            this.Name.TabIndex = 1;
            this.Name.Text = "ModelName";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(8, 496);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(111, 24);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(8, 520);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(56, 24);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(8, 544);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(55, 24);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year ";
            // 
            // buttonPrevImg
            // 
            this.buttonPrevImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevImg.FlatAppearance.BorderSize = 0;
            this.buttonPrevImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevImg.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrevImg.Location = new System.Drawing.Point(36, 177);
            this.buttonPrevImg.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrevImg.Name = "buttonPrevImg";
            this.buttonPrevImg.Size = new System.Drawing.Size(61, 111);
            this.buttonPrevImg.TabIndex = 5;
            this.buttonPrevImg.TabStop = false;
            this.buttonPrevImg.Text = "<";
            this.buttonPrevImg.UseVisualStyleBackColor = false;
            this.buttonPrevImg.Click += new System.EventHandler(this.buttonPrevImg_Click);
            // 
            // buttonNextImg
            // 
            this.buttonNextImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextImg.FlatAppearance.BorderSize = 0;
            this.buttonNextImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNextImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextImg.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextImg.ForeColor = System.Drawing.Color.Black;
            this.buttonNextImg.Location = new System.Drawing.Point(516, 177);
            this.buttonNextImg.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextImg.Name = "buttonNextImg";
            this.buttonNextImg.Size = new System.Drawing.Size(64, 111);
            this.buttonNextImg.TabIndex = 6;
            this.buttonNextImg.TabStop = false;
            this.buttonNextImg.Text = ">";
            this.buttonNextImg.UseVisualStyleBackColor = false;
            this.buttonNextImg.Click += new System.EventHandler(this.buttonNextImg_Click);
            // 
            // labelCurrentImg
            // 
            this.labelCurrentImg.AutoSize = true;
            this.labelCurrentImg.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentImg.Location = new System.Drawing.Point(270, 430);
            this.labelCurrentImg.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentImg.Name = "labelCurrentImg";
            this.labelCurrentImg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCurrentImg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCurrentImg.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentImg.TabIndex = 7;
            this.labelCurrentImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "of";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxImg
            // 
            this.labelMaxImg.AutoSize = true;
            this.labelMaxImg.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxImg.Location = new System.Drawing.Point(324, 430);
            this.labelMaxImg.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxImg.Name = "labelMaxImg";
            this.labelMaxImg.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelMaxImg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMaxImg.Size = new System.Drawing.Size(0, 20);
            this.labelMaxImg.TabIndex = 9;
            this.labelMaxImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 690);
            this.Controls.Add(this.labelMaxImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentImg);
            this.Controls.Add(this.buttonNextImg);
            this.Controls.Add(this.buttonPrevImg);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button buttonPrevImg;
        private System.Windows.Forms.Button buttonNextImg;
        private System.Windows.Forms.Label labelCurrentImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaxImg;
    }
}