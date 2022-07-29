
using Repositorio.Interfaces;
using Repositorio.Implementacao.Contexto;
using System.Linq;
using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace Repositorio.Implementacao.Advogado
{
    public class AdvogadoRepositorio<Advogado> : IDisposable, IAdvogadoRepositorio<Advogado> where Advogado : class
    {
        protected Context Db = new Context();

        public void AdicionarAdvogado(Advogado obj)
        {
            Db.Set<Advogado>().Add(obj);
            Db.SaveChanges();
        }
        public Advogado SelecionarAdvogado(int id)
        {
            return Db.Set<Advogado>().Find(id);
        }

        public IEnumerable<Advogado> ListarAdvogados()
        {
            return Db.Set<Advogado>().ToList();
        }

        public void AtualizarAdvogado(Advogado obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void ExcluirAdvogado(Advogado obj)
        {
            Db.Set<Advogado>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
