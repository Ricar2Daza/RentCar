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
    public partial class FrmGuardarCliente : Form
    {
        public FrmGuardarCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            textBoxNombre.Text = "";
            textBoxIdentificacion.Text = "";
            comboBoxTipo.Text = "";
        }

    
        public void GuardarCliente(Cliente cliente)
        {
            ServiceCliente clienteService = new ServiceCliente();
            string mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje);
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

        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxIdentificacion.Text == "" || comboBoxTipo.Text == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos y pulse luego Guardar");
            }
            else
            {
                GuardarCliente(new Cliente(textBoxIdentificacion.Text, textBoxNombre.Text, comboBoxTipo.Text));
                Limpiar();
            }
        }
    }
}
