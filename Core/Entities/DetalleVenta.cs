using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        public int IdVenta;
        public Venta Venta;
        public int IdProducto;
        public Inventario Inventario;
        public int IdTalla;
        public Talla Talla;

        public int Cantidad;
        public float ValorUnit;
    }
}