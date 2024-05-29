using ProductApp.Data;
using ProductApp.Infrastructure.Abstract;
using ProductApp.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace ProductApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetUserByIdAsync(Guid id) => _userRepository.GetByIdAsync(id);

        public Task<User> GetUserByNameAsync(string name) => _userRepository.GetByNameAsync(name);

        public Task CreateUserAsync(User user) => _userRepository.CreateAsync(user);

        public Task UpdateUserAsync(User user) => _userRepository.UpdateAsync(user);

        public Task DeleteUserAsync(Guid id) => _userRepository.DeleteAsync(id);
    }
}
