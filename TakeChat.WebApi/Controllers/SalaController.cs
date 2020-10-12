using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Otc.DomainBase.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TakeChat.Application.Service;
using TakeChat.Domain.Models;
using TakeChat.WebApi.Dtos.Sala;

namespace TakeChat.WebApi.Controllers
{
    [Route("api/sala")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ISalaAppService salaAppService;

        public SalaController(IMapper mapper,
            ISalaAppService salaAppService)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.salaAppService = salaAppService ?? throw new ArgumentNullException(nameof(salaAppService));
        }

        /// <summary>
        /// Pesquisa por Salas.
        /// </summary>
        /// <param></param>
        /// <response code="200">Lista de resultados.</response>
        /// <response code="400">
        ///     Parametros incorretos ou limite de utilização excedido.
        /// </response>
        /// <response code="500">Erro interno.</response>
        [HttpGet, AllowAnonymous]
        [ProducesResponseType(typeof(SalaGetResult),200)]
        [ProducesResponseType(typeof(CoreException<CoreError>), 400)]
        [ProducesResponseType(typeof(InternalError), 500)]
        public async Task<IActionResult> GetSalasAsync()
        {
            var parametros = await salaAppService.GetSalasAsync();
            return Ok(mapper.Map<IEnumerable<Sala>, IEnumerable<SalaGetResult>>(parametros));
        }


        /// <summary>
        /// Incluir sala de chat
        /// </summary>
        /// <param name="parametro"></param>
        /// <response code="400">
        ///     Parametros incorretos ou limite de utilização excedido.
        /// </response>
        /// <response code="500">Erro interno.</response>
        [HttpPost, AllowAnonymous]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(CoreException<CoreError>), 400)]
        [ProducesResponseType(typeof(InternalError), 500)]
        public async Task<IActionResult> InserirSalasAsync([FromBody] SalaPost parametro)
        {
            var sala = mapper.Map<SalaPost, Sala>(parametro);
            await salaAppService.InserirSalasAsync(sala);
            return Ok();
        }
    }
 }