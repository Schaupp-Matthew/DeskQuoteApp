namespace MegaDesk_3_MatthewSchaupp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heading = new System.Windows.Forms.Label();
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.AutoSize = true;
            this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.Location = new System.Drawing.Point(124, 158);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(161, 35);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "&Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MegaDesk_3_MatthewSchaupp.Properties.Resources.desk;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 237);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.Control;
            this.heading.Location = new System.Drawing.Point(282, 42);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(230, 46);
            this.heading.TabIndex = 5;
            this.heading.Text = "Mega Desk";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.AutoSize = true;
            this.viewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteButton.Location = new System.Drawing.Point(124, 227);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(161, 35);
            this.viewQuoteButton.TabIndex = 6;
            this.viewQuoteButton.Text = "&View Quotes";
            this.viewQuoteButton.UseVisualStyleBackColor = true;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.AutoSize = true;
            this.searchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButton.Location = new System.Drawing.Point(124, 294);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(161, 35);
            this.searchQuotesButton.TabIndex = 7;
            this.searchQuotesButton.Text = "&Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(124, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(161, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuoteButton);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addQuoteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

