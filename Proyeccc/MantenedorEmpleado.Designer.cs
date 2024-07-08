namespace Proyeccc
{
    partial class MantenedorEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvConserjeria = new System.Windows.Forms.DataGridView();
            this.btnModificarEMP = new System.Windows.Forms.Button();
            this.btnCancelarEMP = new System.Windows.Forms.Button();
            this.btnAgregarEMP = new System.Windows.Forms.Button();
            this.cbEstadoEmpleado = new System.Windows.Forms.CheckBox();
            this.txtCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidosEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoEMP = new System.Windows.Forms.Button();
            this.btnInhabilitarEMP = new System.Windows.Forms.Button();
            this.btnEditarEMP = new System.Windows.Forms.Button();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConserjeria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTipoEmpleado);
            this.groupBox1.Controls.Add(this.txtTelefonoEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtgvConserjeria);
            this.groupBox1.Controls.Add(this.btnModificarEMP);
            this.groupBox1.Controls.Add(this.btnCancelarEMP);
            this.groupBox1.Controls.Add(this.btnAgregarEMP);
            this.groupBox1.Controls.Add(this.cbEstadoEmpleado);
            this.groupBox1.Controls.Add(this.txtCorreoEmpleado);
            this.groupBox1.Controls.Add(this.txtApellidosEmpleado);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.txtIDEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 461);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(153, 152);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtTelefonoEmpleado.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Telefono";
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
            this.dtgvConserjeria.EnableHeadersVisualStyles = false;
            this.dtgvConserjeria.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgvConserjeria.Location = new System.Drawing.Point(0, 253);
            this.dtgvConserjeria.Name = "dtgvConserjeria";
            this.dtgvConserjeria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dtgvConserjeria.Size = new System.Drawing.Size(612, 314);
            this.dtgvConserjeria.TabIndex = 50;
            // 
            // btnModificarEMP
            // 
            this.btnModificarEMP.BackColor = System.Drawing.Color.SandyBrown;
            this.btnModificarEMP.FlatAppearance.BorderSize = 0;
            this.btnModificarEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEMP.Location = new System.Drawing.Point(335, 117);
            this.btnModificarEMP.Name = "btnModificarEMP";
            this.btnModificarEMP.Size = new System.Drawing.Size(200, 37);
            this.btnModificarEMP.TabIndex = 47;
            this.btnModificarEMP.Text = "MODIFICAR";
            this.btnModificarEMP.UseVisualStyleBackColor = false;
            // 
            // btnCancelarEMP
            // 
            this.btnCancelarEMP.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancelarEMP.FlatAppearance.BorderSize = 0;
            this.btnCancelarEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEMP.Location = new System.Drawing.Point(438, 74);
            this.btnCancelarEMP.Name = "btnCancelarEMP";
            this.btnCancelarEMP.Size = new System.Drawing.Size(97, 37);
            this.btnCancelarEMP.TabIndex = 46;
            this.btnCancelarEMP.Text = "CANCELAR";
            this.btnCancelarEMP.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEMP
            // 
            this.btnAgregarEMP.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAgregarEMP.FlatAppearance.BorderSize = 0;
            this.btnAgregarEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEMP.Location = new System.Drawing.Point(336, 74);
            this.btnAgregarEMP.Name = "btnAgregarEMP";
            this.btnAgregarEMP.Size = new System.Drawing.Size(96, 37);
            this.btnAgregarEMP.TabIndex = 45;
            this.btnAgregarEMP.Text = "AGREGAR";
            this.btnAgregarEMP.UseVisualStyleBackColor = false;
            // 
            // cbEstadoEmpleado
            // 
            this.cbEstadoEmpleado.AutoSize = true;
            this.cbEstadoEmpleado.Location = new System.Drawing.Point(358, 180);
            this.cbEstadoEmpleado.Name = "cbEstadoEmpleado";
            this.cbEstadoEmpleado.Size = new System.Drawing.Size(152, 21);
            this.cbEstadoEmpleado.TabIndex = 8;
            this.cbEstadoEmpleado.Text = "Estado del Empleado";
            this.cbEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtCorreoEmpleado
            // 
            this.txtCorreoEmpleado.Location = new System.Drawing.Point(153, 124);
            this.txtCorreoEmpleado.Name = "txtCorreoEmpleado";
            this.txtCorreoEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtCorreoEmpleado.TabIndex = 7;
            // 
            // txtApellidosEmpleado
            // 
            this.txtApellidosEmpleado.Location = new System.Drawing.Point(153, 94);
            this.txtApellidosEmpleado.Name = "txtApellidosEmpleado";
            this.txtApellidosEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtApellidosEmpleado.TabIndex = 6;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(153, 66);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtNombreEmpleado.TabIndex = 5;
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(153, 38);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(121, 22);
            this.txtIDEmpleado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Corrreo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado";
            // 
            // btnNuevoEMP
            // 
            this.btnNuevoEMP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevoEMP.FlatAppearance.BorderSize = 0;
            this.btnNuevoEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEMP.Location = new System.Drawing.Point(673, 321);
            this.btnNuevoEMP.Name = "btnNuevoEMP";
            this.btnNuevoEMP.Size = new System.Drawing.Size(99, 45);
            this.btnNuevoEMP.TabIndex = 47;
            this.btnNuevoEMP.Text = "NUEVO";
            this.btnNuevoEMP.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitarEMP
            // 
            this.btnInhabilitarEMP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInhabilitarEMP.FlatAppearance.BorderSize = 0;
            this.btnInhabilitarEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitarEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarEMP.Location = new System.Drawing.Point(673, 387);
            this.btnInhabilitarEMP.Name = "btnInhabilitarEMP";
            this.btnInhabilitarEMP.Size = new System.Drawing.Size(99, 44);
            this.btnInhabilitarEMP.TabIndex = 48;
            this.btnInhabilitarEMP.Text = "INHABILITAR";
            this.btnInhabilitarEMP.UseVisualStyleBackColor = false;
            // 
            // btnEditarEMP
            // 
            this.btnEditarEMP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditarEMP.FlatAppearance.BorderSize = 0;
            this.btnEditarEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEMP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEMP.Location = new System.Drawing.Point(673, 455);
            this.btnEditarEMP.Name = "btnEditarEMP";
            this.btnEditarEMP.Size = new System.Drawing.Size(99, 44);
            this.btnEditarEMP.TabIndex = 49;
            this.btnEditarEMP.Text = "EDITAR";
            this.btnEditarEMP.UseVisualStyleBackColor = false;
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Location = new System.Drawing.Point(153, 180);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(121, 25);
            this.cbTipoEmpleado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tipo";
            // 
            // MantenedorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(804, 647);
            this.Controls.Add(this.btnEditarEMP);
            this.Controls.Add(this.btnInhabilitarEMP);
            this.Controls.Add(this.btnNuevoEMP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorEmpleado";
            this.Text = "MantenedorEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConserjeria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEstadoEmpleado;
        private System.Windows.Forms.TextBox txtCorreoEmpleado;
        private System.Windows.Forms.TextBox txtApellidosEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarEMP;
        private System.Windows.Forms.Button btnCancelarEMP;
        private System.Windows.Forms.Button btnAgregarEMP;
        private System.Windows.Forms.Button btnNuevoEMP;
        private System.Windows.Forms.Button btnInhabilitarEMP;
        private System.Windows.Forms.Button btnEditarEMP;
        private System.Windows.Forms.DataGridView dtgvConserjeria;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
    }
}