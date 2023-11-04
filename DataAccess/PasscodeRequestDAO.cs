using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class PasscodeRequestDAO
    {
        private static PasscodeRequestDAO instance = null;
        private static readonly object objLock = new object();
        private PasscodeRequestDAO() { }

        public static PasscodeRequestDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new PasscodeRequestDAO();
                    }
                    return instance;
                }
            }
        }

        public PasscodeRequest GetPasscodeRequestById(int passcodeRequestId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.PasscodeRequests.Find(passcodeRequestId);
        }

        public List<PasscodeRequest> GetAllPasscodeRequests()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.PasscodeRequests.ToList();
        }

        public void AddPasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.PasscodeRequests.Add(passcodeRequest);
            db.SaveChanges();
        }

        public void UpdatePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(passcodeRequest).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeletePasscodeRequest(PasscodeRequest passcodeRequest)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.PasscodeRequests.Remove(passcodeRequest);
            db.SaveChanges();
        }
    }
}
