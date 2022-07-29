using Dominio.Advogado;
using System.Collections.Generic;

namespace Repositorio.Interfaces
{
    public interface IAdvogadoRepositorio<Advogado> where Advogado : class
    {
        void AdicionarAdvogado(Advogado obj);
        Advogado SelecionarAdvogado(int id);
        IEnumerable<Advogado> ListarAdvogados();
        void AtualizarAdvogado(Advogado obj);
        void ExcluirAdvogado(Advogado obj);
        void Dispose();
    }
}
