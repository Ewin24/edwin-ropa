using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden : BaseEntity
    {
        public DateTime Fecha;
        public int IdEmpleado;
        public int IdCliente;
        public int IdEstado;
    }
}