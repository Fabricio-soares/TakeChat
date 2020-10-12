using System;
using System.Collections.Generic;
using System.Text;

namespace TakeChat.Domain.Models
{
    public class Sala
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativa { get; set; }
    }
}
