﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Application.Service
{
    public interface IMensagemAppService
    {
        Task InserirMensagemAsync(Mensagem mensagem);
    }
}
