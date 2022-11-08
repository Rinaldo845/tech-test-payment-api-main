using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public enum StatusPedido
    {
            AguardandoPagamento = 1,
            PagamentoAprovado,
            EnviadoTransportadora,
            PedidoEntregue,
            PedidoCancelado
    }
}