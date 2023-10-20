using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden : BaseEntity
    {
        public int IdOrden;
        public Orden Orden;
        public int IdPrenda;
        public Prenda Prenda;
        public int CantidadProducir;
        public int IdColor;
        public Color Color;
        public int CantidadProducida;
        public int IdEstado;
        public Estado Estado;

    }
}