using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    private readonly ApplicationDbContext _context;

    public UsuarioRepositorio(ApplicationDbContext context)
    {
        _context = context;
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }

    public Usuario IniciarSesion(string email, string contraseña)
    {
        return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Contraseña == contraseña);
    }
}