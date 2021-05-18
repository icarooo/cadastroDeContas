using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContaBancariaServer.Models
{
    public class conta
    {
        [Key]
        public int id { get; set; } 
        public string codBanco { get; set; }
        public string nomeBanco { get; set; }
        public string numeroConta { get; set; }
        public string agencia { get; set; }
        public string cpfCnpj { get; set; }
        public string nome { get; set; }
        public DateTime dataAbertura { get; set; }
        public bool ativo { get; set; }
    }
}