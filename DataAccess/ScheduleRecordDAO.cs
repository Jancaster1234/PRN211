using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

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

        public List<ScheduleRecord> GetAllScheduleRecords()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ScheduleRecords.Include(scheduleRecord => scheduleRecord.Teacher).ToList();
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
    }
}
