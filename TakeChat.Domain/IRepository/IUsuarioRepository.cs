using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.Models;

namespace TakeChat.Domain.IRepository
{
    public interface IUsuarioRepository
    {
        Task InserirUsuarioAsync(Usuario usuario);
    }
}
