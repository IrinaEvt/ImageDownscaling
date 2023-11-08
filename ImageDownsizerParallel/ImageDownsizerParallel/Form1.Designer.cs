namespace ImageDownsizerParallel
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
            this.label1 = new System.Windows.Forms.Label();
            this.percentageTB = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.buttonDownsizeImage = new System.Windows.Forms.Button();
            this.originalImgPB = new System.Windows.Forms.PictureBox();
            this.downscaledImgPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalImgPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a downscaling percentage:";
            // 
            // percentageTB
            // 
            this.percentageTB.Location = new System.Drawing.Point(255, 22);
            this.percentageTB.Name = "percentageTB";
            this.percentageTB.Size = new System.Drawing.Size(78, 27);
            this.percentageTB.TabIndex = 1;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(25, 67);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(124, 29);
            this.btnOpenImage.TabIndex = 2;
            this.btnOpenImage.Text = "Open image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // buttonDownsizeImage
            // 
            this.buttonDownsizeImage.Location = new System.Drawing.Point(167, 67);
            this.buttonDownsizeImage.Name = "buttonDownsizeImage";
            this.buttonDownsizeImage.Size = new System.Drawing.Size(166, 29);
            this.buttonDownsizeImage.TabIndex = 3;
            this.buttonDownsizeImage.Text = "Downscale Image";
            this.buttonDownsizeImage.UseVisualStyleBackColor = true;
            this.buttonDownsizeImage.Click += new System.EventHandler(this.buttonDownsizeImage_Click);
            // 
            // originalImgPB
            // 
            this.originalImgPB.Location = new System.Drawing.Point(25, 169);
            this.originalImgPB.Name = "originalImgPB";
            this.originalImgPB.Size = new System.Drawing.Size(308, 212);
            this.originalImgPB.TabIndex = 4;
            this.originalImgPB.TabStop = false;
            // 
            // downscaledImgPB
            // 
            this.downscaledImgPB.Location = new System.Drawing.Point(411, 169);
            this.downscaledImgPB.Name = "downscaledImgPB";
            this.downscaledImgPB.Size = new System.Drawing.Size(325, 212);
            this.downscaledImgPB.TabIndex = 5;
            this.downscaledImgPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downscaledImgPB);
            this.Controls.Add(this.originalImgPB);
            this.Controls.Add(this.buttonDownsizeImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.percentageTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalImgPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox percentageTB;
        private Button btnOpenImage;
        private Button buttonDownsizeImage;
        private PictureBox originalImgPB;
        private PictureBox downscaledImgPB;
    }
}