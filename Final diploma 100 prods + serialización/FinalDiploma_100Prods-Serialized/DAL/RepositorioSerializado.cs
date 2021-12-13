using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class RepositorioSerializado
    {
        private BinaryFormatter _formateadorBinario = new BinaryFormatter();

        private static RepositorioSerializado _instancia;

        private const string _path = @"C:\Users\Danisa\Desktop\Serializado.txt";

        private RepositorioSerializado()
        {

        }

        private Stream GetConexion(string pPath, FileMode pModo, FileAccess pAcceso)
        {
            return new FileStream(pPath, pModo, pAcceso);
        }

        //acá un pequeño reflection
        private static bool EsLaPropiedad(PropertyInfo pInfoPropiedad, string pPropiedad)
        {
            return pInfoPropiedad.Name == pPropiedad;
        }


        //este es el singleton
        public static RepositorioSerializado Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new RepositorioSerializado();
            }

            return _instancia;
        }

        public void Store(BE_Producto producto)
        {
            //el flujo es el stream
            Stream Flujo = this.GetConexion(RepositorioSerializado._path, FileMode.Append, FileAccess.Write);
            this._formateadorBinario.Serialize(Flujo, producto);  // los formateadores ya proponen los métodos para serializar o desserializar.
            Flujo.Close();

        }
    }
}

