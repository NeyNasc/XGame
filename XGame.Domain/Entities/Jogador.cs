using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest é Obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um email");
            }
            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um email");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("Digite uma senha de no minimo 6 caracters");
            }
        }

        public Guid Id{ get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public EnumSituacaoJogador Status { get; set; }
    }
}