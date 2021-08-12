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
    public class StatusHealthRepository : IStatusHealthRepository
    {
        public AppDbContext _context;

        public StatusHealthRepository(AppDbContext context)
        {
            _context = context;
        }

        public Guid Cadastrar(StatusHealth statusHealth)
        {
            _context.Add(statusHealth);
            _context.SaveChanges();
            return statusHealth.Id;
        }
        public void Editar(StatusHealth statusHealth)
        {
            _context.Update(statusHealth);
            _context.SaveChanges();
        }

        public IEnumerable<StatusHealth> Listar()
        {
            return _context.StatusHealth.AsNoTracking().ToList();
        }

        public void Excluir(StatusHealth statusHealth)
        {
            _context.Update(statusHealth);
            _context.SaveChanges();
        }
    }
}
