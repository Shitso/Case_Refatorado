using Case_Refatorado.Interfaces;
using Case_Refatorado.Repositories;
using Case_Refatorado.Services;
using Case_Refatorado.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Case_Refatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRepositorioContas, RepositorioContas>()
                .AddSingleton<ITransacaoService, TransacaoService>()
                .BuildServiceProvider();

            var transacaoService = serviceProvider.GetService<ITransacaoService>();

            var transacoes = new List<Transacao>
            {
                new Transacao (1, DateTime.Parse("09/09/2023 14:15:00"), 938485762, 2147483649, 150),
                new Transacao (2, DateTime.Parse("09/09/2023 14:15:05"), 2147483649, 210385733, 149 ),
                new Transacao (3, DateTime.Parse("09/09/2023 14:15:29"), 347586970,  238596054, 1100 ),
                new Transacao (4, DateTime.Parse("09/09/2023 14:17:00"), 675869708,  210385733, 5300 ),
                new Transacao (5, DateTime.Parse("09/09/2023 14:18:00"), 238596054,  674038564, 1489 ),
                new Transacao (6, DateTime.Parse("09/09/2023 14:18:20"), 573659065,  563856300,  49 ),
                new Transacao (7, DateTime.Parse("09/09/2023 14:19:00"), 938485762,  2147483649, 44 ),
                new Transacao (8, DateTime.Parse("09/09/2023 14:19:01"), 573659065,  675869708,  150 )
            };

            foreach (var transacao in transacoes)
            {
                transacaoService.Transferir(transacao);
            }
        }
    }
}
