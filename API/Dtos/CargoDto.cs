using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CargoDto
    {
        public int Id { get; set; }
        public string Descipcion { get; set; }
        public float SueldoBase { get; set; }
    }
}