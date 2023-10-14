using Class04.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Class04.Data
{
    public class DbInitializer
    { 
        private Aula04_EWPL1_Context _context;
        
        public DbInitializer(Aula04_EWPL1_Context context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.EnsureCreated();

            if (_context.Category.Any())
            {
                return;
            }

            var categorias = new Category[]
            {
                new Category{ Name="Programming", Description="bla bla bla"},
                new Category{ Name="Administration", Description="bla bla bla"},
                new Category{ Name="Communication", Description="bla bla bla"}
            };

            _context.Category.AddRange(categorias);

            _context.SaveChanges();
        }
    }
}
