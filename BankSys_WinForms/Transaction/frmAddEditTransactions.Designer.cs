namespace BankSys_WinForms.Transaction
{
    partial class frmAddEditTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditTransactions));
            this.gbTransactionData = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransactionNumRef = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccountTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.MaskedTextBox();
            this.cmbTransferToClient = new System.Windows.Forms.ComboBox();
            this.lblTransferTo = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTransactionData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransactionData
            // 
            this.gbTransactionData.BackColor = System.Drawing.Color.White;
            this.gbTransactionData.Controls.Add(this.txtAmount);
            this.gbTransactionData.Controls.Add(this.label7);
            this.gbTransactionData.Controls.Add(this.cmbAccount);
            this.gbTransactionData.Controls.Add(this.label1);
            this.gbTransactionData.Controls.Add(this.cmbTransactionType);
            this.gbTransactionData.Controls.Add(this.cmbClientName);
            this.gbTransactionData.Controls.Add(this.lblLastName);
            this.gbTransactionData.Controls.Add(this.label2);
            this.gbTransactionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTransactionData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbTransactionData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbTransactionData.Location = new System.Drawing.Point(12, 12);
            this.gbTransactionData.Name = "gbTransactionData";
            this.gbTransactionData.Size = new System.Drawing.Size(399, 190);
            this.gbTransactionData.TabIndex = 21;
            this.gbTransactionData.TabStop = false;
            this.gbTransactionData.Text = "بيانــــــــات العميــــــلة";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(62, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(194, 27);
            this.txtAmount.TabIndex = 46;
            this.txtAmount.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label7.Location = new System.Drawing.Point(261, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "مبلغ العملية:";
            // 
            // cmbAccount
            // 
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(62, 61);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(194, 27);
            this.cmbAccount.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(277, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "الحساب:";
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "-- اختر عملية --",
            "سحب",
            "تحويل",
            "إيداع"});
            this.cmbTransactionType.Location = new System.Drawing.Point(62, 99);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(194, 27);
            this.cmbTransactionType.TabIndex = 26;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // cmbClientName
            // 
            this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(62, 23);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(194, 27);
            this.cmbClientName.TabIndex = 21;
            this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.lblLastName.Location = new System.Drawing.Point(261, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "نوع العملية:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(283, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "العميـــــل:";
            // 
            // txtNote
            // 
            this.txtNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNote.BorderThickness = 2;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.CustomizableEdges.BottomRight = false;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtNote.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(14, 99);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.MaxLength = 30;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(249, 70);
            this.txtNote.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label9.Location = new System.Drawing.Point(327, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "ملاحظات:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(14, 18);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(249, 27);
            this.dtpTransactionDate.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label8.Location = new System.Drawing.Point(271, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "تاريخ ووقت العملية:";
            // 
            // lblTransactionNumRef
            // 
            this.lblTransactionNumRef.AutoSize = true;
            this.lblTransactionNumRef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTransactionNumRef.Location = new System.Drawing.Point(135, 66);
            this.lblTransactionNumRef.Name = "lblTransactionNumRef";
            this.lblTransactionNumRef.Size = new System.Drawing.Size(30, 19);
            this.lblTransactionNumRef.TabIndex = 22;
            this.lblTransactionNumRef.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(283, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم مرجع العملية:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.BorderRadius = 6;
            this.btnSave.BorderThickness = 2;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::BankSys_WinForms.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(318, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 43);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Image = global::BankSys_WinForms.Properties.Resources.ic_delete;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(219, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 43);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbAccountTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCommission);
            this.groupBox1.Controls.Add(this.cmbTransferToClient);
            this.groupBox1.Controls.Add(this.lblTransferTo);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 145);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // cmbAccountTo
            // 
            this.cmbAccountTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountTo.FormattingEnabled = true;
            this.cmbAccountTo.Location = new System.Drawing.Point(55, 100);
            this.cmbAccountTo.Name = "cmbAccountTo";
            this.cmbAccountTo.Size = new System.Drawing.Size(194, 27);
            this.cmbAccountTo.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(303, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "الى حساب:";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(57, 20);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(194, 27);
            this.txtCommission.TabIndex = 39;
            this.txtCommission.ValidatingType = typeof(int);
            // 
            // cmbTransferToClient
            // 
            this.cmbTransferToClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferToClient.FormattingEnabled = true;
            this.cmbTransferToClient.Items.AddRange(new object[] {
            "-- اختر عملية --",
            "سحب",
            "تحويل",
            "إيداع"});
            this.cmbTransferToClient.Location = new System.Drawing.Point(57, 59);
            this.cmbTransferToClient.Name = "cmbTransferToClient";
            this.cmbTransferToClient.Size = new System.Drawing.Size(194, 27);
            this.cmbTransferToClient.TabIndex = 26;
            this.cmbTransferToClient.SelectedIndexChanged += new System.EventHandler(this.cmbTransferToClient_SelectedIndexChanged);
            // 
            // lblTransferTo
            // 
            this.lblTransferTo.AutoSize = true;
            this.lblTransferTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.lblTransferTo.Location = new System.Drawing.Point(255, 62);
            this.lblTransferTo.Name = "lblTransferTo";
            this.lblTransferTo.Size = new System.Drawing.Size(117, 19);
            this.lblTransferTo.TabIndex = 7;
            this.lblTransferTo.Text = "العميل المحول اليه:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label21.Location = new System.Drawing.Point(319, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 19);
            this.label21.TabIndex = 3;
            this.label21.Text = "العمولة:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpTransactionDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTransactionNumRef);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 176);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // frmAddEditTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbTransactionData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إضافة عملية";
            this.Load += new System.EventHandler(this.frmAddEditTransactions_Load);
            this.gbTransactionData.ResumeLayout(false);
            this.gbTransactionData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransactionData;
        private System.Windows.Forms.Label lblTransactionNumRef;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCommission;
        private System.Windows.Forms.ComboBox cmbTransferToClient;
        private System.Windows.Forms.Label lblTransferTo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAccountTo;
        private System.Windows.Forms.Label label4;
    }
}