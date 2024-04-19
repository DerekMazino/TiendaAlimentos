using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Interfaces;

public interface IPedidoRepositorio
{
    void CrearPedido(int usuarioId, List<Producto> productos);
    List<Pedido> ObtenerHistorialPedidos(int usuarioId);
}
