using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case_Refatorado.Models;

namespace Case_Refatorado.Interfaces
{
    public interface IRepositorioContas
    {
        ContasSaldo ObterConta(uint numeroConta);
        void AtualizarConta(ContasSaldo conta);
    }
}
