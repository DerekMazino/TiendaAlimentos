using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Repositorios;

public class PedidoRepositorio : IPedidoRepositorio
{
    private readonly ApplicationDbContext _context;

    public PedidoRepositorio(ApplicationDbContext context)
    {
        _context = context;
    }

    public void CrearPedido(int usuarioId, List<Producto> productos)
    {
        // Aquí implementa la lógica para crear un nuevo pedido en la base de datos
    }

    public List<Pedido> ObtenerHistorialPedidos(int usuarioId)
    {
        return _context.Pedidos.Where(p => p.ID_usuario == usuarioId).ToList();
    }
}

