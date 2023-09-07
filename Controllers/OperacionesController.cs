using Microsoft.AspNetCore.Mvc;

namespace API_FACPYA79.Controllers
{
    [Route("api/[controller]")]
    public class OperacionesController : ControllerBase
    {

        [HttpGet]
        [Route("Suma")]

        public IActionResult Suma()
        {
            return Ok(new { Codigo = "00", response = $"La suma es: {2 + 2}" });
        }

        [HttpGet]
        [Route("SumaValores/{Num1:int}/{Num2:int}")]

        public IActionResult SumaValores(int Num1, int Num2)
        {
            return Ok(new { Codigo = "00", response = $"La suma es: {Num1 + Num2}" });
        }


        [HttpGet]
        [Route("RestaValores/{Num1:int}/{Num2:int}")]

        public IActionResult RestaValores(int Num1, int Num2)
        {
            return Ok(new { Codigo = "00", response = $"La resta es: {Num1 - Num2}" });
        }


        [HttpGet]
        [Route("MultiplicaValores/{Num1:int}/{Num2:int}")]

        public IActionResult MultiplicaValores(int Num1, int Num2)
        {
            return Ok(new { Codigo = "00", response = $"La multiplicacion es: {Num1 * Num2}" });
        }

        [HttpGet]
        [Route("PromedioCalificaciones/{Num1:int}/{Num2:int}/{Num3:int}")]

        public IActionResult PromedioCalificaciones(float Num1, float Num2, float Num3)
        {
            float promedio;
            promedio = (Num1 + Num2 + Num3) / 3;
            return Ok(new { Codigo = "00", response = $"El promedio de las 3 calificaciones es: {promedio}" });
        }

        [HttpGet]
        [Route("NumeroCuadrado/{Num1:double}")]

        public IActionResult NumeroCuadrado(double Num1)
        {
            double resultado;
            resultado = Math.Pow(Num1, 2);
            return Ok(new { Codigo = "00", response = $"El cuadrado del numero es: {resultado}" });
        }

        [HttpGet]
        [Route("AreaCuadrado/{LadoCuadrado:double}")]

        public IActionResult AreaCuadrado(double LadoCuadrado)
        {
            double AreaCuadrado;
            AreaCuadrado = Math.Pow(LadoCuadrado, 2);
            return Ok(new { Codigo = "00", response = $"El Area del cuadrado es: {AreaCuadrado}" });
        }

        [HttpGet]
        [Route("PerimetroCuadrado/{LadoCuadrado:double}")]

        public IActionResult PerimetroCuadrado(double LadoCuadrado)
        {
            double PerimetroCuadrado;
            PerimetroCuadrado = LadoCuadrado * 4;
            return Ok(new { Codigo = "00", response = $"El Perimetro del cuadrado es: {PerimetroCuadrado}" });
        }

        [HttpGet]
        [Route("AreaCirculo/{radio:double}")]

        public IActionResult AreaCirculo(double radio)
        {
            double AreaCirculo;
            AreaCirculo = (System.Math.PI * Math.Pow(radio, 2));
            return Ok(new { Codigo = "00", response = $"El area del circulo es: {AreaCirculo}" });
        }

        [HttpGet]
        [Route("PerimetroCirculo/{diametro:double}")]

        public IActionResult PerimetroCirculo(double diametro)
        {
            double PerimetroCirculo;
            PerimetroCirculo = (System.Math.PI * diametro);
            return Ok(new { Codigo = "00", response = $"El perimetro del circulo es: {PerimetroCirculo}" });
        }

        [HttpGet]
        [Route("AreaTriangulo/{Base:double}/{Altura:double}")]

        public IActionResult AreaTriangulo(double Base, double Altura)
        {
            double AreaTriangulo;
            AreaTriangulo = (Base * Altura) / 2;
            return Ok(new { Codigo = "00", response = $"El area del triangulo es: {AreaTriangulo}" });
        }


    }

}
