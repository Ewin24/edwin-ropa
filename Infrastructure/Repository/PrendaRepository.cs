using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class PrendaVentaRepository : GenericRepository<Prenda>, IPrendaRepository
    {
        private readonly RopaContext _context;
        public PrendaVentaRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}