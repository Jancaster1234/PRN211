using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class SubjectDAO
    {
        private static SubjectDAO instance = null;
        private static readonly object objLock = new object();
        private SubjectDAO() { }

        public static SubjectDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new SubjectDAO();
                    }
                    return instance;
                }
            }
        }

        public Subject GetSubjectById(int subjectId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Subjects.Find(subjectId);
        }

        public List<Subject> GetAllSubjects()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Subjects.ToList();
        }

        public void AddSubject(Subject subject)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Subjects.Add(subject);
            db.SaveChanges();
        }

        public void UpdateSubject(Subject subject)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(subject).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteSubject(Subject subject)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Subjects.Remove(subject);
            db.SaveChanges();
        }
    }
}
