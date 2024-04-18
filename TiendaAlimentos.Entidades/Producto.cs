﻿namespace TiendaAlimentos.Entidades;
public class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Descripción { get; set; }
    public string Categoría { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}
