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
    public class RepositoryBDCliente : ConexionBD
    {
        int filasI, filasA, filasE;
        public void Insertar(Cliente cliente)
        {
            string _sql = string.Format("insert into Clientes (Identificacion, Nombre, Tipo_cliente) values ('{0}', '{1}', '{2}')", cliente.Identificacion, cliente.NombreCliente, cliente.TipoCliente);
            var comando = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasI = comando.ExecuteNonQuery();
            CerrarConnexion();
        }

        public List<Cliente> Consultar()
        {
            string _sql = string.Format("select * from Clientes");
            System.Data.DataTable tabla = new DataTable("Clientes");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Cliente> lista = new List<Cliente>();

            foreach (var fila in tabla.Rows)
            {
                lista.Add(Mapear((DataRow)fila));
            }
            return lista;
        }

        Cliente Mapear(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.Identificacion = (string)fila[0];
            cliente.NombreCliente = (string)fila[1];
            cliente.TipoCliente = (string)fila[2];

            return cliente;
        }

        public void Eliminar(string identificacion)
        {
            string _sql = string.Format("DELETE FROM Clientes WHERE Identificacion='{0}'", identificacion);

            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasE = cmd.ExecuteNonQuery();
            CerrarConnexion();
        }

        public void Actualizar(Cliente cliente)
        {
            string _sql = string.Format("UPDATE Clientes SET [Nombre] = '{0}' ,[TipoCliente] ='{1}' WHERE [identificacion] = '{2}'", cliente.NombreCliente, cliente.TipoCliente, cliente.Identificacion);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasA = cmd.ExecuteNonQuery();
            CerrarConnexion();
        }

        public Cliente Buscar(string id)
        {
            try
            {
                string _sql = string.Format("select * from Clientes where Identificacion ='{0}'", id);
                var comando = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = comando.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    var cliente = new Entidad.Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    CerrarConnexion();
                    return cliente;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
    }
}
