using Microsoft.EntityFrameworkCore;
using Domain.Entidades;
using Infrastructure.EntityConfiguration;

namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gerenciamento_Lead> Gerenciamento_Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new Gerenciamento_LeadConfiguration());
        }
    }
}