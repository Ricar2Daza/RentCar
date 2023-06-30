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
    public class RepositoryBDRegistro : ConexionBD
    {
        int filasI, filasA, filasE;

        public void Insertar(Registro registro)
        {
            string _sql = string.Format("insert into Registros (Placa_FK, Kilometraje_FK, Valor_Kilometraje, Nombre_Propietario_FK, Fecha, Total) values ('{0}', {1}, {2}, '{3}', '{4}', {5})", registro.Placa, registro.Km, registro.ValorKm, registro.Nombre, registro.Fecha, registro.Total);
            var comando = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            filasI = comando.ExecuteNonQuery();
            CerrarConnexion();
        }

        public List<Registro> Consultar()
        {
            string _sql = string.Format("select * from Registros");
            System.Data.DataTable tabla = new DataTable("Registros");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Registro> lista = new List<Registro>();

            foreach (var fila in tabla.Rows)
            {
                lista.Add(Mapear((DataRow)fila));
            }
            return lista;
        }

        Registro Mapear(DataRow fila)
        {
            Registro registro = new Registro();
            registro.Placa = (string)fila[0];
            registro.Km = (int)fila[1];
            registro.ValorKm = (int)fila[2];
            registro.Nombre = (string)fila[3];
            registro.Fecha = (string)fila[4];
            registro.Total = (int)fila[5];

            return registro;
        }

        public Registro Buscar(string placa)
        {
            List<Registro> registros = Consultar();

            foreach (var item in registros)
            {
                if (EsEncontrado(placa, item))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(string placa, Registro item)
        {
            return item.Placa.Equals(placa);
        }

        public List<Registro> FiltrarPlaca(string placa)
        {
            return Consultar().Where(p => p.Placa.Equals(placa)).ToList();
        }

        public List<Registro> FiltrarFecha(string fecha)
        {
            return Consultar().Where(p => p.Fecha.Equals(fecha)).ToList();
        }

    }
}
