using Dominio.Advogado;
using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    public interface IAdvogadoRepositorio<Advogado> where Advogado : class
    {
        void Add(Advogado obj);
        Advogado GetById(int id);
        IEnumerable<Advogado> GetAll();
        void Update(Advogado obj);
        void Remove(Advogado obj);
        void Dispose();
    }
}
