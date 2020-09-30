using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat.Model
{
    class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Member> Writers { get; set; }
        public string Field { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        //Media [Files, Images, Code, ....] ????????
        //Edit after publish ????
        //Comments on the Article ??
        //Rating ???
    }
}
