using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IAccommodationService
    {
        Guid Cadastrar(AccommodationViewModel pet);

        void Editar(AccommodationViewModel petVM);       

        IList<AccommodationViewModel> Listar();
        IList<AccommodationViewModel> ListarAlojamentosLivres();

        void Excluir(AccommodationViewModel petVM);
    }
}
