using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface ISlotRepository
    {
        Slot GetSlotById(int slotId);
        List<Slot> GetSlots();
        void AddSlot(Slot slot);
        void UpdateSlot(Slot slot);
        void DeleteSlot(Slot slot);

        Slot getSlot(int teacherId, DateTime date, TimeSpan start);
        List<Slot> FilterSlots(string? teacherEmail, string? subject, DateTime? startDate, DateTime? endDate);
    }
}
