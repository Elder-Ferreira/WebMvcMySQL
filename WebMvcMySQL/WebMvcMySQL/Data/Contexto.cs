using Microsoft.EntityFrameworkCore;
using WebMvcMySQL.Models;

namespace WebMvcMySQL.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) 
            : base(options)
        {  }

        public DbSet<Usuario> Usuario { get; set; }
    }
}

