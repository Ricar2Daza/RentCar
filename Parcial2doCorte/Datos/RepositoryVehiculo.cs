using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidad;

namespace Datos
{
    public class RepositoryVehiculo
    {
        private string fileName = "Vehiculo.txt";
        public void Guardar(Vehiculo vehiculo)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{vehiculo.Placa};{vehiculo.IdCliente};{vehiculo.DescrpcionVehiculo};{vehiculo.KilometrajeActual};");
            writer.Close();
            file.Close();
        }

        public List<Vehiculo> Consultar()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            string linea = string.Empty;
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(file);

            while ((linea = lector.ReadLine()) != null)
            {
                Mapear(vehiculos, linea);
            }
            lector.Close();
            file.Close();
            return vehiculos;
        }

        private static void Mapear(List<Vehiculo> vehiculos, string linea)
        {
            Vehiculo vehiculo = new Vehiculo();
            char delimiter = ';';
            string[] MatrizVehiculo = linea.Split(delimiter);
            vehiculo.Placa = MatrizVehiculo[0];
            vehiculo.IdCliente = MatrizVehiculo[1];
            vehiculo.DescrpcionVehiculo = MatrizVehiculo[2];
            vehiculo.KilometrajeActual = int.Parse(MatrizVehiculo[3]);
            vehiculos.Add(vehiculo);
        }

        public Vehiculo Buscar(string placa)
        {
            List<Vehiculo> vehiculos = Consultar();

            foreach (var item in vehiculos)
            {
                if (EsEncontrado(placa, item))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EsEncontrado(string identificacion, Vehiculo item)
        {
            return item.Placa.Equals(identificacion);
        }

        private bool BuscarPlaca(string placa, Vehiculo item)
        {
            return item.Placa.Equals(placa);
        }

        public void ActualizarVehiculo(Vehiculo vehiculo)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos = Consultar();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();
            foreach (var item in vehiculos)
            {
                if (vehiculo.Placa == item.Placa)
                {
                    Guardar(vehiculo);
                }
                else
                {
                    Guardar(item);
                }
            }
        }

        public void Eliminar(string placa)
        {
            List<Vehiculo> vehiculos = Consultar();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();

            foreach (var item in vehiculos)
            {
                if (!BuscarPlaca(placa, item))
                {
                    Guardar(item);
                }
            }
        }


    }
}
