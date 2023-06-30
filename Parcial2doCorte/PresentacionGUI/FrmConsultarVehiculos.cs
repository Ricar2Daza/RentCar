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
    public partial class FrmConsultarVehiculos : Form
    {
        public FrmConsultarVehiculos()
        {
            InitializeComponent();
        }


        public void LlenarGridVehiculos()
        {
            ServiceVehiculo serviceVehiculo = new ServiceVehiculo();
            var vehiculoConsultaResponse = serviceVehiculo.Consultar();
            if (vehiculoConsultaResponse.Error)
            {
                MessageBox.Show(vehiculoConsultaResponse.Mensaje, "Error");
            }
            else
            {
                dataGridViewConsultaVehiculos.DataSource = vehiculoConsultaResponse.Vehiculos;
            }
        }


        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxConsultarVehiculos_Click(object sender, EventArgs e)
        {
            LlenarGridVehiculos();
        }
    }
}
