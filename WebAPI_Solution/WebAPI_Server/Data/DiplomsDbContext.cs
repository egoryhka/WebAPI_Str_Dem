using Microsoft.EntityFrameworkCore;
using DiplomsClassLibrary.Models;

namespace WebAPI_Server.Data
{
    public class DiplomsDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public DbSet<Diplom> Diploms { get; set; }
        public DbSet<Author> Authors { get; set; }
    
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Position> Positions { get; set; }


        public DiplomsDbContext(DbContextOptions<DiplomsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
