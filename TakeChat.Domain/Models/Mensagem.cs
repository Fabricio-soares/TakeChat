using System;
using System.Collections.Generic;
using System.Text;

namespace TakeChat.Domain.Models
{
    public class Mensagem
    {
        public string Conteudo { get; set; }
        public Guid Sala { get; set; }
        public Guid UsuarioEnvio { get; set; }
        public Guid UsuarioRecebe { get; set; }
        public DateTime DataEnvio { get; set; }

    }
}
