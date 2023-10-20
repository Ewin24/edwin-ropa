using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Venta : BaseEntity
    {
        public DateTime Fecha;
        public int IdEmpelado;
        public int IdCliente;
        public int IdFormaPago;
    }
}