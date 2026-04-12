using Microsoft.Extensions.Configuration;
using System.Data;

namespace ECommerce.Infrastructure.DbContext;

public class DapperDbContext
{
    private readonly IConfiguration configuration;
    private readonly IDbConnection connection;

    public DapperDbContext(IConfiguration configuration)
    {
        this.configuration = configuration;
        string? connectionString = configuration.GetConnectionString("Postgres");
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string 'Postgres' not found.");
        }
        connection = new Npgsql.NpgsqlConnection(connectionString);
    }

    public IDbConnection Connection => connection;
}

