using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class MeetingRequestDAO
    {
        private static MeetingRequestDAO instance = null;
        private static readonly object objLock = new object();
        private MeetingRequestDAO() { }

        public static MeetingRequestDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new MeetingRequestDAO();
                    }
                    return instance;
                }
            }
        }

        public MeetingRequest GetMeetingRequestById(int meetingRequestId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.MeetingRequests.Find(meetingRequestId);
        }

        public List<MeetingRequest> GetAllMeetingRequests()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.MeetingRequests.ToList();
        }

        public void AddMeetingRequest(MeetingRequest meetingRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.MeetingRequests.Add(meetingRequest);
            db.SaveChanges();
        }

        public void UpdateMeetingRequest(MeetingRequest meetingRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(meetingRequest).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteMeetingRequest(MeetingRequest meetingRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.MeetingRequests.Remove(meetingRequest);
            db.SaveChanges();
        }
    }
}
