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
            switch(type){
                case "area": return Area(unity1, unity2, value); break;
                case "angulo": return Angulo(unity1, unity2, value); break;
                case "comprimento": return Comprimento(unity1, unity2, value); break;
                case "energia": return Energia(unity1, unity2, value); break;
                case "pressao": return Pressao(unity1, unity2, value); break;
                case "potencia": return Potencia(unity1, unity2, value); break;
                case "temperatura": return Temperatura(unity1, unity2, value); break;
                case "tempo": return Tempo(unity1, unity2, value); break;
                case "velocidade": return Velocidade(unity1, unity2, value); break;
                case "volume": return Volume(unity1, unity2, value); break;
                default: return "Inválido!!!";
            }                        
        }
        /// <summary>
        /// Função de Conversão de Ângulo
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Area(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);
            int constant = 1000000;
            if(unity1 == "m2" && unity2 == "mm2"){
                return (valueDouble * constant).ToString("N4");
            }else if(unity1 == "mm2" && unity2 == "m2"){
                return (valueDouble / constant).ToString("N4");
            }else if(unity1 == unity2){
                return value;        
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Ângulo
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Angulo(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "graus" && unity2 == "rad"){
                return (valueDouble*(Math.PI/180)).ToString("N4");
            }else if(unity1 == "rad" && unity2 == "graus"){
                return (valueDouble*(180/Math.PI)).ToString("N4");
            }else if( unity1 == unity2){
                return value; 
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Comprimento
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Comprimento(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "m" && unity2 == "cm"){
                return (valueDouble * 100).ToString("N4");
            }else if(unity1 == "cm" && unity2 == "m"){
                return (valueDouble/100).ToString("N4");
            }else if(unity1 == "m" && unity2 == "mm"){
                return (valueDouble*1000).ToString("N4");
            }else if(unity1 == "mm" && unity2 == "m"){
                return (valueDouble/1000).ToString("N4");
            }else if(unity1 == "m" && unity2 == "in"){
                return (valueDouble * 39.37).ToString("N4");
            }else if(unity1 == "in" && unity2 == "m"){
                return (valueDouble / 39.37).ToString("N4");
            }else if(unity1 == "cm" && unity2 == "mm"){
                return (valueDouble * 10).ToString("N4");
            }else if(unity1 == "mm" && unity2 == "cm"){
                return (valueDouble / 10).ToString("N4");
            }else if(unity1 == "cm" && unity2 == "in"){
                return (valueDouble / 2.54).ToString("N4");
            }else if(unity1 == "in" && unity2 == "cm"){
                return (valueDouble *2.54).ToString("N4");
            }else if(unity1 == "mm" && unity2 == "in"){
                return (valueDouble /25.4).ToString("N4");
            }else if(unity1 == "in" && unity2 == "mm"){
                return (valueDouble * 25.4).ToString("N4");
            }else if( unity1 == unity2){
                return value; 
            }else{
                return "Conversão inválida!!";
            }
        }
        
        /// <summary>
        /// Função de Conversão de Energia
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Energia(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "wh" && unity2 == "j"){
                return (valueDouble * 3600).ToString("N4");
            }else if(unity1 == "j" && unity2 == "wh"){
                return (valueDouble / 3600).ToString("N4");
            }else if(unity1 == "wh" && unity2 == "btu"){
                return (valueDouble * 3.412).ToString("N4");
            }else if(unity1 == "btu" && unity2 == "w/h"){
                return (valueDouble / 3.412).ToString("N4");
            }else if(unity1 == "btu" && unity2 == "j"){
                return (valueDouble* 1055).ToString("N4");
            }else if(unity1 == "j" && unity2 == "btu"){
                return (valueDouble / 1055).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Pressão
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Pressao(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "atm" && unity2 == "bar"){
                return (valueDouble*1.013).ToString("N4");
            }else if(unity1 == "bar" && unity2 == "atm"){
                return (valueDouble/1.013).ToString("N4");
            }else if(unity1 == "atm" && unity2 == "pa"){
                return (valueDouble*101325).ToString("N4");
            }else if(unity1 == "pa" && unity2 == "atm"){
                return (valueDouble/101325).ToString("N4");
            }else if(unity1 == "atm" && unity2 == "psi"){
                return (valueDouble*14.696).ToString("N4");
            }else if(unity1 == "psi" && unity2 == "atm"){
                return (valueDouble/14.696).ToString("N4");
            }else if(unity1 == "bar" && unity2 == "pa"){
                return (valueDouble*10000).ToString("N4");
            }else if(unity1 == "pa" && unity2 == "bar"){
                return (valueDouble/100000).ToString("N4");
            }else if(unity1 == "bar" && unity2 == "psi"){
                return (valueDouble*14.504).ToString("N4");
            }else if(unity1 == "psi" && unity2 == "bar"){
                return (valueDouble/14.504).ToString("N4");
            }else if(unity1 == "pa" && unity2 == "psi"){
                return (valueDouble/6895).ToString("N4");
            }else if(unity1 == "psi" && unity2 == "pa"){
                return (valueDouble*6895).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Potência
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
       
        private string Potencia(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "w" && unity2 == "hp"){
                return (valueDouble / 746).ToString("N4");
            }else if(unity1 == "hp" && unity2 == "w"){
                return (valueDouble * 746).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }
        
        /// <summary>
        /// Função de Conversão de Temperatura
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
        private string Temperatura(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "c" && unity2 == "f"){
                return ((valueDouble*1.8)+32).ToString("N4");
            }else if(unity1 == "f" && unity2 == "c"){
                return ((valueDouble-32)*5/9).ToString("N4");
            }else if(unity1 == "c" && unity2 == "k"){
                return (valueDouble + 273.15).ToString("N4");
            }else if(unity1 == "k" && unity2 == "c"){
                return (valueDouble - 273.15).ToString("N4");
            }else if(unity1 == "f" && unity2 == "k"){
                return ((valueDouble - 32)*5/9+273.15).ToString("N4");
            }else if(unity1 == "k" && unity2 == "f"){
                return ((valueDouble - 273.15) * 9/5 + 32).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Tempo
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>
       private string Tempo(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "s" && unity2 == "min"){
                return (valueDouble / 60).ToString("N4");
            }else if(unity1 == "min" && unity2 == "s"){
                return (valueDouble * 60).ToString("N4");
            }else if(unity1 == "s" && unity2 == "h"){
                return (valueDouble / 3600).ToString("N4");
            }else if(unity1 == "h" && unity2 == "s"){
                return (valueDouble * 3600).ToString("N4");
            }else if(unity1 == "min" && unity2 == "h"){
                return (valueDouble / 60).ToString("N4");
            }else if(unity1 == "h" && unity2 == "min"){
                return (valueDouble * 60).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }
       
        /// <summary>
        /// Função de Conversão de Velocidade
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>       
        private string Velocidade(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "kmh" && unity2 == "ms"){
                return (valueDouble / 3.6).ToString("N4");
            }else if(unity1 == "ms" && unity2 == "kmh"){
                return (valueDouble * 3.6).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }

        /// <summary>
        /// Função de Conversão de Volume
        /// </summary>
        /// <param name="unity1">Unidade origem.</param>
        /// <param name="unity2">Unidade para conversão.</param>
        /// <param name="value">Valor a ser convertido.</param>
        /// <returns>Retorna o valor convertido em String para ser enviado a API</returns>       
        private string Volume(string unity1, string unity2, string value){
            double valueDouble = Convert.ToDouble(value);            
            if(unity1 == "l" && unity2 == "m3"){
                return (valueDouble / 1000).ToString("N4");
            }else if(unity1 == "m3" && unity2 == "l"){
                return (valueDouble * 1000).ToString("N4");
            }else if(unity1 == "l" && unity2 == "in3"){
                return (valueDouble * 61.024).ToString("N4");
            }else if(unity1 == "in3" && unity2 == "l"){
                return (valueDouble / 61.024).ToString("N4");
            }else if(unity1 == "m3" && unity2 == "in3"){
                return (valueDouble * 61024).ToString("N4");
            }else if(unity1 == "in3" && unity2 == "m3"){
                return (valueDouble / 61024).ToString("N4");
            }else if(unity1 == unity2){
                return value;
            }else{
                return "Conversão inválida!!";
            }
        }


    }   
    
}
