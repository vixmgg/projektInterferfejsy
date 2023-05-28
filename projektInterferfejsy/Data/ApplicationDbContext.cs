using Microsoft.EntityFrameworkCore;
using projektInterferfejsy.Models;
using System.Diagnostics;
using System.Net;

namespace projektInterferfejsy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Przepis> Przepisy { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Dieta> Diety { get; set; }

        public DbSet<User> Users { get; set; }


    }
}
