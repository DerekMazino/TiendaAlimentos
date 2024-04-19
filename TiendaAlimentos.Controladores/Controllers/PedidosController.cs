using Microsoft.AspNetCore.Mvc;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Controladores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IPedidoRepositorio _pedidoRepositorio;

    public PedidosController(IPedidoRepositorio pedidoRepositorio)
    {
        _pedidoRepositorio = pedidoRepositorio;
    }

    [HttpPost]
    public IActionResult RealizarPedido(int usuarioId, [FromBody] List<Producto> productos)
    {
        _pedidoRepositorio.CrearPedido(usuarioId, productos);
        return Ok();
    }

    [HttpGet("{usuarioId}/historial")]
    public IActionResult ObtenerHistorialPedidos(int usuarioId)
    {
        var pedidos = _pedidoRepositorio.ObtenerHistorialPedidos(usuarioId);
        return Ok(pedidos);
    }
}

