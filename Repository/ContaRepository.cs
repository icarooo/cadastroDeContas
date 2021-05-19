using System.Collections.Generic;
using ContaBancariaServer.Entities;
using ContaBancariaServer.Interfaces;
using ContaBancariaServer.Models;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ContaBancariaServer.Repository
{
    public class ContaRepository : IContas
    {
        BancoContext _db;
        public ContaRepository ( BancoContext db) 
        {
            _db = db;
        }

        public bool deleteConta(int id)
        {
            try {
                _db.contas.RemoveRange(new conta { id = id});
                _db.SaveChanges();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public conta getContaById(int id)
        {
            return _db.contas.Find(id);
        }

        public List<conta> getContasList()
        {
            return _db.contas.ToList();
        }

        public async Task<conta> gravarDados(conta conta)
        {
            if (conta.id > 0) {
                _db.Entry(conta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            else {
                _db.contas.Add(conta);
            }
            await _db.SaveChangesAsync();
            return conta; 
        }
    }
}