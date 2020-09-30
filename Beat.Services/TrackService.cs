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
    public class TrackService: ITrackService
    {
        private BeatContext db;

        public TrackService()
        {
            db = new BeatContext();
        }

        public List<Track> GetAll()
        {
            return db.Tracks.ToList();
        }

        public Track GetById(int id)
        {
            return db.Tracks.FirstOrDefault(m => m.Id == id);
        }

        public void AddTrack(string name, string abbreviation, int leaderId)
        {
            var leader = db.Members.FirstOrDefault(m => m.Id == leaderId);
            var tobeAddedTrack = new Track { Name = name, Abbreviation = abbreviation, Leader = leader};

            db.Tracks.Add(tobeAddedTrack);
            db.SaveChanges();
        }

        public void DeleteTrack(int id)
        {
            var x = (from y in db.Tracks
                where y.Id == id
                select y).FirstOrDefault();

            if (x == null) return;
            db.Tracks.Remove(x);
            db.SaveChanges();
        }

        public void UpdateTrackLeader(int id, int leaderId)
        {
            Track track = db.Tracks.First(m => m.Id.Equals(id));
            var leader = db.Members.FirstOrDefault(m => m.Id == leaderId);
            track.Leader = leader;
            db.SaveChanges();
        }

        public List<Member> GetAllMembersInTrack(int trackId)
        {
            Track track;
            track = db.Tracks.ToList().Find(t => t.Id == trackId);
            return track.Members;

        }

        public Member GetLeader()
        {
            throw new NotImplementedException();
        }

        public List<Committee> GetCommittees()
        {
            throw new NotImplementedException();
        }

        public void AddMemberToTrack(int trackId,int memberId)
        {
            Track track = db.Tracks.First(m => m.Id.Equals(trackId));
            var member = db.Members.FirstOrDefault(m => m.Id == memberId);

            track.Members.Add(member);
            db.SaveChanges();
        }



    }
}
