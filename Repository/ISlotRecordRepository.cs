using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface ISlotRecordRepository
    {
        SlotRecord GetSlotRecordById(int slotRecordId);
        List<SlotRecord> GetSlotRecords();
        void AddSlotRecord(SlotRecord slotRecord);
        void UpdateSlotRecord(SlotRecord slotRecord);
        void DeleteSlotRecord(SlotRecord slotRecord);
    }
}
