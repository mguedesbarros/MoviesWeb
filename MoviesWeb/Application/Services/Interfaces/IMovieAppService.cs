using MoviesWeb.Application.Models.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Services.Interfaces
{
    public interface IMovieAppService
    {
        Task<CreateMovieResponse> Add(CreateMovieRequest request);        
    }
}
