using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Domain.Interfaces;
using Avaliacao.API.Mapper;
using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Services
{
    public class PetsService : IPetsService
    {
        public IPetsRepository _pets;
        public IStatusHealthRepository _statusHealth;
        public IStatusAccommodationRepository _StatusAcc;
        public PetsService(IPetsRepository pet, IStatusAccommodationRepository statusAcc)
        {
            _pets = pet;
            _StatusAcc = statusAcc;
        }

        public Guid Cadastrar(PetsViewModel pet)
        {
            var statusAccId = pet.Accommodation.Id;
            var status = _StatusAcc.Listar().Where(s => s.Id == statusAccId).FirstOrDefault();
            if (status.Description == "Livre" )
            {
                return _pets.Cadastrar(pet.ViewModelToEntity());
            }

            return new Guid();
        }      

        public void Editar(PetsViewModel petVM)
        {
            _pets.Editar(petVM.ViewModelToEntity());
        }

        public IList<PetsViewModel> Listar()
        {
            var pets = _pets.Listar().ToList();
            var retorno = new List<PetsViewModel>();
            foreach (var pet in pets)
            {
                retorno.Add(pet.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(Guid id)
        {
            var pet = _pets.Listar().Where(s => s.Id == id).FirstOrDefault();
            _pets.Excluir(pet);
        }
    }
}
