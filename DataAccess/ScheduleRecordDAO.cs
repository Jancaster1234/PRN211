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

        public ScheduleRecord GetScheduleRecordByTimeAndDate(TimeSpan start, string dateWeek, int week, int teacherID)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();

            // Find the smallest date for the teacherID
            var minDate = db.ScheduleRecords
                .Where(sr => sr.TeacherId == teacherID)
                .Min(sr => sr.Date);

            if (minDate == null)
            {
                // Handle the case where there are no records for the specified teacherID
                return null;
            }

            // Calculate the starting date for the given week
            DateTime startDate = minDate.Value.Date.AddDays(week * 7);

            // Calculate the ending date for the given week
            DateTime endDate = startDate.AddDays(6); // Assuming a week has 7 days

            // Retrieve the ScheduleRecords for the specified teacherID and within the calculated date range
            var records = db.ScheduleRecords
                .Where(sr => sr.TeacherId == teacherID && sr.Date >= startDate && sr.Date <= endDate)
                .ToList();

            // Find the record that matches the start time and day of the week
            var result = records.FirstOrDefault(sr => sr.StartTime == start
                && sr.Date.Value.DayOfWeek.ToString() == dateWeek);

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
