using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimosLivros.Dto
{
    public class UsuarioRegisterDto
    {
        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Sobrenome!")]

        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Digite o Email!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a Senha!")]

        public string Senha { get; set; }
        [Required(ErrorMessage = "Digite a Confirmação da Senha!"),
         Compare("Senha", ErrorMessage = "As senhas não estão iguais")]

        public string ConfirmaSenha { get; set; }

    }
}