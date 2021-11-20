using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RayWebAPI.EF
{
    public class RayDbContextFactory : IDesignTimeDbContextFactory<RayDbContext>
    {
        public RayDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RayDbContext>();
            var connectionString = @"server=.\SQLEXPRESS; database=RayDB;integrated security=True; MultipleActiveResultSets=True; App=EntityFramework;";
            optionsBuilder.UseSqlServer(connectionString,
                                        options => options.EnableRetryOnFailure());
            return new RayDbContext(optionsBuilder.Options);
        }
    }
}