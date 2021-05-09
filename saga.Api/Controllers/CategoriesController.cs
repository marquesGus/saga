using saga.Dal;
using saga.Domain.Interfaces;
using saga.Domain.Services.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace saga.Api.Controllers
{
    [RoutePrefix("Categories")]
    public class CategoriesController : ApiController
    {
        private readonly ISagaUnitOfWork _unit;
        public CategoriesController()
        {

            _unit = new SagaUnitOfWork(new SagaContext());
        } 
        
        public IHttpActionResult Get()
        {
            return Ok(_unit.Gender.GetAll());
        }

        [Route("Movies")]
        public IHttpActionResult GetMoviesByCategorie(int id)
        {
            GetMoviesByCategorieService srv = new GetMoviesByCategorieService(_unit);
            
            return Ok(srv.Run(id));
        }

    }
}