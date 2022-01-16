
namespace PresentationLayer
{
    partial class FormGoldenRoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoldenRoad));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPopUp = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.buttonFormPayment = new System.Windows.Forms.Button();
            this.buttonFormCheck = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelPopUp.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSideMenu.Controls.Add(this.buttonFormPayment);
            this.panelSideMenu.Controls.Add(this.buttonFormCheck);
            this.panelSideMenu.Controls.Add(this.buttonLogout);
            this.panelSideMenu.Controls.Add(this.buttonRegister);
            this.panelSideMenu.Controls.Add(this.panelPopUp);
            this.panelSideMenu.Controls.Add(this.buttonLogin);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 487);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelPopUp
            // 
            this.panelPopUp.BackColor = System.Drawing.Color.Gold;
            this.panelPopUp.Controls.Add(this.buttonUser);
            this.panelPopUp.Controls.Add(this.buttonAdmin);
            this.panelPopUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPopUp.Location = new System.Drawing.Point(0, 214);
            this.panelPopUp.Name = "panelPopUp";
            this.panelPopUp.Size = new System.Drawing.Size(200, 70);
            this.panelPopUp.TabIndex = 1;
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonUser.Location = new System.Drawing.Point(0, 35);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(200, 35);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.Text = "☻ KORISNIK";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click_1);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAdmin.Location = new System.Drawing.Point(0, 0);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonAdmin.Size = new System.Drawing.Size(200, 35);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "☻ ADMINISTRATOR";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 174);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(837, 487);
            this.panelChildForm.TabIndex = 1;
            // 
            // buttonFormPayment
            // 
            this.buttonFormPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFormPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFormPayment.FlatAppearance.BorderSize = 0;
            this.buttonFormPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonFormPayment.Image = global::PresentationLayer.Properties.Resources.payment;
            this.buttonFormPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormPayment.Location = new System.Drawing.Point(0, 364);
            this.buttonFormPayment.Name = "buttonFormPayment";
            this.buttonFormPayment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFormPayment.Size = new System.Drawing.Size(200, 40);
            this.buttonFormPayment.TabIndex = 7;
            this.buttonFormPayment.Text = "        PLAĆANJE";
            this.buttonFormPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormPayment.UseVisualStyleBackColor = false;
            this.buttonFormPayment.Click += new System.EventHandler(this.buttonFormPayment_Click);
            // 
            // buttonFormCheck
            // 
            this.buttonFormCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonFormCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFormCheck.FlatAppearance.BorderSize = 0;
            this.buttonFormCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonFormCheck.Image = global::PresentationLayer.Properties.Resources.check;
            this.buttonFormCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormCheck.Location = new System.Drawing.Point(0, 324);
            this.buttonFormCheck.Name = "buttonFormCheck";
            this.buttonFormCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFormCheck.Size = new System.Drawing.Size(200, 40);
            this.buttonFormCheck.TabIndex = 6;
            this.buttonFormCheck.Text = "        PROVERA";
            this.buttonFormCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormCheck.UseVisualStyleBackColor = false;
            this.buttonFormCheck.Click += new System.EventHandler(this.buttonFormCheck_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonLogout.Image = global::PresentationLayer.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 447);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(200, 40);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "        ODJAVI SE";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonRegister.Image = global::PresentationLayer.Properties.Resources.register1;
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.Location = new System.Drawing.Point(0, 284);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRegister.Size = new System.Drawing.Size(200, 40);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "        REGISTRUJ SE";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonLogin.Image = global::PresentationLayer.Properties.Resources.login1;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(0, 174);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(200, 40);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "        PRIJAVI SE KAO";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::PresentationLayer.Properties.Resources.logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 174);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormGoldenRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1037, 487);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1053, 526);
            this.Name = "FormGoldenRoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golden Road";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelPopUp.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelPopUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonFormPayment;
        private System.Windows.Forms.Button buttonFormCheck;
    }
}

