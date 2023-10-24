using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class TallaRepository : GenericRepository<Talla>, ITallaRepository
    {
        private readonly RopaContext _context;
        public TallaRepository(RopaContext context) : base(context)
        {
            _context = context;
        }

        public static implicit operator TallaRepository(EstadoRepository v)
        {
            throw new NotImplementedException();
        }
    }
}