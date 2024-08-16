using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Refatorado.Models
{
    public class ContasSaldo
    {
        public ContasSaldo(uint conta, decimal saldo)
        {
            Conta = conta;
            Saldo = saldo;
        }

        public uint Conta { get; set; }
        public decimal Saldo { get; set; }
    }
}
