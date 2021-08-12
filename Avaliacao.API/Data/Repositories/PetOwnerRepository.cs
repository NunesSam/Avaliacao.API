using Avaliacao.API.Data.Context;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avaliacao.API.Data.Repositories
{
    public class PetOwnerRepository : IPetOwnerRepository
    {
        public AppDbContext _context;

        public PetOwnerRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Editar(PetOwner owner)
        {
            _context.Update(owner);
            _context.SaveChanges();
        }

        public Guid Cadastrar(PetOwner owner)
        {
            _context.Add(owner);
            _context.SaveChanges();
            return owner.Id;
        }

        public void Excluir(PetOwner owner)
        {
            _context.Remove(owner);
            _context.SaveChanges();
        }

        public IEnumerable<PetOwner> Listar()
        {
            return _context.PetOwners.AsNoTracking().ToList();
        }
    }
}
