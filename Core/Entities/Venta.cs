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
        public Empleado Empleado;
        public int IdCliente;
        public Cliente Cliente;
        public int IdFormaPago;
        public FormaPago FormaPago;

        public ICollection<DetalleVenta> DetalleVentas;
    }
}