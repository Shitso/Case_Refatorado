using Case_Refatorado.Interfaces;
using Case_Refatorado.Models;
using System.Collections.Generic;
using System.Linq;

namespace Case_Refatorado.Repositories
{
    public class RepositorioContas : IRepositorioContas
    {
        private List<ContasSaldo> tabelaSaldos;

        public RepositorioContas()
        {
            tabelaSaldos = new List<ContasSaldo>
            {
                new ContasSaldo(938485762, 180),
                new ContasSaldo(347586970, 1200),
                new ContasSaldo(2147483649, 0),
                new ContasSaldo(675869708, 4900),
                new ContasSaldo(238596054, 478),
                new ContasSaldo(573659065, 787),
                new ContasSaldo(210385733, 10),
                new ContasSaldo(674038564, 400),
                new ContasSaldo(563856300, 1200)
            };
        }

        public ContasSaldo ObterConta(uint numeroConta)
        {
            return tabelaSaldos.FirstOrDefault(x => x.Conta == numeroConta);
        }

        public void AtualizarConta(ContasSaldo conta)
        {
            tabelaSaldos.RemoveAll(x => x.Conta == conta.Conta);
            tabelaSaldos.Add(conta);
        }
    }
}
