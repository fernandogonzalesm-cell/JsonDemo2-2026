using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace json.demo.Controllers
{
    [Route("api/[controller]")]  //como se ve en url
    [ApiController]  
    public class DemoController : ControllerBase
    {
        public DemoController()
        {
            
        }
        [HttpGet("generica")]
        public IActionResult ListaGenerica()
        {
            var personas = new List<persona>()
            {

                new persona{Id=1,Nombre="Juan",Edad=18},
                new persona{Id=2,Nombre="Maria",Edad=17}
            };
            return Ok(personas);
        }
        [HttpGet("diccionario")]
        public IActionResult Diccionarios()
        {
            var diccionario = new Dictionary<string, string>
            {
                {"clave1","valor1" },
                {"clave2","valor2" },
                {"clave3","valor3" },
                {"clave4","valor4" },
                {"clave5","valor5" },
            };
            return Ok(Diccionarios);
        }


        [HttpGet("dinamico")]
        public IActionResult objetoDinamico()
        {
            var dinamicos=new List<persona>
            
                    dynamic objDinamico = new ExpandoObject();
                      objDinamico.Id = 1;
                      objDinamico.Nombre = "Juan";
                      objDinamico.Edad = 18;
                      return Ok(objDinamico);
            
        }
    }
}
