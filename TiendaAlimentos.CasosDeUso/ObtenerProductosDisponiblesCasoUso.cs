using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.CasosDeUso;

// Caso de uso para obtener la lista de productos disponibles
public class ObtenerProductosDisponiblesCasoUso
{
    private readonly IProductoRepositorio _productoRepositorio;

    public ObtenerProductosDisponiblesCasoUso(IProductoRepositorio productoRepositorio)
    {
        _productoRepositorio = productoRepositorio;
    }

    public List<Producto> Ejecutar()
    {
        // Obtener la lista de productos disponibles del repositorio
        return _productoRepositorio.ObtenerProductosDisponibles();
    }
}
