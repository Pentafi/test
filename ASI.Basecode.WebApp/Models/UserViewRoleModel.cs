using ASI.Basecode.Services.ServiceModels;
using System.Collections.Generic;

namespace ASI.Basecode.WebApp.Models
{
    public class UserViewRoleModel
    {
        public UserViewModel ViewModel { get; set; }
        public List<RoleViewModel> IdentityUsers { get; set; }
    }
}