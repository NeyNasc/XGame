using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Services;

namespace XGameAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando a aplicação...");

            var service = new ServiceJogador();

            Console.WriteLine("Criando instancia do serviço...");
            Console.WriteLine("Criando instancia do objeto request...");
        }
    }
}
