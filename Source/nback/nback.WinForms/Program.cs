using nback.Domain;
using nback.Domain.Timers;
using nback.Interactors.TestIsCompleted;

namespace nback.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfigurationForTheTest? configuration;
            do
            {
                var configWithStreamGenerator = GetConfiguration();

                if (configWithStreamGenerator == null)
                    break;

                configuration = configWithStreamGenerator.Configuration;
                
                var streamOfStimuli = configWithStreamGenerator.
                    StreamOfStimuliGenerator.
                    Generate(configuration.NumberOfStimuli);

                ITimer timer = new DefaultTimer();

                var testResult = ExecuteTest(configuration, streamOfStimuli, timer);
                ShowTestResult(testResult);
            } while (true);
        }

        private static ConfigurationWithStreamGenerator? GetConfiguration()
        {
            using var form = new StartTestForm();
            form.ShowDialog();
            return form.ConfigurationForTheTest;
        }

        private static void ShowTestResult(TestResultDomainModel testResult)
        {
            using var form = new ShowTestResultForm(testResult);
            form.ShowDialog();
        }

        private static TestResultDomainModel ExecuteTest(ConfigurationForTheTest configuration, StreamOfStimuli streamOfStimuli, ITimer timer)
        {
            using var form = new RunTestForm(configuration, streamOfStimuli, timer);
            form.ShowDialog();
            return form.Result;
        }
    }
}