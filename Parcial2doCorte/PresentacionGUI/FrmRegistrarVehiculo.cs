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
    public partial class FrmRegistrarVehiculo : Form
    {
        public FrmRegistrarVehiculo()
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


   
        public void Guardar(Vehiculo vehiculo)
        {
            ClienteResponde clienteResponde = new ClienteResponde();
            ServiceVehiculo serviceVehiculo = new ServiceVehiculo();
            if (int.Parse(textBoxKilometrajeA.Text) <= 0)
            {
                MessageBox.Show("Ingresa un valor mayor a cero");
                Limpiar();
            }

            else
            {
                string mensaje = serviceVehiculo.Guardar(textBoxIdentificacion.Text, vehiculo);
                MessageBox.Show(mensaje);
            }
        }

        private void FrmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
           
        }

        public void SoloNumero(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void textBoxKilometrajeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            if (textBoxPlaca.Text == "" || textBoxIdentificacion.Text == "" || comboBoxDescripcion.Text == "" || textBoxKilometrajeA.Text == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos y pulse luego Guardar");
            }
            else
            {
                Guardar(new Vehiculo(textBoxPlaca.Text, textBoxIdentificacion.Text, comboBoxDescripcion.Text, int.Parse(textBoxKilometrajeA.Text)));
                Limpiar();
            }
        }
    }
}
