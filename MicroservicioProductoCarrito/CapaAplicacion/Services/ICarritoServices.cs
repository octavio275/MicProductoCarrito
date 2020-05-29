using CapaDominio.Commands;
using CapaDominio.DTOs;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion.Services
{
   public interface ICarritoServices
    {
        Carrito CreateCarrito(CarritoDTOs carrito);
        Carrito UpdateCarrito(ProductoCarritoDTOs carrito);
        Carrito DeleteCarrito(CarritoDTOs carrito);


    }
    public class CarritoService : ICarritoServices
    {
        private readonly IGenericsRepository _repository;

        public CarritoService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Carrito CreateCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito()
            {
                ClienteID = carrito.ClienteID,
                ValorID = carrito.ValorID

            };
            _repository.Add<Carrito>(entity);

            return entity;
        }
        public Carrito UpdateCarrito(ProductoCarritoDTOs carrito)
        {
            var entity = new Carrito
            {
                CarritoID = carrito.CarritoID
                 
            };
            _repository.Update<Carrito>(entity);

            return entity;
        }

        public Carrito DeleteCarrito(CarritoDTOs carrito)
        {
            var entity = new Carrito
            {
                CarritoID = carrito.CarritoID,
                 ValorID = carrito.ValorID
            };
            _repository.Delete<Carrito>(entity);

            return entity;

        }

       
    }


}
