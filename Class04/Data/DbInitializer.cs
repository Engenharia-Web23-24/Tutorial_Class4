using Class04.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Class04.Data
{
    public class DbInitializer
    { 
        private Class04Context _context;
        
        public DbInitializer(Class04Context context)
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
                new Category{ Name="Programming", Description="ALgorithms and programming area courses", Date=new DateTime(2023, 10, 12)},
                new Category{ Name="Administration", Description="Public administration and business management courses", Date=new DateTime(2021, 2, 1)},
                new Category{ Name="Communication", Description="Business and institutional communication courses"} // this one uses default date
            };

            _context.Category.AddRange(categorias);
            //foreach(var c in categorias)
            //{
            //    _context.Category.Add(c);
            //    //_context.Add(c); // has the same result
            //}

            _context.SaveChanges();
        }
    }
}
