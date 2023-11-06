using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ActionRecordRepository : IActionRecordRepository
    {
        public ActionRecord GetActionRecordById(int actionRecordId)
        {
            return ActionRecordDAO.Instance.GetActionRecordById(actionRecordId);
        }

        public List<ActionRecord> GetActionRecords()
        {
            return ActionRecordDAO.Instance.GetAllActionRecords();
        }

        public void AddActionRecord(ActionRecord actionRecord)
        {
            ActionRecordDAO.Instance.AddActionRecord(actionRecord);
        }

        public void UpdateActionRecord(ActionRecord actionRecord)
        {
            ActionRecordDAO.Instance.UpdateActionRecord(actionRecord);
        }

        public void DeleteActionRecord(ActionRecord actionRecord)
        {
            ActionRecordDAO.Instance.DeleteActionRecord(actionRecord);
        }

        public List<ActionRecord> FilterActionRecords(int? userId)
        {
            return ActionRecordDAO.Instance.FilterActionRecords(userId);
        }
    }
}
