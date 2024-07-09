namespace Proyeccc
{
    partial class OrdenReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditarRESER = new System.Windows.Forms.Button();
            this.btnCancelarRESER = new System.Windows.Forms.Button();
            this.btnNuevoRESER = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtMotivoRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClienteRes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMPRes = new System.Windows.Forms.ComboBox();
            this.btnMostrarRESER = new System.Windows.Forms.Button();
            this.dtpSalidaRes = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaRes = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistroRes = new System.Windows.Forms.DateTimePicker();
            this.txtIDReserva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnBuscarClienteRESER = new System.Windows.Forms.Button();
            this.cbEstadoRES = new System.Windows.Forms.CheckBox();
            this.txtIDClienteRes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarRES = new System.Windows.Forms.Button();
            this.txtPrecioRES = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHabitacionRes = new System.Windows.Forms.ComboBox();
            this.btnAnularRES = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarRESER
            // 
            this.btnEditarRESER.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditarRESER.FlatAppearance.BorderSize = 0;
            this.btnEditarRESER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRESER.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRESER.Location = new System.Drawing.Point(318, 586);
            this.btnEditarRESER.Name = "btnEditarRESER";
            this.btnEditarRESER.Size = new System.Drawing.Size(164, 37);
            this.btnEditarRESER.TabIndex = 36;
            this.btnEditarRESER.Text = "EDITAR";
            this.btnEditarRESER.UseVisualStyleBackColor = false;
            this.btnEditarRESER.Click += new System.EventHandler(this.btnEditarRESER_Click);
            // 
            // btnCancelarRESER
            // 
            this.btnCancelarRESER.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelarRESER.FlatAppearance.BorderSize = 0;
            this.btnCancelarRESER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRESER.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRESER.Location = new System.Drawing.Point(488, 586);
            this.btnCancelarRESER.Name = "btnCancelarRESER";
            this.btnCancelarRESER.Size = new System.Drawing.Size(164, 37);
            this.btnCancelarRESER.TabIndex = 35;
            this.btnCancelarRESER.Text = "CANCELAR";
            this.btnCancelarRESER.UseVisualStyleBackColor = false;
            this.btnCancelarRESER.Click += new System.EventHandler(this.btnCancelarRESER_Click);
            // 
            // btnNuevoRESER
            // 
            this.btnNuevoRESER.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevoRESER.FlatAppearance.BorderSize = 0;
            this.btnNuevoRESER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRESER.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRESER.Location = new System.Drawing.Point(148, 586);
            this.btnNuevoRESER.Name = "btnNuevoRESER";
            this.btnNuevoRESER.Size = new System.Drawing.Size(164, 37);
            this.btnNuevoRESER.TabIndex = 34;
            this.btnNuevoRESER.Text = "NUEVO";
            this.btnNuevoRESER.UseVisualStyleBackColor = false;
            this.btnNuevoRESER.Click += new System.EventHandler(this.btnNuevoRESER_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnAnularRES);
            this.gbDatos.Controls.Add(this.txtPrecioRES);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.btnAgregarRES);
            this.gbDatos.Controls.Add(this.txtIDClienteRes);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.cbEstadoRES);
            this.gbDatos.Controls.Add(this.txtMotivoRes);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtClienteRes);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.cmbMPRes);
            this.gbDatos.Controls.Add(this.btnMostrarRESER);
            this.gbDatos.Controls.Add(this.btnBuscarClienteRESER);
            this.gbDatos.Controls.Add(this.dtpSalidaRes);
            this.gbDatos.Controls.Add(this.dtpEntradaRes);
            this.gbDatos.Controls.Add(this.dtpRegistroRes);
            this.gbDatos.Controls.Add(this.cmbHabitacionRes);
            this.gbDatos.Controls.Add(this.txtIDReserva);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(14, 25);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(773, 279);
            this.gbDatos.TabIndex = 32;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Orden de Reserva";
            // 
            // txtMotivoRes
            // 
            this.txtMotivoRes.Location = new System.Drawing.Point(392, 165);
            this.txtMotivoRes.Multiline = true;
            this.txtMotivoRes.Name = "txtMotivoRes";
            this.txtMotivoRes.Size = new System.Drawing.Size(222, 54);
            this.txtMotivoRes.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Motivo de viaje";
            // 
            // txtClienteRes
            // 
            this.txtClienteRes.Location = new System.Drawing.Point(130, 215);
            this.txtClienteRes.Name = "txtClienteRes";
            this.txtClienteRes.Size = new System.Drawing.Size(123, 23);
            this.txtClienteRes.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cliente";
            // 
            // cmbMPRes
            // 
            this.cmbMPRes.FormattingEnabled = true;
            this.cmbMPRes.Location = new System.Drawing.Point(514, 79);
            this.cmbMPRes.Name = "cmbMPRes";
            this.cmbMPRes.Size = new System.Drawing.Size(100, 25);
            this.cmbMPRes.TabIndex = 28;
            // 
            // btnMostrarRESER
            // 
            this.btnMostrarRESER.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMostrarRESER.FlatAppearance.BorderSize = 0;
            this.btnMostrarRESER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRESER.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRESER.Location = new System.Drawing.Point(633, 200);
            this.btnMostrarRESER.Name = "btnMostrarRESER";
            this.btnMostrarRESER.Size = new System.Drawing.Size(123, 44);
            this.btnMostrarRESER.TabIndex = 27;
            this.btnMostrarRESER.Text = "Mostrar Costo";
            this.btnMostrarRESER.UseVisualStyleBackColor = false;
            this.btnMostrarRESER.Click += new System.EventHandler(this.btnMostrarRESER_Click);
            // 
            // dtpSalidaRes
            // 
            this.dtpSalidaRes.Location = new System.Drawing.Point(130, 152);
            this.dtpSalidaRes.Name = "dtpSalidaRes";
            this.dtpSalidaRes.Size = new System.Drawing.Size(233, 23);
            this.dtpSalidaRes.TabIndex = 25;
            // 
            // dtpEntradaRes
            // 
            this.dtpEntradaRes.Location = new System.Drawing.Point(130, 115);
            this.dtpEntradaRes.Name = "dtpEntradaRes";
            this.dtpEntradaRes.Size = new System.Drawing.Size(234, 23);
            this.dtpEntradaRes.TabIndex = 24;
            // 
            // dtpRegistroRes
            // 
            this.dtpRegistroRes.Location = new System.Drawing.Point(130, 80);
            this.dtpRegistroRes.Name = "dtpRegistroRes";
            this.dtpRegistroRes.Size = new System.Drawing.Size(233, 23);
            this.dtpRegistroRes.TabIndex = 23;
            // 
            // txtIDReserva
            // 
            this.txtIDReserva.Location = new System.Drawing.Point(130, 45);
            this.txtIDReserva.Name = "txtIDReserva";
            this.txtIDReserva.Size = new System.Drawing.Size(123, 23);
            this.txtIDReserva.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Método de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reserva";
            // 
            // dgvReserva
            // 
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserva.ColumnHeadersHeight = 55;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReserva.EnableHeadersVisualStyles = false;
            this.dgvReserva.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvReserva.Location = new System.Drawing.Point(14, 310);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReserva.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserva.Size = new System.Drawing.Size(765, 270);
            this.dgvReserva.TabIndex = 38;
            // 
            // btnBuscarClienteRESER
            // 
            this.btnBuscarClienteRESER.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBuscarClienteRESER.FlatAppearance.BorderSize = 0;
            this.btnBuscarClienteRESER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClienteRESER.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClienteRESER.Location = new System.Drawing.Point(633, 152);
            this.btnBuscarClienteRESER.Name = "btnBuscarClienteRESER";
            this.btnBuscarClienteRESER.Size = new System.Drawing.Size(123, 42);
            this.btnBuscarClienteRESER.TabIndex = 26;
            this.btnBuscarClienteRESER.Text = "Buscar Cliente";
            this.btnBuscarClienteRESER.UseVisualStyleBackColor = false;
            this.btnBuscarClienteRESER.Click += new System.EventHandler(this.btnBuscarClienteRESER_Click);
            // 
            // cbEstadoRES
            // 
            this.cbEstadoRES.AutoSize = true;
            this.cbEstadoRES.Location = new System.Drawing.Point(431, 225);
            this.cbEstadoRES.Name = "cbEstadoRES";
            this.cbEstadoRES.Size = new System.Drawing.Size(125, 21);
            this.cbEstadoRES.TabIndex = 41;
            this.cbEstadoRES.Text = "Estado Reserva";
            this.cbEstadoRES.UseVisualStyleBackColor = true;
            // 
            // txtIDClienteRes
            // 
            this.txtIDClienteRes.Location = new System.Drawing.Point(130, 186);
            this.txtIDClienteRes.Name = "txtIDClienteRes";
            this.txtIDClienteRes.Size = new System.Drawing.Size(123, 23);
            this.txtIDClienteRes.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID Cliente";
            // 
            // btnAgregarRES
            // 
            this.btnAgregarRES.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAgregarRES.FlatAppearance.BorderSize = 0;
            this.btnAgregarRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRES.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRES.Location = new System.Drawing.Point(633, 56);
            this.btnAgregarRES.Name = "btnAgregarRES";
            this.btnAgregarRES.Size = new System.Drawing.Size(123, 42);
            this.btnAgregarRES.TabIndex = 44;
            this.btnAgregarRES.Text = "Agregar Reserva";
            this.btnAgregarRES.UseVisualStyleBackColor = false;
            this.btnAgregarRES.Click += new System.EventHandler(this.btnAgregarRES_Click);
            // 
            // txtPrecioRES
            // 
            this.txtPrecioRES.Location = new System.Drawing.Point(514, 114);
            this.txtPrecioRES.Name = "txtPrecioRES";
            this.txtPrecioRES.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioRES.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Precio";
            // 
            // cmbHabitacionRes
            // 
            this.cmbHabitacionRes.FormattingEnabled = true;
            this.cmbHabitacionRes.Location = new System.Drawing.Point(514, 45);
            this.cmbHabitacionRes.Name = "cmbHabitacionRes";
            this.cmbHabitacionRes.Size = new System.Drawing.Size(100, 25);
            this.cmbHabitacionRes.TabIndex = 21;
            // 
            // btnAnularRES
            // 
            this.btnAnularRES.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAnularRES.FlatAppearance.BorderSize = 0;
            this.btnAnularRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularRES.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularRES.Location = new System.Drawing.Point(633, 104);
            this.btnAnularRES.Name = "btnAnularRES";
            this.btnAnularRES.Size = new System.Drawing.Size(123, 42);
            this.btnAnularRES.TabIndex = 47;
            this.btnAnularRES.Text = "Anular Reserva";
            this.btnAnularRES.UseVisualStyleBackColor = false;
            this.btnAnularRES.Click += new System.EventHandler(this.btnAnularRES_Click);
            // 
            // OrdenReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(804, 647);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.btnEditarRESER);
            this.Controls.Add(this.btnCancelarRESER);
            this.Controls.Add(this.btnNuevoRESER);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenReserva";
            this.Text = "OrdenReserva";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditarRESER;
        private System.Windows.Forms.Button btnCancelarRESER;
        private System.Windows.Forms.Button btnNuevoRESER;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnMostrarRESER;
        private System.Windows.Forms.DateTimePicker dtpSalidaRes;
        private System.Windows.Forms.DateTimePicker dtpEntradaRes;
        private System.Windows.Forms.DateTimePicker dtpRegistroRes;
        private System.Windows.Forms.TextBox txtIDReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.ComboBox cmbMPRes;
        private System.Windows.Forms.TextBox txtClienteRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMotivoRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarClienteRESER;
        private System.Windows.Forms.CheckBox cbEstadoRES;
        private System.Windows.Forms.TextBox txtIDClienteRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarRES;
        private System.Windows.Forms.TextBox txtPrecioRES;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHabitacionRes;
        private System.Windows.Forms.Button btnAnularRES;
    }
}