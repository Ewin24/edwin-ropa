using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Talla : BaseEntity
    {
        public string Descripcion;

        public ICollection<DetalleVenta> DetalleVentas;
        public ICollection<InventarioTalla> InventarioTallas;

    }
}