using Microsoft.AspNetCore.Mvc;
using BLL;
using Entity;

namespace API_FACPYA79.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly string Cadena;

        public ClienteController(IConfiguration Config)
        {
            Cadena = Config.GetConnectionString("PROD");
        }


        [HttpPost]
        [Route("GaurdarInfo")]

        public IActionResult GuardarInfo([FromBody] DtoCliente Cliente)
        {
            List<string> lstValidaciones = BL_Cliente.ValidaInfo(Cliente);

            if(lstValidaciones.Count == 0) 
            {

                List<string> lstDatos = BL_Cliente.GuardarInfo(Cadena, Cliente);

                if (lstDatos[0] == "00")
                {
                    return Ok(new { codigo = "00", response = "OK" });
                }
                else
                {
                    return Ok(new { codigo = lstDatos[0], response = lstDatos[1] });
                }

            }
            else
            {
                return Ok(new { codigo = "14", response = lstValidaciones});

            }

        }


        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            List<DtoCatCliente> lstCliente = BL_Cliente.ConsulCliente(Cadena);
            return Ok(new {codigo = "00", response = lstCliente});
        }
       
    }
}
