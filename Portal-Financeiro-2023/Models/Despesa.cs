using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Financeiro_2023.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public String Conta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]

        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de vencimento!")]
        public DateTime Vencimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a situação!")]
        [Display(Name = "Situação")]
        public String Status { get; set; }
    }
}
