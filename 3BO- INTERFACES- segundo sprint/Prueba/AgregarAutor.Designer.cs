namespace Prueba
{
    partial class AgregarAutor
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
            this.button1 = new System.Windows.Forms.Button();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.APELLIDO = new System.Windows.Forms.TextBox();
            this.Libro_isbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(41, 112);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.NOMBRE.TabIndex = 2;
            this.NOMBRE.Text = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.Location = new System.Drawing.Point(41, 167);
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.APELLIDO.TabIndex = 3;
            this.APELLIDO.Text = "APELLIDO";
            // 
            // Libro_isbn
            // 
            this.Libro_isbn.Location = new System.Drawing.Point(41, 230);
            this.Libro_isbn.Name = "Libro_isbn";
            this.Libro_isbn.Size = new System.Drawing.Size(100, 20);
            this.Libro_isbn.TabIndex = 4;
            this.Libro_isbn.Text = "isbn Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crear un nuevo Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Libro_isbn);
            this.Controls.Add(this.APELLIDO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.button1);
            this.Name = "AgregarAutor";
            this.Text = "AgregarAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox APELLIDO;
        private System.Windows.Forms.TextBox Libro_isbn;
        private System.Windows.Forms.Label label1;
    }
}