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
        public string Healthcheck(string requisicao, string resposta)
        {
            try
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("requisicao", requisicao);
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("resposta", resposta);
                return "API de Teste Funcionando!";
            }
            catch (Exception)
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("resposta", "fail");
                throw;
            }
           
        }
        [HttpGet]
        [Route("healthcheck2")]
        public string Healthcheck2(string requisicao, string resposta)
        {
            try
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("requisicao", requisicao);
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("resposta", resposta);
                return "API de Teste Funcionando!";
            }
            catch (Exception)
            {
                NewRelic.Api.Agent.NewRelic.GetAgent().CurrentTransaction.AddCustomAttribute("resposta", "fail");
                throw;
            }
           
        }            
    }
}