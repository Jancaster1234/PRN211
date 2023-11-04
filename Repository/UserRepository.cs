using BusinessObject.Models;
using DataAccess;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string email, string password)
        {
            return UserDAO.Instance.CheckLogin(email, password);
        }

        public List<User> GetUsers()
        {
            return UserDAO.Instance.GetAllUsers();
        }

        public User GetUser(int id)
        {
            return UserDAO.Instance.GetUserById(id);
        }

        public void SaveUser(User user)
        {
            UserDAO.Instance.AddUser(user);
        }

        public void DeleteUser(User user)
        {
            UserDAO.Instance.DeleteUser(user);
        }

        public void UpdateUser(User user)
        {
            UserDAO.Instance.UpdateUser(user);
        }
    }
}