using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using JoePizzaPortal.Models;

#nullable disable

namespace JoePizzaPortal.Models
{
    public partial class JoePizzaPortalContext : DbContext
    {
        public JoePizzaPortalContext()
        {
        }

        public JoePizzaPortalContext(DbContextOptions<JoePizzaPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=H5CG1220SMG;Database=JoePizzaPortal;Integrated Security=true");
        }

    }
}
