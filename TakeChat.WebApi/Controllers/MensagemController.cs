using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otc.DomainBase.Exceptions;
using TakeChat.Application.Service;
using TakeChat.Domain.Models;
using TakeChat.WebApi.Dtos.Mensagem;

namespace TakeChat.WebApi.Controllers
{
    [Route("api/mensagem")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMensagemAppService mensagemAppService;

        public MensagemController(IMapper mapper, IMensagemAppService mensagemAppService)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.mensagemAppService = mensagemAppService ?? throw new ArgumentNullException(nameof(mensagemAppService));
        }

        /// <summary>
        /// Incluir Mensagem no chat
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
        public async Task<IActionResult> InserirMensagemAsync([FromBody] MensagemPost parametro)
        {
            var mensagem = mapper.Map<MensagemPost, Mensagem>(parametro);
            await mensagemAppService.InserirMensagemAsync(mensagem);
            return Ok();
        }


    }
}