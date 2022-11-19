using nback.Domain;

namespace nback.WinForms
{
    public partial class StartTestForm : Form
    {
        public StartTestForm()
        {
            InitializeComponent();
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            ConfigurationForTheTest = new ConfigurationForTheTest(
                NameOfSubjectTextBox.Text,
                (int)NNumericUpDown.Value,
                (int)StimulusDurationInMsNumericUpDown.Value,
                (int)NumberOfStimuliNumericUpDown.Value);

            Close();
        }

        public ConfigurationForTheTest? ConfigurationForTheTest = null;
    }
}
