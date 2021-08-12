using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IStatusAccommodationRepository
    {
        Guid Cadastrar(StatusAccommodation statusAccommodation);
        void Editar(StatusAccommodation statusAccommodation);
        IEnumerable<StatusAccommodation> Listar();
        void Excluir(StatusAccommodation statusAccommodation);
    }
}
