using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda : BaseEntity
    {
        public int cantidad;
        public int IdInsumo;
        public Insumo Insumo;
        public int IdPrenda;
        public Prenda Prenda;
    }
}