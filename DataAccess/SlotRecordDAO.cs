using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class SlotRecordDAO
    {
        private static SlotRecordDAO instance = null;
        private static readonly object objLock = new object();
        private SlotRecordDAO() { }

        public static SlotRecordDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new SlotRecordDAO();
                    }
                    return instance;
                }
            }
        }

        public SlotRecord GetSlotRecordById(int slotRecordId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.SlotRecords.Find(slotRecordId);
        }

        public List<SlotRecord> GetAllSlotRecords()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.SlotRecords.ToList();
        }

        public void AddSlotRecord(SlotRecord slotRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.SlotRecords.Add(slotRecord);
            db.SaveChanges();
        }

        public void UpdateSlotRecord(SlotRecord slotRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(slotRecord).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteSlotRecord(SlotRecord slotRecord)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.SlotRecords.Remove(slotRecord);
            db.SaveChanges();
        }
    }
}
