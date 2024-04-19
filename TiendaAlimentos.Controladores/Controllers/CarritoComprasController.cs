using Microsoft.AspNetCore.Mvc;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Controladores.DTOs;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Controladores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarritoComprasController : ControllerBase
{
    private readonly ICarritoCompras _carritoCompras;

    public CarritoComprasController(ICarritoCompras carritoCompras)
    {
        _carritoCompras = carritoCompras;
    }

    [HttpPost("agregar")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult AgregarProductoAlCarrito([FromBody] ProductoCarritoDTO productoDTO)
    {
        var producto = new Producto { ID = productoDTO.Id, Nombre = productoDTO.Nombre, Precio = productoDTO.Precio };
        _carritoCompras.AgregarProducto(producto, productoDTO.Cantidad);
        return Ok();
    }

    [HttpDelete("eliminar/{productoId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult EliminarProductoDelCarrito(int productoId)
    {
        _carritoCompras.EliminarProducto(productoId);
        return Ok();
    }

}

