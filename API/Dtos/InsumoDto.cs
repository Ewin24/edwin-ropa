using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InsumoDto
    {
        public string Nombre;
        public float ValorUnit;
        public int StockMin;
        public int StockMax;
    }
}