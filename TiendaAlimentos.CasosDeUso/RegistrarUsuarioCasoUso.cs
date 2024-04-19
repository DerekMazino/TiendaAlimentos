using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.CasosDeUso;
public class RegistrarUsuarioCasoUso
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public RegistrarUsuarioCasoUso(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    public void Ejecutar(Usuario usuario)
    {
        // Validar y procesar la lógica de registro de usuario
        _usuarioRepositorio.RegistrarUsuario(usuario);
    }
}
