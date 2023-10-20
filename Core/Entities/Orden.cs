using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden : BaseEntity
    {
        public int IdOrden;
        public DateTime Fecha;
        public int IdEmpleado;
        public Empleado Empleado;
        public int IdCliente;
        public Cliente Cliente;
        public int IdEstado;
        public Estado Estado;

        public ICollection<DetalleOrden> DetalleOrdenes;
    }
}