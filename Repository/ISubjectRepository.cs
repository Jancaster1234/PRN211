using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface ISubjectRepository
    {
        Subject GetSubjectById(int subjectId);
        List<Subject> GetSubjects();
        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(Subject subject);
    }
}
