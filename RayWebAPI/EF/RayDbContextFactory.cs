using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RayWebAPI.EF
{
    public class RayDbContextFactory : IDesignTimeDbContextFactory<RayDbContext>
    {
        private readonly IConfiguration _configuration;

        public RayDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public RayDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RayDbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("RayDB"),
                                        options => options.EnableRetryOnFailure());
            return new RayDbContext(optionsBuilder.Options);
        }
    }
}