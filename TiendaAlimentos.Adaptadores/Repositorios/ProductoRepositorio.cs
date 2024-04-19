using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Repositorios;

public class ProductoRepositorio : IProductoRepositorio
{
    private readonly ApplicationDbContext _context;

    public ProductoRepositorio(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Producto> ObtenerProductosDisponibles()
    {
        return _context.Productos.ToList();
    }
}
