using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empresa : BaseEntity
    {
        public string Nit;
        public string RazonSocial;
        public string RepresentanteLegal;
        public string FechaCreacion;
        public int IdMun;
        public Municipio Municipio;

    }
}