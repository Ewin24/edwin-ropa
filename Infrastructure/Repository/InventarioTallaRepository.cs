using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class InventarioTallaRepository : GenericRepository<InventarioTalla>, IInventarioTallaRepository
    {
        private readonly RopaContext _context;
        public InventarioTallaRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}