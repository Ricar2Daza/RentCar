
namespace PresentacionGUI
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.textBoxPersona = new System.Windows.Forms.TextBox();
            this.textBoxValorKm = new System.Windows.Forms.TextBox();
            this.textBoxKM = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.pictureBoxAyuda = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsultarLista = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuardarRenta = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardarRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBoxGuardarRenta);
            this.panel1.Controls.Add(this.pictureBoxConsultarLista);
            this.panel1.Controls.Add(this.pictureBoxVolver);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBoxAyuda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxIdentificacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeFechaRegistro);
            this.panel1.Controls.Add(this.textBoxPersona);
            this.panel1.Controls.Add(this.textBoxValorKm);
            this.panel1.Controls.Add(this.textBoxKM);
            this.panel1.Controls.Add(this.textBoxPlaca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 458);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "IDENTIFICACION";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Location = new System.Drawing.Point(47, 59);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(127, 20);
            this.textBoxIdentificacion.TabIndex = 28;
            this.textBoxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificacion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "TOTAL";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(343, 129);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(111, 20);
            this.textBoxTotal.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "PERSONA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "VALOR KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "KILOMETROS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "PLACA";
            // 
            // dateTimeFechaRegistro
            // 
            this.dateTimeFechaRegistro.Enabled = false;
            this.dateTimeFechaRegistro.Location = new System.Drawing.Point(144, 201);
            this.dateTimeFechaRegistro.Name = "dateTimeFechaRegistro";
            this.dateTimeFechaRegistro.Size = new System.Drawing.Size(216, 20);
            this.dateTimeFechaRegistro.TabIndex = 19;
            this.dateTimeFechaRegistro.Value = new System.DateTime(2022, 6, 5, 23, 9, 55, 0);
            // 
            // textBoxPersona
            // 
            this.textBoxPersona.Enabled = false;
            this.textBoxPersona.Location = new System.Drawing.Point(200, 129);
            this.textBoxPersona.Name = "textBoxPersona";
            this.textBoxPersona.Size = new System.Drawing.Size(111, 20);
            this.textBoxPersona.TabIndex = 18;
            // 
            // textBoxValorKm
            // 
            this.textBoxValorKm.Enabled = false;
            this.textBoxValorKm.Location = new System.Drawing.Point(345, 59);
            this.textBoxValorKm.Name = "textBoxValorKm";
            this.textBoxValorKm.Size = new System.Drawing.Size(108, 20);
            this.textBoxValorKm.TabIndex = 17;
            // 
            // textBoxKM
            // 
            this.textBoxKM.Enabled = false;
            this.textBoxKM.Location = new System.Drawing.Point(191, 59);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(119, 20);
            this.textBoxKM.TabIndex = 16;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(66, 129);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaca.TabIndex = 15;
            this.textBoxPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaca_KeyPress);
            // 
            // pictureBoxAyuda
            // 
            this.pictureBoxAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAyuda.Image")));
            this.pictureBoxAyuda.Location = new System.Drawing.Point(456, 0);
            this.pictureBoxAyuda.Name = "pictureBoxAyuda";
            this.pictureBoxAyuda.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAyuda.TabIndex = 31;
            this.pictureBoxAyuda.TabStop = false;
            this.pictureBoxAyuda.Click += new System.EventHandler(this.pictureBoxAyuda_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Consultar Lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Volver";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Guardar Renta";
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(354, 294);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolver.TabIndex = 35;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // pictureBoxConsultarLista
            // 
            this.pictureBoxConsultarLista.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsultarLista.Image")));
            this.pictureBoxConsultarLista.Location = new System.Drawing.Point(218, 294);
            this.pictureBoxConsultarLista.Name = "pictureBoxConsultarLista";
            this.pictureBoxConsultarLista.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxConsultarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConsultarLista.TabIndex = 36;
            this.pictureBoxConsultarLista.TabStop = false;
            this.pictureBoxConsultarLista.Click += new System.EventHandler(this.pictureBoxConsultarLista_Click);
            // 
            // pictureBoxGuardarRenta
            // 
            this.pictureBoxGuardarRenta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuardarRenta.Image")));
            this.pictureBoxGuardarRenta.Location = new System.Drawing.Point(74, 294);
            this.pictureBoxGuardarRenta.Name = "pictureBoxGuardarRenta";
            this.pictureBoxGuardarRenta.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGuardarRenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGuardarRenta.TabIndex = 37;
            this.pictureBoxGuardarRenta.TabStop = false;
            this.pictureBoxGuardarRenta.Click += new System.EventHandler(this.pictureBoxGuardarRenta_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultarLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardarRenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPersona;
        private System.Windows.Forms.TextBox textBoxValorKm;
        private System.Windows.Forms.TextBox textBoxKM;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.PictureBox pictureBoxAyuda;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxGuardarRenta;
        private System.Windows.Forms.PictureBox pictureBoxConsultarLista;
    }
}