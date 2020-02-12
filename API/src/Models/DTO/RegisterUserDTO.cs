using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApp.Models
{
    public class RegisterUserDTO
    {
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public static implicit operator User(RegisterUserDTO userDTO)
        {
            return new User
            {
                UserName = userDTO.UserName,
                Login = userDTO.Login,
                Password = userDTO.Password,
                RoleId = userDTO.RoleId
            };
        }
    }
}
