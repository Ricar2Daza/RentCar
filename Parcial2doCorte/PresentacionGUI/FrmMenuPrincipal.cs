using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void pictureBoxRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmGuardarCliente frmGuardarCliente = new FrmGuardarCliente();
            frmGuardarCliente.ShowDialog();
        }

        private void pictureBoxConsultarClientes_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frmConsultarCliente = new FrmConsultarCliente();
            frmConsultarCliente.ShowDialog();
        }

        private void pictureBoxEliminarCliente_Click(object sender, EventArgs e)
        {
            FrmEliminarCliente frmEliminarCliente = new FrmEliminarCliente();
            frmEliminarCliente.ShowDialog();
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            FrmRegistrarVehiculo frmRegistrarVehiculo = new FrmRegistrarVehiculo();
            frmRegistrarVehiculo.ShowDialog();
        }

        private void pictureBoxConsultarVehiculos_Click(object sender, EventArgs e)
        {
            FrmConsultarVehiculos frmConsultarVehiculos = new FrmConsultarVehiculos();
            frmConsultarVehiculos.ShowDialog();
        }

        private void pictureBoxEliminarVehiculo_Click(object sender, EventArgs e)
        {
            FrmEliminarVehiculo frmEliminarVehiculo = new FrmEliminarVehiculo();
            frmEliminarVehiculo.ShowDialog();
        }

        private void pictureBoxRegistrarRenta_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();
        }
    }
}
