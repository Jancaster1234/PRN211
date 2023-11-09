using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class PasscodeRequestDAO
    {
        private static PasscodeRequestDAO instance = null;
        private static readonly object objLock = new object();
        private PasscodeRequestDAO() { }

        public static PasscodeRequestDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new PasscodeRequestDAO();
                    }
                    return instance;
                }
            }
        }

        public PasscodeRequest GetPasscodeRequestById(int passcodeRequestId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.PasscodeRequests.Find(passcodeRequestId);
        }

        public List<PasscodeRequest> GetAllPasscodeRequests()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.PasscodeRequests.Include(p => p.Slot).Include(p => p.Student).ToList();
        }

        public void AddPasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.PasscodeRequests.Add(passcodeRequest);
            db.SaveChanges();
        }

        public void UpdatePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(passcodeRequest).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeletePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.PasscodeRequests.Remove(passcodeRequest);
            db.SaveChanges();
        }
        public List<PasscodeRequest> FilterPasscodeRequests(int? studentId, DateTime? startCreatedDate, DateTime? endCreatedDate, string? status, DateTime? startReviewedDate, DateTime? endReviewedDate, int? slotId)
        {
            using (var db = new FptuPrn211MeetMyLecturerContext())
            {
                var query = db.PasscodeRequests.Include(p => p.Slot).Include(p => p.Student).AsQueryable();

                if (studentId.HasValue && studentId > 0)
                {
                    query = query.Where(ac => ac.StudentId == studentId);
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
                if (slotId.HasValue && slotId > 0)
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
                List<PasscodeRequest> filteredPasscodeRequests = query.ToList();

                return filteredPasscodeRequests;
            }
        }
    }
}
