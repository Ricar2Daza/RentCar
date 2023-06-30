using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace PresentacionGUI
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

      

        //trae al vehiculo
        private void textBoxPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarVehiculo(textBoxPlaca.Text);
            }
        }

        public void BuscarVehiculo(string placa)
        {
            ServiceVehiculo serviceVehiculo = new ServiceVehiculo();
            VehiculoResponde vehiculoResponde = serviceVehiculo.ConsultarVehiculo(placa);
            if (!vehiculoResponde.Error)
            {
                Ver(vehiculoResponde);
                return;
            }
            else
            {
                MessageBox.Show("No encontrado");
                return;
            }
        }

        public void Ver(VehiculoResponde vehiculo)
        {
            textBoxPlaca.Text = vehiculo.Vehiculo.Placa;
            textBoxKM.Text = Convert.ToString(vehiculo.Vehiculo.KilometrajeActual);
            textBoxTotal.Text = Total();
        }

        //trae cliente
        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarCliente(textBoxIdentificacion.Text);
            }

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void BuscarCliente(string identificacion)
        {
            
            ServiceCliente clienteService = new ServiceCliente();
            ClienteResponde clienteResponde = clienteService.ConsultarCliente(identificacion);

            if (!clienteResponde.Error)
            {
                Ver(clienteResponde);
                return;
            }
            else
            {
                MessageBox.Show("No encontrado");
                return;
            }
        }

        //busca el tipo de cliente
        public string Tipo()
        {
            ServiceCliente clienteService = new ServiceCliente();
            ClienteResponde clienteResponde = clienteService.ConsultarCliente(textBoxIdentificacion.Text);

            if (clienteResponde.Cliente.TipoCliente.Equals("Ocasional"))
            {
                int ocacional = 100;
                textBoxValorKm.Text = Convert.ToString(ocacional);
            }
            if (clienteResponde.Cliente.TipoCliente.Equals("Contrato"))
            {
                int ocacional = 85;
                textBoxValorKm.Text = Convert.ToString(ocacional);
            }

            return textBoxValorKm.Text;
        }

        //calcula el total
        public string Total()
        {
            ServiceVehiculo serviceVehiculo = new ServiceVehiculo();
            VehiculoResponde vehiculoResponde = serviceVehiculo.ConsultarVehiculo(textBoxPlaca.Text);
            int km, valorkm, total;
            km = vehiculoResponde.Vehiculo.KilometrajeActual;

            valorkm = int.Parse(textBoxValorKm.Text);

            total = km * valorkm;

            textBoxTotal.Text = Convert.ToString(total);

            return textBoxTotal.Text;
        }

        public void Ver(ClienteResponde cliente)
        {
            textBoxIdentificacion.Text = cliente.Cliente.Identificacion;
            textBoxPersona.Text = cliente.Cliente.NombreCliente;
            textBoxValorKm.Text = Tipo();
        }



        public void GuardarRegistro(Registro registro)
        {
            ServiceRegistro serviceRegistro = new ServiceRegistro();
            string mensaje = serviceRegistro.Guardar(textBoxPlaca.Text, registro);
            MessageBox.Show(mensaje);
        }

        public void Limpiar()
        {
            textBoxPlaca.Text = "";
            textBoxIdentificacion.Text = "";
            textBoxKM.Text = "";
            textBoxPersona.Text = "";
            textBoxTotal.Text = "";
            textBoxValorKm.Text = "";
        }

    

        private void pictureBoxAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa cada campo desde identificaión pulsando ENTER. \n", "Info", MessageBoxButtons.OK);
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxConsultarLista_Click(object sender, EventArgs e)
        {
            FrmConsultaRegistro frmConsultaRegistro = new FrmConsultaRegistro();
            frmConsultaRegistro.ShowDialog();
        }

        private void pictureBoxGuardarRenta_Click(object sender, EventArgs e)
        {
            if (textBoxIdentificacion.Text == "" || textBoxPersona.Text == "" || textBoxValorKm.Text == "")
            {
                MessageBox.Show("Por favor ingrese la identificacion y luego pulse ENTER");

                if (textBoxPlaca.Text == "" || textBoxKM.Text == "" || textBoxTotal.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la placa y luego pulse ENTER");
                }
            }
            else
            {
                GuardarRegistro(new Registro(textBoxPlaca.Text, int.Parse(textBoxKM.Text), int.Parse(textBoxValorKm.Text), textBoxPersona.Text, dateTimeFechaRegistro.Text = DateTime.Now.ToString("dd-MM-yyyy"), int.Parse(textBoxTotal.Text)));
                Limpiar();
            }
        }
    }
}
