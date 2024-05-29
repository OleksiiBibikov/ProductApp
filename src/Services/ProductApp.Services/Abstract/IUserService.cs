using ProductApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services.Abstract
{
    public interface IUserService
    { 
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserByNameAsync(string name);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(Guid id);
    }
}
