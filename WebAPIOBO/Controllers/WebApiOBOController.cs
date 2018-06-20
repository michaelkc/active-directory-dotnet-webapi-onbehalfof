using System.Web.Http;

namespace WebAPIOBO.Controllers
{
    public class WebApiOBOController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("WebAPI via OBO");
        }
    }
}