namespace ClinicManagementSystem
{
    public partial class UC_SystemSettings : UserControl
    {
        public UC_SystemSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load default settings
            clinicNameTextBox.Text = "University Health Clinic";
            clinicAddressTextBox.Text = "123 Campus Drive, University City";
            clinicPhoneTextBox.Text = "+1 (555) 123-4567";
            clinicEmailTextBox.Text = "health@university.edu";
            
            backupPathTextBox.Text = @"C:\ClinicBackups\";
            autoBackupCheckBox.Checked = true;
            
            notificationCheckBox.Checked = true;
            emailNotificationCheckBox.Checked = true;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(clinicNameTextBox.Text))
            {
                MessageBox.Show("Clinic name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save settings logic would go here
            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetSettingsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset all settings to default?",
                "Reset Settings",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoadSettings();
                MessageBox.Show("Settings have been reset to default.", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Backup Location";
                folderDialog.SelectedPath = backupPathTextBox.Text;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    backupPathTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void backupNowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Backup started. This may take a few moments...", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Backup logic would go here
        }

        private void testEmailBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test email sent to " + clinicEmailTextBox.Text, "Test Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
