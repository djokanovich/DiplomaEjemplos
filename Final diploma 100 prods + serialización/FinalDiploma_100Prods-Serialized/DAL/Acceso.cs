using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        //patrón strategy
        public void Grabar(IGraboProducto graboProducto, BE_Producto producto)
        {
            graboProducto.Crear(producto);
        }
    }
}
