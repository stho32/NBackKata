using System.Configuration;
using nback.Domain;
using nback.Domain.Timers;
using nback.Interactors;
using nback.Interactors.RunTest;
using nback.Interactors.TestIsCompleted;

namespace nback.WinForms
{
    public partial class RunTestForm : Form
    {
        private RunTestInteractor interactor;

        public RunTestForm(
            ConfigurationForTheTest configuration,
            StreamOfStimuli streamOfStimuli,
            ITimer timer
        )
        {
            interactor = new RunTestInteractor(configuration, streamOfStimuli, timer);
            interactor.UiChangeNotificationEvent += UiChangeNotificationFromInteractor;

            InitializeComponent();
        }

        public RunTestForm()
        {
            InitializeComponent();
        }

        public TestResultDomainModel Result { get; private set; }

        private void UiChangeNotificationFromInteractor(RunTestDomainModel domainmodel)
        {
            Invoke(delegate
            {
                IsARepetitionButton.BackColor = domainmodel.DeclarePatternARepetitionIsLoggedIn ? Color.GreenYellow : Color.Silver;

                IsNotARepetitionButton.BackColor = domainmodel.DeclarePatternIsNotARepetitonIsLoggedIn ? Color.GreenYellow : Color.Silver;

                MessageLabel.Text = domainmodel.Message;
                PatternDisplay.Text = domainmodel.Stimulus;
                TestIsRunningLabel.Visible = !domainmodel.YouHaveReachedTheEnd;
                AbortButton.Text = domainmodel.YouHaveReachedTheEnd ? "Close" : "Abort";

                PositionLabel.Visible = !domainmodel.YouHaveReachedTheEnd;
                PositionLabel.Text = domainmodel.Position + "/" + domainmodel.TotalAmountOfStimuli;
            });
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            interactor.Start();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            interactor.Abort();
            Result = interactor.GetTestResult();
            Close();
        }

        private void RunTestForm_Load(object sender, EventArgs e)
        {
            interactor.Init();
        }

        private void IsARepititionButton_Click(object sender, EventArgs e)
        {
            interactor.DeclarePatternARepetition();
        }

        private void IsNotARepetitionButton_Click(object sender, EventArgs e)
        {
            interactor.DeclarePatternIsNotARepetition();
        }

        private void RunTestForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                interactor.DeclarePatternARepetition();
            }

            if (e.KeyCode == Keys.J)
            {
                interactor.DeclarePatternIsNotARepetition();
            }
        }
    }
}