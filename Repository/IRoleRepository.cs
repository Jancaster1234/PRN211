using BusinessObject.Models;
using DataAccess;



namespace Repository
{
    public class RoleRepository : IRoleRepository
    {
        public Role GetRoleById(int roleId)
        {
            return RoleDAO.Instance.GetRoleById(roleId);
        }

        public List<Role> GetRoles()
        {
            return RoleDAO.Instance.GetAllRoles();
        }

        public void AddRole(Role role)
        {
            RoleDAO.Instance.AddRole(role);
        }

        public void UpdateRole(Role role)
        {
            RoleDAO.Instance.UpdateRole(role);
        }

        public void DeleteRole(Role role)
        {
            RoleDAO.Instance.DeleteRole(role);
        }
    }
}
