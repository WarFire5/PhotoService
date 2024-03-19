using Microsoft.EntityFrameworkCore;
using PhotoService.DAL.Dtos;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace PhotoService.DAL
{
    public class Context:DbContext
    {
        public DbSet<AplicationsDto>Aplications { get; set; }
        public DbSet<ComplainsDto>Complains { get; set; }
        public DbSet<OrdersDto> Orders { get; set; }
        public DbSet<ReviewsDto> Reviews { get; set; }

        public DbSet<RolesDto> Roles { get; set; }
        public DbSet<ServicesDto> Services { get; set; }

        public DbSet<TypesDto> Types { get; set; }

        public DbSet<UsersDto> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(Options.ConnectionString);
        }
    }
}
