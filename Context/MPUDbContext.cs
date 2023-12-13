using Npgsql;
using ApiMpu9250.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiMpu9250.Context;
public class MPUDbContext: DbContext
{
    public MPUDbContext(DbContextOptions<MPUDbContext> options) : base(options) 
    { 
    }

    public DbSet<MPU> Mpus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = "monorail.proxy.rlwy.net",
            Port = 38423,
            Database = "railway",
            Username = "postgres",
            Password = "bggCb36*4BdE3EFC6efDBdGa4e3a4af5",
        };

        string connectionString = builder.ConnectionString;

        optionsBuilder.UseNpgsql(connectionString);
    }
}
