using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ProductCRUD.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
