using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Otc.DomainBase.Exceptions;
using System;
using System.Threading.Tasks;
using TakeChat.Application.Service;
using TakeChat.Domain.Models;
using TakeChat.WebApi.Dtos.Usuario;

namespace TakeChat.WebApi.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService usuarioAppService;
        private readonly IMapper mapper;

        public UsuarioController(IUsuarioAppService  usuarioAppService, IMapper mapper)
        {
            this.usuarioAppService = usuarioAppService ?? throw new ArgumentNullException(nameof(usuarioAppService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Incluir Usuário em sala TakeChat
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
        public async Task<IActionResult> InserirUsuarioAsync([FromBody] UsuarioPost parametro)
        {
            var usuario = mapper.Map<UsuarioPost, Usuario>(parametro);
            await usuarioAppService.InserirUsuarioAsync(usuario);
            return Ok();
        }
    }
}