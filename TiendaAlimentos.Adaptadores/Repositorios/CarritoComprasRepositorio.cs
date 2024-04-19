using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores.Interfaces;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Repositorios;

public class CarritoComprasRepositorio : ICarritoCompras
{
    private readonly ApplicationDbContext _context;

    public CarritoComprasRepositorio(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AgregarProducto(Producto producto, int cantidad)
    {
        // Aquí implementa la lógica para agregar un producto al carrito en la base de datos
    }

    public void EliminarProducto(int productoId)
    {
        // Aquí implementa la lógica para eliminar un producto del carrito en la base de datos
    }

    public void ActualizarCantidadProducto(int productoId, int nuevaCantidad)
    {
        // Aquí implementa la lógica para actualizar la cantidad de un producto en el carrito en la base de datos
    }

    public List<Producto> ObtenerProductosEnCarrito()
    {
        // Aquí implementa la lógica para obtener todos los productos en el carrito desde la base de datos
        return new List<Producto>();
    }

    public void LimpiarCarrito()
    {
        // Aquí implementa la lógica para limpiar el carrito en la base de datos
    }
}

