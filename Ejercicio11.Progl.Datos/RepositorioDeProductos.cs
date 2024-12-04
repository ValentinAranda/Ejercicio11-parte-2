using Ejercicio11.entidades;
using System.ComponentModel;

namespace Ejercicio11.Progl.Datos
{
    public class RepositorioDeProductos
    {
        private List<Producto>? Producto;
        private string? nombreArchivo = "Punto3D.txt";
        private string? rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public RepositorioDeProductos()
        {
            Producto = new List<Producto>();
            Producto = LeerDatos();
        }
        public void Agregar(Producto producto)
        {
            Producto!.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            Producto!.Remove(producto);
        }

        public bool Existe(Producto producto)
        {
            return Producto!.Any(e => e.Clave == producto.Clave);
        }

        public List<Producto> ObtenerProducto()
        {
            return new List<Producto>(Producto!);
        }

        public List<Producto>? OrdenarAsc()
        {
            return Producto!.OrderBy(e => e.Precio).ToList();
        }

        public List<Producto>? OrdenarDesc()
        {
            return Producto!.OrderByDescending(e => e.Precio).ToList();
        }

        private List<Producto>? LeerDatos()
        {
            var listaProducto = new List<Producto>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto!, nombreArchivo!);
            if (!File.Exists(rutaCompletaArchivo))
            {
                return listaProducto;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? linea = lector.ReadLine();
                    Producto? producto = ConstruirProducto(linea);
                    listaProducto.Add(producto!);
                }
            }
            return listaProducto;
        }

        public void GuardarDatos()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto!, nombreArchivo!);
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                foreach (var producto in Producto!)
                {
                    string linea = ConstruirLinea(producto);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Producto producto)
        {
            return $"{producto.Nombre}|{producto.Clave}||{producto.Precio}|{producto.Descripcion}|{producto.Stock}|{producto.Categoria}|";
        }
        private Producto? ConstruirProducto(string? linea)
        {
            var campos = linea!.Split('|');
            var Clave = int.Parse(campos[0]);
            string Nombre = (campos[1]);
            var Precio = decimal.Parse (campos[2]);
            string Descripcion = (campos[3]);
            var Stock = int.Parse(campos[4]);
            string categoria = (campos[5]);
            return new Producto(Clave, Nombre, Precio, Stock, Descripcion);
        }

        public List<Producto> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
