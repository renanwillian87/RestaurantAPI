using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace Model
{
    public class Contexto : DbContext
    {
        public static string conexao = "Data Source=Localhost;Initial Catalog=RestaurantAPI;Persist Security Info=True;User ID=RestaurantAPI;Password=123test!";
        
        public DbSet<Teste> Teste { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuRestaurant> MenuRestaurants { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<MenuItem> MenuItens { get; set; }

        public Contexto() : base(new DbContextOptionsBuilder<DbContext>()
            .UseSqlServer(new SqlConnection(conexao))
            .Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
                        .HasKey(x => new { x.ItemId, x.MenuId });
        }
    }
}
