using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores;
public interface IUsuarioRepositorio
{
    void RegistrarUsuario(Usuario usuario);
    Usuario IniciarSesion(string email, string contraseña);
}
