
namespace PresentationLayer
{
    partial class FormYHSR
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
            this.pictureBoxYHSR = new System.Windows.Forms.PictureBox();
            this.pictureBoxYHSRRB = new System.Windows.Forms.PictureBox();
            this.pictureBoxYHSRRT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSRRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSRRT)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxYHSR
            // 
            this.pictureBoxYHSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxYHSR.Image = global::PresentationLayer.Properties.Resources.yhsr;
            this.pictureBoxYHSR.Location = new System.Drawing.Point(0, 120);
            this.pictureBoxYHSR.Name = "pictureBoxYHSR";
            this.pictureBoxYHSR.Size = new System.Drawing.Size(821, 208);
            this.pictureBoxYHSR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxYHSR.TabIndex = 8;
            this.pictureBoxYHSR.TabStop = false;
            // 
            // pictureBoxYHSRRB
            // 
            this.pictureBoxYHSRRB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxYHSRRB.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxYHSRRB.Location = new System.Drawing.Point(0, 328);
            this.pictureBoxYHSRRB.Name = "pictureBoxYHSRRB";
            this.pictureBoxYHSRRB.Size = new System.Drawing.Size(821, 120);
            this.pictureBoxYHSRRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYHSRRB.TabIndex = 7;
            this.pictureBoxYHSRRB.TabStop = false;
            // 
            // pictureBoxYHSRRT
            // 
            this.pictureBoxYHSRRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxYHSRRT.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxYHSRRT.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxYHSRRT.Name = "pictureBoxYHSRRT";
            this.pictureBoxYHSRRT.Size = new System.Drawing.Size(821, 120);
            this.pictureBoxYHSRRT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYHSRRT.TabIndex = 6;
            this.pictureBoxYHSRRT.TabStop = false;
            // 
            // FormYHSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.pictureBoxYHSR);
            this.Controls.Add(this.pictureBoxYHSRRB);
            this.Controls.Add(this.pictureBoxYHSRRT);
            this.Name = "FormYHSR";
            this.Text = "FormYHSR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSRRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYHSRRT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxYHSR;
        private System.Windows.Forms.PictureBox pictureBoxYHSRRB;
        private System.Windows.Forms.PictureBox pictureBoxYHSRRT;
    }
}