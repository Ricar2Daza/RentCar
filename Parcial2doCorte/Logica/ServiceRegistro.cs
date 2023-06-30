using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class ServiceRegistro
    {
        private RepositoryVehiculo vehiculoRepository;
        public RepositoryRegistro repositoryRegistro;

        public ServiceRegistro()
        {
            vehiculoRepository = new RepositoryVehiculo();
            repositoryRegistro = new RepositoryRegistro();
        }

        public string Guardar(string placa, Registro registro)
        {

            if (repositoryRegistro.Buscar(placa) == null)
            {
                repositoryRegistro.Guardar(registro);
                return "Se a Creado Correctamente el registro";
            }
            else
            {
                return ($"El vehiculo con la placa: {placa} ya se encuentra registrado");
            }
        }

        public ConsultaResponseRegistro Consultar()
        {
            ConsultaResponseRegistro responde;
            try
            {
                List<Registro> registros = repositoryRegistro.Consultar();
                if (registros != null)
                {
                    return responde = new ConsultaResponseRegistro(registros);
                }
                else
                {
                    return responde = new ConsultaResponseRegistro("no Existe cliente en la lista");
                }
            }
            catch (Exception exception)
            {
                return responde = new ConsultaResponseRegistro("Error de aplicacion" + exception.Message);
            }

        }
    }

    public class ConsultaResponseRegistro
    {
        public List<Registro> Registros { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaResponseRegistro(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

        public ConsultaResponseRegistro(List<Registro> registros)
        {
            Registros = registros;
            Error = false;
        }
    }
}
