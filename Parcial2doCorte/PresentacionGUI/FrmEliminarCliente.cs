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
    public partial class FrmEliminarCliente : Form
    {
        public FrmEliminarCliente()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBoxIdentificacion.Text = "";
            textBoxNombre.Text = "";
            comboBoxTipo.Text = "";
        }


        public void EliminarCliente(Cliente cliente)
        {
            ServiceCliente clienteService = new ServiceCliente();
            string mensaje = clienteService.Eliminar(cliente.Identificacion);
            MessageBox.Show(mensaje);
        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarCliente(textBoxIdentificacion.Text);
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

        public void Ver(ClienteResponde cliente)
        {
            textBoxIdentificacion.Text = cliente.Cliente.Identificacion;
            textBoxNombre.Text = cliente.Cliente.NombreCliente;
            comboBoxTipo.Text = cliente.Cliente.TipoCliente;
        }



        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo ingrese letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxEliminarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdentificacion.Text == "" || textBoxNombre.Text == "" || comboBoxTipo.Text == "")
            {
                MessageBox.Show("Por favor ingrese la identificacion y luego pulse ENTER");
            }
            else
            {
                EliminarCliente(new Cliente(textBoxIdentificacion.Text, textBoxNombre.Text, comboBoxTipo.Text));
                Limpiar();
            }
        }

        private void pictureBoxAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Ingresa la identificacion del cliente.\n2. Pulsa Enter.\n3. Por ultimo presione eliminar.", "Info", MessageBoxButtons.OK);
        }
    }
}
