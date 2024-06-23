namespace Proyeccc
{
    partial class MantenedorCliente
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
            this.dtgvConserjeria = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.te = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCL = new System.Windows.Forms.Button();
            this.btnNuevoCL = new System.Windows.Forms.Button();
            this.btnModificarCL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCL = new System.Windows.Forms.Button();
            this.btnBuscarCL = new System.Windows.Forms.Button();
            this.btnAgregarCL = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConserjeria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvConserjeria
            // 
            this.dtgvConserjeria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvConserjeria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvConserjeria.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgvConserjeria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvConserjeria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvConserjeria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvConserjeria.ColumnHeadersHeight = 40;
            this.dtgvConserjeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvConserjeria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.N,
            this.Apellido,
            this.FR,
            this.ce,
            this.te});
            this.dtgvConserjeria.EnableHeadersVisualStyles = false;
            this.dtgvConserjeria.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgvConserjeria.Location = new System.Drawing.Point(35, 251);
            this.dtgvConserjeria.Name = "dtgvConserjeria";
            this.dtgvConserjeria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvConserjeria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvConserjeria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvConserjeria.Size = new System.Drawing.Size(603, 289);
            this.dtgvConserjeria.TabIndex = 52;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // N
            // 
            this.N.HeaderText = "Nombre";
            this.N.Name = "N";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // FR
            // 
            this.FR.HeaderText = "Fecha de Registro";
            this.FR.Name = "FR";
            // 
            // ce
            // 
            this.ce.HeaderText = "Correo Electrónico ";
            this.ce.Name = "ce";
            // 
            // te
            // 
            this.te.HeaderText = "teléfono";
            this.te.Name = "te";
            // 
            // btnEliminarCL
            // 
            this.btnEliminarCL.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminarCL.FlatAppearance.BorderSize = 0;
            this.btnEliminarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCL.Location = new System.Drawing.Point(661, 421);
            this.btnEliminarCL.Name = "btnEliminarCL";
            this.btnEliminarCL.Size = new System.Drawing.Size(117, 37);
            this.btnEliminarCL.TabIndex = 51;
            this.btnEliminarCL.Text = "ELIMINAR";
            this.btnEliminarCL.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCL
            // 
            this.btnNuevoCL.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevoCL.FlatAppearance.BorderSize = 0;
            this.btnNuevoCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCL.Location = new System.Drawing.Point(661, 309);
            this.btnNuevoCL.Name = "btnNuevoCL";
            this.btnNuevoCL.Size = new System.Drawing.Size(117, 37);
            this.btnNuevoCL.TabIndex = 50;
            this.btnNuevoCL.Text = "NUEVO";
            this.btnNuevoCL.UseVisualStyleBackColor = false;
            // 
            // btnModificarCL
            // 
            this.btnModificarCL.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificarCL.FlatAppearance.BorderSize = 0;
            this.btnModificarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCL.Location = new System.Drawing.Point(661, 362);
            this.btnModificarCL.Name = "btnModificarCL";
            this.btnModificarCL.Size = new System.Drawing.Size(117, 37);
            this.btnModificarCL.TabIndex = 49;
            this.btnModificarCL.Text = "MODIFICAR";
            this.btnModificarCL.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarCL);
            this.groupBox1.Controls.Add(this.btnBuscarCL);
            this.groupBox1.Controls.Add(this.btnAgregarCL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDNICliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 220);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // btnCancelarCL
            // 
            this.btnCancelarCL.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancelarCL.FlatAppearance.BorderSize = 0;
            this.btnCancelarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCL.Location = new System.Drawing.Point(268, 162);
            this.btnCancelarCL.Name = "btnCancelarCL";
            this.btnCancelarCL.Size = new System.Drawing.Size(113, 33);
            this.btnCancelarCL.TabIndex = 45;
            this.btnCancelarCL.Text = "CANCELAR";
            this.btnCancelarCL.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCL
            // 
            this.btnBuscarCL.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBuscarCL.FlatAppearance.BorderSize = 0;
            this.btnBuscarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCL.Location = new System.Drawing.Point(268, 59);
            this.btnBuscarCL.Name = "btnBuscarCL";
            this.btnBuscarCL.Size = new System.Drawing.Size(113, 33);
            this.btnBuscarCL.TabIndex = 44;
            this.btnBuscarCL.Text = "BUSCAR";
            this.btnBuscarCL.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCL
            // 
            this.btnAgregarCL.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAgregarCL.FlatAppearance.BorderSize = 0;
            this.btnAgregarCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCL.Location = new System.Drawing.Point(268, 110);
            this.btnAgregarCL.Name = "btnAgregarCL";
            this.btnAgregarCL.Size = new System.Drawing.Size(113, 33);
            this.btnAgregarCL.TabIndex = 43;
            this.btnAgregarCL.Text = "AGREGAR";
            this.btnAgregarCL.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(413, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Registro del Cliente";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(413, 115);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(206, 22);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(20, 173);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(216, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(20, 59);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(216, 22);
            this.txtDNICliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.dtgvConserjeria);
            this.Controls.Add(this.btnEliminarCL);
            this.Controls.Add(this.btnNuevoCL);
            this.Controls.Add(this.btnModificarCL);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConserjeria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvConserjeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ce;
        private System.Windows.Forms.DataGridViewTextBoxColumn te;
        private System.Windows.Forms.Button btnEliminarCL;
        private System.Windows.Forms.Button btnNuevoCL;
        private System.Windows.Forms.Button btnModificarCL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarCL;
        private System.Windows.Forms.Button btnBuscarCL;
        private System.Windows.Forms.Button btnAgregarCL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}