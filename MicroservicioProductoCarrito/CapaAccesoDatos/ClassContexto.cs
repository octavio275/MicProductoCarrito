using CapaDominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatos
{
    public class ClassContexto : DbContext
    {
        public ClassContexto(DbContextOptions<ClassContexto> options)
            : base(options) { }


        public DbSet<Carrito> carrito { get; set; }
        public DbSet<ProductoCarrito> CarritoProducto { get; set; }


    }
}
