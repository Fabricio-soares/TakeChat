using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service
{
    public interface ISalaAppService
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
        Task InserirSalasAsync(Sala sala);
    }
}
