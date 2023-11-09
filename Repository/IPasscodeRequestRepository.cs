﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IPasscodeRequestRepository
    {
        PasscodeRequest GetPasscodeRequestById(int passcodeRequestId);
        List<PasscodeRequest> GetPasscodeRequests();
        void AddPasscodeRequest(PasscodeRequest passcodeRequest);
        void UpdatePasscodeRequest(PasscodeRequest passcodeRequest);
        void DeletePasscodeRequest(PasscodeRequest passcodeRequest);

        List<PasscodeRequest> FilterPasscodeRequests(int? studentId, DateTime? startCreatedDate, DateTime? endCreatedDate, string? status, DateTime? startReviewedDate, DateTime? endReviewedDate, int? slotId);
    }
}
