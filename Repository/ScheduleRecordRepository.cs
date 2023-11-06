using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ScheduleRecordRepository : IScheduleRecordRepository
    {
        public ScheduleRecord GetScheduleRecordById(int scheduleRecordId)
        {
            return ScheduleRecordDAO.Instance.GetScheduleRecordById(scheduleRecordId);
        }

        public List<ScheduleRecord> GetScheduleRecords()
        {
            return ScheduleRecordDAO.Instance.GetAllScheduleRecords();
        }

        public void AddScheduleRecord(ScheduleRecord scheduleRecord)
        {
            ScheduleRecordDAO.Instance.AddScheduleRecord(scheduleRecord);
        }

        public void UpdateScheduleRecord(ScheduleRecord scheduleRecord)
        {
            ScheduleRecordDAO.Instance.UpdateScheduleRecord(scheduleRecord);
        }

        public void DeleteScheduleRecord(ScheduleRecord scheduleRecord)
        {
            ScheduleRecordDAO.Instance.DeleteScheduleRecord(scheduleRecord);
        }

        public void DeleteScheduleRecordByTeacherId(int teacherId)
        {
            ScheduleRecordDAO.Instance.DeleteScheduleRecordsByTeacherId(teacherId);
        }
        ScheduleRecord IScheduleRecordRepository.GetScheduleRecordByTimeAndDate(TimeSpan start, string dateWeek, int week, int teacherID)
        {
            return ScheduleRecordDAO.Instance.GetScheduleRecordByTimeAndDate(start, dateWeek, week,teacherID);
        }

        ScheduleRecord IScheduleRecordRepository.checkExist(string room, TimeSpan start, DateTime date)
        {
            return ScheduleRecordDAO.Instance.checkExist(room, start, date);    
        }
    }
}
