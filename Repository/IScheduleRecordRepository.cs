using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IScheduleRecordRepository
    {
        ScheduleRecord GetScheduleRecordById(int scheduleRecordId);
        List<ScheduleRecord> GetScheduleRecords();
        void AddScheduleRecord(ScheduleRecord scheduleRecord);
        void UpdateScheduleRecord(ScheduleRecord scheduleRecord);
        void DeleteScheduleRecord(ScheduleRecord scheduleRecord);

        ScheduleRecord checkExist(string room, TimeSpan start, DateTime date);

        public void DeleteScheduleRecordByTeacherId(int teacherId);

        ScheduleRecord GetScheduleRecordByTimeAndDate(TimeSpan start, string date);
    }
}
