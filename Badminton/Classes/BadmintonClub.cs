﻿using System.ComponentModel;

namespace Badminton.Classes
{
    public class BadmintonClub
    {
        public Session? CurrentSession { get; set; } = new Session(new int[] { 1, 2, 3, 4 });

        public List<Session> Sessions { get; set; } = new List<Session>();
        public BindingList<Player> Players { get; set; } = new BindingList<Player>();

        public int NumberOfCourts { get; set; } = 4;
    }
}
