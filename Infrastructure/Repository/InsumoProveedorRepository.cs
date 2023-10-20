using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class InsumoProveedorRepository : GenericRepository<InsumoProveedor>, IInsumoProveedorRepository
    {
        private readonly RopaContext _context;
        public InsumoProveedorRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}