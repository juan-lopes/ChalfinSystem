
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

        public void Add(Advogado obj)
        {
            Db.Set<Advogado>().Add(obj);
            Db.SaveChanges();
        }
        public Advogado GetById(int id)
        {
            return Db.Set<Advogado>().Find(id);
        }

        public IEnumerable<Advogado> GetAll()
        {
            return Db.Set<Advogado>().ToList();
        }

        public void Update(Advogado obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(Advogado obj)
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
