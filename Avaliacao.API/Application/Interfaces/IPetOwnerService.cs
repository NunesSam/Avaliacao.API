using Avaliacao.API.Model;
using System;
using System.Collections.Generic;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IPetOwnerService
    {
        Guid Cadastrar(PetOwnerViewModel owner);

        Guid Editar(PetOwnerViewModel owner);
        
        IList<PetOwnerViewModel> Listar();

        void Excluir(PetOwnerViewModel owner);
    }
}
