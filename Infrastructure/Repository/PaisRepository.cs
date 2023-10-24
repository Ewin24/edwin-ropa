using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.Repositories
{
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        private readonly RopaContext _context;
        public PaisRepository(RopaContext context) : base(context)
        {
            _context = context;
        }

        public static implicit operator PaisRepository(EstadoRepository v)
        {
            throw new NotImplementedException();
        }
    }
}