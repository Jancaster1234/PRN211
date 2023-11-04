using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IMeetingRequestRepository
    {
        MeetingRequest GetMeetingRequestById(int meetingRequestId);
        List<MeetingRequest> GetMeetingRequests();
        void AddMeetingRequest(MeetingRequest meetingRequest);
        void UpdateMeetingRequest(MeetingRequest meetingRequest);
        void DeleteMeetingRequest(MeetingRequest meetingRequest);
    }
}
