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
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }


        public void LlenarGridClientes()
        {
            ServiceCliente clienteService = new ServiceCliente();
            var clienteConsultaResponse = clienteService.Consultar();
            if (clienteConsultaResponse.Error)
            {
                MessageBox.Show(clienteConsultaResponse.Mensaje, "Error");
            }
            else
            {
                dataGridViewConsulta.DataSource = clienteConsultaResponse.Clientes;
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     //   private void pictureBoxConsultar_Click(object sender, EventArgs e)
        //{
          //  LlenarGridClientes();
     //   }

      

        private void dataGridViewConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarGridClientes();
        }

        private void pictureBoxConsultar_Click(object sender, EventArgs e)
        {
            LlenarGridClientes();
        }
    }
}
