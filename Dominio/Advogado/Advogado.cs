
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Advogado
{
    [Serializable]
    public class Advogado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senioridade { get; set; }
        public string Endereco { get; set; }
    }
}
