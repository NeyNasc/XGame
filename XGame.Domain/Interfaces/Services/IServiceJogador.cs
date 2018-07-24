using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        string AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(AdicionarJogadorRequest request);
    }
}
