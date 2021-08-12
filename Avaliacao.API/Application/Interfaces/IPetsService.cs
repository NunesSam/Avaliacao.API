using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IPetsService
    {
        Guid Cadastrar(PetsViewModel pet);

        void Editar(PetsViewModel petVM);       

        IList<PetsViewModel> Listar();

        void Excluir(Guid id);
    }
}
