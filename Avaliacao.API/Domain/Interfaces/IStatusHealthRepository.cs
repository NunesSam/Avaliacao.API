using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IStatusHealthRepository
    {
        Guid Cadastrar(StatusHealth statusHealth);
        void Editar(StatusHealth statusHealth);
        IEnumerable<StatusHealth> Listar();
        void Excluir(StatusHealth statusHealth);
    }
}
