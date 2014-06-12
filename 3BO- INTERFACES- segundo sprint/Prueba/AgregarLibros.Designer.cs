namespace Prueba
{
    partial class AgregarLibros
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Agregar = new System.Windows.Forms.Button();
            this.ISBN_text = new System.Windows.Forms.TextBox();
            this.nombre_text = new System.Windows.Forms.TextBox();
            this.stock_text = new System.Windows.Forms.TextBox();
            this.editorial_text = new System.Windows.Forms.TextBox();
            this.edicion_text = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.NA_label = new System.Windows.Forms.Label();
            this.NL_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.UV_label = new System.Windows.Forms.Label();
            this.precio_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(288, 45);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // ISBN_text
            // 
            this.ISBN_text.Location = new System.Drawing.Point(16, 45);
            this.ISBN_text.Name = "ISBN_text";
            this.ISBN_text.Size = new System.Drawing.Size(245, 20);
            this.ISBN_text.TabIndex = 1;
            // 
            // nombre_text
            // 
            this.nombre_text.Location = new System.Drawing.Point(16, 100);
            this.nombre_text.Name = "nombre_text";
            this.nombre_text.Size = new System.Drawing.Size(245, 20);
            this.nombre_text.TabIndex = 2;
            // 
            // stock_text
            // 
            this.stock_text.Location = new System.Drawing.Point(13, 163);
            this.stock_text.Name = "stock_text";
            this.stock_text.Size = new System.Drawing.Size(245, 20);
            this.stock_text.TabIndex = 3;
            // 
            // editorial_text
            // 
            this.editorial_text.Location = new System.Drawing.Point(16, 219);
            this.editorial_text.Name = "editorial_text";
            this.editorial_text.Size = new System.Drawing.Size(245, 20);
            this.editorial_text.TabIndex = 4;
            // 
            // edicion_text
            // 
            this.edicion_text.Location = new System.Drawing.Point(16, 267);
            this.edicion_text.Name = "edicion_text";
            this.edicion_text.Size = new System.Drawing.Size(245, 20);
            this.edicion_text.TabIndex = 5;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(13, 29);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 6;
            this.isbn_label.Text = "ISBN";
            // 
            // NA_label
            // 
            this.NA_label.AutoSize = true;
            this.NA_label.Location = new System.Drawing.Point(10, 138);
            this.NA_label.Name = "NA_label";
            this.NA_label.Size = new System.Drawing.Size(35, 13);
            this.NA_label.TabIndex = 7;
            this.NA_label.Text = "Stock";
            // 
            // NL_label
            // 
            this.NL_label.AutoSize = true;
            this.NL_label.Location = new System.Drawing.Point(15, 84);
            this.NL_label.Name = "NL_label";
            this.NL_label.Size = new System.Drawing.Size(70, 13);
            this.NL_label.TabIndex = 8;
            this.NL_label.Text = "Nombre Libro";
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Location = new System.Drawing.Point(13, 242);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(42, 13);
            this.stock_label.TabIndex = 9;
            this.stock_label.Text = "Edicion";
            // 
            // UV_label
            // 
            this.UV_label.AutoSize = true;
            this.UV_label.Location = new System.Drawing.Point(15, 203);
            this.UV_label.Name = "UV_label";
            this.UV_label.Size = new System.Drawing.Size(44, 13);
            this.UV_label.TabIndex = 10;
            this.UV_label.Text = "Editorial";
            // 
            // precio_text
            // 
            this.precio_text.Location = new System.Drawing.Point(13, 330);
            this.precio_text.Name = "precio_text";
            this.precio_text.Size = new System.Drawing.Size(248, 20);
            this.precio_text.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Precio";
            // 
            // AgregarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precio_text);
            this.Controls.Add(this.UV_label);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.NL_label);
            this.Controls.Add(this.NA_label);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.edicion_text);
            this.Controls.Add(this.editorial_text);
            this.Controls.Add(this.stock_text);
            this.Controls.Add(this.nombre_text);
            this.Controls.Add(this.ISBN_text);
            this.Controls.Add(this.Agregar);
            this.Name = "AgregarLibros";
            this.Text = "Agregar Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox ISBN_text;
        private System.Windows.Forms.TextBox nombre_text;
        private System.Windows.Forms.TextBox stock_text;
        private System.Windows.Forms.TextBox editorial_text;
        private System.Windows.Forms.TextBox edicion_text;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label NA_label;
        private System.Windows.Forms.Label NL_label;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.Label UV_label;
        private System.Windows.Forms.TextBox precio_text;
        private System.Windows.Forms.Label label1;
    }
}

