using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IAdressRepository
    {
        Guid Cadastrar(Adress adress);
        void Editar(Adress adress);
        IEnumerable<Adress> Listar();
        void Excluir(Adress adress);
    }
}
