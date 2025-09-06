namespace BankSys_WinForms.Accounts
{
    partial class frmAddEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAccount));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMainData = new System.Windows.Forms.GroupBox();
            this.txtAccountBlan = new System.Windows.Forms.TextBox();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.cmbAccountCarrency = new System.Windows.Forms.ComboBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMainData.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbMainData
            // 
            this.gbMainData.BackColor = System.Drawing.Color.White;
            this.gbMainData.Controls.Add(this.cmbClientName);
            this.gbMainData.Controls.Add(this.label4);
            this.gbMainData.Controls.Add(this.txtAccountBlan);
            this.gbMainData.Controls.Add(this.txtNote);
            this.gbMainData.Controls.Add(this.lblAccountNum);
            this.gbMainData.Controls.Add(this.cmbAccountCarrency);
            this.gbMainData.Controls.Add(this.lblAccountID);
            this.gbMainData.Controls.Add(this.label6);
            this.gbMainData.Controls.Add(this.lblLastName);
            this.gbMainData.Controls.Add(this.label3);
            this.gbMainData.Controls.Add(this.label2);
            this.gbMainData.Controls.Add(this.label1);
            this.gbMainData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMainData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbMainData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbMainData.Location = new System.Drawing.Point(8, 13);
            this.gbMainData.Name = "gbMainData";
            this.gbMainData.Size = new System.Drawing.Size(615, 197);
            this.gbMainData.TabIndex = 14;
            this.gbMainData.TabStop = false;
            this.gbMainData.Text = "بيانات الحساب";
            // 
            // txtAccountBlan
            // 
            this.txtAccountBlan.Location = new System.Drawing.Point(16, 75);
            this.txtAccountBlan.Name = "txtAccountBlan";
            this.txtAccountBlan.ReadOnly = true;
            this.txtAccountBlan.Size = new System.Drawing.Size(105, 27);
            this.txtAccountBlan.TabIndex = 26;
            this.txtAccountBlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtNote.Location = new System.Drawing.Point(14, 111);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.MaxLength = 30;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(525, 79);
            this.txtNote.TabIndex = 25;
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAccountNum.Location = new System.Drawing.Point(427, 77);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(30, 19);
            this.lblAccountNum.TabIndex = 22;
            this.lblAccountNum.Text = "???";
            // 
            // cmbAccountCarrency
            // 
            this.cmbAccountCarrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountCarrency.FormattingEnabled = true;
            this.cmbAccountCarrency.Location = new System.Drawing.Point(14, 28);
            this.cmbAccountCarrency.Name = "cmbAccountCarrency";
            this.cmbAccountCarrency.Size = new System.Drawing.Size(107, 27);
            this.cmbAccountCarrency.TabIndex = 21;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAccountID.Location = new System.Drawing.Point(502, 34);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(30, 19);
            this.lblAccountID.TabIndex = 20;
            this.lblAccountID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(545, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "ملاحظات:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.lblLastName.Location = new System.Drawing.Point(163, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "رصيد الحساب\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(526, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم الحساب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(127, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "عملة الحساب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(561, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "المعرف:";
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
            this.btnSave.Location = new System.Drawing.Point(513, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 43);
            this.btnSave.TabIndex = 20;
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
            this.btnCancel.Location = new System.Drawing.Point(410, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 43);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbClientName
            // 
            this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(217, 31);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(198, 27);
            this.cmbClientName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(421, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "اسم العميل:";
            // 
            // frmAddEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 263);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMainData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة حساب";
            this.Load += new System.EventHandler(this.frmAddEditAccount_Load);
            this.gbMainData.ResumeLayout(false);
            this.gbMainData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.GroupBox gbMainData;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.ComboBox cmbAccountCarrency;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.TextBox txtAccountBlan;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Label label4;
    }
}