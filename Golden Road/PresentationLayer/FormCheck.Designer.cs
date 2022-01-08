
namespace PresentationLayer
{
    partial class FormCheck
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
            this.panelCheck = new System.Windows.Forms.Panel();
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelCheck.Controls.Add(this.dataGridViewCheck);
            this.panelCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheck.Location = new System.Drawing.Point(35, 35);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Padding = new System.Windows.Forms.Padding(20);
            this.panelCheck.Size = new System.Drawing.Size(751, 378);
            this.panelCheck.TabIndex = 0;
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCheck.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.Size = new System.Drawing.Size(711, 338);
            this.dataGridViewCheck.TabIndex = 0;
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.panelCheck);
            this.Name = "FormCheck";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.Text = "FormCheck";
            this.panelCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.DataGridView dataGridViewCheck;
    }
}