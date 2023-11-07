using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class SlotRepository : ISlotRepository
    {
        public Slot GetSlotById(int slotId)
        {
            return SlotDAO.Instance.GetSlotById(slotId);
        }

        public List<Slot> GetSlots()
        {
            return SlotDAO.Instance.GetAllSlots();
        }

        public void AddSlot(Slot slot)
        {
            SlotDAO.Instance.AddSlot(slot);
        }

        public void UpdateSlot(Slot slot)
        {
            SlotDAO.Instance.UpdateSlot(slot);
        }

        public void DeleteSlot(Slot slot)
        {
            SlotDAO.Instance.DeleteSlot(slot);
        }
        public List<Slot> FilterSlots(string? teacherEmail, string? subject, DateTime? startDate, DateTime? endDate)
        {
            return SlotDAO.Instance.FilterSlots(teacherEmail, subject, startDate, endDate);
        }

        public Slot getSlot(int teacherId, DateTime date, TimeSpan start)
        {
            return SlotDAO.Instance.GetSlot(teacherId, date, start);
        }
    }
}
