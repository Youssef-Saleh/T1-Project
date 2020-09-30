using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public Member Leader { get; set; }
        public List<Member> Members { get; set; } 
        public List<Committee> Committees { get; set; }
    }
}
