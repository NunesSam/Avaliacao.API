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
    public class StatusAccommodationService : IStatusAccommodationService
    {
        public IStatusAccommodationRepository _SttsAcc;

        public StatusAccommodationService(IStatusAccommodationRepository sttsAcc)
        {
            _SttsAcc = sttsAcc;
        }

        public Guid Cadastrar(StatusAccommodationViewModel sttsAcc)
        {
            var retorno = _SttsAcc.Cadastrar(sttsAcc.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(StatusAccommodationViewModel sttsAcc)
        {
            _SttsAcc.Editar(sttsAcc.ViewModelToEntity());
        }

        public IList<StatusAccommodationViewModel> Listar()
        {
            var sttAc = _SttsAcc.Listar().ToList();
            var retorno = new List<StatusAccommodationViewModel>();
            foreach (var item in sttAc)
            {
                retorno.Add(item.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(StatusAccommodationViewModel sttsAcc)
        {
            _SttsAcc.Excluir(sttsAcc.ViewModelToEntity());
        }
    }
}
