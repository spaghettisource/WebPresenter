namespace WebPresenter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.btnSendImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedImage
            // 
            this.selectedImage.Image = ((System.Drawing.Image)(resources.GetObject("selectedImage.Image")));
            this.selectedImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("selectedImage.InitialImage")));
            this.selectedImage.Location = new System.Drawing.Point(12, 12);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(722, 384);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImage.TabIndex = 0;
            this.selectedImage.TabStop = false;
            this.selectedImage.WaitOnLoad = true;
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(331, 419);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(75, 23);
            this.btnSendImage.TabIndex = 1;
            this.btnSendImage.Text = "Send Image";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 454);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.selectedImage);
            this.Name = "Form1";
            this.Text = "Web presenter";
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.Button btnSendImage;
    }
}

