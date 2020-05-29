using CapaDominio.Commands;
using CapaDominio.DTOs;
using CapaDominio.Entidades;
using CapaDominio.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion.Services
{
   public interface IProductoCarritoServices
    {
        ProductoCarrito Create(ProductoCarritoDTOs carritoproducto);
        //Carrito_Producto IngresarProducto(ClienteProducto IngresarClienteProducto);

    }
    public class ProductoCarritoServices : IProductoCarritoServices
    {
        private readonly IGenericsRepository _repository;
        private readonly IProductoCarritoQuery _query;
        public ProductoCarritoServices(IGenericsRepository repository, IProductoCarritoQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public ProductoCarrito Create(ProductoCarritoDTOs carritoproducto)
        {
            var entity = new ProductoCarrito()
            {
                ProductoID = carritoproducto.ProductoID,
                CarritoID = carritoproducto.CarritoID
            };
            _repository.Add<ProductoCarrito>(entity);
            return entity;
        }

    }
}
