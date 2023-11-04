using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

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

        public void AddSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Slots.Add(slot);
            db.SaveChanges();
        }

        public void UpdateSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(slot).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteSlot(Slot slot)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Slots.Remove(slot);
            db.SaveChanges();
        }
    }
}
