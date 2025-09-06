namespace BankSys_WinForms.Users
{
    partial class frmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbIsPermission = new System.Windows.Forms.GroupBox();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.cbLoginRegister = new System.Windows.Forms.CheckBox();
            this.cbCurrencyManaga = new System.Windows.Forms.CheckBox();
            this.cbUsersManaga = new System.Windows.Forms.CheckBox();
            this.cbTransctionsManaga = new System.Windows.Forms.CheckBox();
            this.cbAccountsManaga = new System.Windows.Forms.CheckBox();
            this.cbClientsManaga = new System.Windows.Forms.CheckBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gbMainData = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbComnuctionData = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbIsPermission.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.gbMainData.SuspendLayout();
            this.gbComnuctionData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(176, 74);
            this.mtxtPhone.Mask = "999-000-000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(101, 27);
            this.mtxtPhone.TabIndex = 10;
            this.mtxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPhone_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 27);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label8.Location = new System.Drawing.Point(276, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم التلفون:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(22, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 27);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(253, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 27);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbIsPermission
            // 
            this.gbIsPermission.BackColor = System.Drawing.Color.White;
            this.gbIsPermission.Controls.Add(this.gbPermissions);
            this.gbIsPermission.Controls.Add(this.rbNo);
            this.gbIsPermission.Controls.Add(this.label16);
            this.gbIsPermission.Controls.Add(this.rbYes);
            this.gbIsPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIsPermission.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbIsPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbIsPermission.Location = new System.Drawing.Point(8, 384);
            this.gbIsPermission.Name = "gbIsPermission";
            this.gbIsPermission.Size = new System.Drawing.Size(600, 160);
            this.gbIsPermission.TabIndex = 18;
            this.gbIsPermission.TabStop = false;
            this.gbIsPermission.Text = "الصلاحيات";
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.cbLoginRegister);
            this.gbPermissions.Controls.Add(this.cbCurrencyManaga);
            this.gbPermissions.Controls.Add(this.cbUsersManaga);
            this.gbPermissions.Controls.Add(this.cbTransctionsManaga);
            this.gbPermissions.Controls.Add(this.cbAccountsManaga);
            this.gbPermissions.Controls.Add(this.cbClientsManaga);
            this.gbPermissions.Location = new System.Drawing.Point(0, 74);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(599, 85);
            this.gbPermissions.TabIndex = 9;
            this.gbPermissions.TabStop = false;
            // 
            // cbLoginRegister
            // 
            this.cbLoginRegister.AutoSize = true;
            this.cbLoginRegister.Location = new System.Drawing.Point(473, 55);
            this.cbLoginRegister.Name = "cbLoginRegister";
            this.cbLoginRegister.Size = new System.Drawing.Size(118, 23);
            this.cbLoginRegister.TabIndex = 8;
            this.cbLoginRegister.Text = "سجلات الدخول";
            this.cbLoginRegister.UseVisualStyleBackColor = true;
            // 
            // cbCurrencyManaga
            // 
            this.cbCurrencyManaga.AutoSize = true;
            this.cbCurrencyManaga.Location = new System.Drawing.Point(13, 20);
            this.cbCurrencyManaga.Name = "cbCurrencyManaga";
            this.cbCurrencyManaga.Size = new System.Drawing.Size(100, 23);
            this.cbCurrencyManaga.TabIndex = 7;
            this.cbCurrencyManaga.Text = "إدارة العملات";
            this.cbCurrencyManaga.UseVisualStyleBackColor = true;
            // 
            // cbUsersManaga
            // 
            this.cbUsersManaga.AutoSize = true;
            this.cbUsersManaga.Location = new System.Drawing.Point(125, 20);
            this.cbUsersManaga.Name = "cbUsersManaga";
            this.cbUsersManaga.Size = new System.Drawing.Size(125, 23);
            this.cbUsersManaga.TabIndex = 6;
            this.cbUsersManaga.Text = "إدارة المستخدمين";
            this.cbUsersManaga.UseVisualStyleBackColor = true;
            // 
            // cbTransctionsManaga
            // 
            this.cbTransctionsManaga.AutoSize = true;
            this.cbTransctionsManaga.Location = new System.Drawing.Point(262, 20);
            this.cbTransctionsManaga.Name = "cbTransctionsManaga";
            this.cbTransctionsManaga.Size = new System.Drawing.Size(103, 23);
            this.cbTransctionsManaga.TabIndex = 5;
            this.cbTransctionsManaga.Text = "إدارة العمليات";
            this.cbTransctionsManaga.UseVisualStyleBackColor = true;
            // 
            // cbAccountsManaga
            // 
            this.cbAccountsManaga.AutoSize = true;
            this.cbAccountsManaga.Location = new System.Drawing.Point(377, 20);
            this.cbAccountsManaga.Name = "cbAccountsManaga";
            this.cbAccountsManaga.Size = new System.Drawing.Size(110, 23);
            this.cbAccountsManaga.TabIndex = 4;
            this.cbAccountsManaga.Text = "إدارة الحسابات";
            this.cbAccountsManaga.UseVisualStyleBackColor = true;
            // 
            // cbClientsManaga
            // 
            this.cbClientsManaga.AutoSize = true;
            this.cbClientsManaga.Location = new System.Drawing.Point(499, 20);
            this.cbClientsManaga.Name = "cbClientsManaga";
            this.cbClientsManaga.Size = new System.Drawing.Size(92, 23);
            this.cbClientsManaga.TabIndex = 3;
            this.cbClientsManaga.Text = "إدارة العملاء";
            this.cbClientsManaga.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(451, 45);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(36, 23);
            this.rbNo.TabIndex = 2;
            this.rbNo.Text = "لا";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(416, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 19);
            this.label16.TabIndex = 1;
            this.label16.Text = "اعطاء العميل كل الصلاحيات؟";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(526, 45);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 23);
            this.rbYes.TabIndex = 0;
            this.rbYes.Text = "نعم";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
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
            this.btnSave.Location = new System.Drawing.Point(511, 550);
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
            this.btnCancel.Location = new System.Drawing.Point(408, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 43);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label11.Location = new System.Drawing.Point(302, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "الايميل:";
            // 
            // gbMainData
            // 
            this.gbMainData.BackColor = System.Drawing.Color.White;
            this.gbMainData.Controls.Add(this.txtUserName);
            this.gbMainData.Controls.Add(this.txtPassword);
            this.gbMainData.Controls.Add(this.lblUserID);
            this.gbMainData.Controls.Add(this.label3);
            this.gbMainData.Controls.Add(this.label2);
            this.gbMainData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMainData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbMainData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbMainData.Location = new System.Drawing.Point(8, 13);
            this.gbMainData.Name = "gbMainData";
            this.gbMainData.Size = new System.Drawing.Size(600, 85);
            this.gbMainData.TabIndex = 14;
            this.gbMainData.TabStop = false;
            this.gbMainData.Text = "بيانات الدخول";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUserID.Location = new System.Drawing.Point(526, 31);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(30, 19);
            this.lblUserID.TabIndex = 20;
            this.lblUserID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(172, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة المرور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(403, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم المستخدم:";
            // 
            // gbComnuctionData
            // 
            this.gbComnuctionData.BackColor = System.Drawing.Color.White;
            this.gbComnuctionData.Controls.Add(this.mtxtPhone);
            this.gbComnuctionData.Controls.Add(this.txtEmail);
            this.gbComnuctionData.Controls.Add(this.label8);
            this.gbComnuctionData.Controls.Add(this.label11);
            this.gbComnuctionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbComnuctionData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbComnuctionData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbComnuctionData.Location = new System.Drawing.Point(240, 85);
            this.gbComnuctionData.Name = "gbComnuctionData";
            this.gbComnuctionData.Size = new System.Drawing.Size(354, 136);
            this.gbComnuctionData.TabIndex = 15;
            this.gbComnuctionData.TabStop = false;
            this.gbComnuctionData.Text = "بيانات التواصل";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.btnSetImage);
            this.groupBox2.Controls.Add(this.btnRemoveImage);
            this.groupBox2.Controls.Add(this.gbComnuctionData);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.picUser);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 274);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الدخول";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(308, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 27);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(29, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 27);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // btnSetImage
            // 
            this.btnSetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetImage.FlatAppearance.BorderSize = 0;
            this.btnSetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSetImage.Image")));
            this.btnSetImage.Location = new System.Drawing.Point(101, 222);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(35, 33);
            this.btnSetImage.TabIndex = 19;
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Image = global::BankSys_WinForms.Properties.Resources.delete;
            this.btnRemoveImage.Location = new System.Drawing.Point(15, 222);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(35, 33);
            this.btnRemoveImage.TabIndex = 18;
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label9.Location = new System.Drawing.Point(142, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "صورة العميل:";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(15, 64);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(121, 143);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 16;
            this.picUser.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label17.Location = new System.Drawing.Point(180, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 19);
            this.label17.TabIndex = 5;
            this.label17.Text = "الاسم الاخير:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label18.Location = new System.Drawing.Point(466, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 19);
            this.label18.TabIndex = 3;
            this.label18.Text = "الاسم الاول:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbIsPermission);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMainData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اضافة مستخدم";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.gbIsPermission.ResumeLayout(false);
            this.gbIsPermission.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.gbMainData.ResumeLayout(false);
            this.gbMainData.PerformLayout();
            this.gbComnuctionData.ResumeLayout(false);
            this.gbComnuctionData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbIsPermission;
        private System.Windows.Forms.CheckBox cbTransctionsManaga;
        private System.Windows.Forms.CheckBox cbAccountsManaga;
        private System.Windows.Forms.CheckBox cbClientsManaga;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbYes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbMainData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbComnuctionData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbUsersManaga;
        private System.Windows.Forms.CheckBox cbLoginRegister;
        private System.Windows.Forms.CheckBox cbCurrencyManaga;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}