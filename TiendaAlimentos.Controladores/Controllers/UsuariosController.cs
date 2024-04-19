using Microsoft.AspNetCore.Mvc;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Controladores.DTOs;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Controladores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public UsuariosController(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    [HttpPost("registro")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult RegistrarUsuario([FromBody] Usuario usuario)
    {
        _usuarioRepositorio.RegistrarUsuario(usuario);
        return Ok();
    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult IniciarSesion([FromBody] Credenciales credenciales)
    {
        var usuario = _usuarioRepositorio.IniciarSesion(credenciales.Email, credenciales.Contraseña);
        if (usuario == null)
        {
            return NotFound("Usuario no encontrado");
        }
        return Ok(usuario);
    }
}
