using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class04.Models;

namespace Class04.Data
{
    public class Class04Context : DbContext
    {
        public Class04Context(DbContextOptions<Class04Context> options)
            : base(options)
        {
        }

        public DbSet<Class04.Models.Category> Category { get; set; } = default!;
    }
}
