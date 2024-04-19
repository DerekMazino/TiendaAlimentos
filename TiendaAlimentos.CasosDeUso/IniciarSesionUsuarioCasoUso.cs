using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.CasosDeUso;

// Caso de uso para iniciar sesión de usuario en el sistema
public class IniciarSesionUsuarioCasoUso
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public IniciarSesionUsuarioCasoUso(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    public Usuario Ejecutar(string email, string contraseña)
    {
        // Validar y procesar la lógica de inicio de sesión de usuario
        return _usuarioRepositorio.IniciarSesion(email, contraseña);
    }
}
