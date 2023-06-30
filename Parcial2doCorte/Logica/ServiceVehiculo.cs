using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ServiceVehiculo
    {
        private RepositoryVehiculo vehiculoRepository;
        private RepositoryCliente clienteRepository;

        public ServiceVehiculo()
        {
            vehiculoRepository = new RepositoryVehiculo();
            clienteRepository = new RepositoryCliente();
        }

        public string Guardar(string identificacion, Vehiculo  vehiculo)
        {
            
            if (clienteRepository.Buscar(identificacion) != null)
            {
                vehiculoRepository.Guardar(vehiculo);
                return "Se a Creado Correctamente el vehiculo";
            }
            else
            {
                return ($"El cliente inexistente: {identificacion}");
            }
        }

        public ConsultaVehiculoResponse Consultar()
        {
            ConsultaVehiculoResponse responde;
            try
            {
                List<Vehiculo> vehiculos = vehiculoRepository.Consultar();
                if (vehiculos != null)
                {
                    return responde = new ConsultaVehiculoResponse(vehiculos);
                }
                else
                {
                    return responde = new ConsultaVehiculoResponse("no Existe vehiculo en la lista");
                }
            }
            catch (Exception exception)
            {
                return responde = new ConsultaVehiculoResponse("Error de aplicacion" + exception.Message);

            }
        }

        public string Eliminar(string placa)
        {
            try
            {
                if (vehiculoRepository.Buscar(placa) != null)
                {
                    vehiculoRepository.Eliminar(placa);
                    return ($"Se han eliminado satifactoriamente los datos, del vehiculo con numero de placa: {placa}");
                }
                else
                {
                    return ($"lo sentimos, no se encuentra registrada un vehiculo con numero de placa: {placa} ");
                }
            }
            catch (Exception exception)
            {

                return "Error en la aplicacion" + exception.Message;
            }
        }

        public VehiculoResponde ConsultarVehiculo(string placa)
        {
            try
            {
                Vehiculo vehiculo = vehiculoRepository.Buscar(placa);
                if (vehiculo != null)
                {
                    return new VehiculoResponde(vehiculo);
                }
                else
                {
                    return new VehiculoResponde("El cliente buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {
                return new VehiculoResponde("Error de Aplicacion: " + e.Message);
            }
        }

    }

    public class ConsultaVehiculoResponse
    {
        public List<Vehiculo> Vehiculos { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaVehiculoResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

        public ConsultaVehiculoResponse(List<Vehiculo> vehiculos)
        {
            Vehiculos = vehiculos;
            Error = false;
        }
    }

    public class VehiculoResponde
    {
        public Vehiculo Vehiculo { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public VehiculoResponde(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;
            Error = false;
        }

        public VehiculoResponde(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;

        }

        public VehiculoResponde()
        {
        }
    }
}
