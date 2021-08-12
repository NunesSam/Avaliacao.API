using Avaliacao.API.Data.Context;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avaliacao.API.Data.Repositories
{
    public class PetsRepository : IPetsRepository
    {
        public AppDbContext _context;

        public PetsRepository(AppDbContext context)
        {
            _context = context;
        }        

        public Guid Cadastrar(Pets pet)
        {
            _context.Add(pet);
            _context.SaveChanges();
            return pet.Id;
        }
        public void Editar(Pets pet)
        {
            _context.Update(pet);
            _context.SaveChanges();                  
        }

        public IEnumerable<Pets> Listar()
        {
            return _context.Pets
                .Include(x => x.Accommodation).ThenInclude(s => s.Status)
                .Include(x => x.StatusHealth)
                .Include(p => p.PetOwner).ThenInclude(o => o.Adress)
                .AsNoTracking().ToList();
        }

        public void Excluir(Pets pet)
        {
            _context.Remove(pet);
            _context.SaveChanges();                     
        }                   
    }
}
