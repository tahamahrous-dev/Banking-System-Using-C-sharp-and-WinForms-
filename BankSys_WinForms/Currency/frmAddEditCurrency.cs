using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace BankSys_WinForms.Currency
{
    public partial class frmAddEditCurrency : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _CurrencyID;
        clsCurrency _Currency;

        public frmAddEditCurrency(int CurrencyID)
        {
            InitializeComponent();

            _CurrencyID = CurrencyID;

            if (_CurrencyID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "شاشة إضافة عملة جديدة";
                _Currency = new clsCurrency();
                return;
            }

            _Currency = clsCurrency.Find(_CurrencyID);

            if (_Currency == null)
            {
                MessageBox.Show("⚠️ لا يوجد عملة بهذا الرقم: " + _CurrencyID,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = "شاشة تعديل بيانات العملة";
            txtCountry.Text = _Currency.Country;
            txtCountryCode.Text = _Currency.Code;
            txtCurrencyName.Text = _Currency.Name;
            txtRateOneDolar.Text = _Currency.Rate.ToString();
        }

        private void frmAddEditCurrency_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من المدخلات الأساسية
            if (string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtCountryCode.Text) ||
                string.IsNullOrWhiteSpace(txtCurrencyName.Text) ||
                string.IsNullOrWhiteSpace(txtRateOneDolar.Text))
            {
                MessageBox.Show("⚠️ الرجاء إدخال جميع البيانات", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrencyName.Focus();
                return;
            }

            double rate;
            if (!double.TryParse(txtRateOneDolar.Text, out rate))
            {
                MessageBox.Show("⚠️ الرجاء إدخال قيمة صحيحة لسعر الصرف", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateOneDolar.Focus();
                return;
            }

            // تعبئة الكائن
            _Currency.Country = txtCountry.Text;
            _Currency.Code = txtCountryCode.Text;
            _Currency.Name = txtCurrencyName.Text;
            _Currency.Rate = rate;

            if (_Currency.Save())
            {
                MessageBox.Show("✅ تم حفظ البيانات بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("❌ لم يتم حفظ البيانات", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditCurrency_Load_1(object sender, EventArgs e)
        {
            _LoadData();
            txtCurrencyName.Focus();
        }
    }
}