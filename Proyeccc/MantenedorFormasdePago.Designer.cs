namespace Proyeccc
{
    partial class MantenedorFormasdePago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbEstadoPago = new System.Windows.Forms.CheckBox();
            this.btnDeshabilitarMPAGO = new System.Windows.Forms.Button();
            this.txtDescripcionPago = new System.Windows.Forms.TextBox();
            this.btnAgregarMPAGO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.btnCancelarMPAGO = new System.Windows.Forms.Button();
            this.btnEditarMPAGO = new System.Windows.Forms.Button();
            this.btnNuevoMPAGO = new System.Windows.Forms.Button();
            this.txtIDMP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarMPAGO = new System.Windows.Forms.Button();
            this.btnBuscarMPAGO = new System.Windows.Forms.Button();
            this.txtNombreMP = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNombreMP);
            this.gbDatos.Controls.Add(this.btnBuscarMPAGO);
            this.gbDatos.Controls.Add(this.btnModificarMPAGO);
            this.gbDatos.Controls.Add(this.txtIDMP);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.cbEstadoPago);
            this.gbDatos.Controls.Add(this.btnDeshabilitarMPAGO);
            this.gbDatos.Controls.Add(this.txtDescripcionPago);
            this.gbDatos.Controls.Add(this.btnAgregarMPAGO);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(28, 45);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(739, 220);
            this.gbDatos.TabIndex = 9;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "METODO PAGO";
            // 
            // cbEstadoPago
            // 
            this.cbEstadoPago.AutoSize = true;
            this.cbEstadoPago.Location = new System.Drawing.Point(391, 112);
            this.cbEstadoPago.Name = "cbEstadoPago";
            this.cbEstadoPago.Size = new System.Drawing.Size(124, 21);
            this.cbEstadoPago.TabIndex = 46;
            this.cbEstadoPago.Text = "Estado del pago";
            this.cbEstadoPago.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitarMPAGO
            // 
            this.btnDeshabilitarMPAGO.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDeshabilitarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarMPAGO.Location = new System.Drawing.Point(371, 170);
            this.btnDeshabilitarMPAGO.Name = "btnDeshabilitarMPAGO";
            this.btnDeshabilitarMPAGO.Size = new System.Drawing.Size(109, 34);
            this.btnDeshabilitarMPAGO.TabIndex = 45;
            this.btnDeshabilitarMPAGO.Text = "DESHABILITAR";
            this.btnDeshabilitarMPAGO.UseVisualStyleBackColor = false;
            this.btnDeshabilitarMPAGO.Click += new System.EventHandler(this.btnDeshabilitarMPAGO_Click);
            // 
            // txtDescripcionPago
            // 
            this.txtDescripcionPago.Location = new System.Drawing.Point(529, 47);
            this.txtDescripcionPago.Multiline = true;
            this.txtDescripcionPago.Name = "txtDescripcionPago";
            this.txtDescripcionPago.Size = new System.Drawing.Size(153, 88);
            this.txtDescripcionPago.TabIndex = 12;
            // 
            // btnAgregarMPAGO
            // 
            this.btnAgregarMPAGO.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAgregarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnAgregarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMPAGO.Location = new System.Drawing.Point(141, 170);
            this.btnAgregarMPAGO.Name = "btnAgregarMPAGO";
            this.btnAgregarMPAGO.Size = new System.Drawing.Size(109, 34);
            this.btnAgregarMPAGO.TabIndex = 44;
            this.btnAgregarMPAGO.Text = "AGREGAR";
            this.btnAgregarMPAGO.UseVisualStyleBackColor = false;
            this.btnAgregarMPAGO.Click += new System.EventHandler(this.btnAgregarMPAGO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion del pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metodo de Pago";
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMetodoPago.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMetodoPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMetodoPago.ColumnHeadersHeight = 40;
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMetodoPago.EnableHeadersVisualStyles = false;
            this.dgvMetodoPago.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvMetodoPago.Location = new System.Drawing.Point(28, 271);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodoPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMetodoPago.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMetodoPago.Size = new System.Drawing.Size(582, 347);
            this.dgvMetodoPago.TabIndex = 49;
            // 
            // btnCancelarMPAGO
            // 
            this.btnCancelarMPAGO.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnCancelarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMPAGO.Location = new System.Drawing.Point(630, 464);
            this.btnCancelarMPAGO.Name = "btnCancelarMPAGO";
            this.btnCancelarMPAGO.Size = new System.Drawing.Size(137, 36);
            this.btnCancelarMPAGO.TabIndex = 48;
            this.btnCancelarMPAGO.Text = "CANCELAR";
            this.btnCancelarMPAGO.UseVisualStyleBackColor = false;
            this.btnCancelarMPAGO.Click += new System.EventHandler(this.btnCancelarMPAGO_Click);
            // 
            // btnEditarMPAGO
            // 
            this.btnEditarMPAGO.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnEditarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMPAGO.Location = new System.Drawing.Point(630, 412);
            this.btnEditarMPAGO.Name = "btnEditarMPAGO";
            this.btnEditarMPAGO.Size = new System.Drawing.Size(137, 36);
            this.btnEditarMPAGO.TabIndex = 47;
            this.btnEditarMPAGO.Text = "EDITAR";
            this.btnEditarMPAGO.UseVisualStyleBackColor = false;
            this.btnEditarMPAGO.Click += new System.EventHandler(this.btnEditarMPAGO_Click);
            // 
            // btnNuevoMPAGO
            // 
            this.btnNuevoMPAGO.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevoMPAGO.FlatAppearance.BorderSize = 0;
            this.btnNuevoMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMPAGO.Location = new System.Drawing.Point(630, 362);
            this.btnNuevoMPAGO.Name = "btnNuevoMPAGO";
            this.btnNuevoMPAGO.Size = new System.Drawing.Size(137, 36);
            this.btnNuevoMPAGO.TabIndex = 46;
            this.btnNuevoMPAGO.Text = "NUEVO";
            this.btnNuevoMPAGO.UseVisualStyleBackColor = false;
            this.btnNuevoMPAGO.Click += new System.EventHandler(this.btnNuevoMPAGO_Click);
            // 
            // txtIDMP
            // 
            this.txtIDMP.Location = new System.Drawing.Point(220, 50);
            this.txtIDMP.Name = "txtIDMP";
            this.txtIDMP.Size = new System.Drawing.Size(121, 22);
            this.txtIDMP.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "ID Metodo Pago";
            // 
            // btnModificarMPAGO
            // 
            this.btnModificarMPAGO.BackColor = System.Drawing.Color.SandyBrown;
            this.btnModificarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnModificarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMPAGO.Location = new System.Drawing.Point(486, 170);
            this.btnModificarMPAGO.Name = "btnModificarMPAGO";
            this.btnModificarMPAGO.Size = new System.Drawing.Size(109, 34);
            this.btnModificarMPAGO.TabIndex = 51;
            this.btnModificarMPAGO.Text = "MODIFICAR";
            this.btnModificarMPAGO.UseVisualStyleBackColor = false;
            this.btnModificarMPAGO.Click += new System.EventHandler(this.btnModificarMPAGO_Click);
            // 
            // btnBuscarMPAGO
            // 
            this.btnBuscarMPAGO.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBuscarMPAGO.FlatAppearance.BorderSize = 0;
            this.btnBuscarMPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMPAGO.Location = new System.Drawing.Point(256, 170);
            this.btnBuscarMPAGO.Name = "btnBuscarMPAGO";
            this.btnBuscarMPAGO.Size = new System.Drawing.Size(109, 34);
            this.btnBuscarMPAGO.TabIndex = 52;
            this.btnBuscarMPAGO.Text = "BUSCAR";
            this.btnBuscarMPAGO.UseVisualStyleBackColor = false;
            this.btnBuscarMPAGO.Click += new System.EventHandler(this.btnBuscarMPAGO_Click);
            // 
            // txtNombreMP
            // 
            this.txtNombreMP.Location = new System.Drawing.Point(220, 108);
            this.txtNombreMP.Name = "txtNombreMP";
            this.txtNombreMP.Size = new System.Drawing.Size(121, 22);
            this.txtNombreMP.TabIndex = 53;
            // 
            // MantenedorFormasdePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(804, 647);
            this.Controls.Add(this.dgvMetodoPago);
            this.Controls.Add(this.btnCancelarMPAGO);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnNuevoMPAGO);
            this.Controls.Add(this.btnEditarMPAGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorFormasdePago";
            this.Text = "MantenedorMetodosdePago";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtDescripcionPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshabilitarMPAGO;
        private System.Windows.Forms.Button btnAgregarMPAGO;
        private System.Windows.Forms.Button btnCancelarMPAGO;
        private System.Windows.Forms.Button btnEditarMPAGO;
        private System.Windows.Forms.Button btnNuevoMPAGO;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.CheckBox cbEstadoPago;
        private System.Windows.Forms.TextBox txtIDMP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarMPAGO;
        private System.Windows.Forms.Button btnModificarMPAGO;
        private System.Windows.Forms.TextBox txtNombreMP;
    }
}