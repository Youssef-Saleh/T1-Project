using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Data;
using Beat.Model;
using Beat.Interfaces;

namespace Beat.Services
{
    public class MemberService: IMemberService
    {
        private BeatContext db;

        public MemberService()
        {
            db = new BeatContext();
        }

        public List<Member> GetAll()
        {
            return db.Members.ToList();
        }

        public Member GetById(int id)
        {
            return db.Members.FirstOrDefault(m => m.Id == id);
        }

        public void AddMember(string name, string phone, string email, string gender)
        {
            var toBeAddedMember = new Member { Name = name, Phone = phone, Email = email, Gender = gender };
            // how do we put ID to be added?
            db.Members.Add(toBeAddedMember);
            db.SaveChanges();
        }

        public void DeleteMember(int id)
        {
            var x = (from y in db.Members
                where y.Id == id
                select y).FirstOrDefault();

            if (x == null) return;
            db.Members.Remove(x);
            db.SaveChanges();
        }

        public void UpdateMemberEmail(int id, string emailToChangeTo)
        {
            Member member = db.Members.First(m => m.Id.Equals(id));
            member.Email = emailToChangeTo;
            db.SaveChanges();
            // do we have to add a update function for each member we want to update?
        }


        /*
        public List<Member> GetAllInUniversity(string university)
        {
            return db.Members.ToList().Where(m => m.University == university);
        }
        */

    }
}
