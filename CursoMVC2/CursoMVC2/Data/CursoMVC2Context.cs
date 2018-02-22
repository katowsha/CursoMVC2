using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC2.Models
{
    public class CursoMVC2Context : DbContext
    {
        public CursoMVC2Context (DbContextOptions<CursoMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<CursoMVC2.Models.Categoria> Categoria { get; set; }
    }
}
