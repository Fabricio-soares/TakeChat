using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service.Concreto
{
    public class MensagemAppService : IMensagemAppService
    {
        private readonly IMensagemRepository mensagemRepository;

        public MensagemAppService( IMensagemRepository  mensagemRepository)
        {
            this.mensagemRepository = mensagemRepository ?? throw new ArgumentNullException(nameof(mensagemRepository));
        }

        public async Task InserirMensagemAsync(Mensagem mensagem)
        {
            await mensagemRepository.InserirMensagemAsync(mensagem);
        }
    }
}
