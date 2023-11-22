using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;
using System.Xml.Linq;

namespace DataAccess
{
    public class ActionRecordDAO
    {
        private static ActionRecordDAO instance = null;
        private static readonly object objLock = new object();
        private ActionRecordDAO() { }

        public static ActionRecordDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new ActionRecordDAO();
                    }
                    return instance;
                }
            }
        }

        public ActionRecord GetActionRecordById(int actionRecordId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ActionRecords.Find(actionRecordId);
        }

        public List<ActionRecord> GetAllActionRecords()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.ActionRecords.Include(a => a.User).ToList();
        }

        public void AddActionRecord(ActionRecord actionRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.ActionRecords.Add(actionRecord);
            db.SaveChanges();
        }

        public void UpdateActionRecord(ActionRecord actionRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(actionRecord).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteActionRecord(ActionRecord actionRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.ActionRecords.Remove(actionRecord);
            db.SaveChanges();
        }
        public List<ActionRecord> FilterActionRecords(int? userId)
        {
            using (var db = new FptuPrn211MeetMyLecturerContext())
            {
                var query = db.ActionRecords.Include(a => a.User).AsQueryable();

                if (userId.HasValue && userId > 0)
                {
                    query = query.Where(ac => ac.User.Id == userId);
                }

                List<ActionRecord> filteredActionRecords = query.ToList();

                return filteredActionRecords;
            }
        }
    }
}
