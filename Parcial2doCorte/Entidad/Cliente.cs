using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        string identificacion;
        string nombreCliente;
        string tipoCliente;

        public Cliente()
        {
        }

        public Cliente(string identificacion, string nombreCliente, string tipoCliente)
        {
            Identificacion = identificacion;
            NombreCliente = nombreCliente;
            TipoCliente = tipoCliente;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }

    }
}
