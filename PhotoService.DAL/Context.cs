using Microsoft.EntityFrameworkCore;
using PhotoService.DAL.DTO;
using Oracle.EntityFrameworkCore;
using PhotoService.DAL;

namespace PhotoService
{
    public class Context:DbContext
    {
        public DbSet<ComplainsDto> Complains { get; set; }
        public DbSet<OrdersDto> Orders { get; set; }
        public DbSet<ReviewsDto> Reviews { get; set; }
        public DbSet<RolesDto> Roles { get; set; }
        public DbSet<ServicesDto> Services { get; set; }
        public DbSet<TypesDto> Types { get; set; }
        public DbSet<UsersDto> Users { get; set; }

        public Context()
        {
            // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Options.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComplainsDto>()
                .HasOne(c => c.Author)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction); // Отключение каскадного удаления для автора

            modelBuilder.Entity<ComplainsDto>()
                .HasOne(c => c.Recipient)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction); // Отключение каскадного удаления для получателя
            
            modelBuilder.Entity<OrdersDto>()
                .HasOne(c => c.Customer)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction); // Отключение каскадного удаления для получателя
        }
    }
}