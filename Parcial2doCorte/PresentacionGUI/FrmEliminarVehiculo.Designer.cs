
namespace PresentacionGUI
{
    partial class FrmEliminarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarVehiculo));
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKilometrajeA = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.comboBoxDescripcion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxAyuda = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxEliminarVehiculo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "IDENTIFICACION:";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Enabled = false;
            this.textBoxIdentificacion.Location = new System.Drawing.Point(139, 125);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdentificacion.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "KILOMETRAJE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "PLACA:";
            // 
            // textBoxKilometrajeA
            // 
            this.textBoxKilometrajeA.Enabled = false;
            this.textBoxKilometrajeA.Location = new System.Drawing.Point(139, 253);
            this.textBoxKilometrajeA.Name = "textBoxKilometrajeA";
            this.textBoxKilometrajeA.Size = new System.Drawing.Size(118, 20);
            this.textBoxKilometrajeA.TabIndex = 28;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(139, 66);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(118, 20);
            this.textBoxPlaca.TabIndex = 27;
            this.textBoxPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaca_KeyPress);
            // 
            // comboBoxDescripcion
            // 
            this.comboBoxDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescripcion.Enabled = false;
            this.comboBoxDescripcion.FormattingEnabled = true;
            this.comboBoxDescripcion.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Negro",
            "Verde",
            "Blanco",
            "Amarillo ",
            "Marron"});
            this.comboBoxDescripcion.Location = new System.Drawing.Point(139, 195);
            this.comboBoxDescripcion.Name = "comboBoxDescripcion";
            this.comboBoxDescripcion.Size = new System.Drawing.Size(118, 21);
            this.comboBoxDescripcion.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.pictureBoxEliminarVehiculo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBoxAyuda);
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
            this.panel1.Size = new System.Drawing.Size(580, 368);
            this.panel1.TabIndex = 34;
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(347, 195);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolver.TabIndex = 35;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Volver";
            // 
            // pictureBoxAyuda
            // 
            this.pictureBoxAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAyuda.Image")));
            this.pictureBoxAyuda.Location = new System.Drawing.Point(489, 3);
            this.pictureBoxAyuda.Name = "pictureBoxAyuda";
            this.pictureBoxAyuda.Size = new System.Drawing.Size(88, 50);
            this.pictureBoxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAyuda.TabIndex = 36;
            this.pictureBoxAyuda.TabStop = false;
            this.pictureBoxAyuda.Click += new System.EventHandler(this.pictureBoxAyuda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eliminar Vehiculo";
            // 
            // pictureBoxEliminarVehiculo
            // 
            this.pictureBoxEliminarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEliminarVehiculo.Image")));
            this.pictureBoxEliminarVehiculo.Location = new System.Drawing.Point(347, 73);
            this.pictureBoxEliminarVehiculo.Name = "pictureBoxEliminarVehiculo";
            this.pictureBoxEliminarVehiculo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEliminarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEliminarVehiculo.TabIndex = 38;
            this.pictureBoxEliminarVehiculo.TabStop = false;
            this.pictureBoxEliminarVehiculo.Click += new System.EventHandler(this.pictureBoxEliminarVehiculo_Click);
            // 
            // FrmEliminarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmEliminarVehiculo";
            this.Text = "FrmEliminarVehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKilometrajeA;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxAyuda;
        private System.Windows.Forms.PictureBox pictureBoxEliminarVehiculo;
        private System.Windows.Forms.Label label6;
    }
}