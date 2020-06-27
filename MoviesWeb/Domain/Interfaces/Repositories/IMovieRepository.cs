using MoviesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Interfaces.Repositories
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
    }
}
