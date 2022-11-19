using nback.Interactors.TestIsCompleted;

namespace nback.WinForms
{
    public partial class ShowTestResultForm : Form
    {
        private readonly TestResultDomainModel _testResult;

        public ShowTestResultForm()
        {
            InitializeComponent();
        }

        public ShowTestResultForm(TestResultDomainModel testResult)
        {
            _testResult = testResult;
            InitializeComponent();
        }

        private void ShowTestResultForm_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = _testResult;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
