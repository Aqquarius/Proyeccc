namespace Proyeccc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btInicarSesion = new System.Windows.Forms.Button();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(221, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 2);
            this.label3.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(222, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 2);
            this.label2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Identifícate";
            // 
            // btInicarSesion
            // 
            this.btInicarSesion.BackColor = System.Drawing.Color.SandyBrown;
            this.btInicarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btInicarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicarSesion.ForeColor = System.Drawing.Color.Black;
            this.btInicarSesion.Location = new System.Drawing.Point(222, 450);
            this.btInicarSesion.Name = "btInicarSesion";
            this.btInicarSesion.Size = new System.Drawing.Size(346, 42);
            this.btInicarSesion.TabIndex = 56;
            this.btInicarSesion.Text = "Iniciar Sesión";
            this.btInicarSesion.UseVisualStyleBackColor = false;
            this.btInicarSesion.Click += new System.EventHandler(this.btInicarSesion_Click);
            // 
            // txContraseña
            // 
            this.txContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txContraseña.Location = new System.Drawing.Point(222, 405);
            this.txContraseña.MaxLength = 15;
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.Size = new System.Drawing.Size(346, 17);
            this.txContraseña.TabIndex = 55;
            this.txContraseña.Text = "Contraseña";
            this.txContraseña.Enter += new System.EventHandler(this.txContraseña_Enter);
            this.txContraseña.Leave += new System.EventHandler(this.txContraseña_Leave);
            // 
            // txUsuario
            // 
            this.txUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txUsuario.Location = new System.Drawing.Point(222, 365);
            this.txUsuario.MaxLength = 13;
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(346, 17);
            this.txUsuario.TabIndex = 54;
            this.txUsuario.Text = "Usuario";
            this.txUsuario.Enter += new System.EventHandler(this.txUsuario_Enter);
            this.txUsuario.Leave += new System.EventHandler(this.txUsuario_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(299, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 126);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 31);
            this.label4.TabIndex = 62;
            this.label4.Text = "SISTEMA HOTELERO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInicarSesion);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInicarSesion;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}