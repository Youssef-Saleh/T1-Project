using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    public class Task
    {
        public int Id { get; set; }
        public List<Member> Members { get; set; }
        public Track Track { get; set; } //committee
        public string Name { get; set; }
        public string Description { get; set; }
        public Member HrMember { get; set; }
        public Member Leader { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Submission { get; set; }
        public string Feedback { get; set; }
        public string Evaluation { get; set; }
    }
}
