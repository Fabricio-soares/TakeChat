using System.Collections.Generic;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service.Concreto
{
    public class SalaAppService : ISalaAppService
    {
        private readonly ISalaRepository salaRepository;

        public SalaAppService(ISalaRepository salaRepository)
        {
            this.salaRepository = salaRepository ?? throw new System.ArgumentNullException(nameof(salaRepository));
        }

        public async Task<IEnumerable<Sala>> GetSalasAsync()
        {
            return await salaRepository.ObterSala();
        }

        public async Task InserirSalasAsync(Sala sala)
        {
            await salaRepository.InserirSala(sala);
        }
    }
}
