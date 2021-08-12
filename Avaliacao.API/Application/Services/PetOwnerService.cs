using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Domain.Interfaces;
using Avaliacao.API.Mapper;
using Avaliacao.API.Model;
using System;
using System.Collections.Generic;

namespace Avaliacao.API.Application.Services
{
    public class PetOwnerService : IPetOwnerService
    {
        public IPetOwnerRepository _owner;
       
        public PetOwnerService(IPetOwnerRepository owner)
        {
            _owner = owner;
            
        }

        public Guid Cadastrar(PetOwnerViewModel owner)
        {
            var retorno = _owner.Cadastrar(owner.ViewModelToEntity());
            return retorno;
        }
        
        public Guid Editar(PetOwnerViewModel owner)
        {
            var retorno = _owner.Cadastrar(owner.ViewModelToEntity());
            return retorno;
        }

        public IList<PetOwnerViewModel> Listar()
        {
            var owner = new List<PetOwnerViewModel>();

            foreach (var item in _owner.Listar())
            {
                owner.Add(item.EntityToViewModel());
            }

            return owner;
        }

        public void Excluir(PetOwnerViewModel owner)
        {
            var retorno = _owner.Cadastrar(owner.ViewModelToEntity());
            
        }
    }
}
