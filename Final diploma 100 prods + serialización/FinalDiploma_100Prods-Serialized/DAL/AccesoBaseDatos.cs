using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoBaseDatos : IGraboProducto
    {
        public void Crear(BE_Producto producto)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=examenesDB;Integrated Security=True");

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO Producto3 (Id, Descripcion, Precio) VALUES ({producto.Id}, '{producto.Descripcion}', {producto.Precio})";
            cmd.Connection = cnn;
            //cmd.Parameters.AddWithValue("Id", producto.Id);
            //cmd.Parameters.AddWithValue("Descripcion", producto.Descripcion);
            //cmd.Parameters.AddWithValue("Precio", producto.Precio);
            //producto.Id = (int)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();

            //foreach (var producto in productos)
            //{                                     


            //}



            cnn.Close();
        }
    }
}
