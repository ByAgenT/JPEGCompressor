namespace JPEGCompressor
{
    partial class MainForm
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
            this.OpenFiles_Button = new System.Windows.Forms.Button();
            this.Compress_Button = new System.Windows.Forms.Button();
            this.ChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.CompressProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // OpenFiles_Button
            // 
            this.OpenFiles_Button.Location = new System.Drawing.Point(935, 39);
            this.OpenFiles_Button.Name = "OpenFiles_Button";
            this.OpenFiles_Button.Size = new System.Drawing.Size(97, 46);
            this.OpenFiles_Button.TabIndex = 0;
            this.OpenFiles_Button.Text = "Open";
            this.OpenFiles_Button.UseVisualStyleBackColor = true;
            this.OpenFiles_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Compress_Button
            // 
            this.Compress_Button.Location = new System.Drawing.Point(935, 131);
            this.Compress_Button.Name = "Compress_Button";
            this.Compress_Button.Size = new System.Drawing.Size(97, 51);
            this.Compress_Button.TabIndex = 1;
            this.Compress_Button.Text = "Compress";
            this.Compress_Button.UseVisualStyleBackColor = true;
            this.Compress_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Размер";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(158, 68);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(16, 17);
            this.amount.TabIndex = 4;
            this.amount.Text = "0";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(253, 68);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(16, 17);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "0";
            // 
            // CompressProgressBar
            // 
            this.CompressProgressBar.Location = new System.Drawing.Point(66, 420);
            this.CompressProgressBar.Name = "CompressProgressBar";
            this.CompressProgressBar.Size = new System.Drawing.Size(835, 23);
            this.CompressProgressBar.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 514);
            this.Controls.Add(this.CompressProgressBar);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compress_Button);
            this.Controls.Add(this.OpenFiles_Button);
            this.Name = "MainForm";
            this.Text = "JPEG Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFiles_Button;
        private System.Windows.Forms.Button Compress_Button;
        private System.Windows.Forms.FolderBrowserDialog ChooseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ProgressBar CompressProgressBar;
    }
}

