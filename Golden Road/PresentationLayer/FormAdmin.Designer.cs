
namespace PresentationLayer
{
    partial class FormAdmin
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
            this.panelLoginAdmin = new System.Windows.Forms.Panel();
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.panelLoginAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginAdmin
            // 
            this.panelLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelLoginAdmin.Controls.Add(this.labelAdminLogin);
            this.panelLoginAdmin.Controls.Add(this.buttonAdminLogin);
            this.panelLoginAdmin.Controls.Add(this.labelAdminPassword);
            this.panelLoginAdmin.Controls.Add(this.textBoxAdminPassword);
            this.panelLoginAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginAdmin.Location = new System.Drawing.Point(100, 100);
            this.panelLoginAdmin.Name = "panelLoginAdmin";
            this.panelLoginAdmin.Size = new System.Drawing.Size(621, 248);
            this.panelLoginAdmin.TabIndex = 0;
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelAdminLogin.Location = new System.Drawing.Point(45, 31);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(313, 25);
            this.labelAdminLogin.TabIndex = 7;
            this.labelAdminLogin.Text = "PRIJAVA ADMINISTRATORA";
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminLogin.FlatAppearance.BorderSize = 0;
            this.buttonAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAdminLogin.Location = new System.Drawing.Point(382, 192);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(200, 22);
            this.buttonAdminLogin.TabIndex = 6;
            this.buttonAdminLogin.Text = "PRIJAVI SE";
            this.buttonAdminLogin.UseVisualStyleBackColor = false;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelAdminPassword.Location = new System.Drawing.Point(47, 91);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(70, 16);
            this.labelAdminPassword.TabIndex = 3;
            this.labelAdminPassword.Text = "LOZINKA";
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxAdminPassword.Location = new System.Drawing.Point(382, 88);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.PasswordChar = '*';
            this.textBoxAdminPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxAdminPassword.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.panelLoginAdmin);
            this.Name = "FormAdmin";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelLoginAdmin.ResumeLayout(false);
            this.panelLoginAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginAdmin;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.Button buttonAdminLogin;
        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
    }
}