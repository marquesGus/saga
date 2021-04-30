using saga.Dal;
using saga.Domain.Interfaces;
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
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(_unit.Movie.GetAll());
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok(_unit.Movie.Get(id));
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}