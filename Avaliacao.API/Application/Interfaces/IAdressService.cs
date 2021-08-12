using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IAdressService
    {
        Guid Cadastrar(AdressViewModel adress);
        void Editar(AdressViewModel adress);
        void Excluir(AdressViewModel adress);
        IList<AdressViewModel> Listar();
      
    }
}
