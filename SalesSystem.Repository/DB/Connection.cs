using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SalesSystem.Repository.DB;

public class Connection
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public Connection(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SalesSystemDB") ?? throw new InvalidOperationException("Connection string 'SalesSystemDB' not found.");
    }

    public SqlConnection GetConnection() => new(_connectionString);
}
