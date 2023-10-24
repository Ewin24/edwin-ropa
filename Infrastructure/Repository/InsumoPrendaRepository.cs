using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class InsumoPrendaRepository : GenericRepository<InsumoPrenda>, IInsumoPrendaRepository
    {
        private readonly RopaContext _context;
        public InsumoPrendaRepository(RopaContext context) : base(context)
        {
            _context = context;
        }

        public static implicit operator InsumoPrendaRepository(EstadoRepository v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator InsumoPrendaRepository(InsumoRepository v)
        {
            throw new NotImplementedException();
        }
    }
}