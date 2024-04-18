namespace TiendaAlimentos.Entidades;
public class Pedido
{
    public int ID { get; set; }
    public int ID_usuario { get; set; }
    public DateTime Fecha_hora_pedido { get; set; }
    public string Estado_pedido { get; set; }
}
