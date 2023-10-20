using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        public int IdVenta;
        public int IdProducto;
        public int IdTalla;
        public int Cantidad;
        public float ValorUnit;
    }
}