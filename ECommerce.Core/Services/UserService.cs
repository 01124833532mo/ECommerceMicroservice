using ECommerce.Core.DTO;
using ECommerce.Core.Entities;
using ECommerce.Core.RepositoriesContracts;
using ECommerce.Core.ServiceContracts;

namespace ECommerce.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AuthRespons?> Login(LoginRequest login)
        {
            ApplicationUser? user = await _userRepository.GetUserByEmailAndPassword(login.Email, login.Password);
            if (user == null)
            {
                return null;
            }
            return new AuthRespons(
                user.UserId,
                user.Email,
                user.PersonName,
                user.Gender,
                "This is a dummy token",
                true
            );

        }

        public async Task<AuthRespons?> Register(RegisterRequest register)
        {
            var newUser = new ApplicationUser
            {
                PersonName = register.PersonName,
                Email = register.Email,
                Password = register.Password,
                Gender = register.Gender.ToString()
            };
            ApplicationUser? user = await _userRepository.AddUser(newUser);
            if (user == null)
            {
                return null;
            }
            return new AuthRespons(
                user.UserId,
                user.Email,
                user.PersonName,
                user.Gender,
                "This is a dummy token",
                true
            );
        }
    }
}
