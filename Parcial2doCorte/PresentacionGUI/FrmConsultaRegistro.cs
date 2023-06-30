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
    public partial class FrmConsultaRegistro : Form
    {
        public FrmConsultaRegistro()
        {
            InitializeComponent();
        }

        private void FrmConsultaRegistro_Load(object sender, EventArgs e)
        {
            ServiceRegistro serviceRegistro = new ServiceRegistro();
            var registroConsultaResponse = serviceRegistro.Consultar();
            if (registroConsultaResponse.Error)
            {
                MessageBox.Show(registroConsultaResponse.Mensaje, "Error");
            }
            else
            {
                dataGridRegistro.DataSource = registroConsultaResponse.Registros;
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //string inicio, final;
        //public void FiltroFecha()
        //{
        //    do
        //    {

        //    } while (true);

        //}

        //private void dateTimeFiltro_ValueChanged(object sender, EventArgs e)
        //{
        //    final = dateTimeFiltro.Value.Date.ToString("dd-MM-yyyy");
        //}

        //private void dateTimePrimera_ValueChanged(object sender, EventArgs e)
        //{
        //    inicio = dateTimePrimera.Value.Date.ToString("dd-MM-yyyy");
        //}


    }
}
