using ECommerce.Core.DTO;

namespace ECommerce.Core.ServiceContracts
{
    public interface IUserService
    {
        Task<AuthRespons?> Login(LoginRequest login);

        Task<AuthRespons?> Register(RegisterRequest register);
    }
}
