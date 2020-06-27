using MoviesWeb.Application.Models.Movie;
using MoviesWeb.Application.Services.Interfaces;
using MoviesWeb.Domain.Entities;
using MoviesWeb.Domain.Interfaces.Services;
using MoviesWeb.Infrastructure.Data.UnitOfWork;
using MoviesWeb.Infrastructure.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Services
{
    public class MovieAppService : IMovieAppService
    {
        private readonly IMovieService _service;
        private readonly IUnitOfWork _uow;

        public MovieAppService(IMovieService service, IUnitOfWork uow)
        {
            _service = service;
            _uow = uow;
        }

        public async Task<CreateMovieResponse> Add(CreateMovieRequest request)
        {
            var movie = request.ProjectedAs<Movie>();
            var response = _service.Add(movie);

            if (response.IsSuccess)
                _uow.Commit();

            await Task.Delay(1);

            return movie.ProjectedAs<CreateMovieResponse>();
        }
    }
}
