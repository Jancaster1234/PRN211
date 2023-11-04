using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class RoleDAO
    {
        private static RoleDAO instance = null;
        private static readonly object objLock = new object();
        private RoleDAO() { }

        public static RoleDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                    return instance;
                }
            }
        }

        public Role GetRoleById(int roleId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Roles.Find(roleId);
        }

        public List<Role> GetAllRoles()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Roles.ToList();
        }

        public void AddRole(Role role)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Roles.Add(role);
            db.SaveChanges();
        }

        public void UpdateRole(Role role)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(role).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteRole(Role role)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Roles.Remove(role);
            db.SaveChanges();
        }
    }
}
