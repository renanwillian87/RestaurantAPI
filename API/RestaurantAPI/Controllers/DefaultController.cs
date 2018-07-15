using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Model;
using System;

namespace RestaurantAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Default")]
    public class DefaultController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"Retorno do get" };
        }
        
        [HttpGet("{id}")]
        public string Get(string id)
        {
            Menu menu = new Menu();
            menu.Apelido = "Pizzas";
            menu.DataInicio = DateTime.Now;
            menu.DataFim = DateTime.Now;
            menu.Status = true;

            return $"Retorno do get{id}";
        }
    }
}