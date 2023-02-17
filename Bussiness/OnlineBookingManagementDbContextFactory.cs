using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bussiness
{
    public class OnlineBookingManagementDbContextFactory : IDesignTimeDbContextFactory<OnlineBookingManagementDbContext>
    {
        public OnlineBookingManagementDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\API"))
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<OnlineBookingManagementDbContext>();

            var connectionString = configuration.GetConnectionString("OnlineBookingManagementConnectionString");
            builder.UseSqlServer(connectionString);

            return new OnlineBookingManagementDbContext(builder.Options);
        }
    }
}
