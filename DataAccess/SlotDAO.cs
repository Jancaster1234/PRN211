using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;
using System.Data;

namespace DataAccess
{
    public class SlotDAO
    {
        private static SlotDAO instance = null;
        private static readonly object objLock = new object();
        private SlotDAO() { }

        public static SlotDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new SlotDAO();
                    }
                    return instance;
                }
            }
        }

        public Slot GetSlotById(int slotId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Slots.Find(slotId);
        }

        public List<Slot> GetAllSlots()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Slots.ToList();
        }
        public List<Slot> GetSlotsWithRelatedData()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Slots.Include(slot => slot.Teacher)
                          .Include(slot => slot.Subject)
                          .ToList();
        }

        public Slot GetSlot(int teacherId, DateTime date, TimeSpan startTime)
        {
            using (FptuPrn211MeetMyLecturerContext dbContext = new FptuPrn211MeetMyLecturerContext())
            {
                Slot slot = dbContext.Slots
                    .FirstOrDefault(s => s.TeacherId == teacherId
                                     && s.Date == date
                                     && s.StartTime == startTime);

                return slot;
            }
        }

        public void AddSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Slots.Add(slot);
            db.SaveChanges();
        }

        public void UpdateSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Slots.Update(slot);
            db.SaveChanges();
        }

        public void DeleteSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Slots.Remove(slot);
            db.SaveChanges();
        }

        public List<Slot> FilterSlots(string? teacherEmail, string? subject, DateTime? startDate, DateTime? endDate, string? status)
        {
            using (var db = new FptuPrn211MeetMyLecturerContext())
            {
                // Start with all users in the database
                var query = db.Slots
                    .Include(slot => slot.Subject)
                    .Include(slot => slot.Teacher)
                    .AsQueryable();

                // Apply filters if provided
                if (!string.IsNullOrEmpty(teacherEmail))
                {
                    query = query.Where(slot => slot.Teacher.Email == teacherEmail);
                }
                if (!string.IsNullOrEmpty(subject))
                {
                    query = query.Where(slot => slot.Subject.Name == subject);
                }
                if (startDate != null)
                {
                    query = query.Where(slot => slot.Date >= startDate);
                }

                if (endDate != null)
                {
                    query = query.Where(slot => slot.Date <= endDate);
                }
                if (!string.IsNullOrEmpty(status))
                {
                    query = query.Where(slot => slot.Status == status);
                }
                // Execute the query and return the filtered users as a list
                List<Slot> filteredSlots = query.ToList();

                return filteredSlots;
            }
        }
    }
}
