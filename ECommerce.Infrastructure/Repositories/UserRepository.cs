using ECommerce.Core.DTO;
using ECommerce.Core.Entities;
using ECommerce.Core.RepositoriesContracts;

namespace ECommerce.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser User)
        {
            User.UserId = Guid.NewGuid();

            return User;
        }
        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string email, string password)
        {
            return new ApplicationUser
            {
                UserId = Guid.NewGuid(),
                Email = email,
                Password = password,
                PersonName = "John Doe",
                Gender = GenderOptions.Male.ToString()
            };
        }
    }
}
