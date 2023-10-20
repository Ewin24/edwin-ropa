using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        public int CodInv;
        public int IdPrenda;
        public Prenda Prenda;
        public float ValorVtaUsd;
        public float ValorVtaCop;

        public ICollection<InventarioTalla> InventarioTallas;
        public ICollection<DetalleVenta> DetalleVentas;

    }
}