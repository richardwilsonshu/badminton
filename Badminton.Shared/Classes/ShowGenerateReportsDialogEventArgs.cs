namespace Badminton.Shared.Classes
{
    public class ShowGenerateReportsDialogEventArgs
    {
        public List<Tuple<int, Session>> SessionsToReport { get; set; }

        public ShowGenerateReportsDialogEventArgs(List<Tuple<int, Session>> sessionsToReport)
        {
            SessionsToReport = sessionsToReport;
        }
    }
}
