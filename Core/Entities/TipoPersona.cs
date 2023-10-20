using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoPersona : BaseEntity
    {
        public string Nombre;
        public ICollection<Proveedor> Proveedores;
        public ICollection<Cliente> Clientes;
    }
}