using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class04.Models;

namespace Class04.Data
{
    public class Aula04_EWPL1_Context : DbContext
    {
        public Aula04_EWPL1_Context (DbContextOptions<Aula04_EWPL1_Context> options)
            : base(options)
        {
        }

        public DbSet<Class04.Models.Category> Category { get; set; } = default!;
    }
}
