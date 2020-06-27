using MoviesWeb.Domain.Entities;
using MoviesWeb.Domain.Interfaces.Repositories;
using MoviesWeb.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Domain.Services
{
    public class MovieService : BaseService<Movie>, IMovieService
    {
        public MovieService(IMovieRepository repository) : base(repository)
        {
        }
    }
}
