using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden : BaseEntity
    {
        public int IdOrden;
        public int IdPrenda;
        public int CantidadProducir;
        public int IdColor;
        public int CantidadProducida;
        public int IdEstado;

    }
}