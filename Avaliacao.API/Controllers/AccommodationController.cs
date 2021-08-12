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
    public class AccommodationController : Controller
    {
        private readonly ILogger<AccommodationController> _logger;
        private IAccommodationService _accService;

        public AccommodationController(ILogger<AccommodationController> logger, IAccommodationService accService)
        {
            _logger = logger;
            _accService = accService;
        }
        

        [HttpGet("")]
        [ProducesResponseType(typeof(ApiResult<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var lista = _accService.Listar();
                return Ok(ApiResult.Ok(lista));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return UnprocessableEntity(ApiResult.Fail("Não foi possível listar os dados, favor comunicar administrador do sistema."));
            }
        }

        [HttpGet("​ListarAlojamentosLivres")]
        [ProducesResponseType(typeof(ApiResult<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> ListarAlojamentosLivres()
        {
            try
            {
                var lista = _accService.ListarAlojamentosLivres();
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
