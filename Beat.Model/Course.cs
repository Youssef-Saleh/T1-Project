using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Member> Moderators { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public DateTime StartDate { get; set; } // to be discussed
        public DateTime EndDate { get; set; }
        public Member Leader { get; set; }
        public Member HrMember { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Session> Sessions { get; set; }


    }
}
