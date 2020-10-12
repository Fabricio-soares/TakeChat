using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service
{
    public interface IUsuarioAppService
    {
        /// <summary>
        /// Incluir Usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task InserirUsuarioAsync(Usuario usuario);
    }
}
