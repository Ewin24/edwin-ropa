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
        public float ValorVtaUsd;
        public float ValorVtaCop;

    }
}