using saga.Dal;
using saga.Domain.Interfaces;
using saga.Domain.Services.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace saga.Api.Controllers
{
    [RoutePrefix("Movie")]
    public class MovieController : ApiController
    {
        private readonly ISagaUnitOfWork _unit;
        public MovieController()
        {
            
            _unit = new SagaUnitOfWork(new SagaContext());
        }
        public IHttpActionResult Get()
        {
            return Ok(_unit.Movie.GetAll());
        }

        public IHttpActionResult Get(int id)
        {
            MapMovieService srv = new MapMovieService(_unit);

            return Ok(srv.Run(id));
        }
    }
}