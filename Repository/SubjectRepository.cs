using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        public Subject GetSubjectById(int subjectId)
        {
            return SubjectDAO.Instance.GetSubjectById(subjectId);
        }

        public List<Subject> GetSubjects()
        {
            return SubjectDAO.Instance.GetAllSubjects();
        }

        public void AddSubject(Subject subject)
        {
            SubjectDAO.Instance.AddSubject(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            SubjectDAO.Instance.UpdateSubject(subject);
        }

        public void DeleteSubject(Subject subject)
        {
            SubjectDAO.Instance.DeleteSubject(subject);
        }
    }
}
