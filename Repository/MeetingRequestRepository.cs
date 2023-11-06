using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class MeetingRequestRepository : IMeetingRequestRepository
    {
        public MeetingRequest GetMeetingRequestById(int meetingRequestId)
        {
            return MeetingRequestDAO.Instance.GetMeetingRequestById(meetingRequestId);
        }

        public List<MeetingRequest> GetMeetingRequests()
        {
            return MeetingRequestDAO.Instance.GetAllMeetingRequests();
        }

        public void AddMeetingRequest(MeetingRequest meetingRequest)
        {
            MeetingRequestDAO.Instance.AddMeetingRequest(meetingRequest);
        }

        public void UpdateMeetingRequest(MeetingRequest meetingRequest)
        {
            MeetingRequestDAO.Instance.UpdateMeetingRequest(meetingRequest);
        }

        public void DeleteMeetingRequest(MeetingRequest meetingRequest)
        {
            MeetingRequestDAO.Instance.DeleteMeetingRequest(meetingRequest);
        }
        
        public List<MeetingRequest> FilterMeetingRequests(int? userId, int? teacherId, DateTime? startCreatedDate, DateTime? endCreatedDate, string? status, DateTime? startReviewedDate, DateTime? endReviewedDate, int? slotId)
        {
            return MeetingRequestDAO.Instance.FilterMeetingRequests(userId, teacherId, startCreatedDate, endCreatedDate, status, startReviewedDate, endReviewedDate, slotId);
        }
    }

}
