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
    }
}
