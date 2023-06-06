using Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAccountService
    {
        Task Register(UserDTO user);
        Task Login(string email, string password);
        Task Logout();
    }
}
