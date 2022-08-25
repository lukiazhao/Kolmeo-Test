using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KolmeoTest;

namespace KolmeoTest.Data
{
    public class KolmeoTestContext : DbContext
    {
        public KolmeoTestContext (DbContextOptions<KolmeoTestContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
