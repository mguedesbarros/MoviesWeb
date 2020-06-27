using AutoMapper;
using MoviesWeb.Application.Models.Movie;
using MoviesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile() => MapCreateMovie();

        private void MapCreateMovie()
        {
            CreateMap<MovieModel, Movie>();

            CreateMap<CreateMovieRequest, Movie>()
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.Name))
                .ForMember(d => d.Image, opt => opt.MapFrom(o => o.Image));

            CreateMap<ResultEntity<Movie>, CreateMovieResponse>()
                .ForMember(d => d.Success, opt => opt.MapFrom(o => o.IsSuccess))
                .ForMember(d => d.Erros, opt => opt.MapFrom(o => o.Erros));

        }
    }
}
