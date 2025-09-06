namespace BankSys_WinForms.Currency
{
    partial class frmAddEditCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCurrency));
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRateOneDolar = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbTransactionData = new System.Windows.Forms.GroupBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.gbTransactionData.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(346, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 43);
            this.btnSave.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(247, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(375, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "الدولة:";
            // 
            // txtRateOneDolar
            // 
            this.txtRateOneDolar.Location = new System.Drawing.Point(74, 149);
            this.txtRateOneDolar.Name = "txtRateOneDolar";
            this.txtRateOneDolar.Size = new System.Drawing.Size(194, 27);
            this.txtRateOneDolar.TabIndex = 3;
            this.txtRateOneDolar.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label7.Location = new System.Drawing.Point(266, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "قيمة العملة مقابل 1 دولار:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(352, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "رمز العملة:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.lblLastName.Location = new System.Drawing.Point(348, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "اسم العملة:";
            // 
            // gbTransactionData
            // 
            this.gbTransactionData.BackColor = System.Drawing.Color.White;
            this.gbTransactionData.Controls.Add(this.txtCurrencyName);
            this.gbTransactionData.Controls.Add(this.txtCountryCode);
            this.gbTransactionData.Controls.Add(this.txtCountry);
            this.gbTransactionData.Controls.Add(this.txtRateOneDolar);
            this.gbTransactionData.Controls.Add(this.label7);
            this.gbTransactionData.Controls.Add(this.label1);
            this.gbTransactionData.Controls.Add(this.lblLastName);
            this.gbTransactionData.Controls.Add(this.label2);
            this.gbTransactionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTransactionData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbTransactionData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbTransactionData.Location = new System.Drawing.Point(11, 11);
            this.gbTransactionData.Name = "gbTransactionData";
            this.gbTransactionData.Size = new System.Drawing.Size(428, 190);
            this.gbTransactionData.TabIndex = 49;
            this.gbTransactionData.TabStop = false;
            this.gbTransactionData.Text = "بيانــــــــات العملــــة";
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(150, 108);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(194, 27);
            this.txtCurrencyName.TabIndex = 2;
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(150, 67);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(194, 27);
            this.txtCountryCode.TabIndex = 1;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(150, 26);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(194, 27);
            this.txtCountry.TabIndex = 0;
            // 
            // frmAddEditCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 256);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbTransactionData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditCurrency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضاقة عملة";
            this.Load += new System.EventHandler(this.frmAddEditCurrency_Load_1);
            this.gbTransactionData.ResumeLayout(false);
            this.gbTransactionData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtRateOneDolar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gbTransactionData;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtCountry;
    }
}