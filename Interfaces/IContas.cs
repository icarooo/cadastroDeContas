using System.Collections.Generic;
using System.Threading.Tasks;
using ContaBancariaServer.Models;

namespace ContaBancariaServer.Interfaces
{
    public interface IContas
    {
         List<conta> getContasList();
         conta getContaById(int id);
         Task<conta> gravarDados(conta conta);
         
         bool deleteConta(int id);

    }
}