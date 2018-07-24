using System;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        string AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(Nome nome, Email email, string senha);

    }
}
