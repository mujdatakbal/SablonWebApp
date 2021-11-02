using Microsoft.EntityFrameworkCore;
using SablonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SablonWebApp.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
