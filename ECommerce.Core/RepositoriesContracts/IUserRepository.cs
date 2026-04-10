using ECommerce.Core.Entities;

namespace ECommerce.Core.RepositoriesContracts
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> AddUser(ApplicationUser User);
        Task<ApplicationUser?> GetUserByEmailAndPassword(string email, string password);
    }
}
