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
            ConfigurationForTheTest =
                new ConfigurationWithStreamGenerator(
                    new ConfigurationForTheTest(
                        NameOfSubjectTextBox.Text,
                        (int)NNumericUpDown.Value,
                        (int)StimulusDurationInMsNumericUpDown.Value,
                        (int)NumberOfStimuliNumericUpDown.Value),
                    GetStreamOfStimuliGenerator());

            Close();
        }

        private IStreamOfStimuliGenerator GetStreamOfStimuliGenerator()
        {
            return (StreamOfStimuliOriginDropDown.SelectedValue as IStreamOfStimuliGenerator)!;
        }

        public ConfigurationWithStreamGenerator? ConfigurationForTheTest = null;

        private void StartTestForm_Load(object sender, EventArgs e)
        {
            var listOfGenerators = new List<IStreamOfStimuliGenerator>();
            listOfGenerators.Add(new FixedStreamOfStimuliGenerator("TLHCHSCCQLCKLHCQTRRKCHR"));

            StreamOfStimuliOriginDropDown.DataSource = listOfGenerators;
        }
    }
}
