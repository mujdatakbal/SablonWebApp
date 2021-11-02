using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SablonWebApp.Entity
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int GenreId { get; set; }
    }
}
