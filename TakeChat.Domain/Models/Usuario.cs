using System;
using System.Collections.Generic;
using System.Text;

namespace TakeChat.Domain.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
    }
}
