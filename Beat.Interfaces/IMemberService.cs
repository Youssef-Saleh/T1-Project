using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Model;

namespace Beat.Interfaces
{
    public interface IMemberService
    {
        List<Member> GetAll();
        Member GetById(int id);
        void AddMember(string name, string email, string phone, string gender);
        void DeleteMember(int id);
        void UpdateMemberEmail(int id, string emailToChangeTo);
        //List<Member> GetAllInUniversity(string University);
    }
}
