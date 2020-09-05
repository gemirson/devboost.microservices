﻿using DroneDelivery.Pagamento.Application.Dtos;
using System;
using System.Threading.Tasks;

namespace DroneDelivery.Pagamento.Application.Interfaces
{
    public interface IPedidoPagamentoService
    {
        Task RealizarPagamento(Guid pedidoId, CriarPedidoPagamentoDto criarPedidoPagamentoDto);
    }
}
