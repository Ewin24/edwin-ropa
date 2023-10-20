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
        public Estado Estado;
        public int IdTipoProteccion;
        public TipoProteccion TipoProteccion;
        public int IdGenero;
        public Genero Genero;
        public ICollection<InsumoPrenda> InsumoPrendas;
        public ICollection<Inventario> Inventarios;
        public ICollection<DetalleOrden> DetalleOrdenes;

    }
}