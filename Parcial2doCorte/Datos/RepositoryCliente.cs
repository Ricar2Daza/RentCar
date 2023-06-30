using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidad;

namespace Datos
{
    public class RepositoryCliente
    {
        private string fileName = "Cliente.txt";
        
        public void Guardar(Cliente cliente)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{cliente.Identificacion};{cliente.NombreCliente};{cliente.TipoCliente}");
            writer.Close();
            file.Close();
        }

        public List<Cliente> Consultar()
        {
            List<Cliente> clientes = new List<Cliente>();
            string linea = string.Empty;
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(file);

            while ((linea = lector.ReadLine()) != null)
            {
                Mapear(clientes, linea);
            }
            lector.Close();
            file.Close();
            return clientes;
        }

        private void Mapear(List<Cliente> clientes, string linea)
        {
            Cliente cliente = new Cliente();
            char delimiter = ';';
            string[] MatrizEmpleado = linea.Split(delimiter);
            cliente.Identificacion = MatrizEmpleado[0];
            cliente.NombreCliente = MatrizEmpleado[1];
            cliente.TipoCliente = MatrizEmpleado[2];
            clientes.Add(cliente);
        }

        public Cliente Buscar(string identificacion)
        {
            List<Cliente> clientes = Consultar();

            foreach (var item in clientes)
            {
                if (BuscarIdentificacion(identificacion, item))
                {
                    return item;
                }
            }
            return null;
        }

        private bool BuscarIdentificacion(string identificacion, Cliente item)
        {
            return item.Identificacion.Equals(identificacion);
        }

        public void Eliminar(string identificacion)
        {
            List<Cliente> clientes = Consultar();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();

            foreach (var item in clientes)
            {
                if (!BuscarIdentificacion(identificacion, item))
                {
                    Guardar(item);
                }
            }
        }
    }
}
