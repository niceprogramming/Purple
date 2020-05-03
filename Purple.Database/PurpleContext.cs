using Microsoft.EntityFrameworkCore;
using System;

namespace Purple.Database
{
    public class PurpleContext : DbContext
    {
        public DbSet<Ban> Bans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }

    public class Ban
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Reason { get; set; }
    }
}
