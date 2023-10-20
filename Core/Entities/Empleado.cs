using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado : BaseEntity
    {
        public int IdEmp;
        public string Nombre;
        public int IdCargo;
        public Cargo Cargo;
        public DateTime FechaIngreso;
        public int IdMunicipio;
        public Municipio Municipio;

        public ICollection<Venta> Ventas;
        public ICollection<Orden> Ordenes;

    }
}