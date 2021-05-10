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
            String result = "";

            switch(type){
                case "area": result = Area(unity1, unity2, value); break;
                case "angulo": result = Angulo(unity1, unity2, value); break;
                case "comprimento": break;
                case "energia": break;
                case "pressao": break;
                case "potencia": break;
                case "temperatura": break;
                case "tempo": break;
                case "velocidade": break;
                case "volume": break;
                default: return "Inválido!!!";
            }            

            return result;
        }

        private string Area(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);
            int constant = 1000000;
            if(unity1 == "m2" && unity2 == "mm2"){
                return (valueDouble * constant).ToString("");
            }else if(unity1 == "mm2" && unity2 == "m2"){
                return (valueDouble / constant).ToString("");
            }else if(unity1 == unity2){
                return value;        
            }else{
                return "Conversão inválida!!";
            }
        }

        private string Angulo(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "graus" && unity2 == "rad"){
                return (valueDouble*(Math.PI/180)).ToString("");
            }else if(unity1 == "rad" && unity2 == "graus"){
                return (valueDouble*(180/Math.PI)).ToString("");
            }else if( unity1 == unity2){
                return value; 
            }else{
                return "Conversão inválida!!";
            }
        }

    }   
    
}
