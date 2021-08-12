using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IPetOwnerRepository
    {
        Guid Cadastrar(PetOwner petOwner);
        void Editar(PetOwner petOwner);
        IEnumerable<PetOwner> Listar();
        void Excluir(PetOwner petOwner);
    }
}
