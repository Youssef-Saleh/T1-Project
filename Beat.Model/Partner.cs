using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    class Partner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Website { get; set; }

        // public List<string> AdditionalContact { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string LogoUrl { get; set; } // logo in resources  // DB
    }
}
