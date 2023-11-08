namespace ImageDownsizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDownsizeImage = new System.Windows.Forms.Button();
            this.originalImgPB = new System.Windows.Forms.PictureBox();
            this.downscaledImgPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.percentageTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalImgPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(25, 67);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(132, 29);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open Image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDownsizeImage
            // 
            this.buttonDownsizeImage.Location = new System.Drawing.Point(181, 67);
            this.buttonDownsizeImage.Name = "buttonDownsizeImage";
            this.buttonDownsizeImage.Size = new System.Drawing.Size(143, 29);
            this.buttonDownsizeImage.TabIndex = 1;
            this.buttonDownsizeImage.Text = "Downsize Image";
            this.buttonDownsizeImage.UseVisualStyleBackColor = true;
            this.buttonDownsizeImage.Click += new System.EventHandler(this.buttonDownsizeImage_Click);
            // 
            // originalImgPB
            // 
            this.originalImgPB.Location = new System.Drawing.Point(25, 183);
            this.originalImgPB.Name = "originalImgPB";
            this.originalImgPB.Size = new System.Drawing.Size(279, 184);
            this.originalImgPB.TabIndex = 2;
            this.originalImgPB.TabStop = false;
            // 
            // downscaledImgPB
            // 
            this.downscaledImgPB.Location = new System.Drawing.Point(431, 192);
            this.downscaledImgPB.Name = "downscaledImgPB";
            this.downscaledImgPB.Size = new System.Drawing.Size(295, 191);
            this.downscaledImgPB.TabIndex = 3;
            this.downscaledImgPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Еnter a downscaling percentage:";
            // 
            // percentageTB
            // 
            this.percentageTB.Location = new System.Drawing.Point(267, 22);
            this.percentageTB.Name = "percentageTB";
            this.percentageTB.Size = new System.Drawing.Size(57, 27);
            this.percentageTB.TabIndex = 5;
            this.percentageTB.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentageTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downscaledImgPB);
            this.Controls.Add(this.originalImgPB);
            this.Controls.Add(this.buttonDownsizeImage);
            this.Controls.Add(this.buttonOpenImage);
            this.Name = "Form1";
            this.Text = "Downscale Image";
            ((System.ComponentModel.ISupportInitialize)(this.originalImgPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOpenImage;
        private OpenFileDialog openFileDialog1;
        private Button buttonDownsizeImage;
        private PictureBox originalImgPB;
        private PictureBox downscaledImgPB;
        private Label label1;
        private TextBox percentageTB;
    }
}