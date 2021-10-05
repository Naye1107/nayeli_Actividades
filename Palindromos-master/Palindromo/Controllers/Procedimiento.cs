using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindromo.Controllers
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1, Ejercicio 2: Palíndromos
    Nombre del alumno: Nayeli De Jesus Osornio
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
    [Route("api/[controller]")]
    [ApiController]
    public class Procedimiento : ControllerBase
    {
        [HttpGet]
        public IActionResult Resultado(string guardar)
        {
            var P = new Palindromo();
            P.palindromo = guardar;
            var PalabraFinal = string.Empty;
            var Count = guardar;
            int i = Count.Length;
            var ResultadoF = "";

            for (int j = i - 1; j >= 0; j--)
            {
                PalabraFinal = PalabraFinal + Count[j];
            }
            if (PalabraFinal.ToLower().Replace(" ", string.Empty) == Count.ToLower().Replace(" ", string.Empty))
            {
                ResultadoF = (Count + " es palindrome");
            }
            else
            {
                ResultadoF = (Count + " no es palindrome");
            }
            int Palabras = Count.Length - Count.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("La palabra ingresada: " + ResultadoF.ToLower() + " , invertida es: " + PalabraFinal.ToLower() + ", y en total tiene: " + Palabras + " palabras");
            return Ok(ResultadoInvert.ToLower());
        }
    }
}
