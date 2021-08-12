using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Controllers.Shared;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : Controller
    {
        private readonly ILogger<PetsController> _logger;
        private IPetsService _petsService;

        public PetsController(ILogger<PetsController> logger, IPetsService petsService)
        {
            _logger = logger;
            _petsService = petsService;
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Cadastrar([FromBody] PetsViewModel pets)
        {
            try
            {
                var id = _petsService.Cadastrar(pets);

                if (id == null || id == Guid.Empty)
                {
                    return UnprocessableEntity(ApiResult.Fail("Não foi possível cadastrar, StatusAccommodation invalido."));
                }
                return Ok(ApiResult.Ok(id));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível cadastrar, favor comunicar administrador do sistema."));
            }
        }

        [HttpPut("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Editar([FromBody] PetsViewModel pet)
        {
            try
            {
                _petsService.Editar(pet);
                return Ok(ApiResult.Ok());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível alterar os dados, favor comunicar administrador do sistema."));
            }
        }



        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Excluir(Guid id)
        {
            try
            {
                _petsService.Excluir(id);
                return Ok(ApiResult.Ok());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível realizar a exclusão, favor comunicar administrador do sistema."));
            }
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(ApiResult<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var lista = _petsService.Listar();
                return Ok(ApiResult.Ok(lista));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível listar os dados, favor comunicar administrador do sistema."));
            }
        }
    }
}
