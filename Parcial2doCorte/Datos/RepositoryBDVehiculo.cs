using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class RepositoryBDVehiculo:ConexionBD
    {
        int filasI, filasA, filasE;

        public void Insertar(Vehiculo vehiculo)
        {
            string _sql = string.Format("insert into Vehiculos (Placa, Descripcion_Vehiculo, Kilometraje) values ('{0}', '{1}', {2})", vehiculo.Placa, vehiculo.DescrpcionVehiculo, vehiculo.KilometrajeActual);
            var comando = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasI = comando.ExecuteNonQuery();
            CerrarConnexion();
        }

        public List<Vehiculo> Consultar()
        {
            string _sql = string.Format("select * from Vehiculos");
            System.Data.DataTable tabla = new DataTable("Vehiculos");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var fila in tabla.Rows)
            {
                lista.Add(Mapear((DataRow)fila));
            }
            return lista;
        }

        Vehiculo Mapear(DataRow fila)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = (string)fila[0];
            vehiculo.DescrpcionVehiculo = (string)fila[1];
            vehiculo.KilometrajeActual = (int)fila[2];

            return vehiculo;
        }

        public Vehiculo Buscar(string placa)
        {
            try
            {
                string _sql = string.Format("select * from Vehiculos where Placa='{0}'", placa);
                var comando = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = comando.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    var vehiculo = new Entidad.Vehiculo(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                    CerrarConnexion();
                    return vehiculo;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Eliminar(string placa)
        {
            string _sql = string.Format("DELETE FROM Vehiculos WHERE Placa='{0}'", placa);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasE = cmd.ExecuteNonQuery();
            CerrarConnexion();
        }
    }
}
