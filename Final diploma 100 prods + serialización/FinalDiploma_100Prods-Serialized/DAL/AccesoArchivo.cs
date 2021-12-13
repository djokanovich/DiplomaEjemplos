using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoArchivo : IGraboProducto
    {
        private string archivo = @"C:\Users\Danisa\Desktop\EjercicioFinalDiploma\productos.txt";

        public void Crear(BE_Producto producto)
        {
            var texto = $"Id:{producto.Id}, Descripción:{producto.Descripcion}, Precio{producto.Precio} ";

            using (var sw = File.AppendText(archivo))
            {
                sw.WriteLine(texto);
            }

            //foreach (var producto in productos)
            //{

            //}

        }
    }
}
