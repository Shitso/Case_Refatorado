using Case_Refatorado.Interfaces;
using Case_Refatorado.Models;
using System;

namespace Case_Refatorado.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly IRepositorioContas _repositorioContas;

        public TransacaoService(IRepositorioContas repositorioContas)
        {
            _repositorioContas = repositorioContas;
        }

        public void Transferir(Transacao transacao)
        {
            var contaOrigem = _repositorioContas.ObterConta(transacao.ContaOrigem);
            if (contaOrigem == null || contaOrigem.Saldo < transacao.Valor)
            {
                Console.WriteLine($"Transação número {transacao.CorrelationId} foi cancelada por falta de saldo.");
                return;
            }

            var contaDestino = _repositorioContas.ObterConta(transacao.ContaDestino);
            if (contaDestino == null)
            {
                Console.WriteLine($"Conta destino {transacao.ContaDestino} não encontrada.");
                return;
            }

            contaOrigem.Saldo -= transacao.Valor;
            contaDestino.Saldo += transacao.Valor;

            _repositorioContas.AtualizarConta(contaOrigem);
            _repositorioContas.AtualizarConta(contaDestino);

            Console.WriteLine($"Transação número {transacao.CorrelationId} foi efetivada com sucesso! " +
                              $"Novos saldos -> Conta Origem: {contaOrigem.Saldo} | Conta Destino: {contaDestino.Saldo}");
        }
    }
}
