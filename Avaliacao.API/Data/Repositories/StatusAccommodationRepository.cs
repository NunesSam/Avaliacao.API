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
    public class StatusAccommodationRepository : IStatusAccommodationRepository
    {
        public AppDbContext _context;

        public StatusAccommodationRepository(AppDbContext context)
        {
            _context = context;
        }

        public Guid Cadastrar(StatusAccommodation statusAccommodation)
        {
            _context.Add(statusAccommodation);
            _context.SaveChanges();
            return statusAccommodation.Id;
        }
        public void Editar(StatusAccommodation statusAccommodation)
        {
            _context.Update(statusAccommodation);
            _context.SaveChanges();
        }

        public IEnumerable<StatusAccommodation> Listar()
        {
            return _context.StatusAccommodation.AsNoTracking().ToList();
        }

        public void Excluir(StatusAccommodation statusAccommodation)
        {
            _context.Update(statusAccommodation);
            _context.SaveChanges();
        }
    }

}
