using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidad;


namespace Datos
{
    public class RepositoryRegistro
    {
        private string fileName = "Registro.txt";

        public void Guardar(Registro registro)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{registro.Placa};{registro.Km};{registro.ValorKm};{registro.Nombre};{registro.Fecha};{registro.Total}");
            writer.Close();
            file.Close();
        }

        public List<Registro> Consultar()
        {
            List<Registro> registro = new List<Registro>();
            string linea = string.Empty;
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(file);

            while ((linea = lector.ReadLine()) != null)
            {
                Mapear(registro, linea);
            }
            lector.Close();
            file.Close();
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

        private static void Mapear(List<Registro> registros, string linea)
        {
            Registro registro = new Registro();
            char delimiter = ';';
            string[] MatrizVehiculo = linea.Split(delimiter);
            registro.Placa = MatrizVehiculo[0];
            registro.Km = int.Parse(MatrizVehiculo[1]);
            registro.ValorKm = int.Parse(MatrizVehiculo[2]);
            registro.Nombre = MatrizVehiculo[3];
            registro.Fecha = MatrizVehiculo[4];
            registro.Total = int.Parse(MatrizVehiculo[5]);
            registros.Add(registro);
        }


        
    }
}
