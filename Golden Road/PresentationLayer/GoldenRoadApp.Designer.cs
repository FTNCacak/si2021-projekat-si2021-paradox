
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panelPopUp = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoadBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoadTop = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelPopUp.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSideMenu.Controls.Add(this.buttonLogout);
            this.panelSideMenu.Controls.Add(this.buttonPayment);
            this.panelSideMenu.Controls.Add(this.buttonCheck);
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
            this.buttonLogout.Text = "        LOG OUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonPayment.Image = global::PresentationLayer.Properties.Resources.payment;
            this.buttonPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayment.Location = new System.Drawing.Point(0, 364);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPayment.Size = new System.Drawing.Size(200, 40);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "        PAYMENT";
            this.buttonPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonCheck.Image = global::PresentationLayer.Properties.Resources.check;
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(0, 324);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCheck.Size = new System.Drawing.Size(200, 40);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "        PAYER CHECK";
            this.buttonCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
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
            this.buttonRegister.Text = "        REGISTER";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
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
            this.buttonUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(200, 35);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.Text = "USER";
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
            this.buttonAdmin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAdmin.Size = new System.Drawing.Size(200, 35);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "ADMINISTRATOR";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
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
            this.buttonLogin.Text = "        LOG IN AS:";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
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
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBoxWelcome);
            this.panelChildForm.Controls.Add(this.pictureBoxRoadBottom);
            this.panelChildForm.Controls.Add(this.pictureBoxRoadTop);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(837, 487);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWelcome.Image = global::PresentationLayer.Properties.Resources.welcome1;
            this.pictureBoxWelcome.Location = new System.Drawing.Point(0, 120);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(837, 247);
            this.pictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWelcome.TabIndex = 7;
            this.pictureBoxWelcome.TabStop = false;
            // 
            // pictureBoxRoadBottom
            // 
            this.pictureBoxRoadBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxRoadBottom.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxRoadBottom.Location = new System.Drawing.Point(0, 367);
            this.pictureBoxRoadBottom.Name = "pictureBoxRoadBottom";
            this.pictureBoxRoadBottom.Size = new System.Drawing.Size(837, 120);
            this.pictureBoxRoadBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoadBottom.TabIndex = 6;
            this.pictureBoxRoadBottom.TabStop = false;
            // 
            // pictureBoxRoadTop
            // 
            this.pictureBoxRoadTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxRoadTop.Image = global::PresentationLayer.Properties.Resources.road1;
            this.pictureBoxRoadTop.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRoadTop.Name = "pictureBoxRoadTop";
            this.pictureBoxRoadTop.Size = new System.Drawing.Size(837, 120);
            this.pictureBoxRoadTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoadTop.TabIndex = 5;
            this.pictureBoxRoadTop.TabStop = false;
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
            this.Name = "FormGoldenRoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golden Road";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelPopUp.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoadTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelPopUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
        private System.Windows.Forms.PictureBox pictureBoxRoadBottom;
        private System.Windows.Forms.PictureBox pictureBoxRoadTop;
        private System.Windows.Forms.Button buttonLogout;
    }
}

