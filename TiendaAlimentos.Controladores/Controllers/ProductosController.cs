using Microsoft.AspNetCore.Mvc;
using TiendaAlimentos.Adaptadores.Interfaces;

namespace TiendaAlimentos.Controladores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly IProductoRepositorio _productoRepositorio;

    public ProductosController(IProductoRepositorio productoRepositorio)
    {
        _productoRepositorio = productoRepositorio;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ObtenerProductosDisponibles()
    {
        var productos = _productoRepositorio.ObtenerProductosDisponibles();
        return Ok(productos);
    }
}

