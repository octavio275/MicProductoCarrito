using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacion.Services;
using CapaDominio.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioProductoCarrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoCarritoController : ControllerBase
    {
        private readonly IProductoCarritoServices _service;
        public ProductoCarritoController(IProductoCarritoServices service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(ProductoCarritoDTOs carritoproducto)
        {
            try
            {
                return new JsonResult(_service.Create(carritoproducto)) { StatusCode = 200 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}