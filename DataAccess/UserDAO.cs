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
        public User GetUserByEmail(string Email)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.SingleOrDefault(user => user.Email.Equals(Email));
        }

        public User GetUserById(int userId)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            return db.Users.Find(userId);
        }

        public List<User> FilterUsers(string? role, string? email, string? major, string? name)
        {
            using (var db = new FptuPrn211MeetMyLecturerContext())
            {
                // Start with all users in the database
                var query = db.Users.AsQueryable();

                // Apply filters if provided
                if (!string.IsNullOrEmpty(role))
                {
                    query = query.Where(u => u.RoleNavigation != null && u.RoleNavigation.RoleName == role);
                }
                if (!string.IsNullOrEmpty(email))
                {
                    query = query.Where(u => u.Email == email);
                }
                if (!string.IsNullOrEmpty(major))
                {
                    query = query.Where(u => u.Major == major);
                }
                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(u => u.Name == name);

                }
                // Execute the query and return the filtered users as a list
                List<User> filteredUsers = query.ToList();

                return filteredUsers;
            }
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

        public void UpdateUserImage(User user, string imageName)
        {
            using var db = new FptuPrn211MeetMyLecturerContext();
            user.Image = imageName;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}