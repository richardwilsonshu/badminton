namespace Badminton.Classes
{
    public class SessionCreatedEventArgs : EventArgs
    {
        public Session Session { get; set; }

        public SessionCreatedEventArgs(Session session)
        {
            Session = session;
        }
    }
}
