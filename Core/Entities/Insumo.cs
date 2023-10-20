using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Insumo : BaseEntity
    {
        public string Nombre;
        public float ValorUnit;
        public int StockMin;
        public int StockMax;

        public ICollection<InsumoProveedor> InsumoProveedores;
        public ICollection<InsumoPrenda> InsumoPrendas;

    }
}