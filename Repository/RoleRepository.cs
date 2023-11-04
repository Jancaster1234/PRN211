using BusinessObject.Models;

namespace Repository
{
    public interface IRoleRepository
    {
        Role GetRoleById(int roleId);
        List<Role> GetRoles();
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
    }
}