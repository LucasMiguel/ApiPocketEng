using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiPocketEng.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionsController : ControllerBase
    {
        
        [HttpGet("{type}/{unity1}/{unity2}/{value}")]
        public String Valor(string type, string unity1, string unity2, string value)
        {

            return $"Tipo {type} - Unidade 1 {unity1} - Unidade 2 {unity2} - Valor{value}";
        }

    }   
    
}
