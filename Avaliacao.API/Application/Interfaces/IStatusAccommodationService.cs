using System;
using System.Linq;
using Avaliacao.API.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IStatusAccommodationService
    {
        Guid Cadastrar(StatusAccommodationViewModel statusAcc);

        void Editar(StatusAccommodationViewModel statusAcc);       

        IList<StatusAccommodationViewModel> Listar();

        void Excluir(StatusAccommodationViewModel statusAcc);
    }
}
