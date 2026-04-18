using ftec.projetoweb.TrabalhoPedidos.Aplicacao.DTO;
using ftec.projetoweb.TrabalhoPedidos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projetoweb.TrabalhoPedidos.Aplicacao.Adapter
{
    public static class PedidoAdapter
    {
        public static PedidoDTO PedidoTOPedidoDTO(Pedido pedido)
        {
            return new PedidoDTO();
        }

        public static List<PedidoDTO> PedidoTOPedidoDTO(List<Pedido> pedido)
        {
            return new List<PedidoDTO>();
        }

        public static Pedido PedidoDTOTOPedido(PedidoDTO pedido)
        {
            return new Pedido();
        }

        public static List<Pedido> PedidoDTOTOPedido(List<PedidoDTO> pedido)
        {
            return new List<Pedido>();
        }
    }
}
