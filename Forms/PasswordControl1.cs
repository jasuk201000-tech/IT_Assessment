using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class PasswordControl1 : UserControl
    {
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPin;

        private List<CsvHelper.Staff> _allStaff;
        private string _csvPath => Paths.Staff;
        private int attempts = 3;

        public PasswordControl1()
        {
            InitializeComponent();

            LoadStaffData();

            button1.Click += Button1_Click;
            btnSwitchToPin.Click += SwitchToPinButton_Click;
        }

        private void LoadStaffData()
        {
            if (!File.Exists(_csvPath))
            {
                MessageBox.Show(
                    "Staff data file not found:\n" + _csvPath,
                    "Missing Data File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _allStaff = new List<CsvHelper.Staff>();
                return;
            }

            _allStaff = CsvHelper.LoadStaff(_csvPath);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var matched = _allStaff.FirstOrDefault(s =>
                s.Active && s.Username == username && s.Password == password);

            if (matched != null)
            {
                SessionManager.CurrentUser = matched;
                LoginSuccess?.Invoke(this, EventArgs.Empty);
                return;
            }

            attempts--;

            MessageBox.Show(
                $"Wrong username or password.\nAttempts left: {attempts}",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            txtPassword.Clear();
            txtPassword.Focus();

            if (attempts <= 0)
            {
                MessageBox.Show(
                    "Too many failed attempts. Login disabled.",
                    "Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                button1.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void SwitchToPinButton_Click(object sender, EventArgs e)
        {
            SwitchToPin?.Invoke(this, EventArgs.Empty);
        }
    }
}
