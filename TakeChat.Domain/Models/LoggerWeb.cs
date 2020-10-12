using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace TakeChat.Domain.Models
{
    public class LoggerWeb
    { 
        public Guid Id { get;  set; }
        public string Log { get; set; }
        public DateTime DataCadastro { get; set; }
    }

}

