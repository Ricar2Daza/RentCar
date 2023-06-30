
namespace PresentacionGUI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxRegistrarCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxConsultarClientes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxEliminarCliente = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegistrarVehiculo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxConsultarVehiculos = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxEliminarVehiculo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxRegistrarRenta = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBoxEliminarCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxConsultarClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxRegistrarCliente);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 461);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBoxRegistrarRenta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBoxEliminarVehiculo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBoxConsultarVehiculos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBoxRegistrarVehiculo);
            this.panel2.Controls.Add(this.pictureBoxSalir);
            this.panel2.Location = new System.Drawing.Point(397, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 460);
            this.panel2.TabIndex = 6;
            // 
            // pictureBoxRegistrarCliente
            // 
            this.pictureBoxRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrarCliente.Image")));
            this.pictureBoxRegistrarCliente.Location = new System.Drawing.Point(40, 50);
            this.pictureBoxRegistrarCliente.Name = "pictureBoxRegistrarCliente";
            this.pictureBoxRegistrarCliente.Size = new System.Drawing.Size(118, 75);
            this.pictureBoxRegistrarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrarCliente.TabIndex = 5;
            this.pictureBoxRegistrarCliente.TabStop = false;
            this.pictureBoxRegistrarCliente.Click += new System.EventHandler(this.pictureBoxRegistrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registrar Cliente";
            // 
            // pictureBoxConsultarClientes
            // 
            this.pictureBoxConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsultarClientes.Image")));
            this.pictureBoxConsultarClientes.Location = new System.Drawing.Point(220, 50);
            this.pictureBoxConsultarClientes.Name = "pictureBoxConsultarClientes";
            this.pictureBoxConsultarClientes.Size = new System.Drawing.Size(118, 75);
            this.pictureBoxConsultarClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsultarClientes.TabIndex = 7;
            this.pictureBoxConsultarClientes.TabStop = false;
            this.pictureBoxConsultarClientes.Click += new System.EventHandler(this.pictureBoxConsultarClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Consultar Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Eliminar Cliente";
            // 
            // pictureBoxEliminarCliente
            // 
            this.pictureBoxEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEliminarCliente.Image")));
            this.pictureBoxEliminarCliente.Location = new System.Drawing.Point(133, 211);
            this.pictureBoxEliminarCliente.Name = "pictureBoxEliminarCliente";
            this.pictureBoxEliminarCliente.Size = new System.Drawing.Size(118, 75);
            this.pictureBoxEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEliminarCliente.TabIndex = 10;
            this.pictureBoxEliminarCliente.TabStop = false;
            this.pictureBoxEliminarCliente.Click += new System.EventHandler(this.pictureBoxEliminarCliente_Click);
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(352, 3);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(52, 44);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSalir.TabIndex = 11;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // pictureBoxRegistrarVehiculo
            // 
            this.pictureBoxRegistrarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrarVehiculo.Image")));
            this.pictureBoxRegistrarVehiculo.Location = new System.Drawing.Point(62, 50);
            this.pictureBoxRegistrarVehiculo.Name = "pictureBoxRegistrarVehiculo";
            this.pictureBoxRegistrarVehiculo.Size = new System.Drawing.Size(116, 75);
            this.pictureBoxRegistrarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrarVehiculo.TabIndex = 12;
            this.pictureBoxRegistrarVehiculo.TabStop = false;
            this.pictureBoxRegistrarVehiculo.Click += new System.EventHandler(this.pictureBoxRegistrarVehiculo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registrar Vehiculo";
            // 
            // pictureBoxConsultarVehiculos
            // 
            this.pictureBoxConsultarVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsultarVehiculos.Image")));
            this.pictureBoxConsultarVehiculos.Location = new System.Drawing.Point(237, 50);
            this.pictureBoxConsultarVehiculos.Name = "pictureBoxConsultarVehiculos";
            this.pictureBoxConsultarVehiculos.Size = new System.Drawing.Size(121, 75);
            this.pictureBoxConsultarVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsultarVehiculos.TabIndex = 14;
            this.pictureBoxConsultarVehiculos.TabStop = false;
            this.pictureBoxConsultarVehiculos.Click += new System.EventHandler(this.pictureBoxConsultarVehiculos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consultar Vehiculos";
            // 
            // pictureBoxEliminarVehiculo
            // 
            this.pictureBoxEliminarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEliminarVehiculo.Image")));
            this.pictureBoxEliminarVehiculo.Location = new System.Drawing.Point(237, 211);
            this.pictureBoxEliminarVehiculo.Name = "pictureBoxEliminarVehiculo";
            this.pictureBoxEliminarVehiculo.Size = new System.Drawing.Size(121, 75);
            this.pictureBoxEliminarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEliminarVehiculo.TabIndex = 16;
            this.pictureBoxEliminarVehiculo.TabStop = false;
            this.pictureBoxEliminarVehiculo.Click += new System.EventHandler(this.pictureBoxEliminarVehiculo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Eliminar Vehiculo";
            // 
            // pictureBoxRegistrarRenta
            // 
            this.pictureBoxRegistrarRenta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrarRenta.Image")));
            this.pictureBoxRegistrarRenta.Location = new System.Drawing.Point(62, 211);
            this.pictureBoxRegistrarRenta.Name = "pictureBoxRegistrarRenta";
            this.pictureBoxRegistrarRenta.Size = new System.Drawing.Size(116, 75);
            this.pictureBoxRegistrarRenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrarRenta.TabIndex = 18;
            this.pictureBoxRegistrarRenta.TabStop = false;
            this.pictureBoxRegistrarRenta.Click += new System.EventHandler(this.pictureBoxRegistrarRenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Registrar Renta";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarRenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRegistrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxConsultarClientes;
        private System.Windows.Forms.PictureBox pictureBoxEliminarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxRegistrarVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxConsultarVehiculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxEliminarVehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxRegistrarRenta;
    }
}

