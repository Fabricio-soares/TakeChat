using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service.Concreto
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioAppService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public async Task InserirUsuarioAsync(Usuario usuario)
        {
            await usuarioRepository.InserirUsuarioAsync(usuario);
        }
    }
}
