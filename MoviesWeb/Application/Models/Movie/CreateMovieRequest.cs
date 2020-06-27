using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Models.Movie
{
    public class CreateMovieRequest
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
