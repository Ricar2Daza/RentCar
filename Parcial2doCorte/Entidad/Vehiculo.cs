using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vehiculo
    {
        string placa;
        string idCliente;
        string descripcionVehiculo;
        int kilometrajeActual;

        public Vehiculo()
        {
        }

        public Vehiculo(string placa, string idCliente, string descripcionVehiculo, int kilometrajeActual)
        {
            Placa = placa;
            IdCliente = idCliente;
            DescrpcionVehiculo = descripcionVehiculo;
            KilometrajeActual = kilometrajeActual;
        }

        public string Placa { get => placa; set => placa = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string DescrpcionVehiculo { get => descripcionVehiculo; set => descripcionVehiculo = value; }
        public int KilometrajeActual { get => kilometrajeActual; set => kilometrajeActual = value; }
    }
}
