using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Model.Enums;

namespace Beat.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public DateTime StartDate { get; set; } // to be discussed
        public DateTime EndDate { get; set; }
        public Member Leader { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Member> Organizers { get; set; }
        public EventTypes Type { get; set; }
    }
}
