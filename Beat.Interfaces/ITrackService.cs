using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Model;

namespace Beat.Interfaces
{
    public interface ITrackService
    {
        List<Track> GetAll();
        Track GetById(int id);
        void AddTrack(string name, string abbreviation, int leaderId);
        void DeleteTrack(int id);
        void UpdateTrackLeader(int id, int leaderId);
        List<Member> GetAllMembersInTrack(int trackId);
        Member GetLeader();
        List<Committee> GetCommittees();
        void AddMemberToTrack(int trackId,int memberId);


    }
}
