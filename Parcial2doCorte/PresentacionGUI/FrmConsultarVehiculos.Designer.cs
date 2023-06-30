
namespace PresentacionGUI
{
    partial class FrmConsultarVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVehiculos));
            this.dataGridViewConsultaVehiculos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxConsultarVehiculos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaVehiculos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsultaVehiculos
            // 
            this.dataGridViewConsultaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaVehiculos.Location = new System.Drawing.Point(67, 45);
            this.dataGridViewConsultaVehiculos.Name = "dataGridViewConsultaVehiculos";
            this.dataGridViewConsultaVehiculos.Size = new System.Drawing.Size(357, 187);
            this.dataGridViewConsultaVehiculos.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBoxConsultarVehiculos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxVolver);
            this.panel1.Controls.Add(this.dataGridViewConsultaVehiculos);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 412);
            this.panel1.TabIndex = 12;
            // 
            // pictureBoxConsultarVehiculos
            // 
            this.pictureBoxConsultarVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsultarVehiculos.Image")));
            this.pictureBoxConsultarVehiculos.Location = new System.Drawing.Point(97, 269);
            this.pictureBoxConsultarVehiculos.Name = "pictureBoxConsultarVehiculos";
            this.pictureBoxConsultarVehiculos.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxConsultarVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsultarVehiculos.TabIndex = 19;
            this.pictureBoxConsultarVehiculos.TabStop = false;
            this.pictureBoxConsultarVehiculos.Click += new System.EventHandler(this.pictureBoxConsultarVehiculos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Consultar Vehiculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Volver";
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(269, 269);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolver.TabIndex = 16;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // FrmConsultarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultarVehiculos";
            this.Text = "FrmConsultarVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaVehiculos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewConsultaVehiculos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxConsultarVehiculos;
        private System.Windows.Forms.Label label2;
    }
}