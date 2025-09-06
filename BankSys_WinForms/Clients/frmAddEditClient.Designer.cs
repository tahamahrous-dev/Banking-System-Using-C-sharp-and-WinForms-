namespace BankSys_WinForms.Clients
{
    partial class frmAddEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditClient));
            this.gbMainData = new System.Windows.Forms.GroupBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.btnImageDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.picClient = new System.Windows.Forms.PictureBox();
            this.mtxtPersonalID = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbComnuctionData = new System.Windows.Forms.GroupBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbAddressData = new System.Windows.Forms.GroupBox();
            this.cmbAlqaryah = new System.Windows.Forms.ComboBox();
            this.cmbAluzlah = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAlmudiriyah = new System.Windows.Forms.ComboBox();
            this.cmbAlmuhafazah = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbLoginData = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.brnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTahweal = new System.Windows.Forms.CheckBox();
            this.cbEda3 = new System.Windows.Forms.CheckBox();
            this.cbShab = new System.Windows.Forms.CheckBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).BeginInit();
            this.gbComnuctionData.SuspendLayout();
            this.gbAddressData.SuspendLayout();
            this.gbLoginData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMainData
            // 
            this.gbMainData.BackColor = System.Drawing.Color.White;
            this.gbMainData.Controls.Add(this.lblClientID);
            this.gbMainData.Controls.Add(this.btnImageAdd);
            this.gbMainData.Controls.Add(this.btnImageDelete);
            this.gbMainData.Controls.Add(this.label15);
            this.gbMainData.Controls.Add(this.picClient);
            this.gbMainData.Controls.Add(this.mtxtPersonalID);
            this.gbMainData.Controls.Add(this.label6);
            this.gbMainData.Controls.Add(this.cmbGender);
            this.gbMainData.Controls.Add(this.label5);
            this.gbMainData.Controls.Add(this.dtpDateOfBirth);
            this.gbMainData.Controls.Add(this.label4);
            this.gbMainData.Controls.Add(this.txtLastName);
            this.gbMainData.Controls.Add(this.lblLastName);
            this.gbMainData.Controls.Add(this.txtMidName);
            this.gbMainData.Controls.Add(this.label3);
            this.gbMainData.Controls.Add(this.txtFirstName);
            this.gbMainData.Controls.Add(this.label2);
            this.gbMainData.Controls.Add(this.label1);
            this.gbMainData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMainData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbMainData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbMainData.Location = new System.Drawing.Point(12, 24);
            this.gbMainData.Name = "gbMainData";
            this.gbMainData.Size = new System.Drawing.Size(600, 321);
            this.gbMainData.TabIndex = 1;
            this.gbMainData.TabStop = false;
            this.gbMainData.Text = "البيانات الاساسية";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblClientID.Location = new System.Drawing.Point(485, 34);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(30, 19);
            this.lblClientID.TabIndex = 20;
            this.lblClientID.Text = "???";
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageAdd.FlatAppearance.BorderSize = 0;
            this.btnImageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnImageAdd.Image")));
            this.btnImageAdd.Location = new System.Drawing.Point(103, 272);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(35, 33);
            this.btnImageAdd.TabIndex = 19;
            this.btnImageAdd.UseVisualStyleBackColor = true;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // btnImageDelete
            // 
            this.btnImageDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageDelete.FlatAppearance.BorderSize = 0;
            this.btnImageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageDelete.Image = global::BankSys_WinForms.Properties.Resources.delete;
            this.btnImageDelete.Location = new System.Drawing.Point(17, 272);
            this.btnImageDelete.Name = "btnImageDelete";
            this.btnImageDelete.Size = new System.Drawing.Size(35, 33);
            this.btnImageDelete.TabIndex = 18;
            this.btnImageDelete.UseVisualStyleBackColor = true;
            this.btnImageDelete.Visible = false;
            this.btnImageDelete.Click += new System.EventHandler(this.btnImageDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label15.Location = new System.Drawing.Point(153, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "صورة العميل:";
            // 
            // picClient
            // 
            this.picClient.Location = new System.Drawing.Point(17, 114);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(121, 143);
            this.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClient.TabIndex = 16;
            this.picClient.TabStop = false;
            // 
            // mtxtPersonalID
            // 
            this.mtxtPersonalID.Location = new System.Drawing.Point(389, 123);
            this.mtxtPersonalID.Mask = "99-999-000-000";
            this.mtxtPersonalID.Name = "mtxtPersonalID";
            this.mtxtPersonalID.Size = new System.Drawing.Size(122, 27);
            this.mtxtPersonalID.TabIndex = 15;
            this.mtxtPersonalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPersonalID.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPersonalID_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(517, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "رقم البطاقة:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(43, 79);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(80, 27);
            this.cmbGender.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label5.Location = new System.Drawing.Point(129, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "النوع:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(183, 76);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1870, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.RightToLeftLayout = true;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(115, 27);
            this.dtpDateOfBirth.TabIndex = 11;
            this.dtpDateOfBirth.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(304, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ الميلاد:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(395, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 27);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.lblLastName.Location = new System.Drawing.Point(549, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(45, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "اللقب:";
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(11, 31);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(136, 27);
            this.txtMidName.TabIndex = 6;
            this.txtMidName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMidName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(153, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "الاسم الثاني:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(247, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 27);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(389, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "الاسم الاول:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(544, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "المعرف:";
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
            this.gbComnuctionData.Location = new System.Drawing.Point(18, 351);
            this.gbComnuctionData.Name = "gbComnuctionData";
            this.gbComnuctionData.Size = new System.Drawing.Size(252, 136);
            this.gbComnuctionData.TabIndex = 2;
            this.gbComnuctionData.TabStop = false;
            this.gbComnuctionData.Text = "بيانات التواصل";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(67, 77);
            this.mtxtPhone.Mask = "999-000-000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(101, 27);
            this.mtxtPhone.TabIndex = 10;
            this.mtxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPhone_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 27);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label8.Location = new System.Drawing.Point(167, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم التلفون:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label11.Location = new System.Drawing.Point(193, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "الايميل:";
            // 
            // gbAddressData
            // 
            this.gbAddressData.BackColor = System.Drawing.Color.White;
            this.gbAddressData.Controls.Add(this.cmbAlqaryah);
            this.gbAddressData.Controls.Add(this.cmbAluzlah);
            this.gbAddressData.Controls.Add(this.label10);
            this.gbAddressData.Controls.Add(this.label12);
            this.gbAddressData.Controls.Add(this.cmbAlmudiriyah);
            this.gbAddressData.Controls.Add(this.cmbAlmuhafazah);
            this.gbAddressData.Controls.Add(this.label7);
            this.gbAddressData.Controls.Add(this.label9);
            this.gbAddressData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAddressData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbAddressData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbAddressData.Location = new System.Drawing.Point(276, 351);
            this.gbAddressData.Name = "gbAddressData";
            this.gbAddressData.Size = new System.Drawing.Size(344, 136);
            this.gbAddressData.TabIndex = 11;
            this.gbAddressData.TabStop = false;
            this.gbAddressData.Text = "بيانات العنوان";
            // 
            // cmbAlqaryah
            // 
            this.cmbAlqaryah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlqaryah.FormattingEnabled = true;
            this.cmbAlqaryah.Location = new System.Drawing.Point(8, 79);
            this.cmbAlqaryah.Name = "cmbAlqaryah";
            this.cmbAlqaryah.Size = new System.Drawing.Size(80, 27);
            this.cmbAlqaryah.TabIndex = 21;
            this.cmbAlqaryah.Visible = false;
            // 
            // cmbAluzlah
            // 
            this.cmbAluzlah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluzlah.FormattingEnabled = true;
            this.cmbAluzlah.Location = new System.Drawing.Point(179, 81);
            this.cmbAluzlah.Name = "cmbAluzlah";
            this.cmbAluzlah.Size = new System.Drawing.Size(80, 27);
            this.cmbAluzlah.TabIndex = 20;
            this.cmbAluzlah.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label10.Location = new System.Drawing.Point(87, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "القرية / الحارة:";
            this.label10.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(257, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "الحي / العزلة:";
            this.label12.Visible = false;
            // 
            // cmbAlmudiriyah
            // 
            this.cmbAlmudiriyah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmudiriyah.FormattingEnabled = true;
            this.cmbAlmudiriyah.Location = new System.Drawing.Point(8, 29);
            this.cmbAlmudiriyah.Name = "cmbAlmudiriyah";
            this.cmbAlmudiriyah.Size = new System.Drawing.Size(80, 27);
            this.cmbAlmudiriyah.TabIndex = 17;
            // 
            // cmbAlmuhafazah
            // 
            this.cmbAlmuhafazah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmuhafazah.FormattingEnabled = true;
            this.cmbAlmuhafazah.Location = new System.Drawing.Point(179, 32);
            this.cmbAlmuhafazah.Name = "cmbAlmuhafazah";
            this.cmbAlmuhafazah.Size = new System.Drawing.Size(80, 27);
            this.cmbAlmuhafazah.TabIndex = 16;
            this.cmbAlmuhafazah.SelectedIndexChanged += new System.EventHandler(this.cmbAlmuhafazah_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label7.Location = new System.Drawing.Point(87, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "المديرية:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label9.Location = new System.Drawing.Point(271, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "المحافظة:";
            // 
            // gbLoginData
            // 
            this.gbLoginData.BackColor = System.Drawing.Color.White;
            this.gbLoginData.Controls.Add(this.txtPassword);
            this.gbLoginData.Controls.Add(this.txtUserName);
            this.gbLoginData.Controls.Add(this.label13);
            this.gbLoginData.Controls.Add(this.label14);
            this.gbLoginData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLoginData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gbLoginData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.gbLoginData.Location = new System.Drawing.Point(18, 503);
            this.gbLoginData.Name = "gbLoginData";
            this.gbLoginData.Size = new System.Drawing.Size(252, 136);
            this.gbLoginData.TabIndex = 11;
            this.gbLoginData.TabStop = false;
            this.gbLoginData.Text = "بينات الدخول";
            this.gbLoginData.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 27);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 27);
            this.txtUserName.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label13.Location = new System.Drawing.Point(170, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "كلمة المرور:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label14.Location = new System.Drawing.Point(150, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "اسم المستخدم:";
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
            this.btnSave.Location = new System.Drawing.Point(528, 665);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // brnCancel
            // 
            this.brnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.brnCancel.BorderRadius = 6;
            this.brnCancel.BorderThickness = 2;
            this.brnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.brnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brnCancel.FillColor = System.Drawing.Color.Transparent;
            this.brnCancel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.brnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brnCancel.Image = global::BankSys_WinForms.Properties.Resources.ic_delete;
            this.brnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brnCancel.Location = new System.Drawing.Point(425, 665);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(93, 43);
            this.brnCancel.TabIndex = 12;
            this.brnCancel.Text = "الغاء";
            this.brnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbTahweal);
            this.groupBox1.Controls.Add(this.cbEda3);
            this.groupBox1.Controls.Add(this.cbShab);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.groupBox1.Location = new System.Drawing.Point(276, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 146);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصلاحيات";
            this.groupBox1.Visible = false;
            // 
            // cbTahweal
            // 
            this.cbTahweal.AutoSize = true;
            this.cbTahweal.Location = new System.Drawing.Point(29, 91);
            this.cbTahweal.Name = "cbTahweal";
            this.cbTahweal.Size = new System.Drawing.Size(62, 23);
            this.cbTahweal.TabIndex = 5;
            this.cbTahweal.Text = "تحويل";
            this.cbTahweal.UseVisualStyleBackColor = true;
            // 
            // cbEda3
            // 
            this.cbEda3.AutoSize = true;
            this.cbEda3.Location = new System.Drawing.Point(139, 91);
            this.cbEda3.Name = "cbEda3";
            this.cbEda3.Size = new System.Drawing.Size(55, 23);
            this.cbEda3.TabIndex = 4;
            this.cbEda3.Text = "إيداع";
            this.cbEda3.UseVisualStyleBackColor = true;
            // 
            // cbShab
            // 
            this.cbShab.AutoSize = true;
            this.cbShab.Location = new System.Drawing.Point(242, 91);
            this.cbShab.Name = "cbShab";
            this.cbShab.Size = new System.Drawing.Size(64, 23);
            this.cbShab.TabIndex = 3;
            this.cbShab.Text = "سحب";
            this.cbShab.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(129, 43);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(36, 23);
            this.rbNo.TabIndex = 2;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "لا";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(94, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 19);
            this.label16.TabIndex = 1;
            this.label16.Text = "اعطاء العميل كل الصلاحيات؟";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(204, 43);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 23);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "نعم";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frmAddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(624, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.gbLoginData);
            this.Controls.Add(this.gbAddressData);
            this.Controls.Add(this.gbComnuctionData);
            this.Controls.Add(this.gbMainData);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.Name = "frmAddEditClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة او تعديل بيانات العميل";
            this.Load += new System.EventHandler(this.frmAdd_UpdateClient_Load);
            this.gbMainData.ResumeLayout(false);
            this.gbMainData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            this.gbComnuctionData.ResumeLayout(false);
            this.gbComnuctionData.PerformLayout();
            this.gbAddressData.ResumeLayout(false);
            this.gbAddressData.PerformLayout();
            this.gbLoginData.ResumeLayout(false);
            this.gbLoginData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.GroupBox gbComnuctionData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtPersonalID;
        private System.Windows.Forms.GroupBox gbAddressData;
        private System.Windows.Forms.ComboBox cmbAlmuhafazah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAlmudiriyah;
        private System.Windows.Forms.ComboBox cmbAlqaryah;
        private System.Windows.Forms.ComboBox cmbAluzlah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbLoginData;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picClient;
        private System.Windows.Forms.Button btnImageDelete;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button brnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbTahweal;
        private System.Windows.Forms.CheckBox cbEda3;
        private System.Windows.Forms.CheckBox cbShab;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}