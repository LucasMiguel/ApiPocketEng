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
                case "Area": result = Area(unity1, unity2, value); break;
                case "Angulo": result = Angulo(unity1, unity2, value); break;
                case "Comprimento": break;
                case "Energia": break;
                case "Pressao": break;
                case "Potencia": break;
                case "Temperatura": break;
                case "Tempo": break;
                case "Velocidade": break;
                case "Volume": break;
                default: return "Inválido";
            }            

            return result;
        }

        private string Area(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);
            int constant = 1000000;
            if(unity1 == "m" && unity2 == "mm"){
                return (valueDouble * constant).ToString("");
            }else if(unity1 == "mm" && unity2 == "m"){
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
