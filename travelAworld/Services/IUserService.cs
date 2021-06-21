using System.Collections.Generic;
using System.Threading.Tasks;
using travelAworld.Data;
using travelAworld.Model;

namespace travelAworld.Services
{
    public interface IUserService
    {
        PageResult<UsertoDisplay> Get(UserToSearch queryParams);
        UsertoDisplay GetUserById(int id);
        List<RoleToDisplay> GetRoles(int userId);
        Task UpdateRole(int userId, string roleName);
        bool CanDeleteUser(int userId);
    }
}
