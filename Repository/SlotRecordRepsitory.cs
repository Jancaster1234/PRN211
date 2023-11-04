using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class SlotRecordRepository : ISlotRecordRepository
    {
        public SlotRecord GetSlotRecordById(int slotRecordId)
        {
            return SlotRecordDAO.Instance.GetSlotRecordById(slotRecordId);
        }

        public List<SlotRecord> GetSlotRecords()
        {
            return SlotRecordDAO.Instance.GetAllSlotRecords();
        }

        public void AddSlotRecord(SlotRecord slotRecord)
        {
            SlotRecordDAO.Instance.AddSlotRecord(slotRecord);
        }

        public void UpdateSlotRecord(SlotRecord slotRecord)
        {
            SlotRecordDAO.Instance.UpdateSlotRecord(slotRecord);
        }

        public void DeleteSlotRecord(SlotRecord slotRecord)
        {
            SlotRecordDAO.Instance.DeleteSlotRecord(slotRecord);
        }
    }
}
