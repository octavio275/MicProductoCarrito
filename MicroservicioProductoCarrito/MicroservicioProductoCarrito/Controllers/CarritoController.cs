using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacion.Services;
using CapaDominio.DTOs;
using CapaDominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioProductoCarrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoServices _service;
        public CarritoController(ICarritoServices service)
        {
            _service = service;
        }

    
        [HttpPost]
        public IActionResult Post(CarritoDTOs carrito)
        {
            try
            {
                return new JsonResult( _service.CreateCarrito(carrito)) { StatusCode = 201 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(CarritoDTOs carrito)
        {
            try
            {
                return new JsonResult(_service.DeleteCarrito(carrito)) { StatusCode = 201 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public Carrito Update(ProductoCarritoDTOs carrito)
        {
            return _service.UpdateCarrito(carrito);
        }
        //[HttpGet]
        //public IEnumerable<Carrito> Get()
        //{
        //    return _service.GetAll();
        //}
    }
}