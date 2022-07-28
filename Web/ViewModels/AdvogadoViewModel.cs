using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    [Serializable]
    public class AdvogadoViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Senioridade")]
        public string Senioridade { get; set; }
        [Required(ErrorMessage = "Preencha o campo Endereço")]
        public string Endereco { get; set; }
    }
}