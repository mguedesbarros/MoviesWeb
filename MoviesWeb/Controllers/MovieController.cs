using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesWeb.Application.Models;
using MoviesWeb.Application.Models.Movie;
using MoviesWeb.Application.Services.Interfaces;
using MoviesWeb.Domain.Interfaces.Services;

namespace MoviesWeb.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieAppService _service;

        public MovieController(IMovieAppService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        [Route("GetMovies")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetMovies()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorResponse());

            //var result = await _service.GetAll();
            //if (!result.Any())
            //    return NotFound();

            return Ok();
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> Create([FromBody] CreateMovieRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrorResponse());

                var response = await _service.Add(request);

                if (!response.Success)
                    return BadRequest(response.Erros);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
