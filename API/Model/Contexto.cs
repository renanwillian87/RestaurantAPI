using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace Model
{
    public class Contexto : DbContext
    {
        public static string conexao = "Data Source=Localhost;Initial Catalog=RestaurantAPI;Persist Security Info=True;User ID=RestaurantAPI;Password=123test!";
        
        public DbSet<Teste> Teste { get; set; }

        public Contexto() : base(new DbContextOptionsBuilder<DbContext>()
            .UseSqlServer(new SqlConnection(conexao))
            .Options)
        {

        }
    }
}
