using KGySoft.ComponentModel;
using System.Runtime.Serialization;

namespace Badminton.Classes
{
    public class BadmintonClub
    {
        public SortableBindingList<Player> Players { get; set; } = new SortableBindingList<Player>();
        public List<Session> Sessions { get; set; } = new List<Session> 
        { 
            new Session(numberOfCourts: 4) 
        };

        [IgnoreDataMember] public Session CurrentSession => Sessions.Last();
    }
}
