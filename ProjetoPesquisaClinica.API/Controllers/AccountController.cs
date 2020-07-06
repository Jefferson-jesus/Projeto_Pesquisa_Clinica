using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoPesquisaClinica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // Apenas para test de carregamento.
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("Busca")]
        public IActionResult Index()
        {
            try
            {
                return new JsonResult(Summaries);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }
    }
}