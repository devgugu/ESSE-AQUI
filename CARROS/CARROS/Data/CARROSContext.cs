using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CARROS.Models
{
    public class CARROSContext : DbContext
    {
        public CARROSContext (DbContextOptions<CARROSContext> options)
            : base(options)
        {
        }

        public DbSet<CARROS.Models.Carro> Carro { get; set; }
    }
}
