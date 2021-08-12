using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Avaliacao.API.Data.Context;
using Avaliacao.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Avaliacao.API.Domain.Interfaces;




namespace Avaliacao.API.Data.Repositories
{
    public class AccommodationRepository : IAccommodationRepository
    {
        public AppDbContext _context;

        public AccommodationRepository(AppDbContext context)
        {
            _context = context;
        }

        public Guid Cadastrar(Accommodation accommodation)
        {
            _context.Add(accommodation);
            _context.SaveChanges();
            return accommodation.Id;
        }
        public void Editar(Accommodation accommodation)
        {
            _context.Update(accommodation);
            _context.SaveChanges();
        }

        public IEnumerable<Accommodation> Listar()
        {
            return _context.Accommodation.AsNoTracking().ToList();
        }

        public void Excluir(Accommodation accommodation)
        {
            _context.Update(accommodation);
            _context.SaveChanges();
        }
    }
}
