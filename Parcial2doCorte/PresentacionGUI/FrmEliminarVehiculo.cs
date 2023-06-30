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
    public partial class FrmEliminarVehiculo : Form
    {
        public FrmEliminarVehiculo()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBoxIdentificacion.Text = "";
            textBoxPlaca.Text = "";
            textBoxKilometrajeA.Text = "";
            comboBoxDescripcion.Text = "";
        }


        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            ServiceVehiculo serviceVehiculo = new ServiceVehiculo();
            string mensaje = serviceVehiculo.Eliminar(vehiculo.Placa);
            MessageBox.Show(mensaje);
        }

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
            textBoxIdentificacion.Text = vehiculo.Vehiculo.IdCliente;
            textBoxPlaca.Text = vehiculo.Vehiculo.Placa;
            comboBoxDescripcion.Text = vehiculo.Vehiculo.DescrpcionVehiculo;
            textBoxKilometrajeA.Text = Convert.ToString(vehiculo.Vehiculo.KilometrajeActual);
        }



        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Ingresa la placa del vehiculo que desee eliminar.\n2.Pulsa Enter.\n3.Por ultimo presione eliminar.", "Info", MessageBoxButtons.OK);
        }

        private void pictureBoxEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (textBoxIdentificacion.Text == "" || textBoxPlaca.Text == "" || textBoxKilometrajeA.Text == "" || comboBoxDescripcion.Text == "")
            {
                MessageBox.Show("Por favor ingrese la placa y luego pulse ENTER");
            }
            else
            {
                EliminarVehiculo(new Vehiculo(textBoxPlaca.Text, textBoxIdentificacion.Text, comboBoxDescripcion.Text, int.Parse(textBoxKilometrajeA.Text)));
                Limpiar();
            }
        }
    }
}