using Microsoft.AspNetCore.Mvc;
using BLL;
using Entity;
using System.Data;
using DAL;
using System.Text.Json;

namespace API_FACPYA79.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class ProveedorController : Controller
    {
        private readonly string Cadena;

        public ProveedorController(IConfiguration Config)
        {
            Cadena = Config.GetConnectionString("PROD");
        }


        [HttpPost]
        [Route("GaurdarInfo")]

        public IActionResult GuardarInfo([FromBody] DtoProveedor Proveedor)
        {
            DataTable ResultadoValidacion = BL_Proveedor.ValidaProveedor(Cadena, Proveedor);
            
            DataRow primeraFila = ResultadoValidacion.Rows[0];

            int primerElemento = Convert.ToInt32(primeraFila[0]);

            if (primerElemento > 0) 
            {
                return Ok(new { codigo = "21", response = "El proveedor SI se encuentra registrado" });
            }
            else
            {
                List<string> lstDatos = BL_Proveedor.GuardarInfo(Cadena, Proveedor);

                if (lstDatos[0] == "00")
                {
                    return Ok(new { codigo = "22", response = "El proveedor ha sido registrado con exito" });
                }
                else
                {
                    return Ok(new { codigo = lstDatos[0], response = lstDatos[1] });
                }
            }



           


        }

        
     

    }
}
