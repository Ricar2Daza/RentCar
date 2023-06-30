
namespace PresentacionGUI
{
    partial class FrmConsultaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaRegistro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.dateTimePrimera = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFiltro = new System.Windows.Forms.DateTimePicker();
            this.dataGridRegistro = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxVolver);
            this.panel1.Controls.Add(this.dateTimePrimera);
            this.panel1.Controls.Add(this.dateTimeFiltro);
            this.panel1.Controls.Add(this.dataGridRegistro);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 451);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volver";
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(313, 328);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolver.TabIndex = 3;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // dateTimePrimera
            // 
            this.dateTimePrimera.Location = new System.Drawing.Point(50, 49);
            this.dateTimePrimera.Name = "dateTimePrimera";
            this.dateTimePrimera.Size = new System.Drawing.Size(200, 20);
            this.dateTimePrimera.TabIndex = 2;
            // 
            // dateTimeFiltro
            // 
            this.dateTimeFiltro.Location = new System.Drawing.Point(305, 49);
            this.dateTimeFiltro.Name = "dateTimeFiltro";
            this.dateTimeFiltro.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFiltro.TabIndex = 1;
            // 
            // dataGridRegistro
            // 
            this.dataGridRegistro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistro.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridRegistro.Location = new System.Drawing.Point(34, 102);
            this.dataGridRegistro.Name = "dataGridRegistro";
            this.dataGridRegistro.Size = new System.Drawing.Size(471, 187);
            this.dataGridRegistro.TabIndex = 0;
            // 
            // FrmConsultaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultaRegistro";
            this.Text = "FrmConsultaRegistro";
            this.Load += new System.EventHandler(this.FrmConsultaRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridRegistro;
        private System.Windows.Forms.DateTimePicker dateTimeFiltro;
        private System.Windows.Forms.DateTimePicker dateTimePrimera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
    }
}