using Dapper;
using ECommerce.Core.Entities;
using ECommerce.Core.RepositoriesContracts;
using ECommerce.Infrastructure.DbContext;

namespace ECommerce.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperDbContext _dapperDbContext;

        public UserRepository(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }
        public async Task<ApplicationUser?> AddUser(ApplicationUser User)
        {
            User.UserId = Guid.NewGuid();

            var query = "INSERT INTO public.\"Users\"(\"UserId\", \"Email\", \"PersonName\", \"Gender\", \"Password\") VALUES (@UserId, @Email, @PersonName, @Gender, @Password)";
            var rowcountaffected = await _dapperDbContext.Connection.ExecuteAsync(query, User);

            if (rowcountaffected > 0)
            {
                return User;
            }
            return null;
        }
        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string email, string password)
        {
            var query = "SELECT * FROM public.\"Users\" WHERE \"Email\" = @Email AND \"Password\" = @Password";
            ApplicationUser? user = await _dapperDbContext.Connection.QueryFirstOrDefaultAsync<ApplicationUser>(query,
                new { Email = email, Password = password }
                );

            if (user == null)
            {
                return null;
            }



            return user;
        }

    }
}
