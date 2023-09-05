using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DsApplication.Models
{
    public class Cliente
    {
        [Key]
        public int CodigoCli { get; set; }

        [Required(ErrorMessage = "O campo Nome do Cliente é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome do Cliente deve ter no máximo 100 caracteres.")]
        public string NomeCli { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O Endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [Phone(ErrorMessage = "Informe um número de telefone válido.")]
        [StringLength(20, ErrorMessage = "O Telefone deve ter no máximo 20 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        [StringLength(100, ErrorMessage = "O Email deve ter no máximo 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Informe um CPF válido no formato 123.456.789-00.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
    }
}