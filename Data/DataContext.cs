using Move.Models;
using Microsoft.EntityFrameworkCore;

namespace Move.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades das classes de modelo que vão virar tabelas no banco
        public DbSet<Movie> Movie { get; set; }
    }
}