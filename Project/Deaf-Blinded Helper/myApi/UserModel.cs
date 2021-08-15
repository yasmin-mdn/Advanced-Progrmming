using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using myShared.Models;
namespace myApi
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=MyDataBase.db");

    }

}