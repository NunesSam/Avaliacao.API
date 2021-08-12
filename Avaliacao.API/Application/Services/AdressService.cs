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
    public class AdressService : IAdressService
    {
        public IAdressRepository _adress;

        public AdressService(IAdressRepository adress)
        {
            _adress = adress;
        }

        public Guid Cadastrar(AdressViewModel adress)
        {
            var retorno = _adress.Cadastrar(adress.ViewModelToEntity());
            return retorno;
        }

        public void Editar(AdressViewModel adress)
        {            _adress.Editar(adress.ViewModelToEntity());
            
        }

        public IList<AdressViewModel> Listar()
        {
            var adress = new List<AdressViewModel>();

            foreach (var item in _adress.Listar())
            {
                adress.Add(item.EntityToViewModel());
            }

            return adress;
        }

        public void Excluir(AdressViewModel adress)
        {
            _adress.Excluir(adress.ViewModelToEntity());
        }


    }
}
