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
    public class ApiTeste : ControllerBase
    {
        [HttpGet]
        [Route("healthcheck")]
        public string Healthcheck(int num)
        {
            try
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("request", num);
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("response", "OK");
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("response", "123");
                return "API de Teste Funcionando!";
            }
            catch (Exception)
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("response", "fail");
                throw;
            }
           
        }      
    }
}