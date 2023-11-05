using System.Diagnostics.Metrics;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object objLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO ();
                    }
                    return instance;
                }
            }
        }

        public User CheckLogin(string email, string password)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }

        public User GetUserById(int userId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.Find(userId);
        }
        public User GetUserByEmail(string Email)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.SingleOrDefault(user => user.Email.Equals(Email));
        }
        public List<User> GetAllUsers()
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.ToList();
        }

        public void AddUser(User user)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}