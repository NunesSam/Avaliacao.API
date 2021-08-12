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
    public class AccommodationService : IAccommodationService
    {
        public IAccommodationRepository _acc;
        public IStatusAccommodationRepository _statusAcc;

        public AccommodationService(IAccommodationRepository acc, IStatusAccommodationRepository statusAcc)
        {
            _acc = acc;
            _statusAcc = statusAcc;
        }

        public Guid Cadastrar(AccommodationViewModel accVM)
        {
            var retorno = _acc.Cadastrar(accVM.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(AccommodationViewModel accVM)
        {
            _acc.Editar(accVM.ViewModelToEntity());
        }

        public IList<AccommodationViewModel> Listar()
        {
            var Accommodation = _acc.Listar().ToList();
            var retorno = new List<AccommodationViewModel>();
            foreach (var acc in Accommodation)
            {
                retorno.Add(acc.EntityToViewModel());
            }
            return retorno;
        }

        public IList<AccommodationViewModel> ListarAlojamentosLivres()
        {
            var StatusAccommodation = _statusAcc.Listar().Where(a => a.Description == "Livre").FirstOrDefault();
            var Accommodation = _acc.Listar().Where(a => a.Status.Id == StatusAccommodation.Id).ToList();
            var retorno = new List<AccommodationViewModel>();
            foreach (var acc in Accommodation)
            {
                retorno.Add(acc.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(AccommodationViewModel accVM)
        {
            _acc.Excluir(accVM.ViewModelToEntity());
        }
    }
}
