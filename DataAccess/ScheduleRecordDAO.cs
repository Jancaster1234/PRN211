using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace DataAccess
{
    public class ScheduleRecordDAO
    {
        private static ScheduleRecordDAO instance = null;
        private static readonly object objLock = new object();
        private ScheduleRecordDAO() { }

        public static ScheduleRecordDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new ScheduleRecordDAO();
                    }
                    return instance;
                }
            }
        }

        public ScheduleRecord GetScheduleRecordById(int scheduleRecordId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ScheduleRecords.Find(scheduleRecordId);
        }

        public ScheduleRecord GetScheduleRecordByTimeAndDate(TimeSpan start, string date)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            var records = db.ScheduleRecords.ToList();
            var result = records.FirstOrDefault(sr => sr.StartTime.Equals(start) && sr.Date.HasValue && sr.Date.Value.DayOfWeek.ToString() == date);

            return result;
        }

        public ScheduleRecord checkExist(string room, TimeSpan start, DateTime date)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ScheduleRecords.FirstOrDefault(sr => sr.Room.Equals(room) && sr.StartTime.Equals(start) && sr.Date.Equals(date));
        }

        public List<ScheduleRecord> GetAllScheduleRecords()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ScheduleRecords.ToList();
        }

        public void AddScheduleRecord(ScheduleRecord scheduleRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.ScheduleRecords.Add(scheduleRecord);
            db.SaveChanges();
        }

        public void UpdateScheduleRecord(ScheduleRecord scheduleRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(scheduleRecord).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteScheduleRecord(ScheduleRecord scheduleRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.ScheduleRecords.Remove(scheduleRecord);
            db.SaveChanges();
        }

        public void DeleteScheduleRecordsByTeacherId(int teacherId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();

            // Retrieve all schedule records with teacherId = 1
            var scheduleRecords = db.ScheduleRecords.Where(record => record.TeacherId == teacherId).ToList();

            // Remove each schedule record
            foreach (var scheduleRecord in scheduleRecords)
            {
                db.ScheduleRecords.Remove(scheduleRecord);
            }

            db.SaveChanges();
        }
    }
}
