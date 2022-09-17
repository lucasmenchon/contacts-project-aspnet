﻿using DawnPoets.Enums;
using System.ComponentModel.DataAnnotations;

namespace DawnPoets.Models
{
    public class UserModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário.")]
        public string? Nome { get; set; }

        public string? Login { get; set; }

        public string? Senha { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário.")]
        [EmailAddress(ErrorMessage = "Email informado inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite o login do usuário.")]
        public PerfilEnum? Perfil { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }
        


    }
}
