using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;       
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador(request.Email, request.Senha);
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

            var id = _repositoryJogador.AdicionarJogador(jogador);


            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGADTORIO.ToFormat("AutenticarJogadorRequest"));
            }
           
            var jogador = new Jogador(new Email(request.Email),request.Senha);

            AddNotifications(jogador);

            if (jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);
            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
