using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Event> Events { get; set; }
        public string ContactNumber { get; set; }
        public double Fund { get; set; } // Finiancial Classes
    }
}
