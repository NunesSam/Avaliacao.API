using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Domain.Interfaces;
using Avaliacao.API.Mapper;
using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Services
{
    public class StatusHealthService : IStatusHealthService
    {
        public IStatusHealthRepository _statusHealth;
        public StatusHealthService(IStatusHealthRepository status)
        {
            _statusHealth = status;
        }

        public Guid Cadastrar(StatusHealthViewModel status)
        {
            var retorno = _statusHealth.Cadastrar(status.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(StatusHealthViewModel status)
        {
            _statusHealth.Editar(status.ViewModelToEntity());
        }

        public IList<StatusHealthViewModel> Listar()
        {
            var status = _statusHealth.Listar().ToList();
            var retorno = new List<StatusHealthViewModel>();
            foreach (var item in status)
            {
                retorno.Add(item.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(StatusHealthViewModel status)
        {
            _statusHealth.Excluir(status.ViewModelToEntity());
        }

        public StatusHealth GetById(Guid Id)
        {
            var statusHealth = _statusHealth.Listar().Where(s => s.Id == Id).FirstOrDefault();
            return statusHealth;
        }
    }
}
