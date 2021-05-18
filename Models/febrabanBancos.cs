using System.Collections.Generic;

namespace ContaBancariaServer.Models
{
    public class febrabanBancos
    {
        public string Compensacao { get; set; }
        public string Banco { get; set; }
    }
    public class febrabanLista {
        public List<febrabanBancos> listaBancos { get; set; }
    }
}