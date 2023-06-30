using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ServiceCliente
    {
        private RepositoryCliente clienteRepository;

        public ServiceCliente()
        {
            clienteRepository = new RepositoryCliente();
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                if (clienteRepository.Buscar(cliente.Identificacion) == null)
                {
                    clienteRepository.Guardar(cliente);
                    return $"Se guardo sactifactoriamente los datos de: {cliente.NombreCliente}";
                }
                else
                {
                    return $"Lo sentimos, ya se encuentra un cliente registrada con la identificacion: {cliente.Identificacion}";
                }


            }
            catch (Exception e)
            {
                return "Error de aplicacion:" + e.Message;
            }
        }

        public ConsultaResponse Consultar()
        {
            ConsultaResponse responde;
            try
            {
                List<Cliente> clientes = clienteRepository.Consultar();
                if (clientes != null)
                {
                    return responde = new ConsultaResponse(clientes);
                }
                else
                {
                    return responde = new ConsultaResponse("no Existe cliente en la lista");
                }
            }
            catch (Exception exception)
            {
                return responde = new ConsultaResponse("Error de aplicacion" + exception.Message);

            }

        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (clienteRepository.Buscar(identificacion) != null)
                {
                    clienteRepository.Eliminar(identificacion);
                    return ($"Se han eliminado satifactoriamente los datos, del cliente con identificacion: {identificacion}");
                }
                else
                {
                    return ($"lo sentimos, no se encuentra registrada un cliente con identificacion: {identificacion} ");
                }
            }
            catch (Exception exception)
            {

                return "Error en la aplicacion" + exception.Message;
            }
        }

        public ClienteResponde ConsultarCliente(string identificacion)
        {
            try
            {
                Cliente cliente = clienteRepository.Buscar(identificacion);
                if (cliente != null)
                {
                    return new ClienteResponde(cliente);
                }
                else
                {
                    return new ClienteResponde("El cliente buscado no se encuentra Registrado");
                }
            }
            catch (Exception e)
            {
                return new ClienteResponde("Error de Aplicacion: " + e.Message);
            }
        }

        public string ConsultarTipo(string identificacion)
        {
            try
            {
                Cliente cliente = clienteRepository.Buscar(identificacion);


                if (cliente != null)
                {
                    return cliente.TipoCliente;
                }
                else
                {
                    return "El cliente buscado no se encuentra Registrado";
                }
            }
            catch (Exception e)
            {
                return "Error de Aplicacion: " + e.Message;
            }
        }

    }

    public class ConsultaResponse
    {
        public List<Cliente> Clientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

        public ConsultaResponse(List<Cliente> clientes)
        {
            Clientes = clientes;
            Error = false;
        }
    }

    public class ClienteResponde
    {
        public Cliente Cliente { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ClienteResponde(Cliente cliente)
        {
            Cliente = cliente;
            Error = false;
        }

        public ClienteResponde(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;

        }

        public ClienteResponde()
        {
        }
    }
}
