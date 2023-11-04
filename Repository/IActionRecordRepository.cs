using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IActionRecordRepository
    {
        ActionRecord GetActionRecordById(int actionRecordId);
        List<ActionRecord> GetActionRecords();
        void AddActionRecord(ActionRecord actionRecord);
        void UpdateActionRecord(ActionRecord actionRecord);
        void DeleteActionRecord(ActionRecord actionRecord);
    }
}
