namespace TiendaAlimentos.Entidades;
public class DetallePedido
{
    public int ID { get; set; }
    public int ID_pedido { get; set; }
    public int ID_producto { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio_unitario { get; set; }
    public decimal Subtotal { get; set; }
}
