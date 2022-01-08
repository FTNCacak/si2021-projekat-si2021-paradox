
namespace PresentationLayer
{
    partial class FormUser
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
            this.panelLoginUser = new System.Windows.Forms.Panel();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.panelLoginUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginUser
            // 
            this.panelLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelLoginUser.Controls.Add(this.labelUserLogin);
            this.panelLoginUser.Controls.Add(this.buttonUserLogin);
            this.panelLoginUser.Controls.Add(this.labelUserPassword);
            this.panelLoginUser.Controls.Add(this.labelUserId);
            this.panelLoginUser.Controls.Add(this.textBoxUserPassword);
            this.panelLoginUser.Controls.Add(this.textBoxUserId);
            this.panelLoginUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginUser.Location = new System.Drawing.Point(100, 100);
            this.panelLoginUser.Name = "panelLoginUser";
            this.panelLoginUser.Size = new System.Drawing.Size(621, 248);
            this.panelLoginUser.TabIndex = 1;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelUserLogin.Location = new System.Drawing.Point(45, 31);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(234, 25);
            this.labelUserLogin.TabIndex = 7;
            this.labelUserLogin.Text = "PRIJAVA KORISNIKA";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserLogin.FlatAppearance.BorderSize = 0;
            this.buttonUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonUserLogin.Location = new System.Drawing.Point(382, 192);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(200, 22);
            this.buttonUserLogin.TabIndex = 6;
            this.buttonUserLogin.Text = "PRIJAVI SE";
            this.buttonUserLogin.UseVisualStyleBackColor = false;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelUserPassword.Location = new System.Drawing.Point(47, 142);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(70, 16);
            this.labelUserPassword.TabIndex = 4;
            this.labelUserPassword.Text = "LOZINKA";
            // 
            // labelUserId
            // 
            this.labelUserId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelUserId.Location = new System.Drawing.Point(47, 91);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(110, 16);
            this.labelUserId.TabIndex = 3;
            this.labelUserId.Text = "KORISNIČKI ID";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxUserPassword.Location = new System.Drawing.Point(382, 139);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxUserPassword.TabIndex = 1;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxUserId.Location = new System.Drawing.Point(382, 88);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(200, 22);
            this.textBoxUserId.TabIndex = 0;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.panelLoginUser);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormUser";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "FormUser";
            this.panelLoginUser.ResumeLayout(false);
            this.panelLoginUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginUser;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserId;
    }
}