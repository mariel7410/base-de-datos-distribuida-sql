using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace BD_Banco
{
    public class datosSql
    {
        public DataTable Listar(string sql)
        {
            OracleDataReader listar;
            DataTable tabla = new DataTable();
            OracleConnection con = null;

            try
            {
                // Crear la conexión
                Conexion conexion = new Conexion();
                con = conexion.CrearConexion();

                // Configurar el comando con la consulta proporcionada
                OracleCommand comando = new OracleCommand(sql, con);

                // Ejecutar la consulta
                listar = comando.ExecuteReader();
                tabla.Load(listar); // Cargar los resultados en la tabla
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los datos: " + ex.Message, ex);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }

            return tabla;
        }

    }
}
