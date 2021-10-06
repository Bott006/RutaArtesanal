using System.Net.Security;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RutaArtesanal.Application;

namespace RutaArtesanal.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            var srv = new MessageService();
            var msg = srv.SayHello("Guadalupana");
            var msg2 = srv.SayHello("Helados");
            return Ok(msg2);
        }
    }
}