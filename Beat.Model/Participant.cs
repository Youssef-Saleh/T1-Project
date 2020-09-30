using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Course> Courses { get; set; }
        public string Grade { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
    }
}
