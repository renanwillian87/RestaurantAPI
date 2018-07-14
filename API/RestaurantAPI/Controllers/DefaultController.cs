using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]/[Action]")]
    public class DefaultController : Controller
    {
        [HttpGet]
        public string RetornoSimples()
        {
            return "Retorno do get";
        }
        [HttpGet("{id}")]
        public string RetornoId(string id)
        {
            return $"Retorno do get{id}";
        }

        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"Retorno do get{id}";
        }
    }
}