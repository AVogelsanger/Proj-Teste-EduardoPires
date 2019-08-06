using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caractéres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}