namespace Prueba
{
    partial class EliminarUsuario
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(46, 129);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(213, 20);
            this.text1.TabIndex = 0;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Location = new System.Drawing.Point(43, 91);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(121, 13);
            this.NombreUsuario.TabIndex = 1;
            this.NombreUsuario.Text = "Ingresar NombreUsuario";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(301, 126);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 449);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.text1);
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.Button Eliminar;
    }
}