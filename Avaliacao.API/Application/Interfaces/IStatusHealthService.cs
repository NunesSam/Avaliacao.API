using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IStatusHealthService
    {
        Guid Cadastrar(StatusHealthViewModel statusHVM);

        void Editar(StatusHealthViewModel statusHVM);       

        IList<StatusHealthViewModel> Listar();

        void Excluir(StatusHealthViewModel statusHVM);
    }
}
