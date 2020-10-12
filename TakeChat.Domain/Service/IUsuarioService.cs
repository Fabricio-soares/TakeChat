using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.Service
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Incluir Usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task PostUsuarioAsync(Usuario usuario);
    }
}
