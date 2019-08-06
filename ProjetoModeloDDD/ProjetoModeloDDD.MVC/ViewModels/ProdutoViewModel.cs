using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caractéres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "O campo valor é obrigatório o preenchimento")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível ?")]
        public bool Disponivel { get; set; }
        
        public int ClienteId { get; set; }
        
        public virtual ClienteViewModel Cliente { get; set; }
    }
}