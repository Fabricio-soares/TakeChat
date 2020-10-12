using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.IRepository
{
    public interface IMensagemRepository
    {
        Task InserirMensagemAsync(Mensagem mensagem);
    }
}
