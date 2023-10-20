using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado : BaseEntity
    {
        public string Descripcion;
        public int IdTipoEstado;
        public TipoEstado TipoEstado;

        public ICollection<Prenda> Prendas;
        public ICollection<DetalleOrden> DetalleOrdenes;
        public ICollection<Orden> Ordenes;
    }
}