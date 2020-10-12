using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.Service
{
    public interface ISalaService
    {
        /// <summary>
        /// Responsável por retornar listas de salas disponiveis para acesso
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Sala>> GetSalasAsync();

        /// <summary>
        /// Incluir Sala
        /// </summary>
        /// <param name="sala"></param>
        /// <returns></returns>
        Task PostSalasAsync(Sala sala);
    }
}
