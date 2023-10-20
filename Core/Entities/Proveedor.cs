using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proveedor : BaseEntity
    {
        public string Nombre;
        public string NitProveedor;
        public int IdTipoPersona;
        public int IdMunicipio;

    }
}