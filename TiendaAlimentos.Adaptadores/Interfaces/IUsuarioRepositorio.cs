using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Interfaces;
public interface IUsuarioRepositorio
{
    void RegistrarUsuario(Usuario usuario);
    Usuario IniciarSesion(string email, string contraseña);
}
