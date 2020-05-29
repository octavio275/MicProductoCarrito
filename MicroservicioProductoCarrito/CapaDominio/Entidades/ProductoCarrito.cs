using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominio.Entidades
{
   public class ProductoCarrito
    {
        private int productoCarritoID;
        private int carritoID;
        private int productoID;

        public int ProductoCarritoID { get => ProductoCarritoID; set => ProductoCarritoID = value; }
        public int CarritoID { get => carritoID; set => carritoID = value; }
        public int ProductoID { get => productoID; set => productoID = value; }
        public virtual Carrito CarritoNavigator { get; set; }
    }
}
