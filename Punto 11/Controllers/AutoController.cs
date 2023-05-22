using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Punto_11.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoController : Controller
    {
        private static readonly Auto[] autos = new Auto[]
        {
            new Auto("Volkswagen", "Gol", 2010),
            new Auto("Peugeot", "208", 2016),
            new Auto("Renault", "Logan", 2014)
       
        };
    

        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return autos;
        }
    }
}
