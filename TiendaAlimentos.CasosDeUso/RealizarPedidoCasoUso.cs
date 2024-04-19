using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlimentos.Adaptadores;

namespace TiendaAlimentos.CasosDeUso;

public class RealizarPedidoCasoUso
{
    private readonly IPedidoRepositorio _pedidoRepositorio;
    private readonly ICarritoCompras _carritoCompras;

    public RealizarPedidoCasoUso(IPedidoRepositorio pedidoRepositorio, ICarritoCompras carritoCompras)
    {
        _pedidoRepositorio = pedidoRepositorio;
        _carritoCompras = carritoCompras;
    }

    public void Ejecutar(int usuarioId)
    {
        // Obtener los productos del carrito de compras
        var productosEnCarrito = _carritoCompras.ObtenerProductosEnCarrito();

        // Procesar la lógica para realizar un pedido con los productos en el carrito
        _pedidoRepositorio.CrearPedido(usuarioId, productosEnCarrito);
    }
}
