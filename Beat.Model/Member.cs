using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Model.Enums;

namespace Beat.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public string Address { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public Track Track { get; set; }
        public List<Track> SecondaryTracks { get; set; }
        public List<Committee> Committee { get; set; }
        // public List<Committee> SecondaryCommittees { get; set; }
        public Position Position { get; set; }

    }
}
