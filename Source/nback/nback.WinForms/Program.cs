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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ConfigurationForTheTest configuration = new ConfigurationForTheTest("Stefan", 1, 2000, 4);
            StreamOfStimuli streamOfStimuli = new StreamOfStimuli("AABC");
            ITimer timer = new DefaultTimer();

            var testResult = ExecuteTest(configuration, streamOfStimuli, timer);
            ShowTestResult(testResult);

            //Application.Run(new RunTestForm(configuration, streamOfStimuli, timer));
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