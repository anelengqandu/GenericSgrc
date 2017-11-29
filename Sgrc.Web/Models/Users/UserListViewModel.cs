using System.Collections.Generic;
using Sgrc.Roles.Dto;
using Sgrc.Users.Dto;

namespace Sgrc.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}