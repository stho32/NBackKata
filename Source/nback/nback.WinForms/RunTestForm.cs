using nback.Domain;
using nback.Domain.Timers;
using nback.Interactors;
using nback.Interactors.RunTest;

namespace nback.WinForms
{
    public partial class RunTestForm : Form
    {
        private RunTestInteractor interactor;

        public RunTestForm()
        {
            ConfigurationForTheTest configuration = new ConfigurationForTheTest("Stefan", 1, 2000, 2);
            StreamOfStimuli streamOfStimuli = new StreamOfStimuli("AABC");
            ITimer timer = new DefaultTimer();

            interactor = new RunTestInteractor(configuration, streamOfStimuli, timer);
            interactor.UiChangeNotificationEvent += UiChangeNotificationFromInteractor;

            InitializeComponent();
        }

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