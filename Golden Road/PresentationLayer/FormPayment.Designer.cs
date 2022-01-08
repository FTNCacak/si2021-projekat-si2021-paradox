
namespace PresentationLayer
{
    partial class FormPayment
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
            this.panelPayment = new System.Windows.Forms.Panel();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelReference = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelPayment.Controls.Add(this.labelState);
            this.panelPayment.Controls.Add(this.comboBoxFrom);
            this.panelPayment.Controls.Add(this.dateTimePickerDate);
            this.panelPayment.Controls.Add(this.buttonPayment);
            this.panelPayment.Controls.Add(this.textBoxPurpose);
            this.panelPayment.Controls.Add(this.textBoxAmount);
            this.panelPayment.Controls.Add(this.textBoxReference);
            this.panelPayment.Controls.Add(this.textBoxModel);
            this.panelPayment.Controls.Add(this.textBoxTo);
            this.panelPayment.Controls.Add(this.textBoxName);
            this.panelPayment.Controls.Add(this.labelTo);
            this.panelPayment.Controls.Add(this.labelReference);
            this.panelPayment.Controls.Add(this.labelRecipient);
            this.panelPayment.Controls.Add(this.labelDetails);
            this.panelPayment.Controls.Add(this.labelModel);
            this.panelPayment.Controls.Add(this.labelDate);
            this.panelPayment.Controls.Add(this.labelPurpose);
            this.panelPayment.Controls.Add(this.labelName);
            this.panelPayment.Controls.Add(this.labelAmount);
            this.panelPayment.Controls.Add(this.labelFrom);
            this.panelPayment.Controls.Add(this.labelPayment);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayment.Location = new System.Drawing.Point(35, 35);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(751, 378);
            this.panelPayment.TabIndex = 1;
            // 
            // labelState
            // 
            this.labelState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelState.Location = new System.Drawing.Point(397, 91);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(168, 16);
            this.labelState.TabIndex = 34;
            this.labelState.Text = "STANJE NA RAČUNU: ";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(193, 91);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(150, 24);
            this.comboBoxFrom.TabIndex = 33;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePickerDate.Location = new System.Drawing.Point(522, 281);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 32;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.buttonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonPayment.Location = new System.Drawing.Point(550, 327);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(150, 22);
            this.buttonPayment.TabIndex = 31;
            this.buttonPayment.Text = "UPLATA";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPurpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxPurpose.Location = new System.Drawing.Point(550, 237);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(150, 22);
            this.textBoxPurpose.TabIndex = 27;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxAmount.Location = new System.Drawing.Point(550, 188);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(150, 22);
            this.textBoxAmount.TabIndex = 26;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxReference.Location = new System.Drawing.Point(193, 328);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(150, 22);
            this.textBoxReference.TabIndex = 24;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxModel.Location = new System.Drawing.Point(193, 279);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(150, 22);
            this.textBoxModel.TabIndex = 23;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxTo.Location = new System.Drawing.Point(193, 233);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(150, 22);
            this.textBoxTo.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.textBoxName.Location = new System.Drawing.Point(193, 188);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 21;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelTo.Location = new System.Drawing.Point(48, 235);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(121, 16);
            this.labelTo.TabIndex = 19;
            this.labelTo.Text = "*BROJ RAČUNA";
            // 
            // labelReference
            // 
            this.labelReference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReference.AutoSize = true;
            this.labelReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelReference.Location = new System.Drawing.Point(48, 330);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(127, 16);
            this.labelReference.TabIndex = 17;
            this.labelReference.Text = "*POZIV NA BROJ";
            // 
            // labelRecipient
            // 
            this.labelRecipient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecipient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelRecipient.Location = new System.Drawing.Point(47, 145);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(99, 20);
            this.labelRecipient.TabIndex = 16;
            this.labelRecipient.Text = "PRIMALAC";
            // 
            // labelDetails
            // 
            this.labelDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelDetails.Location = new System.Drawing.Point(396, 145);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(176, 20);
            this.labelDetails.TabIndex = 15;
            this.labelDetails.Text = "DETALJI PLAĆANJA";
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelModel.Location = new System.Drawing.Point(48, 281);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(66, 16);
            this.labelModel.TabIndex = 14;
            this.labelModel.Text = "*MODEL";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelDate.Location = new System.Drawing.Point(397, 284);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(68, 16);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "*DATUM";
            // 
            // labelPurpose
            // 
            this.labelPurpose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelPurpose.Location = new System.Drawing.Point(397, 239);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(141, 16);
            this.labelPurpose.TabIndex = 12;
            this.labelPurpose.Text = "SVRHA PLAĆANJA";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelName.Location = new System.Drawing.Point(48, 190);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 16);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "NAZIV";
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelAmount.Location = new System.Drawing.Point(397, 190);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(59, 16);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "*IZNOS";
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelFrom.Location = new System.Drawing.Point(48, 96);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(101, 16);
            this.labelFrom.TabIndex = 9;
            this.labelFrom.Text = "*SA RAČUNA";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(188)))), ((int)(((byte)(29)))));
            this.labelPayment.Location = new System.Drawing.Point(46, 44);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(129, 25);
            this.labelPayment.TabIndex = 8;
            this.labelPayment.Text = "PLAĆANJE";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(821, 448);
            this.Controls.Add(this.panelPayment);
            this.Name = "FormPayment";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.Text = "FormPayment";
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label labelState;
    }
}