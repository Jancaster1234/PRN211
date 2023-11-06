using BusinessObject.Models;

namespace Repository
{
    public interface IUserRepository
    {
        User CheckLogin(string email, string password);
        List<User> GetUsers();
        User GetUser(int id);
        void SaveUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        void UpdateUserImage(User user, string imageName);
        List<User> FilterUsers(string? role, string? email, string? major, string? name);
    }
}