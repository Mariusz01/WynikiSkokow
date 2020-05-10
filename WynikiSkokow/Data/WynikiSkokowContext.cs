using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WynikiSkokow.Models;

namespace WynikiSkokow.Data
{
    public class WynikiSkokowContext : DbContext
    {
        public WynikiSkokowContext (DbContextOptions<WynikiSkokowContext> options)
            : base(options)
        {
        }

        public DbSet<WynikiSkokow.Models.Skoczek> Skoczek { get; set; }
    }
}
