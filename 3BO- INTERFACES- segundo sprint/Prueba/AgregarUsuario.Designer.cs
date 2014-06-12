namespace Prueba
{
    partial class AgregarUsuario
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
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Location = new System.Drawing.Point(113, 27);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.nombreUsuario.TabIndex = 0;
            this.nombreUsuario.Text = "nombreUsuario";
            this.nombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(23, 81);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(23, 125);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "nombre";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(23, 177);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 3;
            this.apellido.Text = "apellido";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(218, 81);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 4;
            this.direccion.Text = "direccion";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(218, 125);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 5;
            this.email.Text = "email";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(218, 177);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 6;
            this.telefono.Text = "telefono";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(138, 247);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "AgregarUsuario";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 396);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.email);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nombreUsuario);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Button Agregar;
    }
}