namespace Proyeccc
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuHabitaciones = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuOrdendeReserva = new FontAwesome.Sharp.IconMenuItem();
            this.menuFormasdePago = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormasdePago,
            this.menuOrdendeReserva,
            this.menuEmpleados,
            this.menuClientes,
            this.menuHabitaciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 83);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(642, 48);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA HOTELERO";
            // 
            // menuHabitaciones
            // 
            this.menuHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.menuHabitaciones.IconColor = System.Drawing.Color.Black;
            this.menuHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuHabitaciones.IconSize = 60;
            this.menuHabitaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHabitaciones.Name = "menuHabitaciones";
            this.menuHabitaciones.Size = new System.Drawing.Size(88, 79);
            this.menuHabitaciones.Text = "Habitaciones";
            this.menuHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 60;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(72, 79);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.IconSize = 60;
            this.menuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(77, 79);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuOrdendeReserva
            // 
            this.menuOrdendeReserva.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            this.menuOrdendeReserva.IconColor = System.Drawing.Color.Black;
            this.menuOrdendeReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuOrdendeReserva.IconSize = 60;
            this.menuOrdendeReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuOrdendeReserva.Name = "menuOrdendeReserva";
            this.menuOrdendeReserva.Size = new System.Drawing.Size(111, 79);
            this.menuOrdendeReserva.Text = "Orden de Reserva";
            this.menuOrdendeReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuFormasdePago
            // 
            this.menuFormasdePago.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.menuFormasdePago.IconColor = System.Drawing.Color.Black;
            this.menuFormasdePago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFormasdePago.IconSize = 60;
            this.menuFormasdePago.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFormasdePago.Name = "menuFormasdePago";
            this.menuFormasdePago.Size = new System.Drawing.Size(104, 79);
            this.menuFormasdePago.Text = "Formas de Pago";
            this.menuFormasdePago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuHabitaciones;
        private FontAwesome.Sharp.IconMenuItem menuFormasdePago;
        private FontAwesome.Sharp.IconMenuItem menuOrdendeReserva;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
    }
}

