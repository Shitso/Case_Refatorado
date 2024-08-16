using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Refatorado.Models
{

    public class Transacao
    {
        public Transacao(int correlationid, DateTime datahora, uint contaorigem, uint contadestino, decimal valor)
        {
            CorrelationId = correlationid;
            DataHora = datahora;
            ContaOrigem = contaorigem;
            ContaDestino = contadestino;
            Valor = valor;
        }

        public int CorrelationId { get; set; }
        public DateTime DataHora { get; set; }
        public uint ContaOrigem { get; set; }
        public uint ContaDestino { get; set; }
        public decimal Valor { get; set; }
    }
}
