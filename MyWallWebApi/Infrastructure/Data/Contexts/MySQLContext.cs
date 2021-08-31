using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWallWebApi.Domain.Models;


namespace MyWallWebApi
{
    public class MySQLContext : IdentityDbContext<ApplicationUser>
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) :base(options)
        {

        }

        public DbSet <Post> Post { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<ApplicationRole> Role { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Post>();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            modelBuilder.Entity<Post>();
        }

    }
}
