using DatingApp.API.Entities;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext( DbContextOptions  options):base(options){}

        public DataContext()
        {
        }

        public DbSet<Value> Values { get; set; }

        public DbSet<AppUser> Users{ get; set; }


    }
}