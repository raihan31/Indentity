using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
namespace Repository
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions options)
        :base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }     
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // builder.UseNpgsql(@"Server=localhost;Database=authentication;Username=postgres;Password=1qazZAQ!");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}