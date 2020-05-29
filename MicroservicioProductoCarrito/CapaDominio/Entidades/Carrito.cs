using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominio.Entidades
{
   public class Carrito
    {
        private int carritoID;
        private int valorID;
        private int clienteID;

        public int CarritoID { get => carritoID; set => carritoID = value; }
        public int ValorID { get => valorID; set => valorID = value; }
        public int ClienteID { get => clienteID; set => clienteID = value; }
    }
}
