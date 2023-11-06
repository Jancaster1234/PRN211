using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;
using System.Xml.Linq;

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

        public List<MeetingRequest> FilterMeetingRequests(int? userId, int? teacherId, DateTime? startCreatedDate, DateTime? endCreatedDate, string? status, DateTime? startReviewedDate, DateTime? endReviewedDate, int? slotId)
        {
            using (var db = new FptuPrn211MeetMyLecturerContext())
            {
                var query = db.MeetingRequests.AsQueryable();

                if (userId.HasValue && userId > 0)
                {
                    query = query.Where(ac => ac.StudentId == userId);
                }

                if (teacherId.HasValue && teacherId > 0)
                {
                    query = query.Where(ac => ac.TeacherId == teacherId);
                }
                if (startCreatedDate != null)
                {
                    query = query.Where(ac => ac.CreatedDate >= startCreatedDate);
                }
                if (endCreatedDate != null)
                {
                    query = query.Where(ac => ac.CreatedDate <= endCreatedDate);
                }
                if (!string.IsNullOrEmpty(status))
                {
                    query = query.Where(ac => ac.Status == status);
                }
                if(slotId.HasValue && slotId > 0)
                {
                    query = query.Where(ac => ac.SlotId == slotId);
                }
                if (startReviewedDate != null)
                {
                    query = query.Where(ac => ac.ReviewedDate >= startReviewedDate);
                }
                if (endReviewedDate != null)
                {
                    query = query.Where(ac => ac.ReviewedDate <= endReviewedDate);
                }
                // Execute the query and return the filtered users as a list
                List<MeetingRequest> filteredMeetingRequests = query.ToList();

                return filteredMeetingRequests;
            }
        }
    }
}
