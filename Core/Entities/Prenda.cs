using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prenda : BaseEntity
    {
        public int IdPrenda;
        public string Nombre;
        public float ValorUnitCop;
        public float ValorUnitUsd;
        public int IdEstado;
        public int IdTipoProteccion;
        public int IdGenero;
    }
}