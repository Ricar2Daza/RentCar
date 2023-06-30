using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Registro
    {
        string placa;
        int km;
        int valorKm;
        string nombre;
        string fecha;
        int total;

        public Registro()
        {
        }

        public Registro(string placa, int km, int valorKm, string nombre, string fecha, int total)
        {
            Placa = placa;
            Km = km;
            ValorKm = valorKm;
            Nombre = nombre;
            Fecha = fecha;
            Total = total;
        }

        public string Placa { get => placa; set => placa = value; }
        public int Km { get => km; set => km = value; }
        public int ValorKm { get => valorKm; set => valorKm = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Total { get => total; set => total = value; }

        public int contrato = 15;

    }
}
