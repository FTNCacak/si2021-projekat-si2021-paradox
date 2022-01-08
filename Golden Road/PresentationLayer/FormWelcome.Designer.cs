
namespace PresentationLayer
{
    partial class FormWelcome
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
            this.pictureBoxW = new System.Windows.Forms.PictureBox();
            this.pictureBoxWRB = new System.Windows.Forms.PictureBox();
            this.pictureBoxWRT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWRT)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxW
            // 
            this.pictureBoxW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxW.Image = global::PresentationLayer.Properties.Resources.welcome1;
            this.pictureBoxW.Location = new System.Drawing.Point(0, 120);
            this.pictureBoxW.Name = "pictureBoxW";
            this.pictureBoxW.Size = new System.Drawing.Size(821, 208);
            this.pictureBoxW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxW.TabIndex = 5;
            this.pictureBoxW.TabStop = false;
            // 
            // pictureBoxWRB
            // 
            this.pictureBoxWRB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxWRB.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxWRB.Location = new System.Drawing.Point(0, 328);
            this.pictureBoxWRB.Name = "pictureBoxWRB";
            this.pictureBoxWRB.Size = new System.Drawing.Size(821, 120);
            this.pictureBoxWRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWRB.TabIndex = 4;
            this.pictureBoxWRB.TabStop = false;
            // 
            // pictureBoxWRT
            // 
            this.pictureBoxWRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxWRT.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxWRT.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWRT.Name = "pictureBoxWRT";
            this.pictureBoxWRT.Size = new System.Drawing.Size(821, 120);
            this.pictureBoxWRT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWRT.TabIndex = 3;
            this.pictureBoxWRT.TabStop = false;
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.pictureBoxW);
            this.Controls.Add(this.pictureBoxWRB);
            this.Controls.Add(this.pictureBoxWRT);
            this.Name = "FormWelcome";
            this.Text = "FormWelcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWRT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxW;
        private System.Windows.Forms.PictureBox pictureBoxWRB;
        private System.Windows.Forms.PictureBox pictureBoxWRT;
    }
}