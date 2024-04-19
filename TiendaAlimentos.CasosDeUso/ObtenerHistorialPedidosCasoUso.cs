using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.CasosDeUso;

// Caso de uso para obtener el historial de pedidos de un usuario
public class ObtenerHistorialPedidosCasoUso
{
    private readonly IPedidoRepositorio _pedidoRepositorio;

    public ObtenerHistorialPedidosCasoUso(IPedidoRepositorio pedidoRepositorio)
    {
        _pedidoRepositorio = pedidoRepositorio;
    }

    public List<Pedido> Ejecutar(int usuarioId)
    {
        // Obtener el historial de pedidos del usuario del repositorio
        return _pedidoRepositorio.ObtenerHistorialPedidos(usuarioId);
    }
}
