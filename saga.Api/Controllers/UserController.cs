using saga.Dal;
using saga.Domain.Interfaces;
using saga.Domain.Services.Wishlists;
using System.Web.Http;

namespace saga.Api.Controllers
{
    [RoutePrefix("User")]
    public class UserController : ApiController
    {
        private readonly ISagaUnitOfWork _unit;
        public UserController()
        {

            _unit = new SagaUnitOfWork(new SagaContext());
        }

        [HttpGet]
        [Route("Wishlist")]
        public IHttpActionResult GetWishlist(int id) 
        {
            GetWishlistByUserService srv = new GetWishlistByUserService(_unit);
            return Ok(srv.Run(id));
        }

        [HttpPost]
        public IHttpActionResult PostWishlist(int id)
        {
            return Ok();
        }




    }
}