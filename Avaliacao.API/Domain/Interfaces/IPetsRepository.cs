using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IPetsRepository
    {
        Guid Cadastrar(Pets pet);
        void Editar(Pets pet);
        IEnumerable<Pets> Listar();
        void Excluir(Pets pet);
    }
}
