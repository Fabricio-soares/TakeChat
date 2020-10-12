using System.Collections.Generic;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.Service.Concreto
{
    public class SalaService : ISalaService
    {
        public SalaService()
        {

        }

        public Task<IEnumerable<Sala>> GetSalasAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task PostSalasAsync(Sala sala)
        {
            throw new System.NotImplementedException();
        }
    }
}
