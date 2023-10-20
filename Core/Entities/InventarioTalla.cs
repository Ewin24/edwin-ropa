using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InventarioTalla : BaseEntity
    {
        public int cantidad;

        public int IdInv;
        public Inventario Inventario;
        public int IdTalla;
        public Talla Talla;
    }
}