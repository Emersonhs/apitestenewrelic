using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("api")]
    public class BancoSemear : ControllerBase
    {
        [HttpGet]
        [Route("healthcheck")]
        public string Healthcheck()
        {
            return "API de Teste Funcionando!";
        }      
    }
}