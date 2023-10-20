using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente;
        public string Nombre;
        public int IdTipoPersona;
        public TipoPersona TipoPersona;
        public DateTime FechaRegistro;
        public int IdMunicipio;
        public Municipio Municipio;

        public ICollection<Venta> Ventas;
        public ICollection<Orden> Ordenes;
    }
}