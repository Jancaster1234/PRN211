﻿using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class PasscodeRequestRepository : IPasscodeRequestRepository
    {
        public PasscodeRequest GetPasscodeRequestById(int passcodeRequestId)
        {
            return PasscodeRequestDAO.Instance.GetPasscodeRequestById(passcodeRequestId);
        }

        public List<PasscodeRequest> GetPasscodeRequests()
        {
            return PasscodeRequestDAO.Instance.GetAllPasscodeRequests();
        }

        public void AddPasscodeRequest(PasscodeRequest passcodeRequest)
        {
            PasscodeRequestDAO.Instance.AddPasscodeRequest(passcodeRequest);
        }

        public void UpdatePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            PasscodeRequestDAO.Instance.UpdatePasscodeRequest(passcodeRequest);
        }

        public void DeletePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            PasscodeRequestDAO.Instance.DeletePasscodeRequest(passcodeRequest);
        }
    }
}
