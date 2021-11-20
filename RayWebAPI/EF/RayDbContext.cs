using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RayWebAPI.Models;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"server=.\SQLEXPRESS; database=RayDB;integrated security=True; MultipleActiveResultSets=True; App=EntityFramework;";
                optionsBuilder.UseSqlServer(connectionString,
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