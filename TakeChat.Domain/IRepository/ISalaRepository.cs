using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.IRepository
{
    public interface ISalaRepository
    {
        Task<IEnumerable<Sala>> ObterSala();

        Task InserirSala(Sala sala);
    }
}
