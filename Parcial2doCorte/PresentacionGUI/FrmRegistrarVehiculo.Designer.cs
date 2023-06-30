
namespace PresentacionGUI
{
    partial class FrmRegistrarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarVehiculo));
            this.comboBoxDescripcion = new System.Windows.Forms.ComboBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKilometrajeA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxRegistrarVehiculo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDescripcion
            // 
            this.comboBoxDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescripcion.FormattingEnabled = true;
            this.comboBoxDescripcion.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Negro",
            "Verde",
            "Blanco",
            "Amarillo ",
            "Marron"});
            this.comboBoxDescripcion.Location = new System.Drawing.Point(159, 203);
            this.comboBoxDescripcion.Name = "comboBoxDescripcion";
            this.comboBoxDescripcion.Size = new System.Drawing.Size(115, 21);
            this.comboBoxDescripcion.TabIndex = 0;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(156, 139);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(118, 20);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // textBoxKilometrajeA
            // 
            this.textBoxKilometrajeA.Location = new System.Drawing.Point(159, 265);
            this.textBoxKilometrajeA.Name = "textBoxKilometrajeA";
            this.textBoxKilometrajeA.Size = new System.Drawing.Size(115, 20);
            this.textBoxKilometrajeA.TabIndex = 2;
            this.textBoxKilometrajeA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKilometrajeA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "KILOMETRAJE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PLACA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "IDENTIFICACION:";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Location = new System.Drawing.Point(156, 73);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdentificacion.TabIndex = 11;
            this.textBoxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificacion_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBoxRegistrarVehiculo);
            this.panel1.Controls.Add(this.pictureBoxVolver);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIdentificacion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxKilometrajeA);
            this.panel1.Controls.Add(this.textBoxPlaca);
            this.panel1.Controls.Add(this.comboBoxDescripcion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 368);
            this.panel1.TabIndex = 13;
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(365, 203);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(100, 53);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolver.TabIndex = 14;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Volver";
            // 
            // pictureBoxRegistrarVehiculo
            // 
            this.pictureBoxRegistrarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrarVehiculo.Image")));
            this.pictureBoxRegistrarVehiculo.Location = new System.Drawing.Point(365, 76);
            this.pictureBoxRegistrarVehiculo.Name = "pictureBoxRegistrarVehiculo";
            this.pictureBoxRegistrarVehiculo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRegistrarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrarVehiculo.TabIndex = 15;
            this.pictureBoxRegistrarVehiculo.TabStop = false;
            this.pictureBoxRegistrarVehiculo.Click += new System.EventHandler(this.pictureBoxRegistrarVehiculo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Registrar Vehiculo";
            // 
            // FrmRegistrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrarVehiculo";
            this.Text = "FrmRegistrarVehiculo";
            this.Load += new System.EventHandler(this.FrmRegistrarVehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrarVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxKilometrajeA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxRegistrarVehiculo;
        private System.Windows.Forms.Label label6;
    }
}