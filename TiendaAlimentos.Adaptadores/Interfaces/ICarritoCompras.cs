using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Entidades;

namespace TiendaAlimentos.Adaptadores.Interfaces;

public interface ICarritoCompras
{
    void AgregarProducto(Producto producto, int cantidad);
    void EliminarProducto(int productoId);
    void ActualizarCantidadProducto(int productoId, int nuevaCantidad);
    List<Producto> ObtenerProductosEnCarrito();
    void LimpiarCarrito();
}

