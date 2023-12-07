using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assign_5_2._0.Models;

namespace Assign_5_2._0.Data
{
    public class Assign_5_2_0Context : DbContext
    {
        public Assign_5_2_0Context (DbContextOptions<Assign_5_2_0Context> options)
            : base(options)
        {
        }

        public DbSet<Assign_5_2._0.Models.Music> Music { get; set; } = default!;
    }
}
