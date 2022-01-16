
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUptade = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.panelCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelCheck.Controls.Add(this.buttonInsert);
            this.panelCheck.Controls.Add(this.buttonUptade);
            this.panelCheck.Controls.Add(this.buttonDelete);
            this.panelCheck.Controls.Add(this.dataGridViewCheck);
            this.panelCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheck.Location = new System.Drawing.Point(35, 35);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Padding = new System.Windows.Forms.Padding(20);
            this.panelCheck.Size = new System.Drawing.Size(751, 378);
            this.panelCheck.TabIndex = 0;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonInsert.Location = new System.Drawing.Point(269, 333);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(150, 22);
            this.buttonInsert.TabIndex = 34;
            this.buttonInsert.Text = "UNESI";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click_1);
            // 
            // buttonUptade
            // 
            this.buttonUptade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUptade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonUptade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUptade.FlatAppearance.BorderSize = 0;
            this.buttonUptade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUptade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUptade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonUptade.Location = new System.Drawing.Point(425, 333);
            this.buttonUptade.Name = "buttonUptade";
            this.buttonUptade.Size = new System.Drawing.Size(150, 22);
            this.buttonUptade.TabIndex = 33;
            this.buttonUptade.Text = "AŽURIRAJ";
            this.buttonUptade.UseVisualStyleBackColor = false;
            this.buttonUptade.Click += new System.EventHandler(this.buttonUptade_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDelete.Location = new System.Drawing.Point(581, 333);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 22);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "OBRIŠI";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.Size = new System.Drawing.Size(711, 292);
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
            this.Load += new System.EventHandler(this.FormCheck_Load);
            this.panelCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.DataGridView dataGridViewCheck;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUptade;
        private System.Windows.Forms.Button buttonDelete;
    }
}