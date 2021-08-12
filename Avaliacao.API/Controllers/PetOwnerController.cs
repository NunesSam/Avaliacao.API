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
    public class PetOwnerController : Controller
    {
        private readonly ILogger<PetOwnerController> _logger;
        private IPetOwnerService _petOwnerService;

        public PetOwnerController(ILogger<PetOwnerController> logger, IPetOwnerService petOwnerService)
        {
            _logger = logger;
            _petOwnerService = petOwnerService;
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Cadastrar([FromBody] PetOwnerViewModel petOwner)
        {
            try
            {
                var id = _petOwnerService.Cadastrar(petOwner);
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
        public async Task<IActionResult> Editar([FromBody] PetOwnerViewModel petOwner)
        {
            try
            {
                _petOwnerService.Editar(petOwner);
                return Ok(ApiResult.Ok());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível alterar os dados, favor comunicar administrador do sistema."));
            }
        }



        [HttpDelete("")]
        [ProducesResponseType(typeof(ApiResult<Guid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Excluir([FromBody] PetOwnerViewModel petOwner)
        {
            try
            {
                _petOwnerService.Excluir(petOwner);
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
                var lista = _petOwnerService.Listar();
                return Ok(ApiResult.Ok(lista));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível listar os usuários, favor comunicar administrador do sistema."));
            }
        }
    }
}
