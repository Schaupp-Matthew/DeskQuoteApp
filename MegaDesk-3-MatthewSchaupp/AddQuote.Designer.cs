namespace MegaDesk_3_MatthewSchaupp
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.backButton = new System.Windows.Forms.Button();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthMessage = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthMessage = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(78, 30);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "<-- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(177, 106);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            this.widthTextBox.Validated += new System.EventHandler(this.WidthTextBox_Validated);
            // 
            // widthMessage
            // 
            this.widthMessage.AutoSize = true;
            this.widthMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.widthMessage.Location = new System.Drawing.Point(176, 90);
            this.widthMessage.Name = "widthMessage";
            this.widthMessage.Size = new System.Drawing.Size(101, 13);
            this.widthMessage.TabIndex = 2;
            this.widthMessage.Text = "*(min 24\"; max 96\") ";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.widthLabel.Location = new System.Drawing.Point(51, 106);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(114, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width (inches):";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.depthLabel.Location = new System.Drawing.Point(53, 154);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(117, 20);
            this.depthLabel.TabIndex = 13;
            this.depthLabel.Text = "Depth (inches):";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthMessage
            // 
            this.depthMessage.AutoSize = true;
            this.depthMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.depthMessage.Location = new System.Drawing.Point(178, 138);
            this.depthMessage.Name = "depthMessage";
            this.depthMessage.Size = new System.Drawing.Size(101, 13);
            this.depthMessage.TabIndex = 12;
            this.depthMessage.Text = "*(min 12\"; max 48\") ";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(179, 154);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 1;
            this.depthTextBox.TextChanged += new System.EventHandler(this.DepthTextBox_TextChanged);
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.depthMessage);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthMessage);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label widthMessage;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label depthMessage;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
    }
}