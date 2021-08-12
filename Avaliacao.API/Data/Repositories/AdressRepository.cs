using Avaliacao.API.Data.Context;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avaliacao.API.Data.Repositories
{
    public class AdressRepository : IAdressRepository
    {
        public AppDbContext _context;

        public AdressRepository(AppDbContext context)
        {
            _context = context;
        }

        public Guid Cadastrar(Adress adress)
        {
            _context.Add(adress);
            _context.SaveChanges();
            return adress.Id;
        }

        public void Editar(Adress adress)
        {
            _context.Update(adress);
            _context.SaveChanges();
        }
        
        public IEnumerable<Adress> Listar()
        {
            return _context.Adress.AsNoTracking().ToList();
        }

        public void Excluir(Adress adress)
        {
            _context.Remove(adress);
            _context.SaveChanges();
        }
    }
}
