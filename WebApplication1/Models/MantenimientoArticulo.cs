using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApplication1.Models
{
    public class MantenimientoArticulo
    {
        private MySqlConnection conexion = new MySqlConnection();
        private MySqlDataReader registros = null;
        private MySqlCommand comando = new MySqlCommand();

        public List<Articulo> RecuperarTodos()
        {
            //    string cadenaConexion = "datasource=localhost;port=3306;username=root;password=;database=soloenteros";
            string consulta = "select * from articulos";
            List<Articulo> articulos = new List<Articulo>();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["localmysql"].ConnectionString;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = consulta;
            registros = comando.ExecuteReader();
            Articulo art = new Articulo();
            //probar con linq
            while (registros.Read())
            {
                //    art = new Articulo(registros.GetInt32(0), registros.GetString(1), registros.GetFloat(2));

                art = new Articulo()
                {
                    Codigo = registros.GetInt32(0),
                    Descripcion = registros.GetString(1),
                    Precio = registros.GetFloat(2)
                };

                articulos.Add(art);
            }
            return articulos;
        }

        public int Alta(Articulo art)
        {
            int i = 0;
            string sql = "insert into articulos(codigo,descripcion,precio) values (@codigo,@descripcion,@precio)";
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["localmysql"].ConnectionString;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = sql;
            comando.Prepare();
            comando.Parameters.AddWithValue("@codigo", art.Codigo);
            comando.Parameters.AddWithValue("@descripcion", art.Descripcion);
            comando.Parameters.AddWithValue("@precio", art.Precio);
            i = comando.ExecuteNonQuery();
            return i;
        }

    }
}