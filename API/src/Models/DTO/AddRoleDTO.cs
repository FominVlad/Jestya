using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApp.Models.DTO
{
    public class AddRoleDTO
    {
        public string RoleName { get; set; }
        public int GroupId { get; set; }

        public static implicit operator Role(AddRoleDTO roleDTO)
        {
            return new Role
            {
                RoleName = roleDTO.RoleName,
                GroupId = roleDTO.GroupId
            };
        }
    }
}
