namespace Ejercicio11.entidades
{
    public class Producto
    {
        public int Clave { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }

        public Producto()
        {

        }

        public Producto(int clave, string nombre, decimal precio, int stock, string descripcion)
        {
            Clave = clave;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Descripcion = descripcion;
        }
    }
}
