using Case_Refatorado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Refatorado.Interfaces
{
    public interface ITransacaoService
    {
        void Transferir(Transacao transacao);
    }
}
