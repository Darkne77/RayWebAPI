using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RayWebAPI.Entities;

namespace RayWebAPI.EF
{
    public class RayDbContext : DbContext
    {
        public RayDbContext(DbContextOptions options) : base(options)
        {
        }

        internal RayDbContext()
        {
            
        }

        private readonly IConfiguration _configuration;

        public RayDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("RayDB"),
                                            options => options.EnableRetryOnFailure());
            }
        }
        
        //use OnModelCreating for define tables relations

        public DbSet<Hospice> Hospices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Donat> Donats { get; set; }

        public string GetTableName(Type type)
        {
            return Model.FindEntityType(type).GetTableName();
        }
    }
}