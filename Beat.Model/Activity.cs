using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string University { get; set; }
        public string College { get; set; }
        public string Department { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime InitialDate { get; set; }
        public string ActivityLeader { get; set; }
    }
}
