using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IAccommodationRepository
    {
        Guid Cadastrar(Accommodation accommodation);
        void Editar(Accommodation accommodation);
        IEnumerable<Accommodation> Listar();
        void Excluir(Accommodation accommodation);
    }
}
